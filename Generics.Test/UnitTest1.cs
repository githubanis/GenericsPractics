using System;
using System.Collections.Generic;
using System.IO.Pipes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Generics.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void A_List_can_insert()
        {
            var integers = new List<int> { 1, 2, 3 };
            integers.Insert(1, 55);

            Assert.AreEqual(55, integers[1]);
        }

        [TestMethod]
        public void A_List_Can_Remove()
        {
            var integers = new List<int> { 1, 2, 3 };
            integers.Remove(2);

            Assert.AreEqual(2, integers.Count);
        }

        [TestMethod]
        public void A_List_Can_Find()
        {
            var integers = new List<int> { 1, 2, 3 };

            Assert.AreEqual(integers.IndexOf(2), 1);
        }
    }
}
