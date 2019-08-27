using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading_Practice_20190826
{
    class Program
    {/* Overloading method 
     	• the name of the methods should be exactly the same.
	    • the return types should be the same.
	    • arguments should be different.

     Write two methodes;
     1-Square() which gets an int number and print out its square to the console window.
     2-another method again called Square().This method gets an int array. It prints out the square of each elements of the array. 
     */
     
        //Methods 1
        static public void Square(int x)
        {
            Console.WriteLine(x * x);
        }
        static public void Square(int[] y)
        {
            for (int i = 0; i < y.Length; i++)
            {
                Console.WriteLine(y[i] * y[i]); // Power :  Math.Pow(x, y) = x^y 
            }
        }
        static void Main(string[] args)
        {
            int x = 2;
            int[] y = new int[5] { 3, 4, 5, 6, 7 };
            Square(x);
            Square(y);
        }
      
    }
}
