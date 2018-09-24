//Jixian Wang
// class:employee
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE9
{
    class Employee
    {
        //fields
        public string name;
        public string adress;
        public string jobTitle;
        public int employeeNumber;
        public double yearlySalary;

        //constructor
        public Employee()
        {
            name = "Employee";
            adress = "123 Main Street";
            jobTitle = "Worker";
            employeeNumber = 00000;
            yearlySalary = 0.00;

        }

        public Employee(string p_Name, string p_Adress,string p_JobTitle,int p_employeeNumber,double p_YearlySalary)
        {
            name = p_Name;
            adress = p_Adress;
            jobTitle = p_JobTitle;
            employeeNumber = p_employeeNumber;
            yearlySalary = p_YearlySalary;
        }

        //methodt
        public void ChangeName()
        {
            Console.WriteLine("Change {0}'s name...",name);
            Console.WriteLine("What is employee's new name?");
            string newName=Console.ReadLine();
            name = newName;
        }

        public void ChangeSalary()
        {
            Console.WriteLine("Change {0}'s salary...", name);
            Console.WriteLine("What is employee's new salary?");
            string stringSalary = Console.ReadLine();
            double newSalary = double.Parse(stringSalary);
            yearlySalary = newSalary;
        }

        public void PrintEmployee()
        {
            Console.WriteLine("Employee Information:");
            Console.WriteLine("Employee Number: {0}", employeeNumber);
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Address: {0}", adress);
            Console.WriteLine("Title: {0}", jobTitle);
            Console.WriteLine("Salary: ${0}", yearlySalary);
        }
    }
}
