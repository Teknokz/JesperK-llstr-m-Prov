using System;

namespace prov
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Console.WriteLine("Välkommen till antikjägarna");

            System.Console.WriteLine("Din bok är följande:");

            //Här skapas en ny instans av Book vilket triggar resten i klassen

            Book newBook = new Book();

            System.Console.WriteLine("Vad gissar du för pris?");

            string i = Console.ReadLine();



            Console.ReadLine();
        }
    }
}
