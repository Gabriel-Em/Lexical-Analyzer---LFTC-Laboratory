using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Analizator_Lexical
{
    class FIP
    {
        private List<int> coduriAtomi;
        private List<int> adreseTS;

        public FIP()
        {
            coduriAtomi = new List<int>();
            adreseTS = new List<int>();
        }

        public List<int> getFIP1
        {
            get { return coduriAtomi; }
        }
        public List<int> getFIP2
        {
            get { return adreseTS; }
        }
        public int lungimeFIP
        {
            get { return coduriAtomi.Count(); }
        }

        public void addAtom(int codAtom_, int adresaTS_)
        {
            coduriAtomi.Add(codAtom_);
            adreseTS.Add(adresaTS_);
        }

        public int getCodAtom(int index)
        {
            return coduriAtomi[index];
        }

        public int getaAdresaTS(int index)
        {
            return adreseTS[index];
        }

        
    }
}
