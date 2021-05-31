using Algorithms;
using Algorithms.DataStructures;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace SortingAlgorithms
{
    public partial class Form1 : Form
    {
        List<SortedItem> items = new List<SortedItem>();
        public Form1()
        {
            InitializeComponent();
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(AddTextBox.Text, out int value))
            {
                var item = new SortedItem(value, items.Count);
                items.Add(item);

                RefreshItems();
            }

            AddTextBox.Text = "";
        }
        private void FillButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(FillTextBox.Text, out int value))
            {
                var rnd = new Random();

                for (int i = 0; i < value; i++)
                {
                    var item = new SortedItem(rnd.Next(100), items.Count);
                    items.Add(item);
                }

                RefreshItems();
            }

            FillTextBox.Text = "";
        }
        private void DrawItems(List<SortedItem> items)
        {
            panel3.Controls.Clear();

            foreach (var item in items)
            {
                panel3.Controls.Add(item.ProgressBar);
                panel3.Controls.Add(item.Label);
            }
        }
        private void RefreshItems()
        {
            foreach (var item in items)
            {
                item.Refresh();
            }

            DrawItems(items);
        }
        private void AlgorithmSwopEvent(object sender, Tuple<SortedItem, SortedItem> e)
        {
            var temp = e.Item1.Number;
            e.Item1.SetPosition(e.Item2.Number);
            e.Item2.SetPosition(temp);
            panel3.Refresh();
        }
        private void AlgorithmCompareEvent(object sender, Tuple<SortedItem, SortedItem> e)
        {
            e.Item1.SetColor(Color.Red);
            e.Item2.SetColor(Color.Green);
            panel3.Refresh();

            Thread.Sleep(100);

            e.Item1.SetColor(Color.Blue);
            e.Item2.SetColor(Color.Blue);
            panel3.Refresh();
        }
        private void AlgorithmSetEvent(object sender, Tuple<int, SortedItem> e)
        {
            e.Item2.SetColor(Color.Red);
            panel3.Refresh();

            Thread.Sleep(20);

            e.Item2.SetPosition(e.Item1);
            panel3.Refresh();

            Thread.Sleep(20);

            e.Item2.SetColor(Color.Blue);
            panel3.Refresh();

            Thread.Sleep(20);
        }
        private void Button_Click(AlgorithmBase<SortedItem> algorithm)
        {
            RefreshItems();

            for (int i = 0; i < algorithm.Items.Count; i++)
            {
                algorithm.Items[i].SetPosition(i);
            }
            panel3.Refresh();

            algorithm.CompareEvent += AlgorithmCompareEvent;
            algorithm.SwopEvent += AlgorithmSwopEvent;
            algorithm.SetEvent += AlgorithmSetEvent;
            var time = algorithm.Sort();
            TimeLabel.Text = "Время: " + time.Milliseconds;
            CompareLabel.Text = "Количество сравнений: " + algorithm.ComparisonCount;
            SwopLabel.Text = "Количество обменов: " + algorithm.SwopCount;
        }
        private void BubbleSortButton_Click(object sender, EventArgs e)
        {
            var bubble = new BubbleSort<SortedItem>(items);
            Button_Click(bubble);
        }
        private void CocktailSortButton_Click(object sender, EventArgs e)
        {
            var cocktail = new CocktailSort<SortedItem>(items);
            Button_Click(cocktail);
        }
        private void InsertionSortButton_Click(object sender, EventArgs e)
        {
            var insertion = new InsertSort<SortedItem>(items);
            Button_Click(insertion);
        }
        private void ShellSortButton_Click(object sender, EventArgs e)
        {
            var shell = new ShellSort<SortedItem>(items);
            Button_Click(shell);
        }
        private void SelectionSortButton_Click(object sender, EventArgs e)
        {
            var selection = new ShellSort<SortedItem>(items);
            Button_Click(selection);
        }
        private void HeapSortButton_Click(object sender, EventArgs e)
        {
            var heap = new Heap<SortedItem>(items);
            Button_Click(heap);
        }
        private void GnomeSortButton_Click(object sender, EventArgs e)
        {
            var gnome = new GnomeSort<SortedItem>(items);
            Button_Click(gnome);
        }
        private void TreeSortButton_Click(object sender, EventArgs e)
        {
            var tree = new Tree<SortedItem>(items);
            Button_Click(tree);
        }

        private void LsdRadixSortButton_Click(object sender, EventArgs e)
        {
            var lsd = new LsdRadixSort<SortedItem>(items);
            Button_Click(lsd);
        }

        private void MsdRadixSortButton_Click(object sender, EventArgs e)
        {
            var msd = new MsdRadixSort<SortedItem>(items);
            Button_Click(msd);
        }
    }
}
