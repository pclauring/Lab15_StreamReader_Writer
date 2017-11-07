using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace Lab15_Txt_Writer
{
    class CountriesTextFile
    {
        public static ArrayList readFromFile(string fileName)
        {
            StreamReader readFile;
            try
            {
                readFile = new StreamReader(fileName);
            }
            catch (Exception)
            {
                    File.CreateText(fileName);
                readFile = new StreamReader(fileName);
            }

            //readFile = new StreamReader(fileName);

            ArrayList countries = new ArrayList();

            while (true)
            {   
            string line = readFile.ReadLine();
            
                if (line == null || line == "")
                {
                    break;
                }
                    countries.Add(line);
            }
            readFile.Close();
            return countries;
        }

        public static void writeToFile(string fileName, ArrayList countries)
        {
            StreamWriter writeFile = new StreamWriter(fileName, false);
            foreach (string country in countries)
            {
                writeFile.WriteLine(country);
            }
            writeFile.Close();
        }
    }
}
