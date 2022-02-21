using Algorithmes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Algorithmes.Tests
{
    [TestClass]
    public class InsertionSortTest
    {
        [TestMethod]
        public void SortTest()
        {
            // arrange
            var insertion = new InsertionSort<int>();

            var items = new List<int>();
            Random random = new Random();

            for (int i = 0; i < 10000; i++)
                items.Add(random.Next(0, 100));

            insertion.Items.AddRange(items);

            // act
            items.Sort();
            insertion.Sort();

            // assert
            for (int i = 0; i < items.Count; i++)
            {
                Assert.AreEqual(insertion.Items[i], items[i]);
            }
        }
    }
}
