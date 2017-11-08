using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Analizator_Lexical
{
    class Codificari
    {
        private List<string> numeAtom;
        private List<int> codAtom;

        public Codificari()
        {
            numeAtom = new List<string>();
            codAtom = new List<int>();

            using (FileStream stream = File.Open(@".\Codificari.dat", FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    string[] lines = reader.ReadToEnd().Split('\n');

                    foreach (string line in lines)
                    {
                        string line_;

                        if (line.Contains('\r'))
                            line_ = line.Remove(line.Length - 1);
                        else
                            line_ = line;

                        string[] words = line_.Split(' ');

                        if (words.Length == 2)
                        {
                            numeAtom.Add(words[0]);
                            codAtom.Add(Int32.Parse(words[1]));
                        }
                    }

                    reader.Close();
                }
                stream.Close();
            }
        }

        public bool isCuvantRezervat(string word)
        {
            foreach (string s in numeAtom)
                if (s == word)
                    return true;
            return false;
        }

        public int getCodAtom(string word)
        {
            for (int i = 0; i < numeAtom.Count(); i++)
                if (numeAtom[i] == word)
                    return codAtom[i];

            return -1;
        }

    }
}
