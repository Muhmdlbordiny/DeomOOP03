using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeomOOP03.Binding
{
    public class FullTimeEmployee:Employee
    {
        public FullTimeEmployee(int id ,string name,int age ,decimal salary):base(id,name,age)
        {
            Salary = salary;
        }

        public decimal Salary { get; set; }
        public new void GetEmployeeType()
        {
            Console.WriteLine("I am FullTimeEmployee");
        }
        public override void GetEmployeeData()
        {
            Console.WriteLine($"FulltimeEmployee :Id {Id}, Name :{Name} , Age :{Age}, Salary :{Salary:c}");
        }
    }
}
