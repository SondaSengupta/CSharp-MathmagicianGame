using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathgician
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I AM THE MATHGICIAN");
            Console.WriteLine("What shall I math?\nFibonacci, Primes, or Integers");
            string desiredMaths = Console.ReadLine();
            Console.WriteLine("Ok.  I'm gonna do some " + desiredMaths);
            if ("Integers" == desiredMaths)
            {
                PrintIntegers();
            }
            else if ("Fibonacci" == desiredMaths)
            {
                PrintFibonacciSequence();
            }
            else if ("Primes" == desiredMaths)
            {
                PrintPrimesSequence();
            }
            Console.WriteLine("Press Any Key To Exit...");
            Console.ReadKey();
        }

        private static void PrintPrimesSequence()
        {
           // 2, 3, 5, 7, 9, 13
            // primeList.ForEach( i % primeList [i] == 0)
            
            List<int> primeList = new List<int>();
            primeList.Add(2);
            int primeCandidate = 3;
            Console.WriteLine(2);
            while (true)
            {
            
                bool isPrime = true;
                for (int i = 0; i < primeList.Count; i++)
                {
                    if (primeCandidate % primeList[i] == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime == true)
                {
                    Console.WriteLine(primeCandidate);
                    primeList.Add(primeCandidate);
                }
                System.Threading.Thread.Sleep(300);
                primeCandidate += 2;
            }
           
        }

        private static void PrintFibonacciSequence()
        {
            // 1, 1, 3, 5, 8, 13
            int previous = 0;
            int current = 1;
            while (true)
            {
                Console.WriteLine(current);
                System.Threading.Thread.Sleep(100);
                int newValue = previous + current;
                previous = current;
                current = newValue;
            }
        }

        private static void PrintIntegers()
        {
            int nextInteger = 0;
            while (true)
            {
                nextInteger++;
                Console.WriteLine(nextInteger);
            }
        }
    }
}