using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main()
        {


            try
            {
                Console.WriteLine("dein name eingeben");


                string name = Console.ReadLine();

                Console.WriteLine("dein Alter eingeben");

                int alter = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("hallo dein name ist " + name + " du bist " + alter + " Jahre alt ");
            }
            catch (FormatException)
            {
                Console.WriteLine("Geben sie eine Zahl ein");
            }


        }
    }
}
