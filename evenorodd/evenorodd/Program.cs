using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evenorodd
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            Console.WriteLine("Enter Your Numbers");
            num = Convert.ToInt32(Console.ReadLine());
            String output = (num %2 == 0) ? "Even" : "Odd";
            Console.WriteLine("You entered: {0}, therefore your number is {1}",num,output);
            Console.ReadKey();
        }
    }
}
