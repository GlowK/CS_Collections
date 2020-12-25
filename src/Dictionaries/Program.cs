using System;
using System.Collections.Generic;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"/home/goldrush/Project_C#/begcshcollections/src/BegCshCollections/Pop.csv";
            CsvReader reader = new CsvReader(filePath);
            Dictionary<string, Country> countries = reader.ReadAllCountries();

            System.Console.WriteLine("Which country code do you want to look for?");
            string userInput = Console.ReadLine();

            bool gotCountry = countries.TryGetValue(userInput, out Country country);
            if(!gotCountry){
                System.Console.WriteLine($"Sorry, there is no country with code, {userInput}");
            }else{
                System.Console.WriteLine($"{country.Name} has population {PopulationFormatter.FormatPopulation(country.Population)}");
            }
        }
    }
}
