using System;
using System.Collections.Generic;

namespace BegCshCollections2
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"/home/goldrush/Project_C#/begcshcollections/src/BegCshCollections/Pop.csv";
            CsvReader reader = new CsvReader(filePath);

            List<Country> countries = reader.ReadAllCountries();

            foreach( Country country in countries){
                System.Console.WriteLine($"{PopulationFormatter.FormatPopulation(country.Population).PadLeft(15)}: {country.Name}");
            }

            System.Console.WriteLine($"\n{countries.Count} countries");
        }
    }
}
