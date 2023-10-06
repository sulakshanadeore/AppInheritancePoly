using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCodeLibrary
{
    public class Maths
    {
        //1 build library
        //2 reference/add the library (.dll) in the console app

        //instance metthods, ie they are not static
        public int Addition(int i, int j)
        {
            return i + j;
        
        }
        public int subtraction(int i, int j) {
            if (j!=0)
            {
                return i - j;
            }
            return 0;
        
        }

        public int multiply(int i, int j)
        {
            if (j != 0)
            {
                return i * j;
            }
            return 0;
        }
        //Write division
        public double SquareRootOfNumber(double i)
        { 
        return Math.Sqrt(i);
     
        
        }

        //write div with remainder
        

    }
}
