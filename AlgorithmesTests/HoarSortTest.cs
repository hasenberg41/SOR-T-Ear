using Algorithmes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace AlgorithmesTests
{
    [TestClass]
    public class HoarSortTest
    {
        [TestMethod]
        public void SortTest()
        {
            // arrange
            var hoar = new HoarSort<int>();

            var items = new List<int>();
            Random random = new Random();

            for (int i = 0; i < 10000; i++)
                items.Add(random.Next(0, 100));

            hoar.Items.AddRange(items);

            // act
            items.Sort();
            hoar.Sort();

            // assert
            for (int i = 0; i < items.Count; i++)
            {
                Assert.AreEqual(hoar.Items[i], items[i]);
            }
        }
    }
}
