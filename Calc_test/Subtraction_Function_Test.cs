using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVC_Calc;
using NUnit.Framework;

namespace Calc_test
{
    class Subtraction_Function_Test
    {
        Calc_Controller c = new Calc_Controller();

        public void SubtractTwoPositiveNumber()
        {
            int result;
            result = c.sub(10, 5);
            Assert.AreEqual(5m, result, "Subtraction of two positive number failed");
        }

    }
}
