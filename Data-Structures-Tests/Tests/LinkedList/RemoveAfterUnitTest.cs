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
        public void RemoveAfterEmpty()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void RemoveAfterOneElement()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void RemoveAfterManyElement()
        {
            throw new NotImplementedException();
        }
    }
}
