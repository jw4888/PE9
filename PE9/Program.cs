//Jixian Wang
//Pe9


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE9
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee("Jane Bobberson","20 Pine Lane","Acountant",24719,75299.20);

            employee1.PrintEmployee();
            employee1.ChangeName();
            employee1.ChangeSalary();
            employee1.PrintEmployee();
        }
    }
}
