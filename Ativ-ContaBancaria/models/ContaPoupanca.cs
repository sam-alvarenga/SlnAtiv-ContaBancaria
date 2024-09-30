using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SamAlvarenga.Ativ_ContaBancaria.Models;

internal class ContaPoupanca
{
    public string Titular { get; set; }
    public string NumeroConta { get; set; }
    public double Saldo { get; set; }

    public DateTime DataAniversario = DateTime.Now;


    //Método Sacar 

    public void Sacar(double valor)
    {
        if (valor <= this.Saldo)
        {
            this.Saldo -= valor;
            Console.WriteLine($"Saque de R${valor} realizado com Sucesso. Saldo atual é: R${this.Saldo}");
        }
        else
        {

            Console.WriteLine("Saque não permitido. O valor inserido excede o Saldo .");
        }
    }

    //Método Depositar
    public void Depositar(double valor)
    {
        if (valor > 0)
        {
            this.Saldo += valor;
            Console.WriteLine($"Depósito de R${valor} Realizado com Sucesso. Saldo atual é R${this.Saldo}");
        }
        else
        {

            Console.WriteLine("Depósito não permitido. O valor Depósitado deve ser maior que ZERO.");


        }
            


    }
    

    public ContaPoupanca(string TitularPoupanca, string NumeroContaPoupanca, double SaldoPoupanca)
    {
        this.Titular = TitularPoupanca;
        this.NumeroConta = NumeroContaPoupanca;
        this.Saldo = SaldoPoupanca;
    }

    //Retonar o método de exibir os dados Conta Poupança
    public string ExibirDadosConta()
    {
        return $"Titular: {Titular}," +
            $" Número da Conta: {NumeroConta}, " +
            $" Saldo: R$ {Saldo}, " +
            $" Data de Aniversário: {DataAniversario}";
    }
    

}
