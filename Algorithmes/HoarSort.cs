using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmes
{
    public class HoarSort<T> : AlgorithmesBase<T> where T : IComparable
    {
        protected override void MakeSort()
        {
            Hoar(Items, 0, Items.Count - 1);
        }

        protected void Hoar(List<T> items, int low, int hight)
        {
            if (low < hight)
            {
                int p = Partition(items, low, hight);
                Hoar(items, low, p - 1);
                Hoar(items, p + 1, hight);
            }
        }

        protected int Partition(List<T> items, int start, int end)
        {
            var pivot = start - 1;

            for (int i = start; i < end; i++)
            {
                if (items[i].CompareTo(items[end]) == -1)
                {
                    Swap(i, ++pivot);
                }
            }

            Swap(++pivot, end);
            return pivot;
        }
    }
}
