using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithmes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmesTests
{
    [TestClass()]
    public class BubbleSortTests
    {
        [TestMethod()]
        public void SortTest()
        {
            // arrange
            var bubble = new BubbleSort<int>();

            var items = new List<int>();
            Random random = new Random();

            for (int i = 0; i < 10000; i++)
                items.Add(random.Next(0, 100));

            bubble.Items.AddRange(items);

            // act
            items.Sort();
            bubble.Sort();

            // assert
            for (int i = 0; i < items.Count; i++)
            {
                Assert.AreEqual(bubble.Items[i], items[i]);
            }
         }
    }
}