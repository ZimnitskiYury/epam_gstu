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
        [TestMethod()]
        //тест с тремя входными
        public void GetNodTest_6()
        {
            Euclidean test1 = new Euclidean();
            int first = 27;
            int second = 74;
            int third = 58;
            int expected = 1;
            int result = test1.GetNod(first, second, third);
            Assert.AreEqual(expected, result);
        }
        [TestMethod()]
        //тест с тремя входными
        public void GetNodTest_7()
        {
            Euclidean test1 = new Euclidean();
            int first = 130;
            int second = 374;
            int third = 258;
            int expected = 2;
            int result = test1.GetNod(first, second, third);
            Assert.AreEqual(expected, result);
        }
        [TestMethod()]
        //тест с четырьмя входными
        public void GetNodTest_8()
        {
            Euclidean test1 = new Euclidean();
            int first = 130;
            int second = 374;
            int third = 258;
            int fourth = 382;
            int expected = 2;
            int result = test1.GetNod(first, second, third, fourth);
            Assert.AreEqual(expected, result);
        }
        [TestMethod()]
        //тест с пятью входными
        public void GetNodTest_9()
        {
            Euclidean test1 = new Euclidean();
            int first = 180;
            int second = 24;
            int third = 240;
            int fourth = 138;
            int fifth = 186;
            int expected = 6;
            int result = test1.GetNod(first, second, third, fourth, fifth);
            Assert.AreEqual(expected, result);
        }
        [TestMethod()]
        //тест с пятью входными, 1 после первых двух чисел
        public void GetNodTest_10()
        {
            Euclidean test1 = new Euclidean();
            int first = 7;
            int second = 24;
            int third = 240;
            int fourth = 138;
            int fifth = 186;
            int expected = 1;
            int result = test1.GetNod(first, second, third, fourth, fifth);
            Assert.AreEqual(expected, result);
        }
    }
}