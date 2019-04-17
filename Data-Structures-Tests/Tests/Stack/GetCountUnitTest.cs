using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Data_Structures_Tests.Tests.Stack
{
    [TestClass]
    public class GetCountUnitTest
    {
        private Data_Structures_Classes.Classes.DataStructures.Stack.Stack<string> stack;

        [TestInitialize]
        public void TestInitialize()
        {
            this.stack = new Data_Structures_Classes.Classes.DataStructures.Stack.Stack<string>();
        }

        [TestCleanup]
        public void TestCleanUp()
        {
            stack = null;
        }

        [TestMethod]
        public void GetCountEmpty()
        {
            Assert.IsTrue(stack.GetCount() == 0);
        }

        [TestMethod]
        public void GetCountOneElement()
        {
            stack.Push("Test");
            Assert.IsTrue(stack.GetCount() == 1);
        }

        [TestMethod]
        public void GetCountManyElement()
        {
            stack.Push("Test");
            stack.Push("Test");
            stack.Push("Test");
            Assert.IsTrue(stack.GetCount() == 3);
        }
    }
}
