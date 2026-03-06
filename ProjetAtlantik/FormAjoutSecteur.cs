using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ProjetAtlantik
{
    public partial class FormAjoutSecteur : Form
    {
        public FormAjoutSecteur()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nomSecteur = tbxNomSecteur.Text;
            if (string.IsNullOrWhiteSpace(nomSecteur))
            {
                lblMessageSecteur.ForeColor = Color.Red;
                lblMessageSecteur.Text = "Le nom du Secteur est requis.";
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
                        lblMessageSecteur.ForeColor = Color.Red;
                        lblMessageSecteur.Text = "Aucun ID retourné.";
                        return;
                    }

                    int idSecteurGenere = Convert.ToInt32(result);
                    Console.WriteLine("id Secteur généré  :" + idSecteurGenere.ToString());

                    tbxNomSecteur.Text = string.Empty;
                    lblMessageSecteur.ForeColor = Color.Green;
                    lblMessageSecteur.Text = "Opération réussie";
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Erreur " + ex.ToString());
                lblMessageSecteur.ForeColor = Color.Red;
                lblMessageSecteur.Text = ex.Message;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur " + ex.ToString());
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
        }

        private void tbxNomSecteur_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbxNomSecteur.Text))
                lblMessageSecteur = null;
        }
    }
}
