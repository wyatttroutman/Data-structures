using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_Tests.Tests.LinkedList
{
    [TestClass]
    public class EnumerableUnitTest
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
        public void EnumerateEmpty()
        {
            Assert.IsNull(linkedList.GetHead());
            foreach (var node in linkedList)
            {
                throw new KeyNotFoundException();
            }
        }

        [TestMethod]
        public void EnumerateOneElement()
        {
            linkedList.InsertBeginning("Test");
            Assert.IsNotNull(linkedList.GetHead());

            int i = 0;
            foreach (var node in linkedList)
            {
                Assert.IsTrue(i == 0);
                Assert.IsNotNull(node);
                Assert.IsTrue(node.ToString() == "Test");
                i++;
            }
        }

        [TestMethod]
        public void EnumerateManyElement()
        {
            linkedList.InsertBeginning("Test");
            linkedList.InsertBeginning("Test1");
            linkedList.InsertBeginning("Test2");
            Assert.IsNotNull(linkedList.GetHead());

            int i = 0;
            foreach (var node in linkedList)
            {
                Assert.IsTrue(i <= 3);
                Assert.IsNotNull(node);
                i++;
            }
        }
    }
}
