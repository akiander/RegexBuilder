using System;
using System.Collections.Generic;
using System.Text;

namespace RegexBuilder
{
    public static partial class RegexBuilder
    {
        public static string WordBoundary(this string source)
        {
            source += @"\b";
            return source;
        }
    }
}
