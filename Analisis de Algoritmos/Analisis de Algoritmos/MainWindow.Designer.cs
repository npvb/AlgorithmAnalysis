﻿namespace Analisis_de_Algoritmos
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
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("MergeSort");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Sorts", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("LCS");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Potencia");
            this.AlgorithmTreeView = new System.Windows.Forms.TreeView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.infoLCS = new System.Windows.Forms.Label();
            this.formatoLista = new System.Windows.Forms.Label();
            this.PowPotErrorLabel = new System.Windows.Forms.Label();
            this.PowNumErrorLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.potenciaTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numerotxt = new System.Windows.Forms.TextBox();
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
            this.algorithm = new System.Windows.Forms.Label();
            this.algoInformation = new System.Windows.Forms.TextBox();
            this.pseudoInformation = new System.Windows.Forms.TextBox();
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
            treeNode3.Name = "MergeSort";
            treeNode3.Text = "MergeSort";
            treeNode4.Name = "Sorts";
            treeNode4.Text = "Sorts";
            treeNode5.Name = "LCS";
            treeNode5.Text = "LCS";
            treeNode6.Name = "Potencia";
            treeNode6.Text = "Potencia";
            this.AlgorithmTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5,
            treeNode6});
            this.AlgorithmTreeView.Size = new System.Drawing.Size(136, 374);
            this.AlgorithmTreeView.TabIndex = 0;
            this.AlgorithmTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.AlgorithmTreeView_AfterSelect);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1105, 24);
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
            this.panel1.Controls.Add(this.infoLCS);
            this.panel1.Controls.Add(this.formatoLista);
            this.panel1.Controls.Add(this.PowPotErrorLabel);
            this.panel1.Controls.Add(this.PowNumErrorLabel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.potenciaTxt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.numerotxt);
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
            this.panel1.Size = new System.Drawing.Size(720, 374);
            this.panel1.TabIndex = 2;
            // 
            // infoLCS
            // 
            this.infoLCS.AutoSize = true;
            this.infoLCS.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLCS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.infoLCS.Location = new System.Drawing.Point(62, 195);
            this.infoLCS.Name = "infoLCS";
            this.infoLCS.Size = new System.Drawing.Size(186, 15);
            this.infoLCS.TabIndex = 17;
            this.infoLCS.Text = "**Doble Clic para leer un archivo";
            // 
            // formatoLista
            // 
            this.formatoLista.AutoSize = true;
            this.formatoLista.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formatoLista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.formatoLista.Location = new System.Drawing.Point(81, 102);
            this.formatoLista.Name = "formatoLista";
            this.formatoLista.Size = new System.Drawing.Size(271, 15);
            this.formatoLista.TabIndex = 18;
            this.formatoLista.Text = "**Ingrese los valores seguidos con [ , ] Ej: 3,4,5,6,2";
            // 
            // PowPotErrorLabel
            // 
            this.PowPotErrorLabel.AutoSize = true;
            this.PowPotErrorLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PowPotErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.PowPotErrorLabel.Location = new System.Drawing.Point(492, 78);
            this.PowPotErrorLabel.Name = "PowPotErrorLabel";
            this.PowPotErrorLabel.Size = new System.Drawing.Size(160, 16);
            this.PowPotErrorLabel.TabIndex = 16;
            this.PowPotErrorLabel.Text = "**Debe ingresar la potencia";
            this.PowPotErrorLabel.Visible = false;
            // 
            // PowNumErrorLabel
            // 
            this.PowNumErrorLabel.AutoSize = true;
            this.PowNumErrorLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PowNumErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.PowNumErrorLabel.Location = new System.Drawing.Point(492, 54);
            this.PowNumErrorLabel.Name = "PowNumErrorLabel";
            this.PowNumErrorLabel.Size = new System.Drawing.Size(156, 16);
            this.PowNumErrorLabel.TabIndex = 15;
            this.PowNumErrorLabel.Text = "**Debe ingresar un Numero";
            this.PowNumErrorLabel.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Potencia";
            // 
            // potenciaTxt
            // 
            this.potenciaTxt.Location = new System.Drawing.Point(81, 78);
            this.potenciaTxt.Name = "potenciaTxt";
            this.potenciaTxt.Size = new System.Drawing.Size(405, 20);
            this.potenciaTxt.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Número";
            // 
            // numerotxt
            // 
            this.numerotxt.Location = new System.Drawing.Point(81, 51);
            this.numerotxt.Name = "numerotxt";
            this.numerotxt.Size = new System.Drawing.Size(405, 20);
            this.numerotxt.TabIndex = 11;
            // 
            // Info2
            // 
            this.Info2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Info2.Location = new System.Drawing.Point(71, 15);
            this.Info2.Multiline = true;
            this.Info2.Name = "Info2";
            this.Info2.Size = new System.Drawing.Size(177, 180);
            this.Info2.TabIndex = 10;
            this.Info2.DoubleClick += new System.EventHandler(this.Info2_DoubleClick);
            // 
            // Info1
            // 
            this.Info1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Info1.Location = new System.Drawing.Point(294, 15);
            this.Info1.Multiline = true;
            this.Info1.Name = "Info1";
            this.Info1.Size = new System.Drawing.Size(177, 180);
            this.Info1.TabIndex = 9;
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
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55",
            "60",
            "65",
            "70",
            "75",
            "80",
            "85",
            "90",
            "95",
            "100",
            "500",
            "1000"});
            this.arraySize.Location = new System.Drawing.Point(81, 42);
            this.arraySize.Name = "arraySize";
            this.arraySize.Size = new System.Drawing.Size(121, 21);
            this.arraySize.TabIndex = 5;
            this.arraySize.SelectedIndexChanged += new System.EventHandler(this.arraySize_SelectedIndexChanged);
            // 
            // Solution
            // 
            this.Solution.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Solution.Location = new System.Drawing.Point(16, 220);
            this.Solution.Multiline = true;
            this.Solution.Name = "Solution";
            this.Solution.Size = new System.Drawing.Size(660, 140);
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
            this.ListChoice.Location = new System.Drawing.Point(13, 73);
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
            this.RandomChoice.Location = new System.Drawing.Point(11, 41);
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
            this.groupBox1.Location = new System.Drawing.Point(3, 201);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(688, 170);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Solution";
            // 
            // algorithm
            // 
            this.algorithm.AutoSize = true;
            this.algorithm.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.algorithm.ForeColor = System.Drawing.Color.Purple;
            this.algorithm.Location = new System.Drawing.Point(879, 32);
            this.algorithm.Name = "algorithm";
            this.algorithm.Size = new System.Drawing.Size(0, 19);
            this.algorithm.TabIndex = 11;
            // 
            // algoInformation
            // 
            this.algoInformation.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.algoInformation.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.algoInformation.Location = new System.Drawing.Point(883, 74);
            this.algoInformation.Multiline = true;
            this.algoInformation.Name = "algoInformation";
            this.algoInformation.ReadOnly = true;
            this.algoInformation.Size = new System.Drawing.Size(210, 165);
            this.algoInformation.TabIndex = 14;
            // 
            // pseudoInformation
            // 
            this.pseudoInformation.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pseudoInformation.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pseudoInformation.Location = new System.Drawing.Point(883, 245);
            this.pseudoInformation.Multiline = true;
            this.pseudoInformation.Name = "pseudoInformation";
            this.pseudoInformation.ReadOnly = true;
            this.pseudoInformation.Size = new System.Drawing.Size(210, 158);
            this.pseudoInformation.TabIndex = 15;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 413);
            this.Controls.Add(this.pseudoInformation);
            this.Controls.Add(this.algoInformation);
            this.Controls.Add(this.algorithm);
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
        private System.Windows.Forms.TextBox algoInformation;
        private System.Windows.Forms.TextBox pseudoInformation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox potenciaTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numerotxt;
        private System.Windows.Forms.Label PowPotErrorLabel;
        private System.Windows.Forms.Label PowNumErrorLabel;
        private System.Windows.Forms.Label infoLCS;
        private System.Windows.Forms.Label formatoLista;
    }
}

