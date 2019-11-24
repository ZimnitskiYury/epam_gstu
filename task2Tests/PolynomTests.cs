using Microsoft.VisualStudio.TestTools.UnitTesting;
using task2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2.Tests
{
    [TestClass()]
    public class PolynomTests
    {
        [TestMethod()]
        public void PolynomTest()
        {
            int[] test_array = { 7, -3, -5 };
            int[] test_array2 = { 9, 5 };
            Polynom p1 = new Polynom(test_array);
            Polynom p2 = new Polynom(test_array2);
            int[] exp = { 63, 8, -60, -25 };
            Polynom expected = new Polynom(exp);
            Polynom result = p1 * p2;
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void ToStringTest()
        {
            int [] test_array = { 1, 2, 3, 4, 5, 6, 7 };
            Polynom p1 = new Polynom(test_array);
            string test_string = p1.ToString();
            Assert.AreEqual(test_string, "");
        }
    }
}