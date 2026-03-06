namespace ProjetAtlantik
{
    internal class Type
    {
        private string _lettre;
        private int _noType;
        private string _libelle;

        public string GetID()
        {
            return _lettre + _noType;
        }

        public Type(string lettre, int pNOType, string pLIBELLE)
        {
            this._lettre = lettre;
            this._noType = pNOType;
            this._libelle = pLIBELLE;
        }

        public override string ToString()
        {
            return _libelle;
        }
    }
}
