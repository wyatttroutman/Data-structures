using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_Tests.Tests.LinkedList
{
    [TestClass]
    public class GetTailUnitTest
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
        public void TestGetTailEmpty()
        {
            Assert.IsNull(linkedList.GetTail());
        }

        [TestMethod]
        public void TestGetTailOneElement()
        {
            linkedList.InsertBeginning("Test");
            Assert.IsNotNull(linkedList.GetTail());
            Assert.IsTrue(linkedList.GetTail().ToString() == "Test");
        }

        [TestMethod]
        public void TestGetTailManyElement()
        {
            linkedList.InsertBeginning("Test");
            linkedList.InsertBeginning("Test1");
            Assert.IsNotNull(linkedList.GetTail());
            Assert.IsTrue(linkedList.GetTail().ToString() == "Test");
        }
    }
}
