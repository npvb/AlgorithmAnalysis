using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Analisis_de_Algoritmos.BL
{
    class Sorts
    {
        public Sorts() 
        {
            
        }

        private int size = 1;
        List<int> sortingArray = new List<int>();

        public List<int> SortingArray   
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
                int value = sortingArray[i];
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

        public void Quicksort(IComparable[] elements, int left, int right)
         {
              int i = left, j = right;
              IComparable pivot = elements[(left + right) / 2];

              while (i <= j)
              {
                  while (elements[i].CompareTo(pivot) < 0)
                  {
                      i++;
                  }

                  while (elements[j].CompareTo(pivot) > 0)
                  {
                      j--;
                  }

                  if (i <= j)
                  {
                      // Swap
                      IComparable tmp = elements[i];
                      elements[i] = elements[j];
                      elements[j] = tmp;

                      i++;
                      j--;
                  }
              }

              // Recursive calls
              if (left < j)
              {
                  Quicksort(elements, left, j);
              }

              if (i < right)
              {
                  Quicksort(elements, i, right);
              }
        }



    }
}
