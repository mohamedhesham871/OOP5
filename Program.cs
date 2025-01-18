using ConsoleApp1.NewFolder;
using ConsoleApp1.Second;
using ConsoleApp1.Third_project;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region First Project 
            ////_3DPonit P = new _3DPonit(10, 20, 30);
            ////Console.WriteLine(P.ToString());

            //Console.WriteLine("Enter x , y, z for point one");
            //string P1_Input = Console.ReadLine();
            //Console.WriteLine("Enter x , y, z for point Two");
            //string P2_Input = Console.ReadLine();



            ////make Point one  
            //_3DPonit P1 = new _3DPonit();
            ////make Point Two
            //_3DPonit P2 = new _3DPonit();
            //int num = 0 ;

            ////enter x,y,z for P1

            //P1.EnterInput(P1_Input) ;

            ////enter x,y,z for P2

            //P2.EnterInput(P2_Input);

            //// equality of two points
            //if(P1==P2)
            //{
            //    Console.WriteLine("Two points are Equal");
            //}

            #endregion

            #region Second Project

            //Console.WriteLine( Calculator.Sum(23.3, 32.2));
            //Console.WriteLine("*************************");
            //Console.WriteLine( Calculator.Sum(12, 12));
            //Console.WriteLine("*************************");
            //Console.WriteLine( Calculator.Mulit(24.2, 4));
            //Console.WriteLine("*************************");
            //Console.WriteLine( Calculator.Divide(2, 9));
            #endregion

            #region Third Project


                 Duration D1 =new  Duration (1,10,15);
            Console.WriteLine( D1.ToString());
            Console.WriteLine("***************************************");
                Duration D2 =new Duration (3600);
            Console.WriteLine( D2.ToString());
            Console.WriteLine("***************************************");
                Duration D3 =new Duration (7800);
            Console.WriteLine(D3.ToString());
            Console.WriteLine("***************************************");
                Duration D4 =new Duration (666);
            Console.WriteLine(D4.ToString());
            Console.WriteLine("***************************************");
            //overloading 
            //1
            Duration D = D1 + D2;
            Console.WriteLine( D.ToString());
            Console.WriteLine("***************************************");
            //2
            D = D1 + 7800;
            Console.WriteLine(D);
            Console.WriteLine("***************************************");
            //3
            D =  666+ D1;
            Console.WriteLine(D);
            Console.WriteLine("***************************************");
            //4
            D = ++D1;
            Console.WriteLine(D);
            Console.WriteLine("***************************************");
            //5
            D = --D4;
            Console.WriteLine(D);
            Console.WriteLine("***************************************");
            //6
            D = D3 - D2;
            Console.WriteLine(D);
            Console.WriteLine("***************************************");
            //7
            Console.WriteLine((D1 > D2));
            Console.WriteLine("***************************************");
            //8
            Console.WriteLine((D1 <= D2));
            Console.WriteLine("***************************************");
            //9
            DateTime Obj = (DateTime)D1;









            #endregion
        }
    }
}
