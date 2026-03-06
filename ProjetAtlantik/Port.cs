namespace ProjetAtlantik
{
    internal class Port
    {
        private int _noport;
        private string _nom;

        public int GetID()
        {
            return _noport;
        }

        public Port(int pNOPORT, string pNOM)
        {
            this._noport = pNOPORT;
            this._nom = pNOM;
        }

        public override string ToString()
        {
            return _nom;
        }
    }
}
