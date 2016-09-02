using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(2);
            list.Add(3);
            list.Add(7);


            foreach (int prime in list)
            {
                System.Console.WriteLine(prime);
                Console.ReadLine();
            }
        }
    }
}
