using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SamAlvarenga.Ativ_ContaBancaria.Models
{
    /// <summary>
    /// Representação de uma conta poupança, que herda da classe base Conta.
    /// </summary>
    public class ContaPoupanca : Conta
    {
        /// <summary>
        /// Construtor da classe ContaPoupanca.
        /// </summary>
        /// <param name="TitularPoupanca">Nome do titular da conta poupança.</param>
        /// <param name="NumeroContaPoupanca">Número da conta poupança.</param>
        /// <param name="SaldoPoupanca">Saldo inicial da conta poupança.</param>
        /// <param name="DataDeNascimento">Data de nascimento do titular.</param>
        public ContaPoupanca(string TitularPoupanca, string NumeroContaPoupanca, double SaldoPoupanca, DateOnly DataDeNascimento)
        {
            this.Titular = TitularPoupanca;
            this.NumeroConta = NumeroContaPoupanca;
            this.Saldo = SaldoPoupanca;
            this.DataCriacaoConta =  DateTime.Now;
            this.DataDeNascimento = DataDeNascimento;
            TipoDaConta = "Conta Poupança";
        }

        /// <summary>
        /// Método que exibe os dados da conta poupança.
        /// Sobrescreve o método ExibirDadosConta da classe base Conta.
        /// </summary>
        //Retonar o método de exibir os dados Conta Poupança
        public override string ExibirDadosConta()
        {
            return
                $" Tipo da Conta: {this.TipoDaConta},"+
                $" Titular: {this.Titular}," +
                $" Número da Conta: {this.NumeroConta}, " +
                $" Saldo: R$ {this.Saldo}, " +
                $" Data da Criação da Conta: {this.DataCriacaoConta}" +
                $" Data de Nascimento: {this.DataDeNascimento}";
        }

    }


}
