using System;

namespace KnockKnockService
{
    public class RedPill : IRedPill
    {
        // The token issued by readify to identify a user.
        private readonly Guid _myToken = new Guid("339d7ee0-0b07-4748-b8d9-2b8826775390");

        private readonly Func<long, long> _fibonacciFinder;

        private readonly Func<string, string> _stringReverser;

        private readonly Func<int, int, int, TriangleType> _shapeFinder;

        public RedPill() : this(FibonacciSeries.FastDoublingFibonacci, 
            StringProcessor.ReverseWordsUsingRegexSplit, 
            Triangle.DetermineTriangleShape)
        {
        }

        public RedPill(Func<long, long> fibonacciFinder, 
            Func<string, string> stringReverser, 
            Func<int, int, int, TriangleType> shapeFinder)
        {
            _fibonacciFinder = fibonacciFinder;

            _stringReverser = stringReverser;

            _shapeFinder = shapeFinder;
        }

        /// <summary>
        /// Finds n th fibonacci number 
        /// </summary>
        /// <param name="n">the index of the number</param>
        /// <returns>n th fibonacci number</returns>
        public long FibonacciNumber(long n)
        {
            return _fibonacciFinder(n);
        }

        /// <summary>
        /// Reverses all the words in the string. 
        /// Ex: "Hi there" --> "iH ereht".
        /// Spaces are preserved.
        /// </summary>
        /// <param name="s">string to reverse</param>
        /// <returns>reversed string</returns>
        public string ReverseWords(string s)
        {
            return _stringReverser(s);
        }

        /// <summary>
        /// Returns the token issued to a user
        /// </summary>
        /// <returns>guid - issued to a user</returns>
        public Guid WhatIsYourToken()
        {
            return _myToken;
        }

        /// <summary>
        /// Determines whether a set of 3 sides forms what type of triangle.
        /// </summary>
        /// <param name="a">first side</param>
        /// <param name="b">second side</param>
        /// <param name="c">third side</param>
        /// <returns></returns>
        public TriangleType WhatShapeIsThis(int a, int b, int c)
        {
            return _shapeFinder(a, b, c);
        }
    }
}
