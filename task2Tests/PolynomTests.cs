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
        public void PolynomTest01()
        {
            //arrange
            int[] test_array = { 7, -3, -5 };
            int[] test_array2 = { 9, 5 };
            int[] exp = { 63, 8, -60, -25 };
            Polynom p1 = new Polynom(test_array);
            Polynom p2 = new Polynom(test_array2);

            Polynom expected = new Polynom(exp);
            //act
            Polynom result = p1 * p2;
            //assert
            Assert.IsTrue(expected==result);
        }
        [TestMethod()]
        public void PolynomTest02()
        {
            //arrange
            int[] test_array = { 9, -5, 78, 19 };
            int[] test_array2 = { - 9, 0, 7 };
            int[] exp_array = { 0, -5, 85, 19 };
            Polynom p1 = new Polynom(test_array);
            Polynom p2 = new Polynom(test_array2);
            Polynom expected = new Polynom(exp_array);
            //act
            Polynom result = p1 + p2;
            //assert
            Assert.IsTrue(expected==result);
        }
        [TestMethod()]
        public void PolynomTest03()
        {
            //arrange
            int[] test_array = { 49, -17, 145, 12, 2, 0, -8, 19, -15, -7 };
            int[] test_array2 = { -91,-110, 77, 13, -13, -77, 17, 82, 301, -45};
            int[] exp_array = { -42,-127,222,25,-11,-77,9,101,286,-52};
            Polynom p1 = new Polynom(test_array);
            Polynom p2 = new Polynom(test_array2);
            Polynom expected = new Polynom(exp_array);
            //act
            Polynom result = p1 + p2;
            //assert
            Assert.IsTrue(expected == result);
        }
        [TestMethod()]
        public void PolynomTest04()
        {
            //arrange
            int[] test_array = { 49, -17, 145, 12, 2, 0, -8, 19, -15, -7 };
            int[] test_array2 = { -13, -77, 17, 82, 301, -45 };
            int[] exp_array = { 36, -94, 162, 94, 303, -45, -8, 19, -15, -7 };
            Polynom p1 = new Polynom(test_array);
            Polynom p2 = new Polynom(test_array2);
            Polynom expected = new Polynom(exp_array);
            //act
            Polynom result = p1 + p2;
            //assert
            Assert.IsTrue(expected == result);
        }
        [TestMethod()]
        public void PolynomTest05()
        {
            //arrange
            int[] test_array = { 49, -17, 9, 7, 21, -5, -15, -7 };
            int[] test_array2 = { -23, 82, 301, -45 };
            int[] exp_array = {26, 65, 310, -38, 21, -5, -15, -7 };
            Polynom p1 = new Polynom(test_array);
            Polynom p2 = new Polynom(test_array2);
            Polynom expected = new Polynom(exp_array);
            //act
            Polynom result = p1 + p2;
            //assert
            Assert.IsTrue(expected == result);
        }
        [TestMethod()]
        public void PolynomTest06()
        {
            //arrange
            int[] test_array = { 49, -17, 9, 7, 21, -5, -15, -7 };
            int[] test_array2 = { -23, 82, 301, -45 };
            int[] exp_array = { 72, -99, -292, 52, 21, -5, -15, -7 };
            Polynom p1 = new Polynom(test_array);
            Polynom p2 = new Polynom(test_array2);
            Polynom expected = new Polynom(exp_array);
            //act
            Polynom result = p1 - p2;
            //assert
            Assert.IsTrue(expected == result);
        }
        [TestMethod()]
        public void PolynomTest07()
        {
            //arrange
            int[] test_array = { 49, -17, 145, 12, 2, 0, -8, 19, -15, -7 };
            int[] test_array2 = { -13, -77, 17, 82, 301, -45 };
            int[] exp_array = { 62, 60, 128, -70, -299, 45, -8, 19, -15, -7 };
            Polynom p1 = new Polynom(test_array);
            Polynom p2 = new Polynom(test_array2);
            Polynom expected = new Polynom(exp_array);
            //act
            Polynom result = p1 - p2;
            //assert
            Assert.IsTrue(expected == result);
        }
        [TestMethod()]
        public void PolynomTest08()
        {
            //arrange
            int[] test_array = {  2, 0, 0,  0, -7 };
            int[] test_array2 = { -113,  822, 3001, -455, -18 };
            int[] exp_array = { 115, -822, -3001, 455, 11 };
            Polynom p1 = new Polynom(test_array);
            Polynom p2 = new Polynom(test_array2);
            Polynom expected = new Polynom(exp_array);
            //act
            Polynom result = p1 - p2;
            //assert
            Assert.IsTrue(expected == result);
        }
        [TestMethod()]
        public void PolynomTest09()
        {
            //arrange
            int[] test_array = { 0, 0, 0, 0, 0 };
            int[] test_array2 = { 0, 0, 0, 0, 0 };
            int[] exp_array = { 0, 0, 0, 0, 0 };
            Polynom p1 = new Polynom(test_array);
            Polynom p2 = new Polynom(test_array2);
            Polynom expected = new Polynom(exp_array);
            //act
            Polynom result = p1 - p2;
            //assert
            Assert.IsTrue(expected == result);
        }
        [TestMethod()]
        public void PolynomTest10()
        {
            //arrange
            int[] test_array = { 0 };
            int[] test_array2 = { 5, -1 };
            int[] exp_array = { -5,1};
            Polynom p1 = new Polynom(test_array);
            Polynom p2 = new Polynom(test_array2);
            Polynom expected = new Polynom(exp_array);
            //act
            Polynom result = p1 - p2;
            //assert
            Assert.IsTrue(expected == result);
        }
        [TestMethod()]
        public void PolynomTest11()
        {
            //arrange
            int[] test_array = { 17, -13, 5, -71 };
            int[] test_array2 = { 5, -1,-8,-17,-12,-35 };
            int[] exp_array = { 12,-12,13,-54,12,35};
            Polynom p1 = new Polynom(test_array);
            Polynom p2 = new Polynom(test_array2);
            Polynom expected = new Polynom(exp_array);
            //act
            Polynom result = p1 - p2;
            //assert
            Assert.IsTrue(expected == result);
        }
        [TestMethod()]
        public void PolynomTest12()
        {
            //arrange
            int[] test_array = { 7, -3, -5,-9,25,17,63,32,-18,219,30,-1 };
            int[] test_array2 = { 9, 5,13,-15,-7,5,550,1,13,-52,7 };
            int[] exp = { 63,8,31,-250,111,292,4982,-1156,-2320,-4000,14176,12846,32811,14435,-8858,117848,15257,3487,-11125,-40,262,-7};
            Polynom p1 = new Polynom(test_array);
            Polynom p2 = new Polynom(test_array2);

            Polynom expected = new Polynom(exp);
            //act
            Polynom result = p1 * p2;
            //assert
            Assert.IsTrue(expected == result);
        }
        [TestMethod()]
        public void PolynomTest14()
        {
            //arrange
            int[] test_array = { 0 };
            int[] test_array2 = { 9, 5, 1 ,-71, 13, -52, 7 };
            int[] exp = { 0, 0, 0, 0, 0, 0, 0 };
            Polynom p1 = new Polynom(test_array);
            Polynom p2 = new Polynom(test_array2);

            Polynom expected = new Polynom(exp);
            //act
            Polynom result = p1 * p2;
            //assert
            Assert.IsTrue(expected == result);
        }
        [TestMethod()]
        public void PolynomTest13()
        {
            //arrange
            int[] test_array = { 9, 5, 1, -71, 13, -52, 7 };
            int[] test_array2 = { 0 };
            int[] exp = { 0, 0, 0, 0, 0, 0, 0 };
            Polynom p1 = new Polynom(test_array);
            Polynom p2 = new Polynom(test_array2);

            Polynom expected = new Polynom(exp);
            //act
            Polynom result = p1 * p2;
            //assert
            Assert.IsTrue(expected == result);
        }
    }
}
