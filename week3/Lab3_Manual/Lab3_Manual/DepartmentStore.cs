using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Manual
{
    class Product
    {
        public string productName;
        public string productCategory;
        public int productPrice;
        public int stockQuantity;
        public int MinimumStockQuantity;

        public Product()
        {
            productName = string.Empty;
            productCategory = string.Empty;
            productPrice = 0;
            stockQuantity = 0;
            MinimumStockQuantity = 0;
        }
        public Product(string name, string category, int price, int stock, int quantity)
        {
            productName = name;
            productCategory = category;
            productPrice = price;
            stockQuantity = stock;
            MinimumStockQuantity = quantity;
        }
        // copy constructor left
        public Product AddProduct()
        {
            Product product = new Product();
            Console.WriteLine("Enter Product Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Product Category: ");
            string category = Console.ReadLine();
            Console.WriteLine("Enter Product Price: ");
            int price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Product Stock Quantity: ");
            int stock_quantity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Product minimum stock quantity: ");
            int min_stock_quantity = Convert.ToInt32(Console.ReadLine());

            product.productName = name;
            product.productCategory = category;
            product.productPrice = price;
            product.stockQuantity = stock_quantity;
            product.MinimumStockQuantity = min_stock_quantity;
            return product;
        }

        public void PrintProduct()
        {
            Console.WriteLine("Product Name: " + productName);
            Console.WriteLine("Productcategory: " + productCategory);
            Console.WriteLine("Product Price: " + productPrice);
            Console.WriteLine("Product Stock Quantity: " + stockQuantity);
            Console.WriteLine("Product Minimum Stock Quantity: " + MinimumStockQuantity);
        }

        public double salesTax(Product product)
        {
            double sales_tax;
            if(product.productCategory == "Groceries")
            {
                sales_tax = (0.1 * product.productPrice) + product.productPrice;
                return sales_tax;
            }
            else if(product.productCategory == "FreshFruit")
            {
                sales_tax = (0.05 * product.productPrice) + product.productPrice;
                return sales_tax;
            }
            return 0;
        }


    }
}
