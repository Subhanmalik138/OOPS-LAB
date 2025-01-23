using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array=new int[3];
            for (int i = 0; i < array.Length; i++)
            {
                array[i]=int.Parse(Console.ReadLine());
            }
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if(max<array[i])
                {
                    max = array[i];
                }
            }
            Console.WriteLine(max);
            


        }
    }
}
