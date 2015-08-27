using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadKey(true);
            //EulerFunctions.MultiplesOf3And5(1000);

            EulerFunctions.EvenFibonacciNumbers(4000000);
            Console.ReadKey(true);
        }
    }

    class EulerFunctions
    {
        public static void MultiplesOf3And5(int a_limit)
        {
            /*int currentNumber;
            int currentMultiplier = 0;
            List<int> resultsThrees = new List<int>();
            List<int> resultsFives = new List<int>();
            bool limitReached = false;
            //threes
            while (!limitReached)
            {
                currentMultiplier++;
                currentNumber = 3 * currentMultiplier;
                if (currentNumber < a_limit)
                {
                    resultsThrees.Add(currentNumber);
                }
                else
                {
                    limitReached = true;
                }
            }//end threes
            currentMultiplier = 0;
            limitReached = false;
            //fives
            while (!limitReached)
            {
                currentMultiplier++;
                currentNumber = 5 * currentMultiplier;
                if (currentNumber < a_limit)
                {
                    resultsFives.Add(currentNumber);
                }
                else
                {
                    limitReached = true;
                }
            }//end Fives*/

            //List<int> results = new List<int>();
            int sumAll = 0;

            for (int i = 1; i < a_limit; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    Console.Write(i + ", ");
                    //Console.WriteLine();
                    sumAll += i;
                }
            }
            Console.WriteLine();
            Console.WriteLine(sumAll);
        }

        public static void EvenFibonacciNumbers(int a_limit)
        {
            //List<int> results = new List<int>();
            List<int> sequence = new List<int>();
            sequence.Add(1);
            sequence.Add(2);
            bool limitReached = false;
            int sumAll = 0;
            while (!limitReached)//Make the Fibonacci sequence
            {
                int nextNumber = sequence[sequence.Count - 1] + sequence[sequence.Count - 2];
                if (nextNumber < a_limit)
                {
                    sequence.Add(nextNumber);
                    Console.Write(nextNumber + ", ");                   
                }
                else
                {
                    limitReached = true;
                }
            }

            foreach (int i in sequence)
            {
                if (i % 2 == 0)
                {
                    sumAll += i;
                }
            }

            Console.WriteLine();
            Console.WriteLine(sumAll);
            /*foreach (int i in sequence)
            {
                Console.Write(i + ", ");
            }*/
        }
    }
}
