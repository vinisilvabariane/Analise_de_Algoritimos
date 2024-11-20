namespace Algoritimos
{
    partial class ANALISEALG
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            RadixButton = new Button();
            HeapButton = new Button();
            QuickButton = new Button();
            MergeButton = new Button();
            ImprovedBubbleButton = new Button();
            SelectionButton = new Button();
            InserctionButton = new Button();
            BubbleButton = new Button();
            progressBar1 = new ProgressBar();
            panel3 = new Panel();
            panel4 = new Panel();
            CemmilElementos = new RadioButton();
            DezmilElementos = new RadioButton();
            milElementos = new RadioButton();
            results = new Label();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SkyBlue;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1164, 115);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Alef", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(212, 38);
            label2.Name = "label2";
            label2.Size = new Size(63, 47);
            label2.TabIndex = 2;
            label2.Text = "C#";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Alef", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(271, 50);
            label1.Name = "label1";
            label1.Size = new Size(336, 26);
            label1.TabIndex = 1;
            label1.Text = "Software de Análise de Algorítmos\r\n";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ENGENHARIA_600x600;
            pictureBox1.Location = new Point(29, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 103);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(RadixButton);
            panel2.Controls.Add(HeapButton);
            panel2.Controls.Add(QuickButton);
            panel2.Controls.Add(MergeButton);
            panel2.Controls.Add(ImprovedBubbleButton);
            panel2.Controls.Add(SelectionButton);
            panel2.Controls.Add(InserctionButton);
            panel2.Controls.Add(BubbleButton);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 115);
            panel2.Name = "panel2";
            panel2.Size = new Size(1164, 46);
            panel2.TabIndex = 1;
            // 
            // RadixButton
            // 
            RadixButton.Location = new Point(859, 0);
            RadixButton.Name = "RadixButton";
            RadixButton.Size = new Size(115, 46);
            RadixButton.TabIndex = 7;
            RadixButton.Text = "Radix Sort";
            RadixButton.UseVisualStyleBackColor = true;
            RadixButton.Click += RadixSortButton_Click;
            // 
            // HeapButton
            // 
            HeapButton.Location = new Point(738, 0);
            HeapButton.Name = "HeapButton";
            HeapButton.Size = new Size(115, 46);
            HeapButton.TabIndex = 6;
            HeapButton.Text = "Heap Sort ";
            HeapButton.UseVisualStyleBackColor = true;
            HeapButton.Click += HeapSortButton_Click;
            // 
            // QuickButton
            // 
            QuickButton.Location = new Point(617, 0);
            QuickButton.Name = "QuickButton";
            QuickButton.Size = new Size(115, 46);
            QuickButton.TabIndex = 5;
            QuickButton.Text = "Quick Sort ";
            QuickButton.UseVisualStyleBackColor = true;
            QuickButton.Click += QuickSortButton_Click;
            // 
            // MergeButton
            // 
            MergeButton.Location = new Point(496, 0);
            MergeButton.Name = "MergeButton";
            MergeButton.Size = new Size(115, 46);
            MergeButton.TabIndex = 4;
            MergeButton.Text = "Merge Sort ";
            MergeButton.UseVisualStyleBackColor = true;
            MergeButton.Click += MergeSortButton_Click;
            // 
            // ImprovedBubbleButton
            // 
            ImprovedBubbleButton.Location = new Point(133, 0);
            ImprovedBubbleButton.Name = "ImprovedBubbleButton";
            ImprovedBubbleButton.Size = new Size(115, 46);
            ImprovedBubbleButton.TabIndex = 3;
            ImprovedBubbleButton.Text = "Improved Bubble Sort";
            ImprovedBubbleButton.UseVisualStyleBackColor = true;
            ImprovedBubbleButton.Click += ImprovedBubbleButton_Click;
            // 
            // SelectionButton
            // 
            SelectionButton.Location = new Point(375, 0);
            SelectionButton.Name = "SelectionButton";
            SelectionButton.Size = new Size(115, 46);
            SelectionButton.TabIndex = 2;
            SelectionButton.Text = "Selection Sort";
            SelectionButton.UseVisualStyleBackColor = true;
            SelectionButton.Click += SelectionSortButton_Click;
            // 
            // InserctionButton
            // 
            InserctionButton.Location = new Point(254, 0);
            InserctionButton.Name = "InserctionButton";
            InserctionButton.Size = new Size(115, 46);
            InserctionButton.TabIndex = 1;
            InserctionButton.Text = "Inserction Sort";
            InserctionButton.UseVisualStyleBackColor = true;
            InserctionButton.Click += InsertionButton_Click;
            // 
            // BubbleButton
            // 
            BubbleButton.Location = new Point(12, 0);
            BubbleButton.Name = "BubbleButton";
            BubbleButton.Size = new Size(115, 46);
            BubbleButton.TabIndex = 0;
            BubbleButton.Text = "Bubble Sort";
            BubbleButton.UseVisualStyleBackColor = true;
            BubbleButton.Click += BubbleButton_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 5);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(1140, 23);
            progressBar1.TabIndex = 2;
            progressBar1.Click += progressBar1_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(progressBar1);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 623);
            panel3.Name = "panel3";
            panel3.Size = new Size(1164, 31);
            panel3.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(CemmilElementos);
            panel4.Controls.Add(DezmilElementos);
            panel4.Controls.Add(milElementos);
            panel4.Controls.Add(results);
            panel4.Controls.Add(dataGridView1);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 161);
            panel4.Name = "panel4";
            panel4.Size = new Size(1164, 462);
            panel4.TabIndex = 4;
            // 
            // CemmilElementos
            // 
            CemmilElementos.AutoSize = true;
            CemmilElementos.Location = new Point(854, 61);
            CemmilElementos.Name = "CemmilElementos";
            CemmilElementos.Size = new Size(122, 19);
            CemmilElementos.TabIndex = 4;
            CemmilElementos.TabStop = true;
            CemmilElementos.Text = "100.000 Elementos";
            CemmilElementos.UseVisualStyleBackColor = true;
            // 
            // DezmilElementos
            // 
            DezmilElementos.AutoSize = true;
            DezmilElementos.Location = new Point(854, 36);
            DezmilElementos.Name = "DezmilElementos";
            DezmilElementos.Size = new Size(116, 19);
            DezmilElementos.TabIndex = 3;
            DezmilElementos.TabStop = true;
            DezmilElementos.Text = "10.000 Elementos";
            DezmilElementos.UseVisualStyleBackColor = true;
            // 
            // milElementos
            // 
            milElementos.AutoSize = true;
            milElementos.Location = new Point(854, 11);
            milElementos.Name = "milElementos";
            milElementos.Size = new Size(113, 19);
            milElementos.TabIndex = 2;
            milElementos.TabStop = true;
            milElementos.Text = "1.000 Elementos ";
            milElementos.UseVisualStyleBackColor = true;
            // 
            // results
            // 
            results.AutoSize = true;
            results.Font = new Font("Alef", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            results.Location = new Point(155, 175);
            results.Name = "results";
            results.Size = new Size(0, 37);
            results.TabIndex = 1;
            results.Click += results_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Right;
            dataGridView1.Location = new Point(976, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(188, 462);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ANALISEALG
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1164, 654);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ANALISEALG";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Análise de Algotimos";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button BubbleButton;
        private PictureBox pictureBox1;
        private Button SelectionButton;
        private Button InserctionButton;
        private Label label1;
        private Label label2;
        private ProgressBar progressBar1;
        private Panel panel3;
        private Panel panel4;
        private DataGridView dataGridView1;
        private Label results;
        private Button ImprovedBubbleButton;
        private Button HeapButton;
        private Button QuickButton;
        private Button MergeButton;
        private RadioButton DezmilElementos;
        private RadioButton milElementos;
        private RadioButton CemmilElementos;
        private Button RadixButton;
    }
}
