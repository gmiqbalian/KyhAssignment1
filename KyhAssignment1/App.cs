using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyhAssignment1
{
    internal class App
    {
        public void Run()
        {

            int count = 1;
            Console.WriteLine("Gissa ett tal mellan 1 och 100.");

            while (true)
            {
                Random rnd = new Random(); //change 1 to null before submitting.
                int num = rnd.Next(1, 101);
                
                
                Console.Write($"Gissning {count}: ");
                string input = Console.ReadLine();
                int guess;
                bool rightInput = int.TryParse(input, out guess);               
            
                if (num > guess && rightInput)
                {
                    Console.WriteLine("Talet är större.");
                }
                else if(num < guess && rightInput)
                {                 
                    Console.WriteLine("Talet är mindre.");
                }
                else if(guess == num && rightInput)
                {
                    Console.WriteLine($"Rätt! Du gissade rätt på {count} försök.");
                    Console.WriteLine("Vill du spela igen (Ja/Nej)?");
                    string answer = Console.ReadLine();
                    answer = answer.ToLower();
                    if (answer.Contains("nej") || answer.Contains('n') || answer.Contains("nope"))
                    {
                        break;
                    }
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
            Console.WriteLine("Tack för den här gången!");
        }
    }
}
