using System;
using System.Collections.Generic;
using System.Text;

namespace RegexBuilder
{
    public partial class RegexBuilder
    {
        public static string Exactly(this string source, int num, Func<string,string> items = null)
        {
            if (string.IsNullOrWhiteSpace(source))
            {
                source = string.Empty;
            }

            source += "[";

            if (items != null)
            {
                source += items(string.Empty);
            }

            source += "]";

            source += $"{{{num}}}";
          
            return source;
        }
    }
}
