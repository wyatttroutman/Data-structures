using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Data_Structures_Tests.Tests.Stack
{
    [TestClass]
    public class PopUnitTest
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
        public void PopEmpty()
        {
            try
            {
                stack.Pop();
            }
            catch (Exception)
            {
                return;
            }
            Assert.Fail("Pop() on Empty should fail. Test did not throw exception. Assert Failed.");

        }

        [TestMethod]
        public void PopOneElement()
        {
            stack.Push("Test");
            string str = stack.Pop();
            Assert.IsNotNull(str);
            Assert.IsTrue(str == "Test");
        }

        [TestMethod]
        public void PopManyElement()
        {
            stack.Push("Test");
            stack.Push("Test1");
            stack.Push("Test2");

            string str = stack.Pop();
            Trace.Write(str);
            Assert.IsNotNull(str);
            Assert.IsTrue(str == "Test2");

            str = stack.Pop();
            Trace.Write(str);
            Assert.IsNotNull(str);
            Assert.IsTrue(str == "Test1");

            str = stack.Pop();
            Trace.Write(str);
            Assert.IsNotNull(str);
            Assert.IsTrue(str == "Test");
        }
    }
}
