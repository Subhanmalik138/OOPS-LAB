using Lab2_Manual;
using System;



//// default constructor
//clockType empty_time = new clockType();
//Console.Write("Empty Time: ");
//empty_time.printTime();

//// parameterized constructor
//clockType hour_time = new clockType(8);
//Console.Write("Hour Time: ");
//hour_time.printTime();

//// parameterized constructor
//clockType minute_time = new clockType(8,10);
//Console.Write("Hour Time: ");
//minute_time.printTime();

//// parameterized constructor
//clockType full_time = new clockType(8,10,10);
//Console.Write("Hour Time: ");
//full_time.printTime();

//full_time.incrementSecond();
//Console.Write("Full time (increment second): ");
//full_time.printTime();

//full_time.incrementhours();
//Console.Write("Full time (increment hours): ");
//full_time.printTime();

//full_time.incrementminutes();
//Console.Write("Full time (increment minutes): ");
//full_time.printTime();

//bool flag = full_time.isEqual(9, 11, 11);
//Console.WriteLine("Flag: " + flag);


//// elapsedTime and RemainingTime
//int elapsed_time = full_time.elapsedTime(full_time);
//Console.WriteLine("Elapsed Time: " + elapsed_time + "seconds");

//int remaining_time = full_time.remainingTime(full_time);
//Console.WriteLine("Remianing Time: " + remaining_time + "seconds");


////difference in two clocks
//int diff = full_time.difference(full_time, 11, 14, 37);
//Console.WriteLine("Differnce: " + diff + "seconds");

//Console.WriteLine("--------------------------------------------------------------------------------");



Product[] products = new Product[20];
int productCount = 0;


products[0] = new Product("Grapes", "FreshFruit", 32, 50, 10);
productCount++;

Product temp = new Product();
products[1] = temp.AddProduct();
productCount++;

// Find Product with Highest Unit Price
Product highestPriceProduct = products[0];

for (int i = 1; i < productCount; i++)
{
    if (products[i].productPrice > highestPriceProduct.productPrice)
    {
        highestPriceProduct = products[i];
    }
}
Console.WriteLine("Product with Highest Unit Price is below");
highestPriceProduct.PrintProduct();


// Products to be Ordered. (less than the threshold)
Product[] productsToOrder = new Product[20];
for (int i = 0, j = 0; i < productCount; i++)
{
    if (products[i].stockQuantity < products[i].MinimumStockQuantity)
    {
        productsToOrder[j++] = products[i];
    }
}

if (productsToOrder.Length == 0)
{
    Console.WriteLine("No products are to be ordered yet");
}

Console.WriteLine("Products to be Ordered are Below");
for (int i = 0; i < productsToOrder.Length; i++)
{
    productsToOrder[i].PrintProduct();
    Console.WriteLine("--------------------------------------------------");
}