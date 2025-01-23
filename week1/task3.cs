using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float sum = 0F;
            float number;
            while(true)
            {
                Console.WriteLine("ENTER NUMBERS :");
                number=float.Parse(Console.ReadLine());
                if (number == -1)
                {
                    break;
                }
                sum += number;
            }
            Console.WriteLine($"SUM IS : {sum}");
        }
    }
}
