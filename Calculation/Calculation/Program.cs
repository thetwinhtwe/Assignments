using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Calculation
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 5;
            /* Addition */
            int add = b + a;

            /* Subtraction */
            int sub = b - a;

            /* Multiplication */
            int mul = b * a;

            /* Division */
            double div = b % a;

            Console.WriteLine("a = {0}", a);
            Console.WriteLine("b = {0}", b);
            Console.WriteLine("Addition: a + b = {0}",add);
            Console.WriteLine("Subtraction: b - a = {0}", sub);
            Console.WriteLine("Multiplication: b * a = {0}", mul);
            Console.WriteLine("Division: b % a = {0}", div);
            Console.ReadLine();
        }
    }
}
