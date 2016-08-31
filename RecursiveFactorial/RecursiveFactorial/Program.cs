using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveFactorial
{
    class Program
    {
        public int factorial(int num)
        {
            int result;
            if (num == 1)
            {
                return 1;
            }
            else
            {
                result = factorial(num - 1) * num;
                return result;
            }
        }

        static void Main(string[] args)
        {
            Program n = new Program();
            Console.WriteLine("\nEnter Your Number for Factorial Calculation");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Factorial of Your Number is : {0}", n.factorial(num1));
            Console.ReadLine();
        }
    }
}
