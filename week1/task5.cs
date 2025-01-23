using System;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            Console.WriteLine("Enter Lilly's age: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the price of the washing machine: ");
            double machinePrice = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the price of each toy: ");
            int toyPrice = int.Parse(Console.ReadLine());

            double totalMoney = 0;  
            int totalToys = 0;      
            double currentGiftMoney = 10; 

   
            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0) 
                {
                    totalMoney += currentGiftMoney;
                    currentGiftMoney += 10;
                    totalMoney--; 
                }
                else 
                {
                    totalToys++;
                }
            }

          
            totalMoney += totalToys * toyPrice;

           
            if (totalMoney >= machinePrice)
            {
                Console.WriteLine($"Yes! {totalMoney - machinePrice:F2}");
            }
            else
            {
                Console.WriteLine($"No! {machinePrice - totalMoney:F2}");
            }
        }
    }
}
