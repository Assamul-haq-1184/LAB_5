using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    class Company
    {
        private string Company_Name;
        private Employee[] employees;
        private int employee_counter;
        public Company()
        {
            Company_Name ="IT tower";
            employees = new Employee[100];
            employee_counter = 0;
            
        }
        public void Add_employee(Employee employee)
        {
            employees[employee_counter] = employee;
            employee_counter++;
        }
        public void Remove_employee(int employeeID)
        {
            for(int i = 0; i< employee_counter; i++)
            {
                if (employees[i].Employee_ID == employeeID)
                {
                    for (int j = i; j < employee_counter - 1; j++)
                    {
                       employees[j] = employees[j + 1];

                    }
                    employee_counter--;

                    Console.WriteLine($"Removed product with ID: {employeeID}");
                    return;
                }
            }
            Console.WriteLine("Product not found.");
        }
        public void Display()
        {
            Console.WriteLine("\t\t\t\t----Employee Management System----\n");
            for (int i = 0; i < employee_counter; i++)
            {
                Console.WriteLine($"Employee {i + 1} Detail :\n");
                Console.WriteLine($"Employee ID : {employees[i].Employee_ID}");
                Console.WriteLine($"Employee First name: {employees[i].First_Name}");
                Console.WriteLine($"Employee Last name: {employees[i].Last_Name}");
                Console.WriteLine($"Employee Date of birth : {employees[i].DOB}");
                Console.WriteLine($"Employee Salary : {employees[i].Salary}");
                Console.WriteLine($"Employee Department : {employees[i].Department}");
                Console.WriteLine();
            }
        }
    }

}
