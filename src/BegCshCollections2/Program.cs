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
            Country liliput = new Country("Liliput", "LIL", "Somewhere", 2_000_000);
            int liliputIndex = countries.FindIndex(x=>x.Population <2_000_000);
            countries.Insert(liliputIndex,liliput);
            countries.RemoveAt(liliputIndex);

            foreach( Country country in countries){
                System.Console.WriteLine($"{PopulationFormatter.FormatPopulation(country.Population).PadLeft(15)}: {country.Name}");
            }

            System.Console.WriteLine($"\n{countries.Count} countries");
        }
    }
}
