using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destructor
{
    class Program
    {
        
      private double length;   
        public Program()  
        {
            Console.WriteLine("Object is being created");
        }
        ~Program() 
        {
            Console.WriteLine("Object is being deleted");
            Console.ReadLine();
        }

        public void setLength(double len)
        {
            length = len;
        }

        public double getLength()
        {
            return length;
        }

        static void Main(string[] args)
        {
            Program line = new Program();

            
            line.setLength(6.0);
            Console.WriteLine("Length of line : {0}", line.getLength());
        }
     
    }
}

