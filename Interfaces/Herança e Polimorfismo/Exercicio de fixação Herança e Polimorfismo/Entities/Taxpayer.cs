using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;


namespace Exercicio_de_fixação_Herança_e_Polimorfismo.Entities
{
    abstract class Taxpayer
    {
        public string Name { get; set; }
        public double AnualIncome { get;  set; }

        public Taxpayer()
        {
        }

        protected Taxpayer(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract double Tax();
    }
}
