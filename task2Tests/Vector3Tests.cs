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
    public class Vector3Tests
    {
        [TestMethod()]
        public void Vector3Test01()
        {
            //arrange
            Vector3 v1 = new Vector3(2,2.0f,2);
            Vector3 v2 = new Vector3(2);
            Vector3 expected = new Vector3(4, 4, 4);
            //act
            Vector3 result = v1 + v2;
            //assert
            Assert.IsTrue(expected==result);
        }
        [TestMethod()]
        public void Vector3Test02()
        {
            //arrange
            Vector3 v1 = new Vector3(3f, -15.2f, 7);
            Vector3 v2 = new Vector3(-3.1f);
            Vector3 expected = new Vector3(-0.1f, -18.3f, 3.9f);
            //act
            Vector3 result = v1 + v2;
            //assert
            Assert.IsTrue(expected == result);
        }
        [TestMethod()]
        public void Vector3Test03()
        {
            //arrange
            Vector3 v1 = new Vector3(0, 0, 0);
            Vector3 v2 = new Vector3(-3);
            Vector3 expected = new Vector3(-3, -3, -3);
            //act
            Vector3 result = v1 + v2;
            //assert
            Assert.IsTrue(expected == result);
        }
        [TestMethod()]
        public void Vector3Test04()
        {
            //arrange
            Vector3 v1 = new Vector3();
            Vector3 v2 = new Vector3(-3);
            Vector3 expected = new Vector3(-3, -3, -3);
            //act
            Vector3 result = v1 + v2;
            //assert
            Assert.IsTrue(expected == result);
        }
        [TestMethod()]
        public void Vector3Test05()
        {
            //arrange
            Vector3 v1 = new Vector3(-2, 3.25f,1664);
            Vector3 v2 = new Vector3(-315,341.275f,-13.879f);
            Vector3 expected = new Vector3(-317, 344.525f, 1650.121f);
            //act
            Vector3 result = v1 + v2;
            //assert
            Assert.IsTrue(expected == result);
        }
        [TestMethod()]
        public void Vector3Test06()
        {
            //arrange
            Vector3 v1 = new Vector3(-2, 3.25f, 16.4f);
            Vector3 v2 = new Vector3(-31, 34, -13);
            Vector3 expected = new Vector3(29, -30.75f, 29.4f);
            //act
            Vector3 result = v1 - v2;
            //assert
            Assert.IsTrue(expected == result);
        }
        [TestMethod()]
        public void Vector3Test07()
        {
            //arrange
            Vector3 v1 = new Vector3(0);
            Vector3 v2 = new Vector3(-1, 12.4f, -35.1f);
            Vector3 expected = new Vector3(1,-12.4f,35.1f);
            //act
            Vector3 result = v1 - v2;
            //assert
            Assert.IsTrue(expected == result);
        }
        [TestMethod()]
        public void Vector3Test08()
        {
            //arrange
            Vector3 v2 = new Vector3(-1, 12.4f, -35.1f);
            Vector3 expected = new Vector3(1, -12.4f, 35.1f);
            //act
            Vector3 result =- v2;
            //assert
            Assert.IsTrue(expected == result);
        }
        [TestMethod()]
        public void Vector3Test09()
        {
            //arrange
            Vector3 v2 = new Vector3(-1, 0, 0);
            Vector3 expected = new Vector3(1, 0, 0);
            //act
            Vector3 result = -v2;
            //assert
            Assert.IsTrue(expected == result);
        }
        [TestMethod()]
        public void Vector3Test10()
        {
            //arrange
            Vector3 v1 = new Vector3(0);
            float sc = -3f;
            Vector3 expected = new Vector3(0, 0, 0);
            //act
            Vector3 result = v1 * sc;
            //assert
            Assert.IsTrue(expected == result);
        }
        [TestMethod()]
        public void Vector3Test11()
        {
            //arrange
            Vector3 v1 = new Vector3(12);
            float sc = 5;
            Vector3 expected = new Vector3(60, 60, 60);
            //act
            Vector3 result = v1 * sc;
            //assert
            Assert.IsTrue(expected == result);
        }
        [TestMethod()]
        public void Vector3Test12()
        {
            //arrange
            Vector3 v1 = new Vector3(10, 1.1f, -5);
            float sc = 0.1f;
            Vector3 expected = new Vector3(1, 0.11f, -0.5f);
            //act
            Vector3 result = v1 * sc;
            //assert
            Assert.IsTrue(expected == result);
        }
        [TestMethod()]
        public void Vector3Test13()
        {
            //arrange
            Vector3 v1 = new Vector3(14, -71.3f, -5);
            Vector3 v2 = new Vector3(19, 1, 11);
            Vector3 expected = new Vector3(-779.3f,-249f, 1368.7f);
            //act
            Vector3 result = v1 * v2;
            //assert
            Assert.IsTrue(expected == result);
        }
        [TestMethod()]
        public void Vector3Test14()
        {
            //arrange
            Vector3 v1 = new Vector3(-1.1f);
            Vector3 v2 = new Vector3(-7,-12.22f,17);
            Vector3 expected = new Vector3(-32.142f, 26.4f, 5.742f);
            //act
            Vector3 result = v1 * v2;
            //assert
            Assert.IsTrue(expected == result);
        }
        [TestMethod()]
        public void Vector3Test15()
        {
            //arrange
            Vector3 v1 = new Vector3(-1.1f);
            Vector3 v2 = new Vector3(-21.17f);
            Vector3 expected = new Vector3(0, 0, 0);
            //act
            Vector3 result = v1 * v2;
            //assert
            Assert.IsTrue(expected == result);
        }
        [TestMethod()]
        public void Vector3Test16()
        {
            //arrange
            Vector3 v1 = new Vector3(0);
            Vector3 v2 = new Vector3(-21.17f, -25.1f, 17);
            Vector3 expected = new Vector3(0, 0, 0);
            //act
            Vector3 result = v1 * v2;
            //assert
            Assert.IsTrue(expected == result);
        }
        [TestMethod()]
        public void Vector3Test17()
        {
            //arrange
            Vector3 v1 = new Vector3(0);
            Vector3 v2 = new Vector3();
            Vector3 expected = new Vector3(0, 0, 0);
            //act
            Vector3 result = v1 * v2;
            //assert
            Assert.IsTrue(expected == result);
        }
        [TestMethod()]
        public void Vector3Test18()
        {
            //arrange
            Vector3 v1 = new Vector3(10, 1.1f, -5);
            float sc = 0.1f;
            Vector3 expected = new Vector3(100, 11f, -50f);
            //act
            Vector3 result = v1 / sc;
            //assert
            Assert.IsTrue(expected == result);
        }
        [TestMethod()]
        public void Vector3Test19()
        {
            //arrange
            Vector3 v1 = new Vector3(-2.1f, 17f, 33);
            float sc = 5f;
            Vector3 expected = new Vector3(-0.42f, 3.4f, 6.6f);
            //act
            Vector3 result = v1 / sc;
            //assert
            Assert.IsTrue(expected == result);
        }
        [TestMethod()]
        public void Vector3Test20()
        {
            //arrange
            Vector3 v1 = new Vector3(-2.1f, 17f, 33);
            float sc = -1f;
            Vector3 expected = new Vector3(2.1f, -17f, -33f);
            //act
            Vector3 result = v1 / sc;
            //assert
            Assert.IsTrue(expected == result);
        }
        [TestMethod()]
        public void Vector3Test21()
        {
            //arrange
            Vector3 v1 = new Vector3(3);
            Vector3 v2 = new Vector3(2.1f, 13f, -5.4f);
            float expected =29.1f ;
            //act
            float result = Vector3.GetScalar(v1 , v2);
            //assert
            Assert.IsTrue((expected - result) < 0.01);
        }
        [TestMethod()]
        public void Vector3Test22()
        {
            //arrange
            Vector3 v1 = new Vector3(17.2f);
            Vector3 v2 = new Vector3(0);
            float expected = 0;
            //act
            float result = Vector3.GetScalar(v1, v2);
            //assert
            Assert.IsTrue((expected - result) < 0.01);
        }
        [TestMethod()]
        public void Vector3Test23()
        {
            //arrange
            Vector3 v1 = new Vector3(17.2f, -5.21f, 0);
            Vector3 v2 = new Vector3(-13.25f, -17.93f, 33.2f);
            float expected = -134.4847f;
            //act
            float result = Vector3.GetScalar(v1, v2);
            //assert
            Assert.IsTrue((expected - result) < 0.01);
        }
    }
}