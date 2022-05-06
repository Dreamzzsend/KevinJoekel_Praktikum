using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            bool Primzahltest = IsPrimenumber(7);
            Console.WriteLine(" primzahl " + Primzahltest);
            Console.WriteLine("Geben sie eine Nummer ein");
            num1 = Convert.ToInt32(Console.ReadLine());
            if (num1 == 0 || num1 == 1)
            {
                Console.WriteLine(num1 + " ist keine primzahl");
                Console.ReadLine();
            }
            else
            {
                for (int a = num1 / 2; a >= 2; a--)
                {
                    if (num1 % a == 0)
                    {
                        Console.WriteLine(num1 + " ist keine primzahl");
                        return;
                    }

                }
                
                Console.WriteLine("ist eine primzahl");
                
            }
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
    }
}
