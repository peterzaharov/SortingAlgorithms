﻿using Algorithms.DataStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms.Tests
{
    [TestClass()]
    public class BubbleSortTests
    {
        [TestClass()]
        public class SortTests
        {
            Random rnd = new Random();
            List<int> Items = new List<int>();
            List<int> Sorted = new List<int>();

            [TestInitialize]
            public void Init()
            {
                Items.Clear();
                for (int i = 0; i < 1000; i++)
                {
                    Items.Add(rnd.Next(0, 100));
                }

                Sorted.Clear();

                Sorted.AddRange(Items.OrderBy(x => x).ToArray());
            }
            
            [TestMethod()]
            public void BubbleSortTest()
            {
                //arrange
                var bubble = new BubbleSort<int>();
                bubble.Items.AddRange(Items);

                //act
                bubble.Sort();

                //assert
                for (int i = 0; i < Items.Count; i++)
                {
                    Assert.AreEqual(Sorted[i], bubble.Items[i]);
                }
            }
            
            [TestMethod()]
            public void CocktailSortTest()
            {
                //arrange
                var cocktail = new CocktailSort<int>();
                cocktail.Items.AddRange(Items);

                //act
                cocktail.Sort();

                //assert
                for (int i = 0; i < Items.Count; i++)
                {
                    Assert.AreEqual(Sorted[i], cocktail.Items[i]);
                }
            }
            
            [TestMethod()]
            public void InsertSortTest()
            {
                //arrange
                var insert = new InsertSort<int>();
                insert.Items.AddRange(Items);

                //act
                insert.Sort();

                //assert
                for (int i = 0; i < Items.Count; i++)
                {
                    Assert.AreEqual(Sorted[i], insert.Items[i]);
                }
            }

            [TestMethod()]
            public void ShellSortTest()
            {
                //arrange
                var shell = new ShellSort<int>();
                shell.Items.AddRange(Items);

                //act
                shell.Sort();

                //assert
                for (int i = 0; i < Items.Count; i++)
                {
                    Assert.AreEqual(Sorted[i], shell.Items[i]);
                }
            }

            [TestMethod()]
            public void TreeSortTest()
            {
                //arrange
                var tree = new Tree<int>(Items);

                //act
                tree.Sort();

                //assert
                for (int i = 0; i < Items.Count; i++)
                {
                    Assert.AreEqual(Sorted[i], tree.Items[i]);
                }
            }

            [TestMethod()]
            public void HeapSortTest()
            {
                //arrange
                var heap = new Heap<int>(Items);

                //act
                heap.Sort();

                //assert
                for (int i = 0; i < Items.Count; i++)
                {
                    Assert.AreEqual(Sorted[i], heap.Items[i]);
                }
            }

            [TestMethod()]
            public void SelectionSortTest()
            {
                //arrange
                var selection = new SelectionSort<int>();
                selection.Items.AddRange(Items);

                //act
                selection.Sort();

                //assert
                for (int i = 0; i < Items.Count; i++)
                {
                    Assert.AreEqual(Sorted[i], selection.Items[i]);
                }
            }

            [TestMethod()]
            public void GnomeSortTest()
            {
                //arrange
                var gnome = new GnomeSort<int>();
                gnome.Items.AddRange(Items);

                //act
                gnome.Sort();

                //assert
                for (int i = 0; i < Items.Count; i++)
                {
                    Assert.AreEqual(Sorted[i], gnome.Items[i]);
                }
            }

            [TestMethod()]
            public void RadixSortTest()
            {
                //arrange
                var radix = new LsdRadixSort<int>();
                radix.Items.AddRange(Items);

                //act
                radix.Sort();

                //assert
                for (int i = 0; i < Items.Count; i++)
                {
                    Assert.AreEqual(Sorted[i], radix.Items[i]);
                }
            }
        }
    }
}