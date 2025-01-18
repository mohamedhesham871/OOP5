using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.NewFolder
{
    internal class _3DPonit
    {
        public decimal X {  get; set; }
        public decimal Y { get; set; }
        public decimal Z { get; set; }
        public _3DPonit(int x,int y,int z ) { 
            X = x;
            Y = y;
            Z = z;
        }
        public _3DPonit(int x, int y) : this(x, y, 0) { }
        public _3DPonit(int x) : this(x, 0, 0) { }
        public _3DPonit():this(0,0,0) { }

        public void EnterInput(string s)
        {
            string[] arr = s.Split(',');
            int num = 0;
            bool isTrue = int.TryParse(arr[0], out num);
            X = num;
            isTrue = int.TryParse(arr[1], out num);
            Y = num;
            isTrue = int.TryParse(arr[2], out num);
            Z = num;
        }

        public override string ToString()
        {
            return $"Point Coordinates: ({X}, {Y}, {Z})";
        }
        static public bool operator ==(_3DPonit left , _3DPonit right)
        {
          if(left.X == right.X && left.Y ==right.Y && left.Z ==right.Z)
                return true ;
          else return false ;
        } 
        static public bool operator !=(_3DPonit left , _3DPonit right)
        {
            if (left.X != right.X || left.Y != right.Y || left.Z != right.Z)
                return true;
            else return false;
        }
       


    }
}
