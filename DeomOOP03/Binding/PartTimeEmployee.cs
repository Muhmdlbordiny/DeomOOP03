using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeomOOP03.Binding
{
    public class PartTimeEmployee:Employee
    {
        public int CountOfHours { get; set; }
        public decimal HourRate {  get; set; }
        public new void GetEmployeeType()
        {
            Console.WriteLine("I am partTimeEmployee");
        }
        public override void GetEmployeeData()
        {
            Console.WriteLine($"FulltimeEmployee :Id {Id}, Name :{Name} , Age :{Age}, Hour rate :{HourRate} , countof hours {CountOfHours}");
        }
    }
}
