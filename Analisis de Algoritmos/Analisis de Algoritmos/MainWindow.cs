using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;


namespace Analisis_de_Algoritmos
{
    public partial class MainWindow : Form
    {
        BL.Sorts sort = new BL.Sorts();
        
        public MainWindow()
        {
            InitializeComponent();
            HideControls();
                    
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            
        }

        private void HideControls() 
        {
            arraySize.Visible = false;
            arraySizeLbl.Visible = false;
            Solve.Visible = false;
        }
        
        private void ShowSortControls()
        {
            RandomChoice.Visible = true;
            ListChoice.Visible = true;
            listado.Visible = true;
            Solve.Visible = true;
        }
        
        private void AlgorithmTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
           
            TreeNode node = AlgorithmTreeView.SelectedNode;
            if (node.Text.CompareTo("Quick Sort") == 1 || node.Text.CompareTo("Insertion Sort") == 1)
            {
                ShowSortControls();
            }
           //MessageBox.Show(string.Format("You selected: {0}", node.Text));
        }
        
        private void RandomChoice_CheckedChanged(object sender, EventArgs e)
        {
            arraySize.Visible = true;
            arraySizeLbl.Visible = true;          
            
        }
        
        private void Solve_Click(object sender, EventArgs e)
        {
            if (arraySize.SelectedItem == null )
            {
                ArraySizeErrorLabel.Visible = true;
            }
            else
            {
                Stopwatch sw = new Stopwatch();

                sw.Start();
                sort.InsertionSort();
                sw.Stop();

                for (int x = 0; x < sort.SortingArray.Count(); x++)
                {
                    Solution.AppendText(sort.SortingArray.ElementAt(x).ToString() + " ");
                }
                Solution.AppendText("\n");
                Solution.AppendText("Time Elapsed: " + sw.Elapsed);
                Solution.AppendText("\n");
            }
        }
        
        private void ListChoice_CheckedChanged(object sender, EventArgs e)
        {
            arraySize.Visible = false;
            arraySizeLbl.Visible = false;
        }

        private void arraySize_SelectedIndexChanged(object sender, EventArgs e)
        {
            Random random = new Random();
            listado.Text = " ";
            sort.SortingArray.Clear();

            if (arraySize.Text == " ")
            {
                ArraySizeErrorLabel.Visible = true;
            }
            else 
            {
                ArraySizeErrorLabel.Visible = false;
                sort.ArraySize = Convert.ToInt32(arraySize.SelectedItem); 

                for (int x = 0; x < sort.ArraySize; x++)
                {
                    sort.SortingArray.Add(random.Next(1,sort.ArraySize));
                }

                for (int x = 0; x < sort.SortingArray.Count(); x++)
                {
                    listado.AppendText(sort.SortingArray.ElementAt(x).ToString() + " ");
                }
            }

        }

       
    }
}
