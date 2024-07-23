using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4
{
    internal class Helper
    {
        public int x {  get; set; }
        public int y { get; set; }

        public static double PI;

        public Helper() { }

        static Helper() { 
          
            /*
             * static CTOR 
             * can't specify access modifier ,parameters
             * can't be overloaded
             * can't be called explicity
             * 
             * static CTOR will be executed before the first use of the class
             * 1.create object from the class 
             * 2.create object from type that inherits from the class
             * 3.use of any static member
             */
              PI=Math.PI;
        }

        public static double convertTCm(double inch)
        {
            return inch * 2.54;
        }

        public static double circleArea(double r)
        {

            return r * r* PI; 
        } 


    }
}
