using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetAtlantik
{
    public partial class FormAcceuil : Form
    {
        public FormAcceuil()
        {
            InitializeComponent();
        }
        private void unSecteurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAjoutSecteur formAjoutSecteur = new FormAjoutSecteur();
            formAjoutSecteur.ShowDialog();
        }
        private void unPortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAjoutPort formAjoutPort = new FormAjoutPort();
            formAjoutPort.ShowDialog();
        }
        private void uneLiaisonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAjoutLiaison formAjoutLiaison = new FormAjoutLiaison();
            formAjoutLiaison.ShowDialog();
        }
        private void desTarifsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAjoutTarif formAjoutTarif = new FormAjoutTarif();
            formAjoutTarif.ShowDialog();
        }
        private void unBateauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAjoutBateau formAjoutBateau = new FormAjoutBateau();
            formAjoutBateau.ShowDialog();
        }
        private void uneTraverseeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAjoutTraverse ajouterTraverse = new FormAjoutTraverse();
            ajouterTraverse.ShowDialog();
        }
        private void unBateauToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormModifierBateau formModifierBateau = new FormModifierBateau();
            formModifierBateau.ShowDialog();
        }
        private void lesParameresDuSiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormModifierParametre modifierParametre = new FormModifierParametre();
            modifierParametre.ShowDialog();
        }
        private void lesTraverseesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAfficherTraversee afficherTraversee = new FormAfficherTraversee();
            afficherTraversee.ShowDialog();
        }
        private void detailsReservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAfficherReservation afficherReservation = new FormAfficherReservation();
            afficherReservation.ShowDialog();
        }
    }
}
