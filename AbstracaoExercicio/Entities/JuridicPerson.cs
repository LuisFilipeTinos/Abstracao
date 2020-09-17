using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace AbstracaoExercicio.Entities
{
    class JuridicPerson : Person
    {
        public int NumberOfEmployees { get; private set; }

        public JuridicPerson(string name, double anualIncome, int numberOfEmployees) : base(name, anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public sealed override double TaxesPaid()
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

        public override string ToString()
        {
            return Name + ": " + " $ " + TaxesPaid().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
