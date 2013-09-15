﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;


namespace Analisis_de_Algoritmos
{
    public partial class MainWindow : Form
    {
        BL.Sorts sort = new BL.Sorts();
        BL.LCS lcs = new BL.LCS();
        string nodoArbol = "";
        List<IComparable> copySortArray = new List<IComparable>();
        
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
            Info1.Visible = false;
            Info2.Visible = false;
        }

        private void HideSortControls()
        {
            arraySize.Visible = false;
            arraySizeLbl.Visible = false;
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

        private void ShowLCSControls()
        {
            Info1.Visible = true;
            Info2.Visible = true;
            Solve.Visible = true;
        }

        private void HideLCSControls()
        {
            Info1.Visible = false;
            Info2.Visible = false;
            Solve.Visible = false;
        }

        private void ShowSortInfo() 
        {
            ShowSortControls();
            HideLCSControls();
            Solve.Enabled = true;
            Solve.Visible = true;
            listado.Enabled = true;
            listado.Clear();
            Solution.Clear();
        }

        private void AlgorithmTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode node = AlgorithmTreeView.SelectedNode; ;
            nodoArbol = node.Text.ToString();
            algorithm.Text = nodoArbol;

            if (nodoArbol.CompareTo("Sorts") == 0)
            {
                HideControls();
                /*ShowSortControls();
                listado.Clear();
                Solution.Clear();
                Solve.Enabled = false;
                listado.Enabled = false;*/
                
            }else if(nodoArbol.CompareTo("InsertionSort") == 0)
            {
                ShowSortInfo();
                algoInformation.Text = "Es una manera muy natural de ordenar para un ser humano, y puede usarse fácilmente para ordenar un mazo de cartas numeradas en forma arbitraria. Requiere O(n²) operaciones para ordenar una lista de n elementos.";
                pseudoInformation.Text = "para i=1 hasta n-1 \n minimo = i; \n para j=i+1 hasta n \n  si lista[j] < lista[minimo] entonces \n  minimo = j \n fin si \n fin para \nintercambiar(lista[i], lista[minimo])";

            }else if(nodoArbol.CompareTo("QuickSort") == 0)
            {
                ShowSortInfo();
                algoInformation.Text = "Quicksort es un algoritmo de ordenación, es una mejora sustancial del método de intercambio directo y recibe el nombre de Quick Sort por la velocidad con que ordena los elementos del arreglo Este método se basa en la táctica “divide y vencerás”: consiste en dividir un problema en subproblemas y luego juntar las respuestas de estos subproblemas para obtener la solución al problema central (subdividiendo el array en arrays mas pequeños y ordenar estos).Es considerado entre los mas rápidos y eficientes de los métodos de ordenación interna.";
            }
            else if (nodoArbol.CompareTo("MergeSort") == 0) 
            {
                ShowSortInfo();
                algoInformation.Text ="Consiste en dividir en dos partes iguales el vector a ordenar, ordenar por separado cada una de las partes, y luego mezclar ambas partes, manteniendo el orden, en un solo vector ordenado. El algoritmo MergeSort (u Ordenamiento por mezcla) es un algoritmo que sirve para ordenar secuencias de datos.";
            }
            else if (nodoArbol.CompareTo("LCS") == 0)
            {
                HideSortControls();
                ShowLCSControls();
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
                Stopwatch sw = new Stopwatch();
                Stopwatch lw = new Stopwatch();
                bool showComparison = false;
                String[] cadena = listado.Text.ToString().Split(' ', ',');

                Solution.Text = " ";
                if (RandomChoice.Checked && nodoArbol.CompareTo("InsertionSort") == 0)
                {
                    sw = sort.Evaluate(1, cadena);
                    showComparison = true;
                }
                else if (ListChoice.Checked && nodoArbol.CompareTo("InsertionSort") == 0)
                {
                   sw = sort.Evaluate(2,cadena);
                   foreach (String c in cadena)
                   {
                       copySortArray.Add(c);
                   }
                   showComparison = true;
                }
                else if (RandomChoice.Checked && nodoArbol.CompareTo("QuickSort") == 0)
                {
                    sw = sort.Evaluate(3,cadena);
                    showComparison = true;
                }
                else if (ListChoice.Checked && nodoArbol.CompareTo("QuickSort") == 0)
                {
                    sw = sort.Evaluate(4,cadena);
                    foreach (String c in cadena)
                    {
                        copySortArray.Add(c);
                    }

                    showComparison = true;

                }
                else if (ListChoice.Checked && nodoArbol.CompareTo("MergeSort") == 0)
                {
                    sw = sort.Evaluate(5, cadena);
                    foreach (String c in cadena)
                    {
                        copySortArray.Add(c);
                    }

                    showComparison = true;

                }
                else if (RandomChoice.Checked && nodoArbol.CompareTo("MergeSort") == 0)
                {
                    sw = sort.Evaluate(6, cadena);
                    showComparison = true;

                }
                else if (nodoArbol.CompareTo("LCS") == 0) 
                {

                    String[] cadena1 = Info1.Text.ToString().Split('\r', '\n', ' ');
                    String[] cadena2 = Info2.Text.ToString().Split('\r', '\n', ' ');
                    lcs.Info2 = "";
                    lcs.Info1 = "";
                    StringBuilder builder = new StringBuilder();
                    StringBuilder builder1 = new StringBuilder();
                    
                    foreach (string value in cadena1)
                    {
                        builder.Append(value);
                    }
                    //builder.Clear();
                    foreach (string value in cadena2)
                    {
                        builder1.Append(value);
                    }

                    lcs.Info1 = builder.ToString().ToLower();
                    lcs.Info2 = builder1.ToString().ToLower();

                    Solution.Text = lcs.lcsBack(lcs.Info1, lcs.Info2);
                    
                }
                else
                    MessageBox.Show("Escoga una Algoritmo a Evaluar");

                if (nodoArbol.CompareTo("QuickSort") == 0 || nodoArbol.CompareTo("InsertionSort") == 0 || nodoArbol.CompareTo("MergeSort") == 0)
                {
                    for (int x = 0; x < sort.SortingArray.Count(); x++)
                    {
                        string cad = sort.SortingArray.ElementAt(x).ToString();
                        Solution.AppendText(cad + " ");
                    }

                    Solution.AppendText("\n");
                    Solution.AppendText("Time Elapsed with Algorithm: " + sw.Elapsed);
                    Solution.AppendText("\n");

                }

                if (showComparison)
                {
                    lw.Start();
                    copySortArray.Sort();
                    lw.Stop();
                    Solution.AppendText("Time Elapsed List Own Sort: " + lw.Elapsed);
                }
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
                    IComparable randomNumber = random.Next(1, sort.ArraySize);
                    sort.SortingArray.Add(randomNumber);
                    copySortArray.Add(randomNumber);
                }

                for (int x = 0; x < sort.SortingArray.Count(); x++)
                {
                    listado.AppendText(sort.SortingArray.ElementAt(x).ToString() + " ");
                }
            }

        }

        private void Info1_DoubleClick_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            DialogResult result = openFileDialog1.ShowDialog(); 
            if (result == DialogResult.OK)
            {
                string file = openFileDialog1.FileName;
                string texto = File.ReadAllText(file);
                Info1.Text = texto;
                
            }
        }

        private void Info2_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = openFileDialog1.FileName;
                string texto = File.ReadAllText(file);
                Info2.Text = texto;

            }
        }

        private void Info1_Click(object sender, EventArgs e)
        {
            /*lcs.Info1 = null;
            lcs.Info2 = null;*/
        }

    

       
    }
}
