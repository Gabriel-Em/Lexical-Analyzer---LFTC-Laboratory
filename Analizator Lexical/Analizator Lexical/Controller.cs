using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Analizator_Lexical
{
    class Controller
    {
        private Sursa sursa;
        private Codificari codif;
        private FIP fip;
        private TS ts;
        private bool decl;
        private List<string> errList;

        public Controller()
        {
        }

        public void setSursa(string text)
        {
            sursa = new Sursa(text);
            codif = new Codificari();
        }

        public void ctrlStartAnaliza()
        {
            fip = new FIP();
            ts = new TS();
            errList = new List<string>();

            decl = false; // nu suntem in interiorul unei declarari
            string word = string.Empty;

            for (int i = 0; i < sursa.NrLinii; i++)   // verificam fiecare linie din sursa
            {
                string line = getRidOfRT(sursa[i]);
                
                int currentChar = 123, prevChar;  // 0 = litera, 1 = cifra, 2 = simbol, -1 = spatiu, 7 = punct

                word = string.Empty; // un cuvant se formeaza la intalnirea a 2 caractere succesive de tip diferit

                for (int j = 0; j < line.Length; j++) // verificam cate 2 caractere de pe linie deodata
                {
                    if(line.Length >0)  // daca exista caractere pe linia curenta
                    if (j == 0) // daca suntem la primul caracter de pe linie
                    {
                        if (line.Length == 1)   // daca acel caracter e singurul caracter de pe linie
                            analizeazaCuvant(line[j].ToString());
                        else
                        {
                            currentChar = charType(line[j]);    // currentChar primeste tipul caracterului curent
                            word += line[j];                    // adaugam caracterul la cuvant
                        }
                    }
                    else
                    {
                            prevChar = currentChar;
                            currentChar = charType(line[j]);

                            if (prevChar != currentChar)    // daca caracterul curent e diferit de cel anterior
                            {
                                if (currentChar == -1)   // daca caracterul curent e spatiu
                                {
                                    analizeazaCuvant(word); // avem un cuvant nou
                                    word = string.Empty;
                                }
                                else
                                    if (currentChar == 0)   // daca caracterul curent e litera
                                    {
                                        if (prevChar != -1)  // daca caracterul precedent nu e spatiu
                                            analizeazaCuvant(word);

                                        word = line[j].ToString();  // incepe un cuvant nou
                                    }
                                    else
                                        if (currentChar == 1)  // daca caracterul curent e cifra
                                            if (prevChar != 0 && prevChar != 7) // daca caracterul anterior nu e litera avem un cuvant nou
                                            {
                                                analizeazaCuvant(word);
                                                word = line[j].ToString();
                                            }
                                            else // daca caracterul anterior e litera suntem intr-un nume de identificator sau constanta reala
                                            {
                                                word += line[j].ToString();
                                            }
                                        else
                                            if (currentChar == 2)   // daca caracterul curent e simbol
                                            {
                                                if (prevChar != -1) // daca caracterul anterior e diferit de spatiu
                                                {
                                                    analizeazaCuvant(word); // s-a terminat un cuvant
                                                }

                                                word = line[j].ToString(); // incepe un cuvant nou
                                            }
                                            else
                                                if (currentChar == 7)   // daca caracterul curent e .
                                                {
                                                    word += line[j];
                                                }
                        }
                        else
                        {
                            if (line[j] != ' ') // daca nu avem 2 caractere spatii consecutive
                            {
                                if(prevChar == 2)   // daca avem 2 caractere consecutive simboluri
                                    if (line[j] != '=') // daca caracterul curent nu e '='
                                    {
                                        analizeazaCuvant(word); // analizam cuvantul fara caracterul curent
                                        word = line[j].ToString();  // incepem un cuvant nou
                                    }
                                    else // daca caracterul curent e '='
                                    {
                                        word += line[j]; // adaugam caracterul '=' la cuvant
                                        analizeazaCuvant(word);
                                        word = string.Empty;
                                    }
                                else  
                                    word += line[j];
                            }
                        }
                    }
                }
                analizeazaCuvant(word);
            }
        }

        private int charType(char c)
        {
            if (char.IsDigit(c))
                return 1;
            if (char.IsLetter(c))
                return 0;
            if (c == ' ')
                return -1;
            if (c == '.')
                return 7;
            return 2;
        }

        private void analizeazaCuvant(string word)
        {
            if(word != string.Empty)
            if (codif.isCuvantRezervat(word))   // daca cuvantul e rezervat il adaugam in fip
            {
                fip.addAtom(codif.getCodAtom(word), -1);

                if (word == "int" || word == "char" || word == "real" || word == "lista")   // semnalam inceputul unei declarari
                    decl = true;

                if(word == ";") //semnalam sfarsitul unei declarari daca eram in una
                    if(decl)
                        decl = false;
            }
            else 
            {
                if (decl) // daca suntem in interiorul unei declarari inseamna ca am gasit un identificator nou
                {
                    ts.addAtom(word);
                    fip.addAtom(0, ts.getAdresaAtom(word));
                }
                else // daca nu suntem in interiorul unei declarari inseamna ca cuvantul e o constanta sau un identificator sau o eroare
                {
                    if (char.IsLetter(word[0]))  // daca cuvantul e identificator il cautam in tabela de simboluri
                    {
                        if(ts.isSymbol(word))   // daca exista in tabela de simboluri il adaugam in fip
                            fip.addAtom(0,ts.getAdresaAtom(word));
                        else
                            errList.Add(word);
                    }
                    else
                        if (char.IsDigit(word[0])) // daca e constanta
                        {
                            if (!ts.isSymbol(word))
                                ts.addAtom(word);
                            fip.addAtom(1, ts.getAdresaAtom(word));
                        }
                        else
                        {
                            errList.Add(word);
                        }
                }
            }
        }

        public List<int> getFIP1()
        {
            return fip.getFIP1;
        }

        public List<int> getFIP2()
        {
            return fip.getFIP2;
        }

        public List<string> getTS1()
        {
            return ts.getTS1;
        }

        public List<int> getTS2()
        {
            return ts.getTS2;
        }

        private string getRidOfRT(string line)  // elimina \t si \r dintr-un string
        {
            for(int i =0;i<line.Length;i++)
            {
                if (line[i] == '\t' || line[i] == '\r')
                {
                    line = line.Remove(i, 1);
                    i--;
                }
            }
            return line;
        }

        public List<string> getErrorList()
        {
            return errList;
        }
    }
}
