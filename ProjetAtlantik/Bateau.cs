using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetAtlantik
{
    public class Bateau
    {
        public int NOBATEAU { get; set; }
        public string NOM { get; set; }

        public Bateau(int NOBATEAU_, string NOM_)
        {
            this.NOBATEAU = NOBATEAU_;
            this.NOM = NOM_;
        }
        public override string ToString()
        {
            return "n° Bateau : " + NOBATEAU + ", " + "Nom : " + NOM;
        }
    }
}
