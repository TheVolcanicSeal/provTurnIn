using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grundläggande_modellering
{
    class Customer
    {
        int money;
        string[] interests = new string[2];
        Random generator = new Random();
        public bool selling;

        public Customer()
        {

            money = generator.Next(200, 20000);

            for (int i = 0; i < interests.Length; i++)
            {

                interests[i] = book.categories[generator.Next(book.categories.Length)];
            }
            
            if(generator.Next(100) > 50)
            {

                selling = true;

            }
            else
            {

                selling = false;

            }

        }



    }
}
