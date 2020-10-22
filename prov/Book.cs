using System.Collections.Generic;
using System;

namespace prov
{
    public class Book
    {
        public int price;

        private string name;

        private int rarity;

        private string category;

        private int actualValue;

        private bool cursed;

        private Random generator = new Random();

        List<string> Books = new List<string>() {"Bok1", "Bok2", "Bok3"};
        List<string> Category = new List<string>() {"Fantasy", "Racing", "Roleplay"};

        public Book()
        {
             price = generator.Next(100);
             rarity = generator.Next(1, 10);

            int x = generator.Next(0,1);

            if(x == 0)
            {
                cursed = false;
            }
            else
            {
                cursed = true;
            }

            int z = generator.Next(0,2);
            
            string chosenBook = Books[z];

            string chosenCategory = Category[z];

            PrintInfo(chosenBook, chosenCategory, rarity, price);
        }

        public void PrintInfo(string chosenBook, string chosenCategory, int rarity, int actualValue)
        {
            System.Console.WriteLine("Bokens namn: " + chosenBook);
            System.Console.WriteLine("Category: " + chosenCategory);
            System.Console.WriteLine("Rarity: " + rarity);
            System.Console.WriteLine("Pris: " + actualValue);
        }

        public int Evaluate()
        {
            actualValue = price * rarity;
        }
    }


}
