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


    //depois lançar exeception e criar um método de return para retornar os dados de exibição que estão dentro do console, pois não é uma boa pratica
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


    //depois lançar exeception e criar um método de return para retornar os dados de exibição que estão dentro do console, pois não é uma boa pratica

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

    //Sobrecarga de Métodos

    // depois criar uma classe Conta para trabalhar a herença para simplifica o código. Assim não é um boa prática
    // aqui não foi lançado exeception pois não foi lançado nos métodos tra
    public bool Transferir(ContaEspecial pConta, double pValor) //assinatura de método
    {
        this.Sacar(pValor);
        pConta.Depositar(pValor);
        return true;
    }
    public bool Transferir(ContaPoupanca pConta, double pValor)
    {
        this.Sacar(pValor);
        pConta.Depositar(pValor);
        return true;
    }


    // Faria a construção do transferir assim lançando a exeception caso fosse lançado no depositar e Sacar, só nele não funcionaria
    //public bool Transferir(ContaEspecial pConta, double pValor) //assinatura de método
    //{
    //    try
    //    {
    //        this.Sacar(pValor); //Estes métodos devem lançar exeception em caso de erro
    //        pConta.Depositar(pValor); //estes métodos devem lançar exception em caso de erro 
    //    }
    //    catch (Exception)
    //    {
    //        return false;


    //    }
    //    return true;

    //}
    //public bool Transferir(ContaPoupanca pConta, double pValor)
    //{

    //    try
    //    {
    //        this.Sacar(pValor); //Estes métodos devem lançar exeception em caso de erro
    //        pConta.Depositar(pValor); //estes métodos devem lançar exception em caso de erro 
    //    }
    //    catch (Exception)
    //    {
    //        return false;


    //    }
    //    return true;
    //}
}
