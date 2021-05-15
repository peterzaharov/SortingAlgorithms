﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class BubbleSort<T> : AlgorithmBase<T> where T : IComparable
    {
        protected override void MakeSort()
        {
            var count = Items.Count;
            for (int i = 0; i < count; i++)
            {
                var sc = SwopCount;

                for (int j = 0; j < count - i - 1; j++)
                {
                    var a = Items[j];
                    var b = Items[j + 1];

                    if (a.CompareTo(b) == 1)
                    {
                        Swop(j, j + 1);

                        ComparisonCount++;
                    }
                }

                if (sc == SwopCount)
                {
                    break;
                }
            }
        }
    }
}
