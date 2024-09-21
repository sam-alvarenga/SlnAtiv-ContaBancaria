using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamAlvarenga.Ativ_ContaBancaria.Models;

internal class ContaEspecial
{    
        public string Titular { get; set; }
        public string NumeroConta { get; set; }
        public double Saldo { get; set; }
        public double Limite { get; set; }

        public ContaEspecial(string titular, string numeroConta, double saldo, double limite)
        {
      
         this.Titular = titular;
         this.NumeroConta = numeroConta;
         this.Saldo = saldo;
         this.Limite = limite;    
        
        }

    
}   

