using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_Tests.Tests.LinkedList
{
    [TestClass]
    public class InsertBeginningUnitTest
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
        public void TestInsertBeginningEmpty()
        {
            linkedList.InsertBeginning("Test");
            Assert.IsNotNull(linkedList.Find("Test"));
            Assert.IsTrue(linkedList.GetHead().ToString() == "Test");
            Assert.IsTrue(linkedList.GetTail().ToString() == "Test");
        }

        [TestMethod]
        public void TestInsertBeginningOneElement()
        {
            linkedList.InsertBeginning("Test");
            linkedList.InsertBeginning("Test1");
            Assert.IsNotNull(linkedList.Find("Test1"));
            Assert.IsTrue(linkedList.GetHead().ToString() == "Test1");
            Assert.IsTrue(linkedList.GetTail().ToString() == "Test");
        }

        [TestMethod]
        public void TestInsertBeginningManyElement()
        {
            linkedList.InsertBeginning("Test");
            linkedList.InsertBeginning("Test1");
            linkedList.InsertBeginning("Test2");
            Assert.IsNotNull(linkedList.Find("Test2"));
            Assert.IsTrue(linkedList.GetHead().ToString() == "Test2");
            Assert.IsTrue(linkedList.GetTail().ToString() == "Test");
        }
    }
}
