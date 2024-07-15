using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeomOOP03.PolyMorphismoverriding
{
    public class TypeB:TypeA
    {
        public int B {  get; set; }
        public TypeB(int a ,int b):base(a)
        {
            B= b;
        }
        //overriding
        //1.using New keyword
        //2.using override keyword
        //Apply function using new keyword
        //Static Binding [Early binding]
        //MyFunc01()=>static bonded Method
        //static binding works during compile time 
        //compiler will bind function call based on refernce type Not object type
        public new void MyFunc01() //new version from MyFunc01()
        {
            Console.WriteLine("I am a  derived [child] ");
        }
        //Apply function using overriding keyword
        //Function Must be Inherited from parent [public -virtual function]
        //Dynamic binding [Late binding]
        //Myfunc02()=> dynamic bonded Method
        //Dynamic binding works during Run time 
        //ClR will bind function call based on object type not refernce type 

        public override void MyFunc02()
        {
            Console.WriteLine($"Type B .. A : {A},B :{B}");
        }
    }
}
