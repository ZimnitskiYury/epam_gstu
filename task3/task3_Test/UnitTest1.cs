using System;
using System.IO;
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
            StreamXML st = new StreamXML();
            st.Write();
        }
    }
}
