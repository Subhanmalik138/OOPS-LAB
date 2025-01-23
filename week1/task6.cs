using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "D:\\textfile.txt";
            StreamReader sr = new StreamReader(path);
            if (File.Exists(path))
            {
                string line;
                while((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }

        }
    }
}
