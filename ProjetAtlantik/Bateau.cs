namespace ProjetAtlantik
{
    internal class Bateau
    {
        private int _nobateau;
        private string _nom;
        public Bateau(int pNOBATEAU, string pNOM)
        {
            this._nobateau = pNOBATEAU;
            this._nom = pNOM;
        }

        public int GetID()
        {
            return _nobateau;
        }

        public override string ToString()
        {
            return _nom;
        }
    }
}