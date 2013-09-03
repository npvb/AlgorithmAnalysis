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

        public  List<IComparable> Sort (List<IComparable> list)
        {
            List<IComparable> left = new List<IComparable>();
            List<IComparable> right = new List<IComparable>();
            if (list.Count <= 1)
            {
                return list;
            }
            else
            {
                left = list.GetRange(0, list.Count / 2);
                right = list.GetRange(left.Count, list.Count - left.Count);
            }

            return MergeSort(Sort(left), Sort(right)); 
        }
        public List<IComparable> MergeSort(List<IComparable> left, List<IComparable> right)
        {
            List<IComparable> result = new List<IComparable>(); 
            while (left.Count > 0 && right.Count > 0) 
            { 
                if (left[0].CompareTo(right[0]) <= 0) 
                {
                    result.Add(left[0]); left.RemoveAt(0); 
                }
                else {
                    result.Add(right[0]);
                    right.RemoveAt(0); 
                } 
            } 
            result.AddRange(left); 
            result.AddRange(right); 
            return result;
        }

        public Stopwatch Evaluate(int choice, string [] cadena)
        {
                Stopwatch sw = new Stopwatch();
                List<IComparable> temp = new List<IComparable>();
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

                    case 5:
                           SortingArray.Clear();
                            for (int x = 0; x < cadena.Length; x++)
                            {
                                SortingArray.Add(cadena[x]);
                            }
                            sw.Start();
                            sortingArray = Sort(sortingArray);
                            sw.Stop();break;
                        
                    case 6:
                            sw.Start();
                            sortingArray = Sort(sortingArray);
                            sw.Stop();
                            break;                                           

                }
                     return sw;

            }
           
        }


    }

