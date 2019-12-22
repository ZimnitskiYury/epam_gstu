using Microsoft.VisualStudio.TestTools.UnitTesting;
using task4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4.Tests
{
    [TestClass()]
    public class ServerTests
    {
        [TestMethod()]
        public void ConnectTest()
        {
            Server s1 = new Server();
            s1.Start();
            Client c1 = new Client();
        }
    }
}