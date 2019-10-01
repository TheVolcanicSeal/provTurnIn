using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Grundläggande_modellering
{
    public class Utils
    {
        static Random generator = new Random();

        public static int checkIfNumber(string line)
        {
            bool Success = false;
            int generatedNumber = 0;

            while (Success == false)
            {

                Success = int.TryParse(line, out generatedNumber);

                if (Success == false)
                {
                    Console.Clear();
                    Console.WriteLine("Input a number: \n");
                    line = Console.ReadLine();

                }

            }

            return generatedNumber;


        }

        public static string GibberishWord()
        {

            string[] syllables = File.ReadAllLines(@"C: \Users\oskar.emanuelsson1\Documents\Gibberish\Syllables.txt".Trim());

            int amountOfSyllables = generator.Next(2, 4);

            string newSyllable = "";

            string[] fullWord = new string[amountOfSyllables + 1];

            for (int i = 0; i <= amountOfSyllables; i++)
            {

                int nextSyllableNumber = generator.Next(syllables.Length);

                newSyllable = (syllables[nextSyllableNumber]).ToLower();

                fullWord[i] = newSyllable;




            }



            return (String.Join("", fullWord));


        }

    }
}
