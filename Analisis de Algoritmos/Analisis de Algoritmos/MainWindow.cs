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
        string nodoArbol = "";
        
        public MainWindow()
        {
            InitializeComponent();
            HideControls();
                    
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            HideControls();
        }

        private void HideControls() 
        {
            arraySize.Visible = false;
            arraySizeLbl.Visible = false;
            Solve.Visible = false;
            RandomChoice.Visible = false;
            ListChoice.Visible = false;
            listado.Visible = false;
            errorListlabel.Visible = false;
            ArraySizeErrorLabel.Visible = false;
        }

        private void HideSortControls()
        {
            arraySize.Visible = false;
            arraySizeLbl.Visible = false;
            Solve.Visible = false;
            RandomChoice.Visible = false;
            ListChoice.Visible = false;
            listado.Visible = false;
            errorListlabel.Visible = false;
            ArraySizeErrorLabel.Visible = false;
        }
        
        private void ShowSortControls()
        {
            Solve.Visible = true;
            RandomChoice.Visible = true;
            ListChoice.Visible = true;
            listado.Visible = true;
        }
        
        private void AlgorithmTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode node = AlgorithmTreeView.SelectedNode; ;
            nodoArbol = node.Text.ToString();
            if (nodoArbol.CompareTo("Sorts") == 0)
            {
                ShowSortControls();
                Solve.Enabled = false;
                listado.Enabled = false;
                
            }else if(nodoArbol.CompareTo("InsertionSort") == 0 || nodoArbol.CompareTo("QuickSort") == 0)
            {
                ShowSortControls();
                Solve.Enabled = true;
                listado.Enabled = true;
            }
            else
                HideSortControls();
           
        }
        
        private void RandomChoice_CheckedChanged(object sender, EventArgs e)
        {
            arraySize.Visible = true;
            arraySizeLbl.Visible = true;
            listado.Enabled = false;
            
        }
        
        private void Solve_Click(object sender, EventArgs e)
        {
            try
            {
                Solution.Text = " ";
                if (RandomChoice.Checked && nodoArbol.CompareTo("InsertionSort") == 0)
                {
                    Evaluate(1);
                }
                else if (ListChoice.Checked && nodoArbol.CompareTo("InsertionSort") == 0)
                {
                    Evaluate(2);
                }
                else
                    MessageBox.Show("NADA");
            }
            catch (Exception exc) 
            {
                Solution.Text=exc.ToString();
            }
        }
        
        private void ListChoice_CheckedChanged(object sender, EventArgs e)
        {
            arraySize.Visible = false;
            arraySizeLbl.Visible = false;
            listado.Text = "";
            Solution.Text = "";
            listado.Enabled = true;
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

        private void Evaluate(int choice) 
        {
            try
            {
                Stopwatch sw = new Stopwatch();
                Stopwatch lw = new Stopwatch();

                if (choice == 1)
                {
                    if (arraySize.SelectedItem == null)
                    {
                        ArraySizeErrorLabel.Visible = true;
                    }
                    else
                    {
                        sw.Start();
                        sort.InsertionSort();
                        sw.Stop();

                    }
                }
                else
                {
                    arraySize.Visible = false;
                    ArraySizeErrorLabel.Visible = false;
                    arraySizeLbl.Visible = false;

                    if (listado.Text == "")
                    {
                        errorListlabel.Visible = true;
                    }
                    else
                    {
                        string[] cadena = listado.Text.ToString().Split(' ');
                        sort.SortingArray.Clear();
                        for (int x = 0; x < cadena.Length; x++) 
                        {
                            sort.SortingArray.Add(Convert.ToInt32(cadena[x]));
                        }
                        /*foreach (char c in cadena) 
                        {
                           if (char.IsLetterOrDigit(c)) 
                           {
                              sort.SortingArray.Add(Convert.ToInt32(c.ToString()));
                           }
                         }*/
  
                        sw.Start();
                        sort.InsertionSort();
                        sw.Stop();
                    }
                }

                for (int x = 0; x < sort.SortingArray.Count(); x++)
                {
                    string cad = sort.SortingArray.ElementAt(x).ToString();
                    Solution.AppendText(cad+ " ");
                }

                lw.Start();
                sort.SortingArray.Sort();
                lw.Stop();

                Solution.AppendText("\n");
                Solution.AppendText("Time Elapsed with Algorithm: " + sw.Elapsed);
                Solution.AppendText("\n");
                Solution.AppendText("Time Elapsed with List Sort: " + lw.Elapsed);
                Solution.AppendText("\n");


            }catch (Exception er) 
            {
                Solution.Text = er.ToString();
            }
        }
       
    }
}
