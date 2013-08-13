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
            this.AlgorithmTreeView = new System.Windows.Forms.TreeView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Solution = new System.Windows.Forms.TextBox();
            this.RandomChoice = new System.Windows.Forms.RadioButton();
            this.ListChoice = new System.Windows.Forms.RadioButton();
            this.listado = new System.Windows.Forms.TextBox();
            this.Solve = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AlgorithmTreeView
            // 
            this.AlgorithmTreeView.Location = new System.Drawing.Point(1, 29);
            this.AlgorithmTreeView.Name = "AlgorithmTreeView";
            treeNode1.Name = "InsertionSort";
            treeNode1.Text = "InsertionSort";
            treeNode2.Name = "QuickSort";
            treeNode2.Text = "QuickSort";
            treeNode3.Name = "Sorts";
            treeNode3.Text = "Sorts";
            this.AlgorithmTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.AlgorithmTreeView.Size = new System.Drawing.Size(136, 414);
            this.AlgorithmTreeView.TabIndex = 0;
            this.AlgorithmTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.AlgorithmTreeView_AfterSelect);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(883, 24);
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
            this.panel1.Controls.Add(this.Solve);
            this.panel1.Controls.Add(this.listado);
            this.panel1.Controls.Add(this.ListChoice);
            this.panel1.Controls.Add(this.RandomChoice);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(144, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(727, 414);
            this.panel1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Solution);
            this.groupBox1.Location = new System.Drawing.Point(4, 270);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(720, 144);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Solution";
            // 
            // Solution
            // 
            this.Solution.Location = new System.Drawing.Point(13, 19);
            this.Solution.Multiline = true;
            this.Solution.Name = "Solution";
            this.Solution.Size = new System.Drawing.Size(686, 107);
            this.Solution.TabIndex = 0;
            // 
            // RandomChoice
            // 
            this.RandomChoice.AutoSize = true;
            this.RandomChoice.Location = new System.Drawing.Point(17, 41);
            this.RandomChoice.Name = "RandomChoice";
            this.RandomChoice.Size = new System.Drawing.Size(65, 17);
            this.RandomChoice.TabIndex = 1;
            this.RandomChoice.TabStop = true;
            this.RandomChoice.Text = "Random";
            this.RandomChoice.UseVisualStyleBackColor = true;
            // 
            // ListChoice
            // 
            this.ListChoice.AutoSize = true;
            this.ListChoice.Location = new System.Drawing.Point(17, 73);
            this.ListChoice.Name = "ListChoice";
            this.ListChoice.Size = new System.Drawing.Size(44, 17);
            this.ListChoice.TabIndex = 2;
            this.ListChoice.TabStop = true;
            this.ListChoice.Text = "List:";
            this.ListChoice.UseVisualStyleBackColor = true;
            // 
            // listado
            // 
            this.listado.Location = new System.Drawing.Point(81, 73);
            this.listado.Name = "listado";
            this.listado.Size = new System.Drawing.Size(201, 20);
            this.listado.TabIndex = 3;
            // 
            // Solve
            // 
            this.Solve.Location = new System.Drawing.Point(207, 100);
            this.Solve.Name = "Solve";
            this.Solve.Size = new System.Drawing.Size(75, 23);
            this.Solve.TabIndex = 4;
            this.Solve.Text = "Solve";
            this.Solve.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 449);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
    }
}

