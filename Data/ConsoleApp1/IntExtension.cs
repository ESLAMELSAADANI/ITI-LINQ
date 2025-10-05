using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal static class IntExtension
    {
        public static void Print(this IComparable number)
        {
            Console.WriteLine(number);
        }
    }
}
