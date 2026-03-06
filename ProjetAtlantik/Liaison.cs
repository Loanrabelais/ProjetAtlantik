namespace ProjetAtlantik
{
    internal class Liaison
    {
        private int _noLiaison;
        private int _noPortDepart;
        private int _noSecteur;
        private int _noPortArrivee;
        private string _nomPortDepart;
        private string _nomPortArrivee;

        public Liaison(int noLiaison, int noPortDepart, int noSecteur,
            int noPortArrivee, string nomPortDepart ,string nomPortArrive)
        {
            _noLiaison = noLiaison;
            _noPortDepart = noPortDepart;
            _noSecteur = noSecteur;
            _noPortArrivee = noPortArrivee;
            _nomPortDepart = nomPortDepart;
            _nomPortArrivee = nomPortArrive;
        }

        public int GetID()
        {
            return _noLiaison;
        }

        public override string ToString()
        {
            return $"{_nomPortDepart} - {_nomPortArrivee}";
        }
    }
}
