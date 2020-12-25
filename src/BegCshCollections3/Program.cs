using System;
using System.Collections.Generic;

namespace BegCshCollections3
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"/home/goldrush/Project_C#/begcshcollections/src/BegCshCollections/Pop.csv";
            CsvReader reader = new CsvReader(filePath);

            List<Country> countries = reader.ReadAllCountries();

            System.Console.WriteLine("Enter no. of countries to display>");
            bool inputIsInt = int.TryParse(Console.ReadLine(), out int userInput);
            if(!inputIsInt || userInput <= 0){
                System.Console.WriteLine("You must type in a +ve integer. Exiting");
                return;
            }
            int maxToDisplay = userInput;

            // foreach( Country country in countries){
            // for(int i = 0; i < countries.Count; i++){
            for(int i = countries.Count-1; i >= 0; i--){

                int displayIndex = countries.Count - 1 - i;

                if( displayIndex > 0 && (displayIndex % maxToDisplay == 0)){
                    System.Console.WriteLine("Hit return to continue, anything else to quit");
                    if(Console.ReadLine() != "")
                        break;
                }
                Country country = countries[i];
                System.Console.WriteLine($"[{displayIndex+1}] {PopulationFormatter.FormatPopulation(country.Population).PadLeft(15)}: {country.Name}");
            }
        }
    }
}
