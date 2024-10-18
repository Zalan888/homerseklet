using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homerseklet
{
    internal class Program
    {
        static int[] temps = new int[7];

        static void input()
        {
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine($"Kérem a(z) {i + 1}. nap hőmérsékletét");
                temps[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        static void Main(string[] args)
        {
        }
    }
}
