
namespace SortingAlgorithms
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.AddTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.FillButton = new System.Windows.Forms.Button();
            this.FillTextBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BubbleSortButton = new System.Windows.Forms.Button();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.CompareLabel = new System.Windows.Forms.Label();
            this.SwopLabel = new System.Windows.Forms.Label();
            this.CocktailSortButton = new System.Windows.Forms.Button();
            this.InsertionSortButton = new System.Windows.Forms.Button();
            this.ShellSortButton = new System.Windows.Forms.Button();
            this.SelectionSortButton = new System.Windows.Forms.Button();
            this.HeapSortButton = new System.Windows.Forms.Button();
            this.GnomeSortButton = new System.Windows.Forms.Button();
            this.TreeSortButton = new System.Windows.Forms.Button();
            this.LsdRadixSortButton = new System.Windows.Forms.Button();
            this.MsdRadixSortButton = new System.Windows.Forms.Button();
            this.MergeSortButton = new System.Windows.Forms.Button();
            this.QuickSortButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.AddButton);
            this.panel1.Controls.Add(this.AddTextBox);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 70);
            this.panel1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Добавить число";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(212, 25);
            this.AddButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(100, 30);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AddTextBox
            // 
            this.AddTextBox.Location = new System.Drawing.Point(5, 26);
            this.AddTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddTextBox.Multiline = true;
            this.AddTextBox.Name = "AddTextBox";
            this.AddTextBox.Size = new System.Drawing.Size(200, 27);
            this.AddTextBox.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.FillButton);
            this.panel2.Controls.Add(this.FillTextBox);
            this.panel2.Location = new System.Drawing.Point(12, 89);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(315, 70);
            this.panel2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(274, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Заполнить массив случайными числами";
            // 
            // FillButton
            // 
            this.FillButton.Location = new System.Drawing.Point(212, 25);
            this.FillButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FillButton.Name = "FillButton";
            this.FillButton.Size = new System.Drawing.Size(100, 30);
            this.FillButton.TabIndex = 1;
            this.FillButton.Text = "Заполнить";
            this.FillButton.UseVisualStyleBackColor = true;
            this.FillButton.Click += new System.EventHandler(this.FillButton_Click);
            // 
            // FillTextBox
            // 
            this.FillTextBox.Location = new System.Drawing.Point(5, 26);
            this.FillTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FillTextBox.Multiline = true;
            this.FillTextBox.Name = "FillTextBox";
            this.FillTextBox.Size = new System.Drawing.Size(200, 27);
            this.FillTextBox.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Location = new System.Drawing.Point(333, 12);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(972, 146);
            this.panel3.TabIndex = 3;
            // 
            // BubbleSortButton
            // 
            this.BubbleSortButton.Location = new System.Drawing.Point(12, 164);
            this.BubbleSortButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BubbleSortButton.Name = "BubbleSortButton";
            this.BubbleSortButton.Size = new System.Drawing.Size(99, 28);
            this.BubbleSortButton.TabIndex = 0;
            this.BubbleSortButton.Text = "Bubble Sort";
            this.BubbleSortButton.UseVisualStyleBackColor = true;
            this.BubbleSortButton.Click += new System.EventHandler(this.BubbleSortButton_Click);
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Location = new System.Drawing.Point(9, 203);
            this.TimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(58, 17);
            this.TimeLabel.TabIndex = 7;
            this.TimeLabel.Text = "Время: ";
            // 
            // CompareLabel
            // 
            this.CompareLabel.AutoSize = true;
            this.CompareLabel.Location = new System.Drawing.Point(9, 230);
            this.CompareLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CompareLabel.Name = "CompareLabel";
            this.CompareLabel.Size = new System.Drawing.Size(168, 17);
            this.CompareLabel.TabIndex = 8;
            this.CompareLabel.Text = "Количество сравнений: ";
            // 
            // SwopLabel
            // 
            this.SwopLabel.AutoSize = true;
            this.SwopLabel.Location = new System.Drawing.Point(9, 256);
            this.SwopLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SwopLabel.Name = "SwopLabel";
            this.SwopLabel.Size = new System.Drawing.Size(154, 17);
            this.SwopLabel.TabIndex = 9;
            this.SwopLabel.Text = "Количество обменов: ";
            // 
            // CocktailSortButton
            // 
            this.CocktailSortButton.Location = new System.Drawing.Point(117, 164);
            this.CocktailSortButton.Margin = new System.Windows.Forms.Padding(4);
            this.CocktailSortButton.Name = "CocktailSortButton";
            this.CocktailSortButton.Size = new System.Drawing.Size(100, 28);
            this.CocktailSortButton.TabIndex = 10;
            this.CocktailSortButton.Text = "Cocktail Sort";
            this.CocktailSortButton.UseVisualStyleBackColor = true;
            this.CocktailSortButton.Click += new System.EventHandler(this.CocktailSortButton_Click);
            // 
            // InsertionSortButton
            // 
            this.InsertionSortButton.Location = new System.Drawing.Point(224, 164);
            this.InsertionSortButton.Margin = new System.Windows.Forms.Padding(4);
            this.InsertionSortButton.Name = "InsertionSortButton";
            this.InsertionSortButton.Size = new System.Drawing.Size(100, 28);
            this.InsertionSortButton.TabIndex = 11;
            this.InsertionSortButton.Text = "Insert Sort";
            this.InsertionSortButton.UseVisualStyleBackColor = true;
            this.InsertionSortButton.Click += new System.EventHandler(this.InsertionSortButton_Click);
            // 
            // ShellSortButton
            // 
            this.ShellSortButton.Location = new System.Drawing.Point(333, 164);
            this.ShellSortButton.Margin = new System.Windows.Forms.Padding(4);
            this.ShellSortButton.Name = "ShellSortButton";
            this.ShellSortButton.Size = new System.Drawing.Size(99, 28);
            this.ShellSortButton.TabIndex = 12;
            this.ShellSortButton.Text = "Shell Sort";
            this.ShellSortButton.UseVisualStyleBackColor = true;
            this.ShellSortButton.Click += new System.EventHandler(this.ShellSortButton_Click);
            // 
            // SelectionSortButton
            // 
            this.SelectionSortButton.Location = new System.Drawing.Point(534, 163);
            this.SelectionSortButton.Name = "SelectionSortButton";
            this.SelectionSortButton.Size = new System.Drawing.Size(115, 30);
            this.SelectionSortButton.TabIndex = 13;
            this.SelectionSortButton.Text = "Selection Sort";
            this.SelectionSortButton.UseVisualStyleBackColor = true;
            this.SelectionSortButton.Click += new System.EventHandler(this.SelectionSortButton_Click);
            // 
            // HeapSortButton
            // 
            this.HeapSortButton.Location = new System.Drawing.Point(439, 164);
            this.HeapSortButton.Name = "HeapSortButton";
            this.HeapSortButton.Size = new System.Drawing.Size(89, 28);
            this.HeapSortButton.TabIndex = 14;
            this.HeapSortButton.Text = "Heap Sort";
            this.HeapSortButton.UseVisualStyleBackColor = true;
            this.HeapSortButton.Click += new System.EventHandler(this.HeapSortButton_Click);
            // 
            // GnomeSortButton
            // 
            this.GnomeSortButton.Location = new System.Drawing.Point(655, 163);
            this.GnomeSortButton.Name = "GnomeSortButton";
            this.GnomeSortButton.Size = new System.Drawing.Size(96, 29);
            this.GnomeSortButton.TabIndex = 15;
            this.GnomeSortButton.Text = "Gnome Sort";
            this.GnomeSortButton.UseVisualStyleBackColor = true;
            this.GnomeSortButton.Click += new System.EventHandler(this.GnomeSortButton_Click);
            // 
            // TreeSortButton
            // 
            this.TreeSortButton.Location = new System.Drawing.Point(757, 163);
            this.TreeSortButton.Name = "TreeSortButton";
            this.TreeSortButton.Size = new System.Drawing.Size(88, 30);
            this.TreeSortButton.TabIndex = 16;
            this.TreeSortButton.Text = "Tree Sort";
            this.TreeSortButton.UseVisualStyleBackColor = true;
            this.TreeSortButton.Click += new System.EventHandler(this.TreeSortButton_Click);
            // 
            // LsdRadixSortButton
            // 
            this.LsdRadixSortButton.Location = new System.Drawing.Point(851, 163);
            this.LsdRadixSortButton.Name = "LsdRadixSortButton";
            this.LsdRadixSortButton.Size = new System.Drawing.Size(122, 30);
            this.LsdRadixSortButton.TabIndex = 17;
            this.LsdRadixSortButton.Text = "LSD Radix Sort";
            this.LsdRadixSortButton.UseVisualStyleBackColor = true;
            this.LsdRadixSortButton.Click += new System.EventHandler(this.LsdRadixSortButton_Click);
            // 
            // MsdRadixSortButton
            // 
            this.MsdRadixSortButton.Location = new System.Drawing.Point(979, 163);
            this.MsdRadixSortButton.Name = "MsdRadixSortButton";
            this.MsdRadixSortButton.Size = new System.Drawing.Size(126, 30);
            this.MsdRadixSortButton.TabIndex = 18;
            this.MsdRadixSortButton.Text = "MSD Radix Sort";
            this.MsdRadixSortButton.UseVisualStyleBackColor = true;
            this.MsdRadixSortButton.Click += new System.EventHandler(this.MsdRadixSortButton_Click);
            // 
            // MergeSortButton
            // 
            this.MergeSortButton.Location = new System.Drawing.Point(1111, 163);
            this.MergeSortButton.Name = "MergeSortButton";
            this.MergeSortButton.Size = new System.Drawing.Size(95, 30);
            this.MergeSortButton.TabIndex = 19;
            this.MergeSortButton.Text = "Merge Sort";
            this.MergeSortButton.UseVisualStyleBackColor = true;
            this.MergeSortButton.Click += new System.EventHandler(this.MergeSortButton_Click);
            // 
            // QuickSortButton
            // 
            this.QuickSortButton.Location = new System.Drawing.Point(1212, 163);
            this.QuickSortButton.Name = "QuickSortButton";
            this.QuickSortButton.Size = new System.Drawing.Size(94, 30);
            this.QuickSortButton.TabIndex = 20;
            this.QuickSortButton.Text = "Quick Sort";
            this.QuickSortButton.UseVisualStyleBackColor = true;
            this.QuickSortButton.Click += new System.EventHandler(this.QuickSortButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 291);
            this.Controls.Add(this.QuickSortButton);
            this.Controls.Add(this.MergeSortButton);
            this.Controls.Add(this.MsdRadixSortButton);
            this.Controls.Add(this.LsdRadixSortButton);
            this.Controls.Add(this.TreeSortButton);
            this.Controls.Add(this.GnomeSortButton);
            this.Controls.Add(this.HeapSortButton);
            this.Controls.Add(this.SelectionSortButton);
            this.Controls.Add(this.ShellSortButton);
            this.Controls.Add(this.InsertionSortButton);
            this.Controls.Add(this.CocktailSortButton);
            this.Controls.Add(this.SwopLabel);
            this.Controls.Add(this.CompareLabel);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.BubbleSortButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox AddTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button FillButton;
        private System.Windows.Forms.TextBox FillTextBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BubbleSortButton;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label CompareLabel;
        private System.Windows.Forms.Label SwopLabel;
        private System.Windows.Forms.Button CocktailSortButton;
        private System.Windows.Forms.Button InsertionSortButton;
        private System.Windows.Forms.Button ShellSortButton;
        private System.Windows.Forms.Button SelectionSortButton;
        private System.Windows.Forms.Button HeapSortButton;
        private System.Windows.Forms.Button GnomeSortButton;
        private System.Windows.Forms.Button TreeSortButton;
        private System.Windows.Forms.Button LsdRadixSortButton;
        private System.Windows.Forms.Button MsdRadixSortButton;
        private System.Windows.Forms.Button MergeSortButton;
        private System.Windows.Forms.Button QuickSortButton;
    }
}

