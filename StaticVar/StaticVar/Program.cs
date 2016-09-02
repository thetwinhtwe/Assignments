using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticVar
{
    class Program
    {
        class StaticVar
        {
            public static int num=0;
            public void count()
            {
                num++;
            }
            public static int getNum()
            {
                return num;
            }
        }
        class StaticTester
        {
            static void Main(string[] args)
            {
                StaticVar s = new StaticVar();
                s.count();
                s.count();
                s.count();
                Console.WriteLine("Variable num: {0}", StaticVar.getNum());
                Console.ReadKey();
            }
        }
    }
}
