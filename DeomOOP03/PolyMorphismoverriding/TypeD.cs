using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeomOOP03.PolyMorphismoverriding
{
    /// TypeA => indirect parent  <summary>
    /// TypeB => indirect parent 
    /// TypeC =>Direct parent 
    public class TypeD:TypeC
    {
        public int D {  get; set; }
        public TypeD(int a, int b , int c, int d):base(a,b,c)
        {
            D = d;
        }
        public new void MyFunc01()
        {
            Console.WriteLine("I am Derived [Child  Grand Child]");
        }
        //MyFunc02() => public viritual
        //New => end old  sequence
        //virtual => start new sequence 
        //IntypeD MyFunc02() public new => you can  not override using Keyword override
        //IntypeD MyFunc02() public new virtual => you can   override using Keyword override [New Sequence]
        public new virtual  void MyFunc02()
        {
            Console.WriteLine($"Type D  . A : {A},B :{B} , C :{C} , D :{D}");
        }
    }
}
