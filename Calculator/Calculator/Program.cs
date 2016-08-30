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
                Console.WriteLine("\nEnter First Number");
                int num1;
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nEnter Second Number");
                int num2;
                num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nChoose Operation Type \n [a] to Addition \n [s] to Subtraction \n [m] to Multiplication \n [d] to Division \n [Other KEY] to EXIT \n");
                operation = Console.ReadKey();
            switch (operation.KeyChar)
                {
                    case 'a':
                        add = num1 + num2;
                        Console.WriteLine("\n Addition: {0}", add);
                        //Console.WriteLine("Press Any Key to Exit");
                    break;
                    case 's':
                        sub = num1 - num2;
                        Console.WriteLine("\nSubtraction: {0}", sub);
                        //Console.WriteLine("Press Any Key to Exit");
                    break;
                    case 'm':
                        mul = num1 * num2;
                        Console.WriteLine("\nMultiplication: {0}", mul);
                       // Console.WriteLine("Press Any Key to Exit");
                    break;
                    case 'd':
                        div = (float)num1 / num2;
                        Console.WriteLine("\nDivision: {0}", div);
                        
                    break;
                    case 'x':
                    break;
                    default:
                        break;


                }
            Console.WriteLine("\nPress Any Key to Exit");
            Console.ReadLine();

            //} while (operation.Key != ConsoleKey.Escape);
        }
    }
}
