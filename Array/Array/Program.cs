using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[100]; 

            for (int i = 0; i < 100; i++)
            {
                num[i] = i + 100;
            }

            foreach (int j in num)
            {
                int i = j - 100;
                Console.WriteLine("Element[{0}] = {1}", i, j);

            }
            Console.ReadKey();
        }
    }
}
