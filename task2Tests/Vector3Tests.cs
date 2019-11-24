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
    }
}