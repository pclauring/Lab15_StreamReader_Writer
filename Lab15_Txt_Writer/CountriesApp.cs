using System;
using System.Collections;

namespace Lab15_Txt_Writer
{
    class CountriesApp
    {
        static void Main(string[] args)
        {
            ArrayList countries;
            countries = CountriesTextFile.readFromFile("countries.txt");

            Console.WriteLine("Welcome to the Countries Maintenance Application");
            while (true)
            {
                Console.WriteLine("1-See the list of Countries\n2-Add a country\n3-Remove the last item of the list\n4-Exit");

                int input = Validator.GetValidSelection("Select a Menu Item (1, 2, 3, or 4): ", 4, 1);
                if (input == 1)
                {
                    countries = CountriesTextFile.readFromFile("countries.txt");
                    Console.WriteLine("The list contains...");
                    foreach (string country in countries)
                    {

                        Console.WriteLine(country);
                    }
                    Console.WriteLine();
                }
                if (input == 2)
                {
                    Console.Write("Please write the country you would like to add: ");
                    countries.Add(Console.ReadLine());
                    CountriesTextFile.writeToFile("countries.txt", countries);

                }
                if (input == 3)
                {
                    if (countries.Count < 1)
                    {
                        Console.WriteLine("The list is empty\n");
                    }
                    else
                    {
                        countries.RemoveAt(countries.Count - 1);
                        CountriesTextFile.writeToFile("countries.txt", countries);
                    }

                }
                if (input == 4)
                {
                    Console.WriteLine("Thank you for viewing our country application.");
                    return;
                }
            }
        }
    }
}
