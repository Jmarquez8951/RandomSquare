using System;
using System.Collections.Generic;
using System.Linq;

namespace RandomSquare
{
    class Program
    {
        static void Main()
        {
            Random rnd = new Random();
            var numbersToSquare = new List<int>();
            for (int i = 1; i < 20; i++)
            {
                numbersToSquare.Add(rnd.Next(50));
            }

            Console.Write("My random list: ");
            Console.Write(string.Join(",", numbersToSquare));
            Console.WriteLine("");

            for (int i = 0; i < numbersToSquare.Count; i++)
            {
                numbersToSquare[i] = numbersToSquare[i] * numbersToSquare[i];
            }

            Console.Write("My squared list: ");
            Console.Write(string.Join(",", numbersToSquare));
            Console.WriteLine("");

            var onlyEvens = numbersToSquare.FindAll(IsEven);

            Console.Write("Removed all odds: ");
            Console.Write(string.Join(",", onlyEvens));
        }

        public static bool IsEven(int i)
        {
            return ((i % 2) == 0);
        }
    }
}
