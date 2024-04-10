using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO2_2
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                Console.WriteLine("Too few arguments!");
                return;
            }
            String control = args[0];
            int start = 0, end = 0;
            try
            {
                start = Convert.ToInt32(args[1]);
                end = Convert.ToInt32(args[2]);
            } catch (FormatException e)
            {
                Console.WriteLine("Incorrect input");
                return;
            }
            if (start > control.Length)
            {
                Console.WriteLine("Incorrect input data");
            }
            int size = end  - start + 1;
            if (size + start > control.Length)
            {
                size = control.Length - start;
            }
            String result = control.Substring(start, size);
            Console.WriteLine(result);
            while (true)
            {

            }
        }
    }
}
