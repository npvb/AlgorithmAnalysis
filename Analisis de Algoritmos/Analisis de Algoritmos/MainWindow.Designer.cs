namespace Analisis_de_Algoritmos
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("InsertionSort");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("QuickSort");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Sorts", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("LCS");
            this.AlgorithmTreeView = new System.Windows.Forms.TreeView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.algorithm = new System.Windows.Forms.Label();
            this.Info2 = new System.Windows.Forms.TextBox();
            this.Info1 = new System.Windows.Forms.TextBox();
            this.errorListlabel = new System.Windows.Forms.Label();
            this.ArraySizeErrorLabel = new System.Windows.Forms.Label();
            this.arraySizeLbl = new System.Windows.Forms.Label();
            this.arraySize = new System.Windows.Forms.ComboBox();
            this.Solution = new System.Windows.Forms.TextBox();
            this.Solve = new System.Windows.Forms.Button();
            this.listado = new System.Windows.Forms.TextBox();
            this.ListChoice = new System.Windows.Forms.RadioButton();
            this.RandomChoice = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AlgorithmTreeView
            // 
            this.AlgorithmTreeView.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlgorithmTreeView.Location = new System.Drawing.Point(1, 29);
            this.AlgorithmTreeView.Name = "AlgorithmTreeView";
            treeNode1.Name = "InsertionSort";
            treeNode1.Text = "InsertionSort";
            treeNode2.Name = "QuickSort";
            treeNode2.Text = "QuickSort";
            treeNode3.Name = "Sorts";
            treeNode3.Text = "Sorts";
            treeNode4.Name = "LCS";
            treeNode4.Text = "LCS";
            this.AlgorithmTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4});
            this.AlgorithmTreeView.Size = new System.Drawing.Size(136, 351);
            this.AlgorithmTreeView.TabIndex = 0;
            this.AlgorithmTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.AlgorithmTreeView_AfterSelect);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(889, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.algorithm);
            this.panel1.Controls.Add(this.Info2);
            this.panel1.Controls.Add(this.Info1);
            this.panel1.Controls.Add(this.errorListlabel);
            this.panel1.Controls.Add(this.ArraySizeErrorLabel);
            this.panel1.Controls.Add(this.arraySizeLbl);
            this.panel1.Controls.Add(this.arraySize);
            this.panel1.Controls.Add(this.Solution);
            this.panel1.Controls.Add(this.Solve);
            this.panel1.Controls.Add(this.listado);
            this.panel1.Controls.Add(this.ListChoice);
            this.panel1.Controls.Add(this.RandomChoice);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(143, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(720, 351);
            this.panel1.TabIndex = 2;
            // 
            // algorithm
            // 
            this.algorithm.AutoSize = true;
            this.algorithm.ForeColor = System.Drawing.Color.Purple;
            this.algorithm.Location = new System.Drawing.Point(598, 6);
            this.algorithm.Name = "algorithm";
            this.algorithm.Size = new System.Drawing.Size(0, 13);
            this.algorithm.TabIndex = 11;
            // 
            // Info2
            // 
            this.Info2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Info2.Location = new System.Drawing.Point(273, 3);
            this.Info2.Multiline = true;
            this.Info2.Name = "Info2";
            this.Info2.Size = new System.Drawing.Size(177, 180);
            this.Info2.TabIndex = 10;
            this.Info2.TextChanged += new System.EventHandler(this.Info2_TextChanged);
            this.Info2.DoubleClick += new System.EventHandler(this.Info2_DoubleClick);
            // 
            // Info1
            // 
            this.Info1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Info1.Location = new System.Drawing.Point(45, 3);
            this.Info1.Multiline = true;
            this.Info1.Name = "Info1";
            this.Info1.Size = new System.Drawing.Size(177, 180);
            this.Info1.TabIndex = 9;
            this.Info1.TextChanged += new System.EventHandler(this.Info1_TextChanged);
            this.Info1.DoubleClick += new System.EventHandler(this.Info1_DoubleClick_1);
            // 
            // errorListlabel
            // 
            this.errorListlabel.AutoSize = true;
            this.errorListlabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorListlabel.ForeColor = System.Drawing.Color.Red;
            this.errorListlabel.Location = new System.Drawing.Point(565, 73);
            this.errorListlabel.Name = "errorListlabel";
            this.errorListlabel.Size = new System.Drawing.Size(145, 32);
            this.errorListlabel.TabIndex = 8;
            this.errorListlabel.Text = "**Debe ingresar una lista \r\nde Elementos a Ordenar";
            this.errorListlabel.Visible = false;
            // 
            // ArraySizeErrorLabel
            // 
            this.ArraySizeErrorLabel.AutoSize = true;
            this.ArraySizeErrorLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArraySizeErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ArraySizeErrorLabel.Location = new System.Drawing.Point(228, 45);
            this.ArraySizeErrorLabel.Name = "ArraySizeErrorLabel";
            this.ArraySizeErrorLabel.Size = new System.Drawing.Size(166, 16);
            this.ArraySizeErrorLabel.TabIndex = 7;
            this.ArraySizeErrorLabel.Text = "**Escoga Tamaño del Arreglo";
            this.ArraySizeErrorLabel.Visible = false;
            // 
            // arraySizeLbl
            // 
            this.arraySizeLbl.AutoSize = true;
            this.arraySizeLbl.Location = new System.Drawing.Point(78, 25);
            this.arraySizeLbl.Name = "arraySizeLbl";
            this.arraySizeLbl.Size = new System.Drawing.Size(54, 13);
            this.arraySizeLbl.TabIndex = 6;
            this.arraySizeLbl.Text = "Array Size";
            // 
            // arraySize
            // 
            this.arraySize.FormattingEnabled = true;
            this.arraySize.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.arraySize.Location = new System.Drawing.Point(81, 42);
            this.arraySize.Name = "arraySize";
            this.arraySize.Size = new System.Drawing.Size(121, 21);
            this.arraySize.TabIndex = 5;
            this.arraySize.SelectedIndexChanged += new System.EventHandler(this.arraySize_SelectedIndexChanged);
            // 
            // Solution
            // 
            this.Solution.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Solution.Location = new System.Drawing.Point(16, 203);
            this.Solution.Multiline = true;
            this.Solution.Name = "Solution";
            this.Solution.Size = new System.Drawing.Size(660, 120);
            this.Solution.TabIndex = 0;
            // 
            // Solve
            // 
            this.Solve.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Solve.Location = new System.Drawing.Point(486, 99);
            this.Solve.Name = "Solve";
            this.Solve.Size = new System.Drawing.Size(75, 23);
            this.Solve.TabIndex = 4;
            this.Solve.Text = "Solve";
            this.Solve.UseVisualStyleBackColor = true;
            this.Solve.Click += new System.EventHandler(this.Solve_Click);
            // 
            // listado
            // 
            this.listado.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listado.Location = new System.Drawing.Point(81, 73);
            this.listado.Name = "listado";
            this.listado.Size = new System.Drawing.Size(480, 21);
            this.listado.TabIndex = 3;
            // 
            // ListChoice
            // 
            this.ListChoice.AutoSize = true;
            this.ListChoice.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListChoice.Location = new System.Drawing.Point(17, 73);
            this.ListChoice.Name = "ListChoice";
            this.ListChoice.Size = new System.Drawing.Size(44, 20);
            this.ListChoice.TabIndex = 2;
            this.ListChoice.TabStop = true;
            this.ListChoice.Text = "List:";
            this.ListChoice.UseVisualStyleBackColor = true;
            this.ListChoice.CheckedChanged += new System.EventHandler(this.ListChoice_CheckedChanged);
            // 
            // RandomChoice
            // 
            this.RandomChoice.AutoSize = true;
            this.RandomChoice.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RandomChoice.Location = new System.Drawing.Point(17, 41);
            this.RandomChoice.Name = "RandomChoice";
            this.RandomChoice.Size = new System.Drawing.Size(73, 20);
            this.RandomChoice.TabIndex = 1;
            this.RandomChoice.TabStop = true;
            this.RandomChoice.Text = "Random";
            this.RandomChoice.UseVisualStyleBackColor = true;
            this.RandomChoice.CheckedChanged += new System.EventHandler(this.RandomChoice_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 189);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(688, 154);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Solution";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 384);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AlgorithmTreeView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView AlgorithmTreeView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Solution;
        private System.Windows.Forms.Button Solve;
        private System.Windows.Forms.TextBox listado;
        private System.Windows.Forms.RadioButton ListChoice;
        private System.Windows.Forms.RadioButton RandomChoice;
        private System.Windows.Forms.Label arraySizeLbl;
        private System.Windows.Forms.ComboBox arraySize;
        private System.Windows.Forms.Label ArraySizeErrorLabel;
        private System.Windows.Forms.Label errorListlabel;
        private System.Windows.Forms.TextBox Info2;
        private System.Windows.Forms.TextBox Info1;
        private System.Windows.Forms.Label algorithm;
    }
}

