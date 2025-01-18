using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1.Third_project
{
    internal class Duration
    {
       public  int Hours { get; set; }
       public  int Minutes {  get; set; }
       public  int Seconds { get; set; }

        public Duration(int hours,int min,int sec)
        {
            Hours = hours; Minutes = min; Seconds = sec;
        }
        public Duration()
        {
            Hours = 0; Minutes = 0; Seconds = 0;
        }
        public Duration(int hoursInsecond) { 
            Hours = hoursInsecond/3600;
            hoursInsecond%=3600 ;
            Minutes = hoursInsecond/60;
            Seconds = hoursInsecond%60;
        }


        static public Duration operator +(Duration left , Duration right)
        {
            return new Duration()
            {
                Hours = left.Hours + right.Hours,
                Minutes = left.Minutes + right.Minutes,
                Seconds = left.Seconds + right.Seconds,
            };
        }
        static public Duration operator +(Duration left,int hoursInsecond)
        {
            Duration result = new Duration();
            result.Hours = left.Hours + (hoursInsecond / 3600);
            hoursInsecond %= 3600;
            result. Minutes = left.Minutes + (hoursInsecond / 60);
            result. Seconds = left.Seconds + (hoursInsecond % 60);
            return result;
            
        }

        static public Duration operator +( int hoursInsecond, Duration left)
        {
            Duration result = new Duration();
            result.Hours = left.Hours + (hoursInsecond / 3600);
            hoursInsecond %= 3600;
            result.Minutes = left.Minutes + (hoursInsecond / 60);
            result.Seconds = left.Seconds + (hoursInsecond % 60);
            return result;

        }

        static public Duration operator ++(Duration left)
        {

            return new Duration()
            {
                Hours = left.Hours,
                Minutes = left.Minutes + 1,
                Seconds = left.Seconds,
            };
        }
        static public Duration operator --(Duration left)
        {

            return new Duration()
            {
                Hours = left.Hours,
                Minutes = left.Minutes - 1,
                Seconds = left.Seconds,
            };
        }
        static public Duration operator -(Duration left, Duration right)
        {
            return new Duration()
            {
                Hours =   (left.Hours - right.Hours)>0?(left.Hours - right.Hours) : 0,
                Minutes = (left.Minutes - right.Minutes) > 0 ? (left.Minutes - right.Minutes) : 0,
                Seconds = (left.Seconds - right.Seconds) > 0 ? (left.Seconds - right.Seconds) : 0,
            };
        }
        static public bool operator >(Duration left, Duration right)
        {
           if (left.Hours == right.Hours)
            {
                if (left.Minutes == right.Minutes)
                 {
                    return left.Seconds> right.Seconds;
                 }
                else
                    return left.Minutes > right.Minutes;
            }
           else
                return left.Hours > right.Hours;
        }
        static public bool operator <(Duration left, Duration right)
        {
            if (left.Hours == right.Hours)
            {
                if (left.Minutes == right.Minutes)
                {
                    return left.Seconds < right.Seconds;
                }
                else
                    return left.Minutes < right.Minutes;
            }
            else
                return left.Hours < right.Hours;
        }

        static public bool operator <=(Duration left, Duration right)
        {
            if(left.Hours > right.Hours)
            {
                if( left.Minutes > right.Minutes)
                {
                    return (left.Seconds <= right.Seconds);
                }
                return true;
            }
            else
            {
                return true;
            }

        }
        static public bool operator >=(Duration left, Duration right)
        {
            if (left.Hours < right.Hours)
            {
                if (left.Minutes < right.Minutes)
                {
                    return (left.Seconds <= right.Seconds);
                }
                return true;
            }
            else
            {
                return true;
            }
        }

        static public explicit operator DateTime(Duration D)
        {
            return new DateTime(2025,1,17,D.Hours,D.Minutes,D.Seconds) {
            };
            
        }

        //  Override All System.Object Members(ToString, Equals, GetHasCode) .
        public override string ToString()
        {
            if(Hours != 0) 
            return$"Hours {Hours} Minutes {Minutes} Seconds {Seconds}";
            else if(Minutes != 0)
                return $"Minutes {Minutes} Seconds {Seconds}";
            else 
                return $"Seconds {Seconds}";
        }

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            else   return true;
        }

        public override int GetHashCode()
        {
            return RuntimeHelpers.GetHashCode(this);
        }
    }
}
