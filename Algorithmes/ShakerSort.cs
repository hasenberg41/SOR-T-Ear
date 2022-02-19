using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmes
{
    public class ShakerSort<T>: AlgorithmesBase<T> where T : IComparable
    {
        public override void Sort()
        {
            int left = 0;
            int right = Items.Count - 1;

            while (left < right)
            {
                for (int i = left; i < right; i++)
                {
                    if (Items[i].CompareTo(Items[i+1]) > 0)
                    {
                        Swap(i, i+1);
                    }
                }
                right--;

                for (int i = right; i > left; i--)
                {
                    if (Items[i].CompareTo(Items[i-1]) < 0)
                    {
                        Swap(i, i - 1);
                    }
                }
                left++;
            }
        }
    }
}
