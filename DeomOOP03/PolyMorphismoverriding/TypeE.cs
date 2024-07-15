using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeomOOP03.PolyMorphismoverriding
{
    /// typeA => indiect parent 
    /// typeB => indiect parent 
    /// typec => indiect parent  
    /// typeD=> diect parent 

    public class TypeE:TypeD
    {
        public int E { get; set; }
        public TypeE(int a, int b ,int c,int d, int e):base(a,b,c,d)
        {
            E = e;
        }
        public override void MyFunc02()
        {
            Console.WriteLine($"Type E  A : {A},B :{B} , C :{C} , D :{D}, E :{E}") ;
        }
    }
}
