using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjetAtlantik
{
    public partial class FormAjoutSecteur : Form
    {
        public FormAjoutSecteur()
        {
            InitializeComponent();
        }

        private void btnAjout_Click(object sender, EventArgs e)
        {
            string nomSecteur = tbxNomSecteur.Text;

            if (string.IsNullOrWhiteSpace(nomSecteur))
            {
                errorProvider.SetError(tbxNomSecteur, "Entrer un nom pour le secteur.");
                return;
            }

            MySqlConnection maCnx;
            maCnx = new MySqlConnection("Server=127.0.0.1;Port=3306;User Id= appuser;Password=mdp;Database=projectatlantik;");

            try
            {
                string requête;
                maCnx.Open();
                requête = "Insert into Secteur(NOM) values (@nomSecteur); SELECT LAST_INSERT_ID();";
                using (var maCde = new MySqlCommand(requête, maCnx))
                {
                    maCde.Parameters.AddWithValue("@nomSecteur", nomSecteur);
                    var result = maCde.ExecuteScalar();

                    if (result == null || result == DBNull.Value)
                    {
                        errorProvider.SetError(tbxNomSecteur, "Aucun ID retourné.");
                        return;
                    }

                    tbxNomSecteur.Text = string.Empty;
                }
            }
            catch (MySqlException ex)
            {
                lblMessageSecteur.ForeColor = Color.Red;
                lblMessageSecteur.Text = ex.Message;
            }
            catch (Exception ex)
            {
                lblMessageSecteur.ForeColor = Color.Red;
                lblMessageSecteur.Text = ex.Message;
            }
            finally
            {
                if (maCnx is object && maCnx.State == System.Data.ConnectionState.Open)
                {
                    maCnx.Close();
                }
            }
            lblMessageSecteur.ForeColor = Color.Green;
            lblMessageSecteur.Text = "Opération réussie";
        }

        private void tbxNomSecteur_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {   
            var objetRegEx = new Regex("^[a-zA-Zéèêëçàâôù ûïî]*$");
            // Nombre : ^[0-9]*$
            // Alphabétique (sans accent, sans blanc : ^[a-zA-Z]*$
            // Alphabétique (avec accent) : ^[a-zA-Zéèêëçàâôù ûïî]*$

            var résultatTest = objetRegEx.Match(tbxNomSecteur.Text);
            if (!résultatTest.Success)
            {
                errorProvider.SetError(tbxNomSecteur, "Entrée non valide");
                tbxNomSecteur.BackColor = Color.Red;
            }
            else
            {
                errorProvider.SetError(tbxNomSecteur, "");
                tbxNomSecteur.BackColor = Color.Green;
            }
        }
    }
}
