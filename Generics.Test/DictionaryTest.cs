using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Generics.Test
{
    [TestClass]
    public class DictionaryTest
    {
        [TestMethod]
        public void Can_Use_Dictionary_As_Map()
        {
            var map = new Dictionary<int, string>();

            map.Add(1, "One");
            map.Add(2, "Two");
            map.Add(3, "Three");

            Assert.AreEqual("Two", map[2]);
        }
    }
}
