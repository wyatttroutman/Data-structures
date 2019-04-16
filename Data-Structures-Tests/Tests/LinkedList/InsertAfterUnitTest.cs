using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_Tests.Tests.LinkedList
{
    [TestClass]
    public class InsertAfterUnitTest
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
        public void TestInsertAfter()
        {
            linkedList.InsertBeginning("Test");
            linkedList.InsertAfter(linkedList.GetTail(), "Test1");
            Assert.IsNotNull(linkedList.Find("Test1"));
            Assert.IsTrue(linkedList.GetHead().ToString() == "Test");
            Assert.IsTrue(linkedList.GetTail().ToString() == "Test1");
        }
    }
}
