using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            short num1;
            int num2;
            double num3;

            num1 = 10;
            num2 = 20;
            num3 = num1 + num2;
            Console.WriteLine("First Number = {0}, Second Number = {1}, Sum = {2}", num1, num2, num3);
            Console.ReadLine();
        }
    }
}
