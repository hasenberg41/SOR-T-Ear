using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Algorithmes
{
    /// <summary>
    /// Базовый класс для алгоритмов сортировки
    /// </summary>
    /// <typeparam name="T">любое числовое значение</typeparam>
    public class AlgorithmesBase<T> where T : IComparable
    {
        #region Инициализация счётчиков
        public int SwapCount { get; protected set; } = 0; // Счётчик, запоминающий количество вызовов метода Swap()
        public int ComparisonCount { get; protected set;} = 0; // Счётчик, запоминающий количество изменений в массиве в момент сортировки для сравнения алгоритмов
        #endregion

        public List<T> Items { get; set; } = new List<T>();

        /// <summary>
        /// Метод, меняющий местами два элемента списка
        /// </summary>
        /// <param name="posA"></param>
        /// <param name="posB"></param>
        protected void Swap (int posA, int posB)
        {
            if (posA < Items.Count && posB < Items.Count)
            {
                (Items[posB], Items[posA]) = (Items[posA], Items[posB]);
                SwapCount++;
            }
        }

        /// <summary>
        /// Вызывает метод MakeSort(), возвращая временной промежуток его выполнения
        /// </summary>
        /// <returns></returns>
        public TimeSpan Sort()
        {
            SwapCount = 0;
            var timer = new Stopwatch();

            timer.Start();
            MakeSort();
            timer.Stop();
            return timer.Elapsed;
        }

        /// <summary>
        /// Вызывает встроенную в .net сортировку, с возможностью переопределения
        /// </summary>
        protected virtual void MakeSort()
        {
            Items.Sort();
        }
    }
}
