using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_Tests.Tests.LinkedList
{
    [TestClass]
    public class IndexerUnitTest
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
        public void GetEmpty()
        {
            try
            {
                string str = linkedList[0];
            }
            catch (Exception)
            {
                return;
            }
            Assert.Fail();
        }

        [TestMethod]
        public void GetOneElement()
        {
            linkedList.InsertBeginning("Test");
            Assert.IsTrue(linkedList[0] == "Test");
        }

        [TestMethod]
        public void GetOneElementOutsideOfIndex()
        {
            linkedList.InsertBeginning("Test");
            try
            {
                string str = linkedList[1];
            }
            catch (Exception)
            {
                return;
            }
            Assert.Fail();
        }


        [TestMethod]
        public void GetManyElement()
        {
            linkedList.InsertBeginning("Test");
            linkedList.InsertBeginning("Test1");
            linkedList.InsertBeginning("Test2");
            Assert.IsTrue(linkedList[0] == "Test2");
            Assert.IsTrue(linkedList[1] == "Test1");
            Assert.IsTrue(linkedList[2] == "Test");
        }

        [TestMethod]
        public void SetEmpty()
        {
            try
            {
                linkedList[0] = "Test";
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void SetOneElement()
        {
            linkedList.InsertBeginning("Test");
            linkedList[1] = "Test2";
            Assert.IsTrue(linkedList[1] == "Test2");
        }

        [TestMethod]
        public void SetOneElementOutsideOfIndex()
        {
            linkedList.InsertBeginning("Test");
            try
            {
                linkedList[100] = "Test2";
            }
            catch (Exception)
            {
                return;
            }
            Assert.Fail();
        }


        [TestMethod]
        public void SetManyElement()
        {
            linkedList[0] = "Test2";
            linkedList[1] = "Test1";
            linkedList[2] = "Test";
            Assert.IsTrue(linkedList[0] == "Test2");
            Assert.IsTrue(linkedList[1] == "Test1");
            Assert.IsTrue(linkedList[2] == "Test");
        }
    }
}
