using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    class Employee
    {
        public int Employee_ID;
        public string First_Name;

        public string Last_Name;
        public string DOB;
        public double Salary;
        public string Department;

        public Employee(int employee_ID, string first_Name, string last_Name, string dOB, double salary, string department)
        {
            Employee_ID = employee_ID;
            First_Name = first_Name;
            Last_Name = last_Name;
            DOB = dOB;
            Salary = salary;
            Department = department;
        }
    }
}
