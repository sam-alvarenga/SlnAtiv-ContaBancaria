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
    /// <param name="esDataDeNascimento">Data de nascimento do titular.</param>
    public ContaEspecial(string esTitular, string esNumeroConta, double esSaldo, double esLimite, DateOnly esDataDeNascimento)
    {

        this.Titular = esTitular;
        this.NumeroConta = esNumeroConta;
        this.Saldo = esSaldo;
        this.Limite = esLimite;
        this.DataCriacaoConta = DateTime.Now;
        this.DataDeNascimento = esDataDeNascimento;
        TipoDaConta = "Conta Especial";

    }

    /// <summary>
    /// Método responsável por realizar um saque de valor da conta. O saque pode utilizar o saldo disponível e, caso necessário, o limite da conta.
    /// Se o valor do saque for maior que o saldo e o limite combinado, uma exceção do tipo <see cref="InvalidOperationException"/> será lançada.
    /// Caso o valor do saque seja negativo ou zero, uma exceção do tipo <see cref="ArgumentException"/> será lançada.
    /// O método retorna uma mensagem indicando o sucesso da operação ou a descrição da exceção lançada.
    /// </summary>
    /// <param name="valor">O valor a ser sacado.</param>
    /// <returns>Retorna uma mensagem indicando o sucesso do saque ou o erro ocorrido durante o processo.</returns>
    public string Sacar(double valor)
    {
        try
        {
            if (valor > 0)
            {
                
                if (valor <= this.Saldo + this.Limite)
                {
                    if (valor > this.Saldo)
                    {
                        double valorUsadoLimite = valor - this.Saldo;
                        this.Saldo = 0;
                        this.Limite -= valorUsadoLimite;
                        return $"Saque de R${valor} realizado com sucesso. Saldo atual é: R${this.Saldo}, Limite restante: R${this.Limite}";
                    }
                    else
                    {
                        this.Saldo -= valor;
                        return $"Saque de R${valor} realizado com sucesso. Saldo atual é: R${this.Saldo}, Limite Disponível: R${this.Limite}";
                    }
                }
                else
                {
                    throw new InvalidOperationException("Saque não permitido. O valor inserido excede o saldo e o limite.");
                }
            }
            else
            { 
                throw new ArgumentException("O valor do saque deve ser maior que zero."); 
           
            }
         
        }
        catch (Exception ex)
        {

            return $"{ex}";
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
            $" Data de Nascimento: {this.DataDeNascimento}";

    }

}





