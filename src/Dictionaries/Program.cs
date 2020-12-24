using System;
using System.Collections.Generic;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Country norway = new Country("Norway", "NOR", "Europe", 5_282_223);
            Country finland = new Country("Finland", "FIN", "Europe", 5_111_303);

            var countries = new Dictionary<string, Country>();

            countries.Add(norway.Code, norway);
            countries.Add(finland.Code, finland);

            foreach (var item in countries.Values)
            {
                System.Console.WriteLine($"{item.Name}, {item.Code}, {item.Population}");
            }

        }
    }
}
