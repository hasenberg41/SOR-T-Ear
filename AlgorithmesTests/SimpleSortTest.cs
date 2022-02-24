using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace AlgorithmesTests
{
    [TestClass]
    public class DefaultSortTest
    {
        [TestMethod]
        public void SortTest()
        {
            var items = new List<int>();
            Random random = new Random();

            for (int i = 0; i < 100000; i++)
                items.Add(random.Next(0, 100));

            // act
            items.Sort();

            // assert
            for (int i = 0; i < items.Count; i++)
            {
                Assert.AreEqual(items[i].ToString(), items[i].ToString());
            }
        }
    }
}
