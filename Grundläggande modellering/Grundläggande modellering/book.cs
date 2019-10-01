using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grundläggande_modellering
{
    class book
    {

        public int price;
        public string name;
        public int rarity;
        static public string[] categories = new string[6];
        public string category;
        int actualValue;
        bool cursed;
        bool cursedCheck = false;
        bool priceChecked = false;
        public bool curseCheckResult;
        public int priceCheckResult;

        Random generator = new Random();

        static public void Startup ()
        {
            categories[0] = "Norse";
            categories[1] = "Aztec";
            categories[2] = "Mayan";
            categories[3] = "Egyptian";
            categories[4] = "Siberian";

        }

        public book()
        {
            name = Utils.GibberishWord();//Yes!, jag fick använda den.
            rarity = generator.Next(5);
            actualValue = generator.Next(200, 7000);
            category = categories[generator.Next(categories.Length)];
            price = generator.Next(200, 7000);

            if(generator.Next(100) >= 80)
            {

                cursed = true;

            }
            else
            {

                cursed = false;

            }

        }
        public void PrintInfo()
        {
            Console.Clear();
            Console.WriteLine("[" + name + "]");
            Console.WriteLine("Price: " + price);
            Console.WriteLine("Category: " + category);

            if(cursedCheck == true)
            {

                Console.WriteLine("Cursed?: " + curseCheckResult + "?");

            }
            if(priceChecked == true)
            {

                Console.WriteLine("Appraised price: " + priceCheckResult);

            }

            Console.ReadKey();

        }
        public void Appraise()
        {



        }

    }
}
