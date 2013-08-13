using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Analisis_de_Algoritmos
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void AlgorithmTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // Get the selected node.
            //
            TreeNode node = AlgorithmTreeView.SelectedNode;
            //
            // Render message box.
            //
            MessageBox.Show(string.Format("You selected: {0}", node.Text));
        }

       
    }
}
