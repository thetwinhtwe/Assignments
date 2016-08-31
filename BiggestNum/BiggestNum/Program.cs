using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiggestNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("\nEnter First Number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter Second Number");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
                Console.WriteLine("\nFirst Number is bigger than the Second");
            else
                Console.WriteLine("\nSecond Number is bigger than the First");

            Console.ReadLine();
        }
    }
}
