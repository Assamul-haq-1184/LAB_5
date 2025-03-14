using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    class ShoppingCart
    {
        private int Cart_ID;
        private string customer_name;
        private double Total_price;
        private Product[] products;
        private int product_count;

        public ShoppingCart()
        {
            Cart_ID = 012789;
            customer_name = "";
            products = new Product[10];
            product_count = 0;
            Total_price = 0.0;
        }
       

        public void Add_product(Product product)
        {
            products[product_count] = product;
            product_count++;

            Total_price += product.Price;
        }
        public void Remove_product(int productID)
        {
            for (int i = 0; i < product_count; i++)
            {
                if (products[i].Product_ID == productID)
                {
                    Total_price = Total_price - products[i].Price;
                    for (int j = i; j < product_count - 1; j++)
                    {
                        products[j] = products[j + 1];
                        
                    }
                    product_count--;
                    
                    Console.WriteLine($"Removed product with ID: {productID}");
                    return; 
                }
            }
            Console.WriteLine("Product not found.");
        }

        public void Display_products()
        {
            Console.WriteLine($"\t\t\t\t----Products in Cart----");
            for (int i = 0; i < product_count; i++)
            {
                Console.WriteLine($"Product {i+1} Detail :");
                Console.WriteLine($"-Product ID = {products[i].Product_ID}");
                Console.WriteLine($"-Product Name = {products[i].Name}");
                Console.WriteLine($"-Product Price = {products[i].Price}\n");
                
            }
        }
        public int get_id()
        {
            return Cart_ID;
        }
        public string get_customer_name()
        {
            return customer_name;
        }
        public double get_Total_price()
        {
            return Total_price;
        }

    }
}
