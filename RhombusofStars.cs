using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhombusofStars
{
    class RhombusofStars
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (var i = 1; i <=n; i++)
            {
                Console.Write(new string(' ', n - i));
                Console.Write('*');

                for (int row = 0; row < i-1; row++) 
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
            for (var i = n - 1; i > 0; i--)
            {
                Console.Write(new string(' ', n - i));
                Console.Write('*');
                for (int row = 0; row < i - 1; row++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }
    }
}
