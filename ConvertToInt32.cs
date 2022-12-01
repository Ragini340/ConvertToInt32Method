using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertToInt32Method
{
    class ConvertToInt32
    {
     public static void Main(string[] args)
        {
            double number = 40.5;
          
            int num = Convert.ToInt32(number);
          
            Console.WriteLine("Converted number {0} to {1} in 32-bit signed integer.", number, num);
            
        }
    }
}
