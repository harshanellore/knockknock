using System;

namespace KnockKnockService
{
    internal class FibonacciSeries
    {
        /// <summary>
        ///  Calculates Nth finonacci number using fast doubling algorithm.
        ///  https://www.nayuki.io/page/fast-fibonacci-algorithms
        /// </summary>
        /// <param name="n">N - the Nth number to find in the fibonacci series</param>
        /// <returns>Nth fibonacci number</returns>
        public static long FastDoublingFibonacci(long n)
        {
            // handle negative index
            var index = Math.Abs(n);

            long fOfN = 0;

            long fOfNPlus1 = 1;

            for (var i = 63; i >= 0; i--)
            {
                //  F(2k)=F(k)[2F(k+1)−F(k)]
                //  F(2k+1)=F(k+1)2+F(k)2
                var fOf2K = fOfN * (fOfNPlus1 * 2 - fOfN);

                var fOf2KPlus1 = fOfN * fOfN + fOfNPlus1 * fOfNPlus1;

                fOfN = fOf2K;

                fOfNPlus1 = fOf2KPlus1;

                if ((((ulong)index >> i) & 1) != 0)
                {
                    var nextFib = fOfN + fOfNPlus1;

                    fOfN = fOfNPlus1;

                    fOfNPlus1 = nextFib;
                }
            }

            if (n < 0) return -1 * fOfN;

            return fOfN;
        }
    }
}