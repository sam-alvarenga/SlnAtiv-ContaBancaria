﻿// See https://aka.ms/new-console-template for more information
using SamAlvarenga.Ativ_ContaBancaria.Models;
using System.ComponentModel;

class Program
{
    
    static void Main()
    {
        // Coletando dados para a Conta Especial
        Console.WriteLine("\n Conta Especial:");
        Console.Write("Titular: ");
        string esTitular = Console.ReadLine();
        Console.Write("Número da Conta: ");
        string esNumeroConta = Console.ReadLine();
        Console.Write("Saldo: R$ ");
        double esSaldo = Convert.ToDouble(Console.ReadLine());
        Console.Write("Limite: R$ ");
        double esLimite = Convert.ToDouble(Console.ReadLine());

        //chamando o objecto da Conta Especial
        ContaEspecial especial = new ContaEspecial(esTitular, esNumeroConta, esSaldo, esLimite);

        //Mostrando os dados da Conta Especial
        Console.WriteLine("\n Dados da Conta Especial:");
        Console.WriteLine(especial.ExibirDadosConta());

        // Realizando saques Conta Especial
        Console.Write("\nDigite o valor do saque da Conta Especial: ");
        double valorSaqueEspecial = Convert.ToDouble(Console.ReadLine());
        especial.Sacar(valorSaqueEspecial);



        // Instanciando ContaPoupanca
        //ContaPoupanca poupanca = new ContaPoupanca();


        // Coletando dados para a Conta Poupança
        Console.WriteLine("\n Conta Poupança:");
        Console.Write("Titular: ");
        string TitularPoupanca = Console.ReadLine();
        Console.Write("Número da Conta: ");
        string NumeroContaPoupanca = Console.ReadLine();
        Console.Write("Saldo: R$ ");
        double SaldoPoupanca = Convert.ToDouble(Console.ReadLine());

        

        //chamando class objeto
        ContaPoupanca poupanca = new ContaPoupanca(TitularPoupanca, NumeroContaPoupanca, SaldoPoupanca);

        //Realizando saques Conta Poupança
        Console.Write("\n Digite o valor do saque da Conta Poupança: ");
        double valorSaquePoupanca = Convert.ToDouble(Console.ReadLine());
        poupanca.Sacar(valorSaquePoupanca);

        //Mostrando os dados Poupança
        Console.WriteLine("\n Dados da Conta Poupança:");
        Console.WriteLine(poupanca.ExibirDadosConta());

        









    }

}