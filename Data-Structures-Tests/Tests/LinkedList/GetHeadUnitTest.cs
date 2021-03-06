﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_Tests.Tests.LinkedList
{
    [TestClass]
    public class GetHeadUnitTest
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
        public void TestGetHeadEmpty()
        {
            Assert.IsNull(linkedList.GetHead());
        }

        [TestMethod]
        public void TestGetHeadNotEmptyOneElement()
        {
            linkedList.InsertBeginning("Test");
            Assert.IsNotNull(linkedList.GetHead());
            Assert.IsTrue(linkedList.GetHead().ToString() == "Test");
        }

        [TestMethod]
        public void TestGetHeadNotEmptyManyElement()
        {
            linkedList.InsertBeginning("Test");
            linkedList.InsertBeginning("Test1");
            Assert.IsNotNull(linkedList.GetHead());
            Assert.IsTrue(linkedList.GetHead().ToString() == "Test1");
        }
    }
}
