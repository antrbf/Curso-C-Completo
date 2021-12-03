using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_de_fixação_Herança_e_Polimorfismo.Entities
{
    class Company : Taxpayer
    {
        public double NumberOfEmployees { get; set; }

        public Company()
        {
        }

        public Company(string name, double anualIncome, double numberOfEmployees) : base(name, anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            if (NumberOfEmployees > 10)
            {
                return AnualIncome * 0.14;
            }
            else
            {
                return AnualIncome * 0.16;
            }
        }
    }
}
