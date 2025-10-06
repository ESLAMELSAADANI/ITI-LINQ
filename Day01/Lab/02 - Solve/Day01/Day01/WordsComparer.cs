using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01
{
    internal class WordsComparer : IEqualityComparer<string>
    {
        bool IEqualityComparer<string>.Equals(string? x, string? y)
        {
            if (x == null || y == null) return false;

            string cleanX = new string(x.ToLower().Trim().OrderBy(c => c).ToArray());
            string cleanY = new string(y.ToLower().Trim().OrderBy(c => c).ToArray());

            return cleanX == cleanY;
        }

        int IEqualityComparer<string>.GetHashCode(string obj)
        {
            // Normalize the word (trim, lowercase, sort letters)
            string clean = new string(obj.ToLower().Trim().OrderBy(c => c).ToArray());
            return clean.GetHashCode();
        }
    }
}
