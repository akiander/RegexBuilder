using System;
using System.Collections.Generic;
using System.Text;

namespace RegexBuilder
{
    public partial class RegexBuilder
    {
        public static string Optional(this string source, Func<string,string> items = null)
        {
            if (string.IsNullOrWhiteSpace(source))
            {
                source = string.Empty;
            }

            source += "(?:";

            if (items != null)
            {
                source += items(string.Empty);
            }

            source += ")?";
                
            return source;
        }
    }
}
