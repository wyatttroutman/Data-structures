using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_Tests.Tests.LinkedList
{
    [TestClass]
    public class ClearUnitTest
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
        public void ClearEmpty()
        {
            Assert.IsNull(linkedList.GetHead());
            linkedList.Clear();
            Assert.IsNull(linkedList.GetHead());
        }

        [TestMethod]
        public void ClearOneElement()
        {
            linkedList.InsertBeginning("Test");
            Assert.IsNotNull(linkedList.GetHead());
            linkedList.Clear();
            Assert.IsNull(linkedList.GetHead());
        }

        [TestMethod]
        public void ClearManyElement()
        {
            linkedList.InsertBeginning("Test");
            linkedList.InsertBeginning("Test1");
            linkedList.InsertBeginning("Test2");
            Assert.IsNotNull(linkedList.GetHead());
            linkedList.Clear();
            Assert.IsNull(linkedList.GetHead());
        }
    }
}
