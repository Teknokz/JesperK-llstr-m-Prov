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


        // Book är min konstruktor som först randomizar värdet på price (0 - 100) och sedan rarity (1 - 10)

        
        public Book()
        {
             price = generator.Next(100);
             rarity = generator.Next(1, 10);

            // Sedan så har jag en generator som randmizar om boken blir cursed eller inte 50% chans att boken blir cursed.

            int x = generator.Next(0,1);
            // Om generatorn randomizar 0 blir boken inte cursed
            if(x == 0)
            {
                cursed = false;
            }
            //Om det blir något annat blir boken cursed( i detta fall endast 1)
            else
            {
                cursed = true;
            }

            //Generatorn här randomizar vilken bok och vilken kategori i min lista som ska användas

            int z = generator.Next(0,2);
            
            //Här tas boken från listan

            string chosenBook = Books[z];

            //Här tas Kategorin från listan

            string chosenCategory = Category[z];

            //I Printiinfo så tar jag in alla values från konstruktorn och lägger in dem i Console.WriteLines.
            // Efter det så skriver jag ut dem i konsolen

            PrintInfo(chosenBook, chosenCategory, rarity, price);
        }

        public void PrintInfo(string chosenBook, string chosenCategory, int rarity, int actualValue)
        {
            System.Console.WriteLine("Bokens namn: " + chosenBook);
            System.Console.WriteLine("Category: " + chosenCategory);
            System.Console.WriteLine("Rarity: " + rarity);
            System.Console.WriteLine("Pris: " + actualValue);
        }

        //I Evaluate tar vi priset gånger rarity vilket ger oss det riktiga priset på boken. Sen returner vi värdet.
        public int Evaluate()
        {
            actualValue = price * rarity;

            return actualValue;
        }
    }


}
