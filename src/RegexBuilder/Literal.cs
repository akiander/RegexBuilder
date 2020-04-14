using System;
using System.Collections.Generic;
using System.Text;

namespace RegexBuilder
{
    public static partial class RegexBuilder
    {
        public static string Literal(this string source, string literal)
        {
            if (string.IsNullOrWhiteSpace(literal))
            {
                throw new ArgumentException($"literal cannot be null or whitespace. If you want whitespace, use one of the dedicated whitespace classes such as Tab or WordBoundary.");
            }
            source += literal;
            return source;
        }
    }
}
