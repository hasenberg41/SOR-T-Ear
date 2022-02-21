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
            Hoar(Items, 0, Items.Count);
        }

        protected void Hoar(List<T> items, int low, int hight)
        {
            int start = low, end = hight;
            Partition(items, ref start, ref end);
            
            if (start < hight)
                Hoar(items, start, hight);

            if (end > low)
                Hoar(items, low, end);         
        }

        protected void Partition(List<T> items, ref int start, ref int end)
        {
            var pivot = items[(start + end) / 2];
            int i = start;
            int j = end;

            do
            {
                while (items[i].CompareTo(pivot) == -1)
                    i++;

                while (items[j].CompareTo(pivot) == 1)
                    j++;

                if (i >= j)
                {
                    i++;
                    j--;                    
                }
                Swap(i, j);
            }
            while (i <= j);
        }
    }
}
