using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Calc
{
    public class Program
    {
        static void Main(string[] args)
        {
            Calc_View c = new Calc_View();
            c.view();
            Console.ReadLine();

        }
        
    }
}
