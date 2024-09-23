using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamAlvarenga.Ativ_ContaBancaria.Models;

internal class ContaEspecial
{
    public string Titular { get; set; }
    public string NumeroConta { get; set; }
    public double Saldo { get; set; }
    public double Limite { get; set; }

    public ContaEspecial(string esTitular, string esNumeroConta, double esSaldo, double esLimite)
    {

        this.Titular = esTitular;
        this.NumeroConta = esNumeroConta;
        this.Saldo = esSaldo;
        this.Limite = esLimite;

    }

    public void Sacar(double valor)
    {
        if (valor <= this.Saldo + this.Limite)
        {
            this.Saldo -= valor;
            Console.WriteLine($"Saque de R${valor} realizado com Sucesso. Saldo atual é: R${this.Saldo}");
        }
        else
        {

            Console.WriteLine("Saque não permitido. O valor inserido excede o saldo e o limite.");
        }
    }
    //Retonar o método de exibir os dados Conta Especial
    public string ExibirDadosConta()
    {          

        return 
            $"Titular: {Titular}," +
            $" Número da Conta: {NumeroConta}," +
            $" Saldo: R$ {Saldo}," +
            $" Limite Disponivel: R$ {Limite}";

    }
}


