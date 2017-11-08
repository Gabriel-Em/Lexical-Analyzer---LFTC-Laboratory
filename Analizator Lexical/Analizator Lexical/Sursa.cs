using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Analizator_Lexical
{
    class Sursa
    {
        private List<string> sursa;
        private int nrLinii;

        public Sursa(string sursa_)
        {
            sursa = new List<string>();

            string[] lines = sursa_.Split('\n');
            foreach (string s in lines)
                sursa.Add(s);

            nrLinii = lines.Length;
        }

        public int NrLinii
        {
            get { return nrLinii; }
        }

        public string this[int index]
        {
            get { return sursa[index]; }
        }
    }
}
