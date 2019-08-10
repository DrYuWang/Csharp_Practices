using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Chicken gogo = new Chicken() ;
            gogo.scientificName = "comecome";
            gogo.Fly();
            Mackerel soso = new Mackerel();
            soso.Hunt();
             
        }
    }
}
