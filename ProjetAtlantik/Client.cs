using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetAtlantik
{
    internal class Client
    {
        private int _noClient;
        private string _nom;
        private string _prenom;

        public Client(int noClient, string nom, string prenom)
        {
            this._noClient = noClient;
            this._nom = nom;
            this._prenom = prenom;
        }

        public int GetID()
        {
            return _noClient;
        }

        public override string ToString()
        {
            return $"{_nom}, {_prenom}";
        }
    }
}