﻿using System;
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
            int primeCandidate = 0;
            primeList.Add(0);
            for (int i = 0; i < primeList.Count; i++)
            {
                primeCandidate = i;
               
                    Console.WriteLine(primeCandidate);
                    primeList.Add(primeCandidate);
                    primeList.ForEach(Console.WriteLine);
                
               
                System.Threading.Thread.Sleep(300);
            }

            Console.WriteLine("Well, Actually... I Lied..");
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