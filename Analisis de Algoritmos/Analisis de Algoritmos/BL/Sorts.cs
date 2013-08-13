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

      public String[] InsertionSort(String[] objetoComparar) 
        {
            int i, j;

            for (i = 1; i < objetoComparar.Length; i++)
            {
                String value = objetoComparar[i];
                j = i - 1;
                while ((j >= 0) && (objetoComparar[j].CompareTo(value) > 0))
                {
                    objetoComparar[j + 1] = objetoComparar[j];
                    j--;
                }
                objetoComparar[j + 1] = value;
            }
            return objetoComparar;
        }

      public static void Quicksort(IComparable[] elements, int left, int right)
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
