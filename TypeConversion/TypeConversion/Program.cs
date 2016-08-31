using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 20;
            float num2 = 54.005f;
            double num3 = 2468.1234;
            bool num4 = false;

            Console.WriteLine(num1.ToString());
            Console.WriteLine(num2.ToString());
            Console.WriteLine(num3.ToString());
            Console.WriteLine(num4.ToString());
            Console.ReadKey();
        }
    }
}
