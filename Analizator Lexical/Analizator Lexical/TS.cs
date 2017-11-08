using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Analizator_Lexical
{
    class TS
    {
        private List<string> numeAtomi;
        private List<int> adresaAtomi;

        public TS()
        {
            numeAtomi = new List<string>();
            adresaAtomi = new List<int>();
        }

        public List<string> getTS1
        {
            get { return numeAtomi; }
        }

        public List<int> getTS2
        {
            get { return adresaAtomi; }
        }

        public int lungimeTS
        {
            get { return numeAtomi.Count(); }
        }

        public void addAtom(string numeAtom)
        {
            numeAtomi.Add(numeAtom);
            adresaAtomi.Add(adresaAtomi.Count()+1);
        }

        public bool isSymbol(string word)
        {
            foreach (string s in numeAtomi)
                if (s == word)
                    return true;

            return false;
        }

        public int getAdresaAtom(string atom)
        {
            for (int i = 0; i < numeAtomi.Count(); i++)
                if (numeAtomi[i] == atom)
                    return adresaAtomi[i];
            return -1;
        }
    }
}
