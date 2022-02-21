using System;
using System.Collections.Generic;

namespace Algorithmes
{
    public class BubbleSort<T>: AlgorithmesBase<T> where T : IComparable
    {
        protected override void MakeSort()
        {
            var count = Items.Count;

            for (int j = 0; j < count; j++)
            {
                for (int i = 0; i < count - 1 - j; i++)
                {
                    var a = Items[i];
                    var b = Items[i + 1];

                    if (a.CompareTo(b) == 1)
                    {
                        ComparisonCount++;

                        Swap(i, i + 1);
                    }
                }
            }
        }
    }
}
