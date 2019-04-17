using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Data_Structures_Tests.Tests.Stack
{
    [TestClass]
    public class IsEmptyUnitTest
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
        public void IsEmptyEmpty()
        {
            Assert.IsTrue(stack.IsEmpty());
        }

        [TestMethod]
        public void IsEmptyOneElement()
        {
            stack.Push("Test");
            Assert.IsFalse(stack.IsEmpty());
        }

        [TestMethod]
        public void IsEmptyManyElement()
        {
            stack.Push("Test");
            stack.Push("Test");
            stack.Push("Test");
            Assert.IsFalse(stack.IsEmpty());
        }
    }
}
