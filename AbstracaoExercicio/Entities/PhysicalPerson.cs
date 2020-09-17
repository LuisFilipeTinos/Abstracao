using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace AbstracaoExercicio.Entities
{
    class PhysicalPerson : Person
    {

        public double HealthExpenditures { get; private set; }

        public PhysicalPerson(string name, double anualIncome, double healthExpenditures) : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public sealed override double TaxesPaid()
        {
            if (AnualIncome < 20000.00)
            {
                return AnualIncome * 0.15 - HealthExpenditures * 0.50;
            }
            else if (AnualIncome > 20000.00)
            {
                return AnualIncome * 0.25 - HealthExpenditures * 0.50;
            }
            else
            {
                return 0;
            }

            
        }

        public override string ToString()
        {
            return Name + ": " + " $ " + TaxesPaid().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
