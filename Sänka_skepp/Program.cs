using System;

namespace Sänka_skepp
{
    class Program
    {
        static void Main(string[] args)
        {
            int xcordinat = 6;
            int svar = 0;
            Console.WriteLine("Välkonnen till sänka skepp. Målet med spelet är att du ska träffa det skeppet jag har placerat ut. ");
            //Gör så loopen körs så länge användaren inte gissat rätt.
            while (svar != xcordinat)
            {
                bool siffra = true;
                Console.WriteLine("Skriv en kordinat. (1-10)");
                string svar1 = Console.ReadLine();

                //Kollar om det är en siffra.
                try
                {
                    svar = int.Parse(svar1);
                }
                catch
                {
                    Console.WriteLine("Det där var inte en siffra! Försök igen");
                    siffra = false;
                }

                if (siffra == true)
                {
                    //Kollar om den är mellan 1 och 10.
                    if (svar >= 1 && svar <= 10)
                    {
                        //kollar hur nära den är.
                        if (svar <= 3 || svar >= 9)
                        {
                            Console.WriteLine("Miss!");
                        }
                        else if (svar == 5 || svar == 7 || svar == 4 || svar == 8)
                        {
                            Console.WriteLine("Near miss");
                        }
                        else if (svar == xcordinat)
                        {
                            Console.WriteLine("Hit! Bra jobbat");
                        }
                    }
                    //Om den inte är mellan 1 och 10 så informeras användaren.
                    else
                    {
                        Console.WriteLine("Det var inte mellan 1 och 10!");
                    }
                }
            }

            //För att inte programmet ska stägas direkt.
            Console.WriteLine("Tryck på ENTER för att stänga programmet.");
            Console.ReadLine();
        }
    }
}
