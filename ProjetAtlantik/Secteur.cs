using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetAtlantik
{
    internal class Secteur
    {
        private int _noSecteur;
        private string _nom;

        public int GetID()
        {
            return _noSecteur;
        }

        public Secteur(int pNOSECTEUR, string pNOM)
        {
            this._noSecteur = pNOSECTEUR;
            this._nom = pNOM;
        }

        public override string ToString()
        {
            return _nom;
        }
    }
}
