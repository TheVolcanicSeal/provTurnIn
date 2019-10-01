using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grundläggande_modellering
{
    class Program
    {
        static void Main(string[] args)
        {

            int money = 5000;
            string storeName;
            List<book> inventory;

            book.Startup();
            

            Console.WriteLine("Name you shop!\n");
            storeName = Console.ReadLine();

            while(money > 0)
            {
                Console.Clear();
                
                Console.WriteLine("A customer approaches " + storeName + "!");

                Customer currentCustomer = new Customer();

                if(currentCustomer.selling == true)
                {
                    book aBook = new book();

                    Console.WriteLine("The customer ");


                }
                

                Console.ReadKey();
            }


        }
    }
}
