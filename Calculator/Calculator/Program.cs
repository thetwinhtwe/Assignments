using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo operation;
            //Console.TreatControlCAsInput = true;
            int add, sub, mul;
            float div;
            //do{
                Console.WriteLine("Choose Operation Type \n [a] to Addition \n [s] to Subtraction \n [m] to Multiplication \n [d] to Division \n [ESC] to EXIT \n");
                operation = Console.ReadKey();
                Console.WriteLine("\nEnter First Number");
                int num1;
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nEnter Second Number");
                int num2;
                num2 = Convert.ToInt32(Console.ReadLine());
                switch (operation.KeyChar)
                {
                    case 'a':
                        add = num1 + num2;
                        Console.WriteLine("Addition: {0}", add);
                        break;
                    case 's':
                        sub = num1 - num2;
                        Console.WriteLine("Subtraction: {0}", sub);
                        break;
                    case 'm':
                        mul = num1 * num2;
                        Console.WriteLine("Multiplication: {0}", mul);
                        break;
                    case 'd':
                        div = (float)num1 / num2;
                        Console.WriteLine("Division: {0}", div);
                        break;
                    default:
                    Console.WriteLine("Type ESC to Quit");
                        break;


                }
            Console.ReadLine();

           // } while (operation.Key != ConsoleKey.Escape);
        }
    }
}
