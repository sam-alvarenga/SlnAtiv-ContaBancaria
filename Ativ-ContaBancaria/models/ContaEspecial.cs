﻿using System;
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

        public ContaEspecial(string esTitular, string esNumeroConta, double esSaldo, double esLimite)
        {
      
         this.Titular = esTitular;
         this.NumeroConta = esNumeroConta;
         this.Saldo = esSaldo;
         this.Limite = esLimite;    
        
        }

    
}   

