using System;
using System.Globalization;
using System.Collections.Generic;
using AbstracaoExercicio.Entities;

namespace AbstracaoExercicio
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Person> list = new List<Person>();

            Console.Write("Enter the number of payers: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tag player #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char word = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if(word == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditure = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Person physicalPerson = new PhysicalPerson(name, anualIncome, healthExpenditure);
                    list.Add(physicalPerson);
                }
                else if(word == 'c')
                {
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());
                    Person juridicPerson = new JuridicPerson(name, anualIncome, numberOfEmployees);
                    list.Add(juridicPerson);
                }
            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            double sum = 0.0;
            foreach(Person obj in list)
            {
                Console.WriteLine(obj.ToString());
                sum += obj.TaxesPaid();
            }

            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: " + "$ " + sum.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
