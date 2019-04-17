using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Data_Structures_Tests.Tests.Stack
{
    [TestClass]
    public class PeekUnitTest
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
        public void PeekEmpty()
        {
            try
            {
                stack.Peek();
            }
            catch (Exception)
            {
                return;
            }
            Assert.Fail("Peek() on Empty should fail. Test did not throw exception. Assert Failed.");
        }

        [TestMethod]
        public void PeekOneElement()
        {
            stack.Push("Test");
            Assert.IsNotNull(stack.Peek());
            Assert.IsTrue(stack.Peek() == "Test");
        }

        [TestMethod]
        public void PeekManyElement()
        {
            stack.Push("Test");
            stack.Push("Test1");
            stack.Push("Test2");
            Assert.IsNotNull(stack.Peek());
            Assert.IsTrue(stack.Peek() == "Test2");
        }
    }
}
