using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ativ_ContaBancaria.models
{
    internal class ContaEspecial
    {    
            public string Titular { get; set; }
            public string NumeroConta { get; set; }
            public double Saldo { get; set; }
            public double Limite { get; set; }
    
            public ContaEspecial(string titular, string numeroConta, double saldo, double limite)
            {
          
             Titular = titular;
             NumeroConta = numeroConta;
             Saldo = saldo;
             Limite = limite;    
            
            }

        
    }   
}
