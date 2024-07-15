using DeomOOP03.Binding;
using DeomOOP03.PolyMorphismoverriding;
using System.Security.Cryptography.X509Certificates;

namespace DeomOOP03
{
    internal class Program
    {
        //refrence employee 
        //can refer  =>object Employee
        //can refer => object from class inherit from employee [parttimeemployee- fulltimeemployee]
        public static void ProcessEmployee(Employee employee)
        {
            if(employee is not null)
            {
                employee.GetEmployeeType();
                employee.GetEmployeeData();
            }
        }
        //Not overloading 
        //public static void ProcessEmployee(PartTimeEmployee partemployee)
        //{
        //    if (partemployee is not null)
        //    {
        //        partemployee.GetEmployeeType();
        //        partemployee.GetEmployeeData();
        //    }
        //}
        #region  OverLoading
        //Method overloading Using Just for Readbility
        public static int Sum(int X,int Y)
        {
            return X + Y;
        }
        public static int Sum(int X, int Y,int Z)
        {
            return X + Y +Z;
        }
        public static double Sum(double X, double Y)
        {
            return X + Y ;
        }
        public static double Sum(int X, double Y)
        {
            return X + Y;
        }
        #endregion
        static void Main(string[] args)
        {
            #region Polymorhism [overloading]
            //double Result = Sum(5,3.2);
            // Console.WriteLine($"Result = {Result}");
            // Console.WriteLine(1);
            // Console.WriteLine(1.2);
            // Console.WriteLine(1.2M);
            // Console.WriteLine(1.2F);
            // Console.WriteLine("3");
            // Console.WriteLine('h');
            #endregion
            #region PolyMorphism [Overriding]
            //Supported with class only
            //Function Overriding Must be Must be with RelationShip [inheritance]
            TypeA typeA = new TypeA(1);
            typeA.A = 10;
            typeA.MyFunc01();// Iam base [parent]
            typeA.MyFunc02();// typeA :A = 10
            Console.WriteLine("************************");
            TypeB typeB = new TypeB(1, 2);
            typeB.A = 10;
            typeB.B = 20;
            typeB.MyFunc01();
            typeB.MyFunc02();
            #endregion
            #region Binding
            //Ref from parent => object from child 
            //TypeA Refbase;
            /////Declare for ref from type typeA
            /////refBase refer to an object from type typeA
            /////Or refer to an object from any class [inherit from typeA]
            //Refbase = new TypeB(1,2);
            ////binding 
            //Refbase.A =10;
            ////Refbase.B= 20;//Invaild
            //Refbase.MyFunc01();//override using new [static binding] i am base parent
            //Refbase.MyFunc02(); //override using override[Dynamic binding] TypeB :A =10,B=2
            #endregion
            #region Not Binding
            ///Ref from child => object from parent
            ///TypeB childRef = new TypeA(); // Invaild 
            ///TypeB childRef =(TypeB) new TypeA(1); // vaild .. Explicit casting [unsafe]
            //TypeA typeAa = new TypeA(1);//vaild 
            //TypeB typeb = (TypeB)typeAa;//Explicit Casting
            //                            //(TypeB) =>casting operator
            //Console.WriteLine(typeb.A);
            //Console.WriteLine(typeb.B);
            //Sysytem.InvaildCastingException
            //TypeA type_A = new TypeB(1,2);
            //TypeB typeB1 = (TypeB)type_A;
            //Console.WriteLine(typeB1.A);//1
            //Console.WriteLine(typeB1.B);//2
            //object o = 2;
            //int x = (int)o;
            //Console.WriteLine(x);

            #endregion
            #region Ex01 Binding
            FullTimeEmployee fulltimeemployee = new FullTimeEmployee(10, "mohamed", 25, 6000);
            ProcessEmployee(fulltimeemployee);
            ////I am FullTimeEmployee
            //FulltimeEmployee: Id 10, Name: Mohamed , Age: 25, Salary:$6,000.00
            PartTimeEmployee parttimeemployee = new PartTimeEmployee() { Id =10, Name ="7amo",Age =25,CountOfHours = 15, HourRate =1.2M};
            ProcessEmployee(parttimeemployee);
            //employee = new parttimeemployee();


            #endregion
            #region Ex02
            //TypeA typeA1 = new TypeC(1,2,3);
            ////Binding
            //typeA1.A = 10;
            ////typeA1.B = 2;//invaild
            ////typeA1.C = 2;//Invaild
            //typeA1.MyFunc01(); //override using new keyword [static binding] early binding
            //// I am base [parent]
            //typeA1.MyFunc02();//override using override keyword [Dynmic binding] Late binding
            //Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^6^^");
            //TypeB typeB1 = new TypeC(3, 4, 5);
            ////typeB parent for Typec
            //typeB1.A = 10;
            //typeB1.B = 20;
            ////typeB1.C = 30 //Invaild
            //typeB1.MyFunc01(); //static bonded Method  I am derived [child]
            //typeB1.MyFunc02();// Dynamic bonded Method  A=10 B =20 C = 5
            TypeA typeA1 = new TypeE(1,2,3,4,5); //indirect parent
            TypeB typeB1 = new TypeE(1,2,3,4,5);//indirect parent
            TypeC typeC1 = new TypeE(1,2,3,4,5);//indirect parent
            typeA1.MyFunc02();//Dynamic bonded Method 
            typeB1.MyFunc02();//Dynamic bonded Method
            typeC1.MyFunc02();//Dynamic bonded Method
            // last override of MyFunc02() => was in typec
            //TypeD =new virtual
            #endregion
        }
    }
}
