using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_Tests.Tests.LinkedList
{
    [TestClass]
    public class PrintUnitTest
    {
        private Data_Structures_Classes.Classes.DataStructures.LinkedList.LinkedList<string> linkedList;

        [TestInitialize]
        public void TestInitialize()
        {
            this.linkedList = new Data_Structures_Classes.Classes.DataStructures.LinkedList.LinkedList<string>();
        }

        [TestCleanup]
        public void TestCleanUp()
        {
            linkedList = null;
        }

        [TestMethod]
        public void PrintEmpty()
        {
            Assert.IsTrue(linkedList.ToString() == "");
        }

        [TestMethod]
        public void PrintOneElement()
        {
            linkedList.InsertBeginning("Test");
            Assert.IsTrue(linkedList.ToString() == "Test");
        }

        [TestMethod]
        public void PrintManyElement()
        {
            linkedList.InsertBeginning("Test");
            linkedList.InsertBeginning("Test1");
            linkedList.InsertBeginning("Test2");
            Assert.IsTrue(linkedList.ToString() == "Test2, Test1, Test");
        }
    }
}
