using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Analisis_de_Algoritmos.BL
{
    class LCS
    {
        enum Arrows { none, up, upleft, left };
        string info1;
        string info2;
        string lcs="";
        int[,] b;
        

        public string Info1
        {
            get
            {
                return info1;
            }
            set
            {
                info1 = value;
            }
        }

        public string Info2
        {
            get
            {
                return info2;
            }
            set
            {
                info2 = value;
            }
        }

        public string lcsBack(string str1, string str2) 
        {
            int m = str1.Length;
            int n = str2.Length;

            int[,] c = new int[m, m];
            b = new int[m, m];

            //int [][] b = new int[m];

            for (int i = 1; i < m; i++)
            {
                c[i,0] = 0;
            }
            for (int j = 0; j < n; j++)
            {
                c[0, j] = 0;
            }

            for (int i = 1; i < m; i++) 
            {
                for (int j = 1; j < n; j++) 
                {
                    if(str1.ElementAt(i).CompareTo(str2.ElementAt(j)) == 0)
                    {
                        c[i, j] = c[i - 1, j - 1] + 1;
                        b[i,j] = (int)Arrows.upleft;

                    }else if (c[i - 1,j] >= c[i,j - 1])
                    {
                        c[i,j] = c[i - 1,j];
                        b[i, j] = (int)Arrows.up;
                    }else
                    {
                        c[i,j] = c[i,j - 1];
                        b[i, j] = (int)Arrows.left;
                    }
                }
            }
            lcs = "";
            PrintLCS(str1, m - 1, n - 1);
            return lcs;
            /*string aSub = a.Substring(0, (a.Length - 1 < 0) ? 0 : a.Length - 1);
            string bSub = b.Substring(0, (b.Length - 1 < 0) ? 0 : b.Length - 1);

            if (a.Length == 0 || b.Length == 0)
                return "";
            else if (a[a.Length - 1] == b[b.Length - 1])
                return lcsBack(aSub, bSub) + a[a.Length - 1];
            else
            {
                string x = lcsBack(a, bSub);
                string y = lcsBack(aSub, b);
                return (x.Length > y.Length) ? x : y;
            }*/

        }

        private void PrintLCS(string str1, int i, int j)
        {
            if (i == 0 || j == 0)
                return;

            if (b[i,j] == (int)Arrows.upleft)
            {
                PrintLCS(str1, i - 1, j - 1);
                lcs += str1.ElementAt(i);
            }
            else if (b[i, j] == (int)Arrows.up)
            {
                PrintLCS(str1, i - 1, j);
            }
            else
            {
                PrintLCS(str1, i, j - 1);
            }
        }
     
    }
}
