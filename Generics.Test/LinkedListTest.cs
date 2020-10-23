using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Generics.Test
{
    [TestClass]
    public class LinkedListTest
    {
        [TestMethod]
        public void CAn_Add_After()
        {
            var list = new LinkedList<string>();

            list.AddFirst("Anisur");
            list.AddLast("Sarker");

            list.AddAfter(list.First, "Rahman");

            Assert.AreEqual("Rahman", list.First.Next.Value);
        }
    }
}
