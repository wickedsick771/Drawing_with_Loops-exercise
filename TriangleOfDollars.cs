using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleOfDollars
{
    class TriangleOfDollars
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (var i = 0; i < n; i++)
            {
                Console.Write("$");
                for (var r = 0; r < i; r++)
                {
                    Console.Write(" $");
                }
                Console.WriteLine();
            }
        }
    }
}
