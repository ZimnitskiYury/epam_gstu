using Microsoft.VisualStudio.TestTools.UnitTesting;
using task01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task01.Tests
{
    [TestClass()]
    public class EuclideanTests
    {
        [TestMethod()]
        //тест с обычными значениями
        public void GetNodTest_1()
        {
            Euclidean test1 = new Euclidean();
            int first = 100;
            int second = 25;
            int expected= 25;
            int result=test1.GetNod(first, second);
            EuclideanTests.Equals(expected, result);
        }
        [TestMethod()]
        //тест с обратными
        public void GetNodTest_2()
        {
            Euclidean test1 = new Euclidean();
            int first = 25;
            int second = 100;
            int expected = 25;
            int result = test1.GetNod(first, second);
            Assert.AreEqual(expected, result);
        }
        [TestMethod()]
        //тест с вызовом рекурсии
        public void GetNodTest_3()
        {
            Euclidean test1 = new Euclidean();
            int first = 120;
            int second = 25;
            int expected = 5;
            int result = test1.GetNod(first, second);
            Assert.AreEqual(expected, result);
        }
        [TestMethod()]
        //тест с вызовом рекурсии
        public void GetNodTest_4()
        {
            Euclidean test1 = new Euclidean();
            int first = 219;
            int second = 39;
            int expected = 3;
            int result = test1.GetNod(first, second);
            Assert.AreEqual(expected, result);
        }
        [TestMethod()]
        //тест с вызовом рекурсии
        public void GetNodTest_5()
        {
            Euclidean test1 = new Euclidean();
            int first = 13;
            int second = 13;
            int expected = 13;
            int result = test1.GetNod(first, second);
            Assert.AreEqual(expected, result);
        }
    }
}