using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace KnockKnockService
{
    internal class StringProcessor
    {
        /// <summary>
        /// Reverses all the words in the string. 
        /// Ex: "Hi there" --> "iH ereht".
        /// Spaces are preserved.
        /// </summary>
        /// <param name="s">string to reverse</param>
        /// <returns>reversed string</returns>
        public static string ReverseWordsUsingRegexSplit(string s)
        {
            if (s == null) throw new ArgumentNullException(nameof(s));

            // Spiltting using REGEX preserves spaces, ex: "Hi    there" ===> "iH    ereht"
            var words = Regex.Split(s, @"([^\w]+)");

            var b = new StringBuilder();

            foreach (var word in words)
            {
                b.Append(new string(word.Reverse().ToArray()));
            }

            return b.ToString();
        }
    }
}