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

        private void btnModifierBateau_Click(object sender, EventArgs e)
        {
            FormModifierBateau formModifierBateau = new FormModifierBateau();
            formModifierBateau.ShowDialog();
        }

        private void ajouterUnSecteurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAjoutSecteur formAjoutSecteur = new FormAjoutSecteur();
            formAjoutSecteur.ShowDialog();

        }

        private void ajouterUnPortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAjoutPort formAjoutPort = new FormAjoutPort();
            formAjoutPort.ShowDialog();
        }

        private void ajouterUneLiaisonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAjoutLiaison formAjoutLiaison = new FormAjoutLiaison();
            formAjoutLiaison.ShowDialog();
        }

        private void ajouterUnTarifToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAjoutTarif formAjoutTarif = new FormAjoutTarif();
            formAjoutTarif.ShowDialog();
        }

        private void ajouterUnBateauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAjoutBateau formAjoutBateau = new FormAjoutBateau();
            formAjoutBateau.ShowDialog();
        }

        private void modifierUnBateauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAjoutTraverse formAjoutTraverse = new FormAjoutTraverse();
            formAjoutTraverse.ShowDialog();
        }

        private void ajouterUneTraverseeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAjoutTraverse ajouterTraverse = new FormAjoutTraverse();
            ajouterTraverse.ShowDialog();
        }

        private void afficherUneTraverseeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAfficherTraversee afficherTraversee = new FormAfficherTraversee();
            afficherTraversee.ShowDialog();
        }

        private void ajouterUnDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void modiferLesParameresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
