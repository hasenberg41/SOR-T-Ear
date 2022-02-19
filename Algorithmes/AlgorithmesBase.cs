using System;
using System.Collections.Generic;

namespace Algorithmes
{
    public class AlgorithmesBase<T> where T : IComparable
    {
        public int SwapCount { get; protected set; } = 0;
        public int ComparisonCount { get; protected set;} = 0;

        public List<T> Items { get; set; } = new List<T>();

        protected void Swap (int posA, int posB)
        {
            if (posA < Items.Count && posB < Items.Count)
            {
                var temp = Items[posA];
                Items[posA] = Items[posB];
                Items[posB] = temp;
                SwapCount++;
            }
        }

        public virtual void Sort()
        {
            SwapCount = 0;
            Items.Sort();
        }
    }
}
