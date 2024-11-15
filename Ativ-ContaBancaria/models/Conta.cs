using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
        /// Propriedade que representa a senha da conta. A senha deve ter no máximo 8 caracteres.
        /// Se um valor com mais de 8 caracteres for atribuído, uma exceção do tipo <see cref="ArgumentException"/> será lançada.
        /// </summary>
        /// <value>
        /// A senha da conta, que é validada para garantir que tenha no máximo 8 caracteres.
        /// </value>
        /// <exception cref="ArgumentException">Lançada quando a senha atribuída tem mais de 8 caracteres.
        /// </exception>
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
        /// Realiza um saque de um valor especificado, se o valor for válido e não exceder o saldo disponível.
        /// Caso o valor do saque seja maior que o saldo, ou inválido (menor ou igual a zero), o método retorna uma mensagem de erro.
        /// Se o valor do saque for inválido (menor ou igual a zero), uma exceção é lançada.
        /// </summary>
        /// <param name="valor">O valor que se deseja sacar.</param>
        /// <returns>Uma string que indica o resultado do saque. Caso seja bem-sucedido, retorna uma mensagem de sucesso com o saldo atual.
        /// Caso contrário, retorna uma mensagem de erro indicando o motivo (ex: valor excede o saldo ou valor inválido).</returns>
        /// <exception cref="Exception">Lança uma exceção caso o valor do saque seja menor ou igual a zero, indicando que o saque é inválido.</exception>
        
        public string Sacar(double valor)
        {

            try
            {
                if (valor > 0)
                {

                    if (valor <= this.Saldo)
                    {
                        this.Saldo -= valor;
                        return $"Saque de R${valor} realizado com Sucesso. Saldo atual é: R${this.Saldo}";
                    }
                    else
                    {

                        return "Saque não permitido. O valor inserido excede o Saldo .";
                    }
                }
                else
                {
                    throw new Exception("Saque inválido");
                }
            }
            catch (Exception ex)
            {

                return $"{ex}";
            }
        }

        /// <summary>
        /// Realiza um depósito de um valor especificado, se o valor for maior que zero.
        /// Caso o valor seja inválido (menor ou igual a zero), uma exceção do tipo `ArgumentException` será lançada.
        /// </summary>
        /// <param name="valor">O valor que se deseja depositar.</param>
        /// <returns>Uma string que indica o resultado do depósito. Caso seja bem-sucedido, retorna uma mensagem de sucesso com o saldo atual.
        /// Caso contrário, retorna uma mensagem de erro indicando o motivo (ex: valor inválido).</returns>
        /// <exception cref="ArgumentException">Lança uma exceção do tipo `ArgumentException` se o valor depositado for menor ou igual a zero, indicando que o depósito não é permitido.</exception>
        public string Depositar(double valor)
        {
            try
            {
                if (valor > 0)
                {

                    this.Saldo += valor;
                    return $"Depósito de R${valor} Realizado com Sucesso. Saldo atual é R${this.Saldo}";
                }
                else
                {
                    throw new ArgumentException("Depósito não permitido. O valor depositado deve ser maior que ZERO.");
                }

            }
            catch (Exception ex)
            {

                return $"{ex}";
            }
        }

        /// <summary>
        /// Método responsável por realizar a transferência de um valor de uma conta (objeto atual) para outra conta (objeto `pConta`).
        /// Tenta realizar a operação de saque e depósito. Se ocorrer qualquer erro durante o processo, uma exceção será lançada e capturada.
        /// Em caso de falha, a exceção será reportada e o método retornará `false`.
        /// </summary>
        /// <param name="pConta">A conta para a qual o valor será transferido.</param>
        /// <param name="pValor">O valor a ser transferido.</param>
        /// <returns>Retorna `true` se a transferência for bem-sucedida, `false` caso contrário, indicando que houve um erro durante o processo.</returns>
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


