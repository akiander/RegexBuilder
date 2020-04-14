using System;

namespace RegexBuilder
{
    public partial class RegexBuilder
    {
        public static string Numeric(this string source, int start = 0, int end = 9)
        {
            if (start < 0 || start > 9)
            {
                throw new ArgumentException($"{nameof(start)} must be between 0 and 9");
            }

            if (end < 0 || end > 9)
            {
                throw new ArgumentException($"{nameof(end)} must be between 0 and 9");
            }

            if (end < start)
            {
                throw new ArgumentException($"{nameof(end)} ({end}) must be greater than or equal to {nameof(start)} ({start})");
            }

            source += $"{start}-{end}";
            return source;
        }
    }
}
