namespace ProjetAtlantik
{
    internal class Liaison
    {
        private int _noLiaison;
        private string _nomPortDepart;
        private string _nomPortArrivee;

        public Liaison(int noLiaison, string nomPortDepart ,string nomPortArrive)
        {
            _noLiaison = noLiaison;
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
