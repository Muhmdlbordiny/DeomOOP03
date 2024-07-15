using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeomOOP03.PolyMorphismoverriding
{
    //Type C => Direct parent {typeB}
    //TypeC =>inDirect parent{TypeA}
    public class TypeC:TypeB
    {
        public int C {  get; set; }
        public TypeC( int a , int b , int c):base(a,b)
        {
            C = c;
        }
        public new void MyFunc01()
        {
            Console.WriteLine("Iam Derived [Grand Child]");
        }
        public override void MyFunc02()
        {
            Console.WriteLine($"Type C .. A : {A},B :{B} , C :{C}");
        }
    }
}
