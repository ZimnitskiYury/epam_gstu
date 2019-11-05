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
            int f = 100;
            int s = 25;
            int expected= 25;
            int result=test1.GetNod(f, s);
            EuclideanTests.Equals(expected, result);
        }
        [TestMethod()]
        //тест с обратными
        public void GetNodTest_2()
        {
            Euclidean test1 = new Euclidean();
            int f = 25;
            int s = 100;
            int expected = 25;
            int result = test1.GetNod(f, s);
            Assert.AreEqual(expected, result);
        }
        [TestMethod()]
        //тест с вызовом рекурсии
        public void GetNodTest_3()
        {
            Euclidean test1 = new Euclidean();
            int f = 120;
            int s = 25;
            int expected = 5;
            int result = test1.GetNod(f, s);
            Assert.AreEqual(expected, result);
        }
        [TestMethod()]
        //тест с вызовом рекурсии
        public void GetNodTest_4()
        {
            Euclidean test1 = new Euclidean();
            int f = 219;
            int s = 39;
            int expected = 3;
            int result = test1.GetNod(f, s);
            Assert.AreEqual(expected, result);
        }
    }
}