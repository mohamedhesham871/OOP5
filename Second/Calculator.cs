using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Second
{
    internal class Calculator
    {
        //Sum for int
        static public int Sum(int x,int y)
        {
            return x + y;
        }
        //sum for Double
        static public double Sum(double x, double y)
        {
            return x + y;
        }
        //concat strings
        static public string Sum(string x, string y)
        {
            return x + y;
        }
        //****************************************
        //sub for int 
        static public object Sub(int x,int y)
        {
            return x - y;
        }
        //sub for double
        static public double Sub(double x, double y)
        {
            return x - y;
        }
        //****************************************
        //fro int 
        static public int Mulit(int x,int y)
        {
            return x *y;
        }
        //for double 
        static public double Mulit(double x, double y)
        {
            return x * y;
        }
        //****************************************
        // for int 
        static public object Divide(int x,int y)
        {
            if (x != 0)
                return x / y;
            else
                return 0;
        }
        //for double 
        static public double Divide(double x, double y)
        {
            if (x != 0)
                return x / y;
            else
                return 0;
        }

    }
}
