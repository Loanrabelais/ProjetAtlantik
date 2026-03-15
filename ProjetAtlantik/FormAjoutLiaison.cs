using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjetAtlantik
{
    public partial class FormAjoutLiaison : Form
    {
        public FormAjoutLiaison()
        {
            InitializeComponent();
            MySqlConnection maCnx;
            MySqlDataReader jeuEnr = null;
            maCnx = new MySqlConnection("Server=127.0.0.1;Port=3306;User Id= appuser;Password=mdp;Database=projectatlantik;");
            try
            {
                maCnx.Open();

                // -------- Secteurs --------
                var requeteSecteur = "SELECT NOSECTEUR, NOM FROM SECTEUR";
                using (var cmdSecteur = new MySqlCommand(requeteSecteur, maCnx))
                {
                    jeuEnr = cmdSecteur.ExecuteReader();
                    while (jeuEnr.Read())
                    {
                        int no = (int)jeuEnr["NOSECTEUR"];
                        string nom = (string)jeuEnr["NOM"];
                        var unSecteur = new Secteur(no, nom);
                        lbxSecteur.Items.Add(unSecteur);
                    }
                    jeuEnr.Close();
                }

                // -------- Ports --------
                var requetePort = "SELECT NOPORT, NOM FROM PORT";
                using (var cmdPort = new MySqlCommand(requetePort, maCnx))
                {
                    jeuEnr = cmdPort.ExecuteReader();
                    while (jeuEnr.Read())
                    {
                        int no = (int)jeuEnr["NOPORT"];
                        string nom = (string)jeuEnr["NOM"];
                        var unPort = new Port(no, nom);
                        cmbDepart.Items.Add(unPort);
                        cmbArrivee.Items.Add(unPort);
                    }
                    jeuEnr.Close();
                }
            }
            catch (MySqlException e)
            {
                lblMessageLiaison.ForeColor = Color.Red;
                lblMessageLiaison.Text = e.Message;
            }
            catch (Exception e)
            {
                lblMessageLiaison.ForeColor = Color.Red;
                lblMessageLiaison.Text = e.Message;
            }
            finally
            {
                if (jeuEnr is object & !jeuEnr.IsClosed)
                {
                    jeuEnr.Close(); // s'il existe et n'est pas déjà fermé
                }

                if (maCnx is object & maCnx.State == ConnectionState.Open)
                {
                    maCnx.Close();
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Vérifie qu'un secteur est sélectionné
            if (lbxSecteur.SelectedIndex == -1)
            {
                lblMessageLiaison.ForeColor = Color.Red;
                lblMessageLiaison.Text = "Veuillez sélectionner un secteur.";
                return;
            }

            // Vérifie départ/arrivée sélectionnés
            if (cmbDepart.SelectedIndex == -1 || cmbArrivee.SelectedIndex == -1)
            {
                lblMessageLiaison.ForeColor = Color.Red;
                lblMessageLiaison.Text = "Sélectionnez le port de départ et d'arrivée.";
                return;
            }

            // Vérifie qu'ils ne sont pas identiques (par index)
            if (cmbDepart.SelectedIndex == cmbArrivee.SelectedIndex)
            {
                lblMessageLiaison.ForeColor = Color.Red;
                lblMessageLiaison.Text = "Le départ et l'arrivée doivent être différents.";
                return;
            }

            // Vérification distance
            if (string.IsNullOrWhiteSpace(tbxDistance.Text))
            {
                lblMessageLiaison.ForeColor = Color.Red;
                lblMessageLiaison.Text = "Veuillez saisir la distance.";
                return;
            }

            if (!double.TryParse(tbxDistance.Text.Replace(',', '.'), NumberStyles.Number, CultureInfo.InvariantCulture, out double distance))
            {
                lblMessageLiaison.ForeColor = Color.Red;
                lblMessageLiaison.Text = "Distance invalide (doit être un nombre).";
                return;
            }

            // Vérifier format 5,2 : valeur absolue < 1000 (3 chiffres entiers max) et 2 décimales max
            distance = Math.Round(distance, 2); // arrondir à 2 décimales
            if (Math.Abs(distance) >= 1000) // 5,2 => max 999.99
            {
                lblMessageLiaison.ForeColor = Color.Red;
                lblMessageLiaison.Text = "Distance hors plage (max 999.99).";
                return;
            }

            MySqlConnection maCnx;
            maCnx = new MySqlConnection("Server=127.0.0.1;Port=3306;User Id= appuser;Password=mdp;Database=projectatlantik;");

            try
            {
                string requête;
                maCnx.Open();
                requête = "Insert into LIAISON(NOPORT_DEPART, NOSECTEUR, NOPORT_ARRIVEE, DISTANCE)" +
                    "values (@nomPortDepart, @nosecteur, @nomPortArrivee, @distance);" +
                    "SELECT LAST_INSERT_ID();";
                using (var maCde = new MySqlCommand(requête, maCnx))
                {
                    maCde.Parameters.AddWithValue("@nomPortDepart", ((Port)cmbDepart.SelectedItem).GetID());
                    maCde.Parameters.AddWithValue("@nosecteur", ((Secteur)lbxSecteur.SelectedItem).GetID());
                    maCde.Parameters.AddWithValue("@nomPortArrivee", ((Port)cmbArrivee.SelectedItem).GetID());
                    maCde.Parameters.AddWithValue("@distance", tbxDistance.Text);
                    var result = maCde.ExecuteScalar();

                    if (result == null || result == DBNull.Value)
                    {
                        lblMessageLiaison.ForeColor = Color.Red;
                        lblMessageLiaison.Text = "Aucun ID retourné.";
                        return;
                    }

                    int idPortGenere = Convert.ToInt32(result);
                    Console.WriteLine("id Liaison généré  :" + idPortGenere.ToString());

                    tbxDistance.Text = string.Empty;
                    lblMessageLiaison.ForeColor = Color.Green;
                    lblMessageLiaison.Text = "Opération réussie";
                }
            }
            catch (MySqlException ex)
            {
                lblMessageLiaison.ForeColor = Color.Red;
                lblMessageLiaison.Text = ex.Message;
            }
            catch (Exception ex)
            {
                lblMessageLiaison.ForeColor = Color.Red;
                lblMessageLiaison.Text = ex.Message;
            }
            finally
            {
                if (maCnx is object && maCnx.State == ConnectionState.Open)
                {
                    maCnx.Close();
                }
            }
        }
    }
}

