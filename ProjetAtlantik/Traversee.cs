using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetAtlantik
{
    internal class Traversee
    {
        private int _noTraversee;
        private string _dateTraversee;
        private string _nomBateau;
        public Traversee(int noTraversee, string dateTraversee, string nomBateau)
        {
            _noTraversee = noTraversee;
            _dateTraversee = dateTraversee;
            _nomBateau = nomBateau;
        }

        public int GetID()
        {
            return _noTraversee;
        }

        public string GetNomBateau()
        {
            return _nomBateau;
        }
        public string GetDateTraversee()
        {
            return _dateTraversee;
        }

        public override string ToString()
        {
            return $"{_noTraversee}; {_dateTraversee}; {_nomBateau}";
        }
    }
}
