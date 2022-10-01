using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyhAssignment1
{
    public class App
    {
        public void Run()
        {

            int count = 1;
            
            Console.WriteLine("Gissa ett tal mellan 1 och 100.");

            while (true)
            {

                var randomNum = GenerateRandom();

                Console.Write($"Gissning {count}: ");
                string input = Console.ReadLine();
                int userGuess;
                bool rightInput = int.TryParse(input, out userGuess);

                if (randomNum > userGuess && rightInput)
                {
                    Console.WriteLine("Talet är större.");
                }
                else if (randomNum < userGuess && rightInput)
                {
                    Console.WriteLine("Talet är mindre.");
                }
                else if (userGuess == randomNum && rightInput)
                {
                    Console.WriteLine($"Rätt! Du gissade rätt på {count} försök.");
                    while (true)
                    {
                        Console.WriteLine("Vill du spela igen (Ja/Nej)?");
                        string answer = Console.ReadLine();
                        answer = answer.ToLower();

                        if (answer == "nej" || answer == "n" || answer == "nope")
                        {
                            Console.WriteLine("Tack för den här gången!");
                            return;
                        }
                        else if (answer == "ja" || answer == "yes")
                        {
                            count = 1;
                            break;
                        }
                    }                    
                    continue;

                }

                if (rightInput)
                {
                    count++;
                }
                else
                {
                    Console.WriteLine("Du kan bara skriva ett tal med siffror. Försök igen!");
                }

            }            
            
        }
        public int GenerateRandom()
        {
            Random rnd = new Random();
            int num = rnd.Next(1, 101);
            return num;
        }     

    }
}
