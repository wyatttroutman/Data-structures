﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_Tests.Tests.LinkedList
{
    [TestClass]
    public class RemoveBeginningUnitTest
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
        public void RemoveBeginningEmpty()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void RemoveBeginningOneElement()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void RemoveBeginningManyElement()
        {
            throw new NotImplementedException();
        }
    }
}