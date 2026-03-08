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

        private void button1_Click(object sender, EventArgs e)
        {
            FormAjoutSecteur formAjoutSecteur = new FormAjoutSecteur();
            formAjoutSecteur.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormAjoutPort formAjoutPort = new FormAjoutPort();
            formAjoutPort.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormAjoutLiaison formAjoutLiaison = new FormAjoutLiaison();
            formAjoutLiaison.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormAjoutTarif formAjoutTarif = new FormAjoutTarif();
            formAjoutTarif.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormAjoutBateau formAjoutBateau = new FormAjoutBateau();
            formAjoutBateau.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void FormAcceuil_Load(object sender, EventArgs e)
        {

        }

        private void btnModifierBateau_Click(object sender, EventArgs e)
        {
            //FormModifierBateau formModifierBateau = new FormModifierBateau();
            //formModifierBateau.ShowDialog();
        }
    }
}
