using System;

namespace Palindrom_For
{
    class Program
    {
        static void Main(string[] args)
        {
            Palidromecheck();
        }
        static void Palidromecheck()
        {
            bool ausfuehren = true;


            while (ausfuehren)
            {
                Console.WriteLine("Geben sie einen Text ein");
                Console.WriteLine("---------------------------------------------------------------");

                if (isPalindrom(Console.ReadLine()))
                {
                    Console.WriteLine("ist ein palidrome");
                }
                else
                {
                    Console.WriteLine("ist kein palidrome");
                }

                ausfuehren = erneutausfuehren();
            }
        }
        static bool isPalindrom(string pString)
        {
            string reverse = string.Empty;

            for (int i = pString.Length - 1; i >= 0; i--)
            {
                reverse += pString[i];
            }
            if (pString == reverse)
            {
                return true;

            }
            else
            {
                return false;
            }
        }
        static bool erneutausfuehren()
        {
            Console.WriteLine("möchten sie das programm weiterhin benutzen? [J/N]");
            string antwort = Console.ReadLine();

            if (antwort == "J" || antwort == "j")
            {
                return true;
            }
            if (antwort == "N" || antwort == "n")
            {
                Environment.Exit(0);
                return false;
            }
            else
            {
                erneutausfuehren();
            }
            return true;
            
        }
    }
}    
      
