using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamAlvarenga.Ativ_ContaBancaria.Models
{
    //classe abstrata não pode instanciar o objeto
    /// <summary>
    /// Classe abstrata que representa uma conta bancária.
    /// Não pode ser instanciada diretamente, serve como base para diferentes tipos de contas.
    /// </summary>
    public abstract class Conta
    {
        /// <summary>
        /// Obtém ou define o nome do titular da conta.
        /// </summary>
        public string Titular { get; set; }

        /// <summary>
        /// Obtém ou define o número da conta bancária.
        /// </summary>
        public string NumeroConta { get; set; }

        /// <summary>
        /// Obtém ou define o saldo atual da conta.
        /// </summary>
        public double Saldo { get; set; }

        /// <summary>
        /// Obtém ou define a data de criação da conta.
        /// </summary>
        public DateTime DataCriacaoConta { get; set; }

        /// <summary>
        /// Obtém ou define a data de nascimento do titular da conta.
        /// </summary>
        public DateOnly DataDeNascimento { get; set; }

        /// <summary>
        /// Obtém ou define o tipo da conta (por exemplo, corrente, poupança).
        /// </summary>
        public string TipoDaConta { get; set; }

        /// <summary>
        /// Armazena a senha do usuário.
        /// </summary>
        private string _senha;
        /// <summary>
        /// Senha da conta. Deve ter no máximo 8 caracteres.
        /// </summary>
        public string Senha
        {
            get { return _senha; }
            set
            {
                if (value.Length > 8)
                {
                    throw new ArgumentException("A senha deve ter no máximo 8 caracteres.");
                }
                _senha = value;
            }
        }


        /// <summary>
        /// Método para sacar um valor da conta.
        /// </summary>
        /// <param name="valor">Valor a ser sacado.</param>
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

        /// <summary>
        /// Método para depositar um valor na conta.
        /// </summary>
        /// <param name="valor">Valor a ser depositado.</param>
        //Método Sacar 
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

        /// <summary>
        /// Método para transferir um valor para outra conta.
        /// </summary>
        /// <param name="pConta">Conta para a qual o valor será transferido.</param>
        /// <param name="pValor">Valor a ser transferido.</param>
        /// <returns>True se a transferência for bem-sucedida, caso contrário, false.</returns>
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
        /// <summary>
        /// Método abstrato para exibir os dados da conta.
        /// Deve ser implementado nas classes derivadas.
        /// </summary>
        /// <returns>String com os dados da conta.</returns>
        public abstract string ExibirDadosConta();

    }
}


