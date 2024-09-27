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
            if (valor > this.Saldo)
            {
                double valorUsadoLimite = valor - this.Saldo;
                this.Saldo = 0;
                this.Limite -= valorUsadoLimite;
                Console.WriteLine($"Saque de R${valor} realizado com sucesso. Saldo atual é: R${this.Saldo}, Limite restante: R${this.Limite}");
            }
            else
            {
                this.Saldo -= valor;
                Console.WriteLine($"Saque de R${valor} realizado com sucesso. Saldo atual é: R${this.Saldo} Limite Disponivel: R${this.Limite}");
            }
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
            $"Titular: {this.Titular}," +
            $" Número da Conta: {this.NumeroConta}," +
            $" Saldo: R$ {this.Saldo}," +
            $" Limite Disponivel: R$ {this.Limite}";

    }
}





