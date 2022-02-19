using System;
using System.Collections.Generic;

namespace Algorithmes
{
    public class AlgorithmesBase<T> where T : IComparable
    {
        public List<T> Items { get; set; } = new List<T>();

        protected void Swap (int posA, int posB)
        {
            if (posA < Items.Count && posB < Items.Count)
            {
                var temp = Items[posA];
                Items[posA] = Items[posB];
                Items[posB] = temp;
            }
        }

        public virtual void Sort()
        {
            Items.Sort();
        }
    }
}
