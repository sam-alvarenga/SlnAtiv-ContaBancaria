using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamAlvarenga.Ativ_ContaBancaria.Models;

/// <summary>
/// Representação de uma conta especial, que herda da classe base Conta.
/// Inclui um limite de crédito que pode ser utilizado em saques.
/// </summary>
/// 
public class ContaEspecial : Conta
{
 
    /// <summary>
    /// Limite de crédito disponível para a conta especial.
    /// </summary>
    public double Limite { get; set; }

    /// <summary>
    /// Construtor da classe ContaEspecial.
    /// </summary>
    /// <param name="esTitular">Nome do titular da conta especial.</param>
    /// <param name="esNumeroConta">Número da conta especial.</param>
    /// <param name="esSaldo">Saldo inicial da conta especial.</param>
    /// <param name="esLimite">Limite de crédito da conta especial.</param>
    /// <param name="esDataDeAniversário">Data de nascimento do titular.</param>
    public ContaEspecial(string esTitular, string esNumeroConta, double esSaldo, double esLimite, DateOnly esDataDeAniversário)
    {

        this.Titular = esTitular;
        this.NumeroConta = esNumeroConta;
        this.Saldo = esSaldo;
        this.Limite = esLimite;
        this.DataCriacaoConta = DateTime.Now;
        this.DataDeNascimento = esDataDeAniversário;
        TipoDaConta = "Conta Especial";

    }

    /// <summary>
    /// Método para sacar um valor da conta especial.
    /// Permite o uso do limite de crédito se o saldo for insuficiente.
    /// </summary>
    /// <param name="valor">Valor a ser sacado.</param>
    //Método Sacar 
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
                Console.WriteLine($"Saque de R${valor} realizado com sucesso. Saldo atual é: R${this.Saldo}, Limite Disponível: R${this.Limite}");
            }
        }
        else
        {
            Console.WriteLine("Saque não permitido. O valor inserido excede o saldo e o limite.");
        }
    }

    /// <summary>
    /// Método que exibe os dados da conta especial.
    /// Sobrescreve o método ExibirDadosConta da classe base Conta.
    /// </summary>
    /// <returns>String formatada com os detalhes da conta especial.</returns>
    //Retonar o método de exibir os dados Conta Especial
    public override string ExibirDadosConta()
    {
        return
            $" Tipo da Conta: {this.TipoDaConta}," +
            $" Titular: {this.Titular}," +
            $" Número da Conta: {this.NumeroConta}," +
            $" Saldo: R$ {this.Saldo}," +
            $" Limite Disponível: R$ {this.Limite}" +
            $" Data da Criação da Conta: {this.DataCriacaoConta}" +
            $" Data de Aniversário: {this.DataDeNascimento}";

    }

}





