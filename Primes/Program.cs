using System;
using System.Collections;

namespace Primes
{
    class Program
    {
        private static int[] CalcPrimes(int a, int b)
        {
            var arrayList = new ArrayList();

            for (var i = a; i <= b; i++)
            {
                var isPrime = true;

                //The conveintion in C# is to start body expressions in a seperate line and with bracets "{ }", even for oneliners
                if ((i & 1) == 0)
                {
                    if (i != 2)
                    {
                        isPrime = false;
                    }
                }
                for (var j = 3; (j*j) <= i; j += 2)
                {
                    if (i%j == 0)
                    {
                        isPrime = false;
                    }
                }
                if (isPrime)
                {
                    arrayList.Add(i);
                }
            }

            var myPrimesArray = new int[arrayList.Count];
            arrayList.CopyTo(myPrimesArray);

            return myPrimesArray;
        }
        static void Main()
        {

            //consider better names
            const int fn = 3;
            const int sn = 20;
            var calculatePrimes = CalcPrimes(fn, sn);

            //The conveintion in C# is to start body expressions in a seperate line and with bracets "{ }", even for oneliners
            foreach (var prime in calculatePrimes)
                Console.WriteLine(prime);
        }
    }
}
