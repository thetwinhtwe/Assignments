using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] fruits = { "apple", "banana", "orange" };
            string[] fruits = new string[] { "orange", "banana", "apple"};

            for (int i = 0; i < fruits.Length; i++)
            {
                Console.WriteLine("Fruits: {0}", fruits[i]);
            }
            Console.ReadLine();

        }
    }
}
