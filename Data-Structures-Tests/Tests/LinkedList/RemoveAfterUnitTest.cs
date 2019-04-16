using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_Tests.Tests.LinkedList
{
    [TestClass]
    public class RemoveAfterUnitTest
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
        public void RemoveAfterNull()
        {
            linkedList.RemoveAfter(null);
        }

        [TestMethod]
        public void RemoveAfterOneElement()
        {
            linkedList.InsertBeginning("Test");
            Assert.IsTrue(linkedList.GetHead() == linkedList.GetTail());
            linkedList.RemoveAfter(linkedList.GetHead());
            Assert.IsTrue(linkedList.GetHead() == linkedList.GetTail());
            Assert.IsTrue(linkedList.GetHead().ToString() == "Test");
        }

        [TestMethod]
        public void RemoveAfterManyElement()
        {
            linkedList.InsertBeginning("Test");
            linkedList.InsertBeginning("Test1");
            linkedList.InsertBeginning("Test2");
            Assert.IsTrue(linkedList.GetHead().ToString() == "Test2");

            linkedList.RemoveAfter(linkedList.GetHead());
            linkedList.RemoveAfter(linkedList.GetHead());

            Assert.IsTrue(linkedList.GetHead().ToString() == linkedList.GetTail().ToString());
        }
    }
}
