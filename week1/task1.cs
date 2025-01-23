using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER YOUR MARKS :");
            float marks = float.Parse(Console.ReadLine());
            if (check(marks))
            {
                Console.WriteLine("YOUR ARE PASSED :");

            }
            else
            {
                Console.WriteLine("YOU ARE FAILLED :");
            }
        }
        static bool check(float marks)
        {
            if (marks > 50)
            {
                return true;

            }
            else
            {
                return false;
            }

        }
    }
}
