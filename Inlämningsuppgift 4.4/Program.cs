using System;
using System.Diagnostics.SymbolStore;

namespace uppgift4._4 
{
    class program
    {
        static void Main(string[] args)
        {
           
            
                Console.WriteLine("Välj ett av följande alternativ:");
                Console.WriteLine("1. Subtrahera ett tal med ett annat");
                Console.WriteLine("2. Dividera ett tal med ett annat");
                Console.WriteLine("3. Avsluta programmet");

                string svar = Console.ReadLine();
            do
            {
                switch (svar)
                {
                    case "1":
                        {
                            Console.WriteLine("Skriv in tal nr. 1");
                            double tal_1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("skriv in tal nr. 2");
                            double tal_2 = int.Parse(Console.ReadLine());
                            Console.WriteLine(tal_1 + " minus " + tal_2 + " är lika med " + (tal_1 - tal_2));
                            break;
                        }
                    case "2":
                        {
                            Console.WriteLine("Skriv in tal nr. 1");
                            double tal_1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("skriv in tal nr. 2");
                            double tal_2 = int.Parse(Console.ReadLine());
                            Console.WriteLine(tal_1 + " delat med " + tal_2 + " är lika med " + tal_1 / tal_2);
                            break;
                        }
                    case "3":
                        {
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Du har int valt ett giltigt alternativ");
                            break;
                        }
                }
            } while (svar != "3");
        }
    }
}

