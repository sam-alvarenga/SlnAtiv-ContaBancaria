using System;
using System.Collections.Generic;
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

    public ContaPoupanca() { }

    
    public ContaPoupanca( string TitularPoupanca, string NumeroContaPoupanca, double SaldoPoupanca) {
        this.Titular = TitularPoupanca;
        this.NumeroConta = NumeroContaPoupanca;
        this.Saldo = SaldoPoupanca;
    }

    //Retonar o método de exibir os dados Conta Poupança
    public string ExibirDadosConta()
    {
        return $"Titular: {Titular}," +
            $" Número da Conta: {NumeroConta}, " +
            $"Saldo: R$ {Saldo}, " +
            $"Data de Aniversário: {DataAniversario}";
}

}
