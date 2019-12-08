using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using task3;

namespace task3_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Figure f1 = new Circle
            {
                Material = Figure.Materials.paper,
                Color = Figure.Colors.red
            };
        }
    }
}
