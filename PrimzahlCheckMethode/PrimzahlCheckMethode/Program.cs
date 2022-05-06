using System;

namespace PrimzahlenCheck
{
    class Program
    {
        static void Main()
        {
            PrimzahlenCheck();
        }
        static bool IsPrimenumber(int pValue)
        {
            if (pValue == 0 || pValue == 1)
            {
                return false;
            }
            else
            {
                for (int i = pValue / 2; i >= 2; i--)
                {
                    if (pValue % i == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        static void PrimzahlenCheck()
        {
            try
            {
                bool ErneutAusfuehren = true;

                while (ErneutAusfuehren)
                {
                    Console.WriteLine("Geben sie eine zahl ein");
                    Console.WriteLine("-----------------------------------------------------------------------------------------------------");
                    bool Primzahltest = IsPrimenumber(Convert.ToInt32(Console.ReadLine()));
                    Console.WriteLine(" primzahl " + Primzahltest);
                    ErneutAusfuehren = Ausfuehren();
            
                }   
            } 
            catch (OverflowException)
            {
                while (true)
                {
                    Console.WriteLine("kleinere zahl eingeben");
                    Ausfuehren();
                    PrimzahlenCheck();
                }               
            }
            catch (FormatException)
            {
                while (true)
                {
                    Console.WriteLine("Bitte nur Zahlen eingeben");
                    Ausfuehren();
                    PrimzahlenCheck();
                } 
            }
        }
        static bool Ausfuehren()
        {
            Console.WriteLine("möchten sie das programm weiterhin benutzen? [J/N]");
            string antwort = Console.ReadLine();
            if (antwort == "J" || antwort == "j")
            {
                return true;
            }
            else if (antwort == "N" || antwort == "n")
            {
                Environment.Exit(0);
                return false;
            }
            return false;
        }
    }
}

