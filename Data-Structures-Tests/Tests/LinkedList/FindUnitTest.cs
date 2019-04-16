using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_Tests.Tests.LinkedList
{
    [TestClass]
    public class FindUnitTest
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
        public void TestFindEmpty()
        {
            Assert.IsNull(linkedList.Find("Test"));
        }

        [TestMethod]
        public void TestFindOneElement()
        {
            linkedList.InsertBeginning("Test");
            Assert.IsNotNull(linkedList.Find("Test"));
            Assert.IsTrue(linkedList.Find("Test").ToString() == "Test");
        }

        [TestMethod]
        public void TestFindManyElement()
        {
            linkedList.InsertBeginning("Test");
            linkedList.InsertBeginning("Test1");
            linkedList.InsertBeginning("Test2");
            linkedList.InsertBeginning("Test3");
            Assert.IsNotNull(linkedList.Find("Test3"));
            Assert.IsTrue(linkedList.Find("Test3").ToString() == "Test3");
        }
    }
}
