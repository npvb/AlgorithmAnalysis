using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Analisis_de_Algoritmos.BL
{
    class LCS
    {
        string info1;
        string info2;
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

        public string lcsBack(string a, string b) 
        {
            string aSub = a.Substring(0, (a.Length - 1 < 0) ? 0 : a.Length - 1); string bSub = b.Substring(0, (b.Length - 1 < 0) ? 0 : b.Length - 1); if (a.Length == 0 || b.Length == 0) return ""; else if (a[a.Length - 1] == b[b.Length - 1]) return lcsBack(aSub, bSub) + a[a.Length - 1]; else { string x = lcsBack(a, bSub); string y = lcsBack(aSub, b); return (x.Length > y.Length) ? x : y; }

        }

     
    }
}
