namespace ProjetAtlantik
{
    internal class Categorie
    {
        private string _lettreCategorie;
        private string _libelle;

        public Categorie(string pLETTRECATEGORIE, string pLIBELLE)
        {
            this._lettreCategorie = pLETTRECATEGORIE;
            this._libelle = pLIBELLE;
        }

        public string GetID()
        {
            return _lettreCategorie;
        }

        public override string ToString()
        {
            return _libelle;
        }
    }
}