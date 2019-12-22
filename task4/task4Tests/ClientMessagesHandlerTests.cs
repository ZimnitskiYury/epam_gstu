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
    public class ClientMessagesHandlerTests
    {
        [TestMethod()]
        public void TransliterationTest()
        {
            ClientMessagesHandler cmh = new ClientMessagesHandler();
            var txt = "Добрый вечер! Хорошего дня!";
            var expected = "Dobryi vecher! Khoroshego dnia!";
            var result = cmh.Transliteration(txt);
            Assert.AreEqual(expected, result);
        }
    }
}