using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Analisis_de_Algoritmos.BL
{
    class Sorts
    {
        public Sorts() 
        {
            
        }

        private int size = 1;
        List<IComparable> sortingArray = new List<IComparable>();

        public List<IComparable> SortingArray   
        {
            get
            {
                return sortingArray;
            }
            set 
            {
                sortingArray = value;
            }
        }

        public int ArraySize
        {
            get
            {
                return size;
            }
            set
            {
                size= value;
            }
        }

        public void InsertionSort() 
        {
            int i, j;

            for (i = 1; i < sortingArray.Count(); i++)
            {
                IComparable value = sortingArray[i];
                j = i - 1;
                while ((j >= 0) && (sortingArray[j].CompareTo(value) > 0))
                {
                    sortingArray[j + 1] = sortingArray[j];
                    j--;
                }
                sortingArray[j + 1] = value;
            }
            ///return sortingArray;
        }

        public void QuickSort(List<IComparable> a, int left, int right)
        {
            int i = left;
            int j = right;
            IComparable leftString = a[i];
            IComparable rightString = a[j];
            double pivotValue = ((left + right) / 2);
            IComparable middle = a[Convert.ToInt32(pivotValue)];
            IComparable temp = null;

             while (i <= j)
             {
                 while(a[i].CompareTo(middle) < 0)
                 {
                     i++;
                     leftString = a[i];               
                 }
             while(a[j].CompareTo(middle) > 0)        
             {               
                 j--;           
                 rightString = a[j];       
             }
                 if (i <= j)        
                 {                  
                    temp = a[i];      
                    a[i++] = a[j];      
                    a[j--] = temp;        
                 }
             } 
            if (left < j) 
            { 
                QuickSort(a, left, j); 
            } 
            if (i < right) 
            { 
                QuickSort(a, i, right);
            }

        }

        public Stopwatch Evaluate(int choice, string [] cadena)
        {
                Stopwatch sw = new Stopwatch();

                switch (choice)
                {
                    case 1:
                            sw.Start();
                            InsertionSort();
                            sw.Stop();break;

                    case 2:
                      
                            SortingArray.Clear();
                            for (int x = 0; x < cadena.Length; x++)
                            {
                                SortingArray.Add(cadena[x]);
                            }
                            sw.Start();
                            InsertionSort();
                            sw.Stop(); break;

                    case 3:
                            sw.Start();
                            QuickSort(SortingArray, 0, SortingArray.Count() - 1);
                            sw.Stop();break;

                    case 4:
                            
                           SortingArray.Clear();
                            for (int x = 0; x < cadena.Length; x++)
                            {
                                SortingArray.Add(cadena[x]);
                            }
                            sw.Start();
                            QuickSort(SortingArray, 0, SortingArray.Count() - 1);
                            sw.Stop();break;

                }
                     return sw;

            }
           
        }


    }

