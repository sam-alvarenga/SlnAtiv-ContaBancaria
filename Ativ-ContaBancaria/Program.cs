// See https://aka.ms/new-console-template for more information
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

        //Mostrando os dados
        Console.WriteLine("\n Dados da Conta Especial:");
        Console.WriteLine($"Titular: {especial.Titular}," +
            $" Número: {especial.NumeroConta}, " +
            $"Saldo: {especial.Saldo}, " +
            $"Limite Disponivel: {especial.Limite}");


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



        //Mostrando os dados
        Console.WriteLine("\n Dados da Conta Poupança:");
        Console.WriteLine($"Nome do Titular: {poupanca.Titular}, " +
            $"Número: {poupanca.NumeroConta}," +
            $"Saldo: R$ {poupanca.Saldo}, " +
            $"Data de Aniversário: {poupanca.DataAniversario}");

       







    }

}