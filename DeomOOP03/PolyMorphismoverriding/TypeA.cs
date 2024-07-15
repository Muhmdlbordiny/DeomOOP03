using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeomOOP03.PolyMorphismoverriding
{
    public class TypeA
    {
        public TypeA(int a)
        {
            A = a;
        }

        public int A {  get; set; }
        //Automatic property 
        // compiler will generate hidden private Attribute [backingfield]


        //object member function [non static function]
        public void MyFunc01()
        {
            Console.WriteLine("I am base [parent]");
        }
        public virtual void MyFunc02()
        {
            Console.WriteLine($"Type A  : A {A}");
        }
    }
}
