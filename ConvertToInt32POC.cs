using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertToInt32Method
{
    class ConvertToInt32POC
    {
        public static void Main(String[] args)
        {
            string[] values = { "One", "1.34e28", "-26.87", "-18", "-6.00",
                    " 0", "137", "1601.9", Int32.MaxValue.ToString() };
            int result;

            foreach (string value in values)
            {
                try
                {
                    result = Convert.ToInt32(value);
                    Console.WriteLine("Converted the {0} value '{1}' to the {2} value {3}.",
                                      value.GetType().Name, value, result.GetType().Name, result);
                }
                catch (OverflowException)
                {
                    Console.WriteLine("{0} is outside the range of the Int32 type.", value);
                }
                catch (FormatException)
                {
                    Console.WriteLine("The {0} value '{1}' is not in a recognizable format.",
                                      value.GetType().Name, value);
                }
            }
        }
    }
}
