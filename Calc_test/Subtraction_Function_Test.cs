using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVC_Calc;
using NUnit.Framework;

namespace Calc_test
{
    [TestFixture]

    class Subtraction_Function_Test
    {
        Calc_Controller c = new Calc_Controller();

        [TestCase]
        public void SubtractTwoPositiveNumber()
        {
            int result;
            result = c.sub(10, 5);
            Assert.AreEqual(5m, result, "Subtraction of two positive number failed");
        }

        [TestCase]
        public void SubtractOnePositiveOneNegativeNumber()
        {
            int result;
            result = c.sub(-10, 5);
            Assert.AreEqual(-15m, result, "Subtraction of one positive one negative number failed");
        }

        [TestCase]
        public void SubtractTwoNegativeNumber()
        {
            int result;
            result = c.sub(-10, -5);
            Assert.AreEqual(-5m, result, "Subtraction of two neagtive number failed");
        }

        [TestCase]
        public void SubtractOneNumberOneCharacter()
        {
            int result;
            result = c.sub('a', 5);
            Assert.AreEqual(92m, result, "Subtraction of one Number and one character failed");
        }


        [TestCase]
        public void SubtractTwoCharacter()
        {
            int result;
            result = c.sub('a', 'b');
            Assert.AreEqual(-1m, result, "Subtraction of two Character failed");
        }
    }
}
