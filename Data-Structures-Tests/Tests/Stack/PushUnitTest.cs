using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Data_Structures_Tests.Tests.Stack
{
    [TestClass]
    public class PushUnitTest
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
        public void PushEmpty()
        {
            stack.Push("Test");

            Assert.IsTrue(stack.Peek() == "Test");
        }

        [TestMethod]
        public void PushOneElement()
        {
            stack.Push("Test");
            stack.Push("Test1");

            Assert.IsTrue(stack.Peek() == "Test1");
        }

        [TestMethod]
        public void PushManyElement()
        {
            stack.Push("Test");
            stack.Push("Test1");
            stack.Push("Test2");
            stack.Push("Test3");

            Assert.IsTrue(stack.Peek() == "Test3");
        }
    }
}
