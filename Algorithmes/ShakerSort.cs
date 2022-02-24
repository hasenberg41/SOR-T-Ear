using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmes
{
    /// <summary>
    /// Реализация шейкерной сортировки
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ShakerSort<T>: AlgorithmesBase<T> where T : IComparable
    {
        protected override void MakeSort() // Переопределение встроенной сортировки
        {
            int left = 0;
            int right = Items.Count - 1;

            while (left < right)
            {
                int breaker = SwapCount;

                for (int i = left; i < right; i++)
                {
                    if (Items[i].CompareTo(Items[i+1]) > 0)
                    {
                        ComparisonCount++; // Счётчик количества изменений в массиве

                        Swap(i, i+1);
                    }
                }
                right--;

                if (breaker == SwapCount) break;

                for (int i = right; i > left; i--)
                {
                    if (Items[i].CompareTo(Items[i-1]) < 0)
                    {
                        ComparisonCount++; // Счётчик количества изменений в массиве

                        Swap(i, i - 1);
                    }
                }
                left++;

                if (breaker == SwapCount) break;
            }
        }
    }
}
