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

        static int avaragetemp()
        {
            int avarage = 0;
            foreach (int i in temps)
            {
                avarage += i;
            }
            avarage /= 7;

            return avarage;
        }

        static int maxtemp()
        {
            int max = temps[0];
            foreach (int i in temps)
            {
                if (i > max)
                {
                    max = i;
                }
            }
            return max;
        }

        static void Main(string[] args)
        {
            input();
        }
    }
}
