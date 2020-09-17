using System;
using System.Collections.Generic;
using System.Text;

namespace AbstracaoExercicio.Entities
{
    abstract class Person
    {
        public string Name { get; private set; }
        public double AnualIncome { get; private set; }

        public Person(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract double TaxesPaid();
    
    
    }
}
