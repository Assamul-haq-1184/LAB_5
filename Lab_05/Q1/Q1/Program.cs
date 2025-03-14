using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            ShoppingCart cart = new ShoppingCart();
            Product P1 = new Product(1001,"Banana",120.0);
            Product P2 = new Product(1002, "Bread", 190.0);
            Product P3 = new Product(1003, "Mango Jam", 1220.0);
            Product P4 = new Product(1004, "Apple", 220.0);
            cart.Add_product(P1);
            cart.Add_product(P2);
            cart.Add_product(P3);
            cart.Add_product(P4);
            cart.Display_products();
            Console.WriteLine($"Total price of cart ={cart.get_Total_price()}");
            Console.WriteLine("Enter id of product which you want to remove :");
            int id = int.Parse(Console.ReadLine());
            cart.Remove_product(id);
            cart.Display_products();
            
            Console.WriteLine($"Total Price after removing product :{cart.get_Total_price()}");
            

        }
    }
}
