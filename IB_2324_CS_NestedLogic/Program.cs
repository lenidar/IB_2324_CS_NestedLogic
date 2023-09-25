using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IB_2324_CS_NestedLogic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // right triangle
            for(int x = 0; x < 10; x++)
            {
                for(int y = 0; y <= x; y++)
                {
                    Console.Write("-");
                }
                Console.WriteLine();
            }
            // horizontal mirror right triangle
            for (int x = 10; x > 0; x--)
            {
                for (int y = 0; y < x; y++)
                {
                    Console.Write("x");
                }
                Console.WriteLine();
            }

            /*
             *      ---------x
             *      --------xx
             *      -------xxx
             *      ------xxxx
             *      -----xxxxx
             *      ----xxxxxx
             *      ---xxxxxxx
             *      --xxxxxxxx
             *      -xxxxxxxxx
             *      xxxxxxxxxx
             */

            for(int x = 1; x < 11; x++)
            {
                for(int y = 10 - x; y > 0; y--)
                {
                    Console.Write("-");
                }
                for(int y = 0; y < x; y++)
                {
                    Console.Write("x");
                }
                Console.WriteLine();
            }

            for(int x = 1; x < 11; x++)
            {
                for (int y = 1; y <= x - 1; y++)
                {
                    Console.Write("-");
                }
                for (int y = 11 - x; y > 0; y--)
                {
                    Console.Write("x");
                }
                Console.WriteLine();
            }


            Console.ReadKey();
        }
    }
}
