using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Data_Structures_Tests.Tests.LinkedList
{
    [TestClass]
    public class FunctionalityUnitTest
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
        public void FunctionalityTestMethod1()
        {
            for (int i = 1; i <= 50; i++)
            {
                linkedList.InsertBeginning("Test" + i);
            }

            for (int i = 50; i > 1; i--)
            {
                Assert.IsNotNull(linkedList.Find("Test" + i));
                Assert.IsTrue(linkedList.GetHead().ToString() == "Test" + i);
                linkedList.RemoveBeginning();
                Assert.IsTrue(linkedList.GetHead().ToString() != "Test" + i);
            }
        }

        [TestMethod]
        public void FunctionalityTestMethod2()
        {
            for (int i = 1; i <= 5; i++)
            {
                linkedList.InsertBeginning("Test" + i);
            }

            string linkedListStr = "Test5, Test4, Test3, Test2, Test1";

            Assert.IsTrue(linkedList.ToString() == linkedListStr);
        }

        [TestMethod]
        public void FunctionalityTestMethod3()
        {
            linkedList.InsertBeginning("Head");
            linkedList.InsertAfter(linkedList.GetHead(), "Node 0");
            for (int i = 1; i <= 3; i++)
            {
                linkedList.InsertAfter(linkedList.Find("Node " + (i - 1)), "Node " + i);
            }

            string linkedListStr = "Head, Node 0, Node 1, Node 2, Node 3";

            Assert.IsTrue(linkedList.ToString() == linkedListStr);
        }
    }
}
