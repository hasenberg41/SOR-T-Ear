using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithmes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmes.Tests
{
    [TestClass()]
    public class ShakerSortTests
    {
        [TestMethod()]
        public void SortTest()
        {
            // arrange
            var shaker = new ShakerSort<int>();

            var items = new List<int>();
            Random random = new Random();

            for (int i = 0; i < 10; i++)
                items.Add(random.Next(0, 100));

            shaker.Items.AddRange(items);

            // act
            items.Sort();
            shaker.Sort();

            // assert
            for (int i = 0; i < items.Count; i++)
            {
                Assert.AreEqual(shaker.Items[i], items[i]);
            }
        }
    }
}