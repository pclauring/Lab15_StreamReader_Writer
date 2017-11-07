using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15_Txt_Writer
{
    class Validator
    {
        public static int GetValidSelection(string prompt, int upperLimit, int lowerLimit)
        {
            bool success = false;
            int selection = 0;
            while (!success)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();
                success = int.TryParse(input, out selection);

                if (selection > upperLimit || selection < lowerLimit)
                {
                    Console.Write($"Not a valid input... ");
                    success = false;
                }
            }
            return selection;
        }
    }
}
