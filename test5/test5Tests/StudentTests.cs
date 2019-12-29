using Microsoft.VisualStudio.TestTools.UnitTesting;
using test5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test5.Tests
{
    [TestClass()]
    public class StudentTests
    {
        [TestMethod()]
        public void CompareToTest()
        {
            var s1 = new Student("Zimnitski", 27, "DataStructure", new DateTime(2015, 7, 20));
            var s2 = new Student("Kruchkov", 10, "DataStructure", new DateTime(2016, 3, 25));
            var s3 = new Student("Varochkin", 58, "DataStructure", new DateTime(2018, 1, 12));
            var s4 = new Student("Varochkin", 53, "DataStructure", new DateTime(2017, 2, 10));
            var s5 = new Student("Utyashev", 88, "DataStructure", new DateTime(2019, 2, 11));
            var s6 = new Student("Karlov", 75, "DataStructure", new DateTime(2015, 2, 11));
            var s7 = new Student("Puchkin", 99, "DataStructure", new DateTime(2015, 2, 11));
            var s8 = new Student("Segen", 12, "DataStructure", new DateTime(2015, 2, 11));
            var s9 = new Student("Artek", 63, "DataStructure", new DateTime(2015, 2, 11));
            var s10 = new Student("Polko", 77, "DataStructure", new DateTime(2015, 2, 11));
            var s11= new Student("Ninchenko", 16, "DataStructure", new DateTime(2015, 2, 11));
            var s12= new Student("Artov", 93, "DataStructure", new DateTime(2015, 2, 11));
           // var result = s1.CompareTo(s2);
            var expected = 1;
            //Assert.AreEqual(expected, result);*/
            var b1 = new BinaryTree<Student>();
            b1.Add(s1);
            b1.Add(s2);
            b1.Add(s3);
          // b1.Add(s4);
           b1.Add(s5);
            b1.Add(s6);
            b1.Add(s7);
            b1.Add(s8);
            b1.Add(s9);
            b1.Add(s10);
            b1.Add(s11);
            b1.Add(s12);
            b1.Balance();
            b1.Add(s4);
        }
    }
}