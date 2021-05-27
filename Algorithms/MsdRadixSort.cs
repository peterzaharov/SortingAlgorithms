﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class MsdRadixSort<T> : AlgorithmBase<T> where T : IComparable
    {
        public MsdRadixSort(IEnumerable<T> items) : base(items) { }
        public MsdRadixSort() { }
        protected override void MakeSort()
        {
            int length = GetMaxLength(Items);
            var result = SortCollection(Items, length - 1);
            Items = result;
        }
        private List<T> SortCollection(List<T> collection, int step)
        {
            var result = new List<T>();
            var groups = new List<List<T>>();
            for (int i = 0; i < 10; i++)
            {
                groups.Add(new List<T>());
            }

            //Распределение элементов по корзинам.
            foreach (var item in collection)
            {
                var i = item.GetHashCode();
                var value = i % (int)Math.Pow(10, step + 1) / (int)Math.Pow(10, step);
                groups[value].Add(item);
            }

            //Сборка элементов.
            foreach (var group in groups)
            {
                if(group.Count > 1 && step > 0)
                {
                    result.AddRange(SortCollection(group, step - 1));
                    continue;
                }
                
                result.AddRange(group);
            }

            return result;
        }

        private int GetMaxLength(List<T> collection)
        {
            int length = 0;
            foreach (var item in collection)
            {
                if (item.GetHashCode() < 0)
                {
                    throw new ArgumentException("Поразрядная сортировка поддерживает только целые числа!", nameof(Items));
                }

                var l = item.GetHashCode().ToString().Length;
                if (l > length)
                {
                    length = l;
                }
            }
            return length;
        }
    }
}
