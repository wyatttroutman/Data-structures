using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Data_Structures_Tests.Tests.LinkedList
{
    [TestClass]
    public class GetCountUnitTest
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
        public void GetCountEmpty()
        {
            Assert.IsTrue(linkedList.GetCount() == 0);
        }

        [TestMethod]
        public void GetCountOneElement()
        {
            linkedList.InsertBeginning("Test");
            Assert.IsTrue(linkedList.GetCount() == 1);
        }

        [TestMethod]
        public void GetCountManyElement()
        {
            linkedList.InsertBeginning("Test");
            linkedList.InsertBeginning("Test1");
            linkedList.InsertBeginning("Test2");
            Assert.IsTrue(linkedList.GetCount() == 3);
        }
    }
}
