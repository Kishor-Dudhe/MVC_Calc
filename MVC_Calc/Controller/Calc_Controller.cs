using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Calc
{
    public class Calc_Controller
    {

        public int sum(int a, int b)
        {
            int c = a + b;
            return c;
        }

        public int sub(int a, int b)
        {
            int c = a - b;
            return c;
        }

        public int mul(int a, int b)
        {
            int c = a * b;
            return c;
        }

        public int div(int a, int b)
        {
            int c = a / b;
            return c;
        }
        
    }
}
