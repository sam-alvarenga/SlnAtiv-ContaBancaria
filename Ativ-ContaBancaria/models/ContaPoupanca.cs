using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SamAlvarenga.Ativ_ContaBancaria.Models
{
    public class ContaPoupanca : Conta
    {
        public DateTime DataAniversario = DateTime.Now;

        public ContaPoupanca(string TitularPoupanca, string NumeroContaPoupanca, double SaldoPoupanca)
        {
            this.Titular = TitularPoupanca;
            this.NumeroConta = NumeroContaPoupanca;
            this.Saldo = SaldoPoupanca;
        }

        //Retonar o método de exibir os dados Conta Poupança
        public override string ExibirDadosConta()
        {
            return $"Titular: {Titular}," +
                $" Número da Conta: {NumeroConta}, " +
                $" Saldo: R$ {Saldo}, " +
                $" Data de Aniversário: {DataAniversario}";
        }

    }


}
