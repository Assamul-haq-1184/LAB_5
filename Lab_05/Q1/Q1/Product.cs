using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    class Product
    {
       public int Product_ID;
       public string Name;
       public double Price;
        public Product(int Product_ID, string Name, double Price)
        {
            this.Product_ID = Product_ID;
            this.Name = Name;
            this.Price = Price;
        }
  


    }
}
