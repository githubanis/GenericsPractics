using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Generics.Test
{
    [TestClass]
    public class StackTest
    {
        [TestMethod]
        public void Can_Peek()
        {
            var stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
                 
            Assert.AreEqual(3, stack.Peek());
        }

        [TestMethod]
        public void Can_Contain()
        {
            var stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Assert.IsTrue(stack.Contains(3));
        }

        [TestMethod]
        public void Can_Convert_queue_to_array()
        {
            var stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            var asArray = stack.ToArray();
            stack.Pop();

            Assert.AreEqual(3, asArray[0]);
            Assert.AreEqual(2, stack.Count);
        }
    }
}
