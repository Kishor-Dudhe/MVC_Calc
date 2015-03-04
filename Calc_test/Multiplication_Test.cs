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
    class Multiplication_Test
    {
        Calc_Controller c = new Calc_Controller();

        [TestCase]
        public void MultiplicateTwoPositiveNumber()
        {
            int result;
            result = c.mul(10, 5);
            Assert.AreEqual(50m, result, "Multiplication of two positive number failed");
        }

        [TestCase]
        public void MultiplicationOnePositiveOneNegativeNumber()
        {
            int result;
            result = c.mul(-10, 5);
            Assert.AreEqual(-50m, result, "Multiplication of one positive one negative number failed");
        }

        [TestCase]
        public void MultiplicateTwoNegativeNumber()
        {
            int result;
            result = c.mul(-10, -5);
            Assert.AreEqual(50m, result, "Multiplication of two neagtive number failed");
        }

        [TestCase]
        public void MultiplicateOneNumberOneCharacter()
        {
            int result;
            result = c.mul('a', 5);
            Assert.AreEqual(485m, result, "Multiplication of one Number and one character failed");
        }


        [TestCase]
        public void MultiplicateTwoCharacter()
        {
            int result;
            result = c.mul('a', 'b');
            Assert.AreEqual(9506m, result, "Multiplication of two character failed");
        }
    }
}
