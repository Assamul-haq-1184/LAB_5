using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company();
            
            Employee E1 = new Employee(1001, "Ali", "Arham", "13-1-2005", 30000, "IT");
            Employee E2 = new Employee(1007, "Raza", "Ali", "1-1-2005", 40000, "Textile");
            Employee E3 = new Employee(1003, "Athar", "Zaid", "15-6-2005", 60000, "FBS");
            Employee E4 = new Employee(1008, "Arham", "Bilal", "11-3-2006", 50000, "Design");
            company.Add_employee(E1);
            company.Add_employee(E4);
            company.Add_employee(E3);
            company.Add_employee(E2);
            company.Display();
       
            Console.WriteLine("Enter employee id which you want remove :");
            int id = int.Parse(Console.ReadLine());
            company.Remove_employee(id);
            company.Display();
        }
    }
}
