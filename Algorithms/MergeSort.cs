﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class MergeSort<T> : AlgorithmBase<T> where T : IComparable
    {
        public MergeSort(IEnumerable<T> items) : base(items) { }
        public MergeSort() { }
        protected override void MakeSort()
        {
            Items = Sort(Items);
        }
        private List<T> Sort(List<T> items)
        {
            if (items.Count == 1)
            {
                return items;
            }

            //Центральный элемент, по которому делим коллекцию
            var mid = items.Count / 2;

            //Левая и правая части коллекции
            var left = items.Take(mid).ToList();
            var right = items.Skip(mid).ToList();

            return Merge(Sort(left), Sort(right));
        }
        private List<T> Merge(List<T> left, List<T> right)
        {
            //Число элементов
            var length = left.Count + right.Count;
            //Указатели
            var leftPointer = 0;
            var rightPointer = 0;

            //Итоговая коллекция
            var result = new List<T>();

            for (int i = 0; i < length; i++)
            {
                if(leftPointer < left.Count && rightPointer < right.Count)
                {
                    if(Compare(left[leftPointer], right[rightPointer]) == -1)
                    {
                        result.Add(left[leftPointer]);
                        leftPointer++;
                    }
                    else
                    {
                        result.Add(right[rightPointer]);
                        rightPointer++;
                    }
                }
                else
                {
                    if(rightPointer < right.Count)
                    {
                        result.Add(right[rightPointer]);
                        rightPointer++;
                    }
                    else
                    {
                        result.Add(left[leftPointer]);
                        leftPointer++;
                    }
                }
            }

            return result;
        }
    }
}
