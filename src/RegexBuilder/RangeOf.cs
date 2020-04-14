using System;
using System.Collections.Generic;
using System.Text;

namespace RegexBuilder
{
    public partial class RegexBuilder
    {
        public static string RangeOf(this string source, int start = 0, int? end = null, Func<string,string> items = null)
        {
            if (string.IsNullOrWhiteSpace(source))
            {
                source = string.Empty;
            }

            if (end.HasValue && end < start)
            {
                throw new ArgumentException($"{nameof(end)} ({end}) must be greater than or equal to {nameof(start)} ({start})");
            };

            source += "[";

            if (items != null)
            {
                source += items(string.Empty);
            }

            source += "]";

            if (start == 0 && !end.HasValue)
            {
                source += "*";
            } 
            else if (start == 1 && !end.HasValue)
            {
                source += "+";
            }
            else if (end.HasValue && start == end)
            {
                source += $"{{{start}}}";
            }
            else
            {
                source += $"{{{start}, {end}}}";
            }

            return source;
        }
    }
}
