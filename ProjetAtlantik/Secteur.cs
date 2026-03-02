using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetAtlantik
{
    public class secteur
    {
        public int NOSECTEUR { get; set; }
        public string NOM { get; set; }

        public secteur(int NOSECTEUR_, string NOM_)
        {
            this.NOSECTEUR = NOSECTEUR_;
            this.NOM = NOM_;
        }
        public override string ToString()
        {
            return "n° Secteur : " + NOSECTEUR + ", " + "Nom : " + NOM;
        }
    }
}
