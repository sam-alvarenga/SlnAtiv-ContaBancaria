using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamAlvarenga.Ativ_ContaBancaria.Models
{
    //classe abstrata não pode instanciar o objeto
    public abstract class Conta
    {
        public string Titular { get; set; }
        public string NumeroConta { get; set; }
        public double Saldo { get; set; }


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


        //Método Transferir
        public bool Transferir(Conta pConta, double pValor)
        {
            try
            {
                this.Sacar(pValor); // estes métodos devem lançar um exception em caso de erro  
                pConta.Depositar(pValor);
            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }

        public abstract string ExibirDadosConta();

    }
}


