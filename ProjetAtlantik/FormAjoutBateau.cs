using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjetAtlantik
{
    public partial class FormAjoutBateau : Form
    {
        public FormAjoutBateau()
        {
            InitializeComponent();

            MySqlConnection maCnx;
            MySqlDataReader jeuEnr = null;
            maCnx = new MySqlConnection("Server=127.0.0.1;Port=3306;User Id= appuser;Password=mdp;Database=projectatlantik;");
            try
            {
                maCnx.Open();

                // -------- Categorie Generation dynamique --------
                var requeteType = "SELECT LETTRECATEGORIE, LIBELLE FROM CATEGORIE";
                var cmdType = new MySqlCommand(requeteType, maCnx);
                jeuEnr = cmdType.ExecuteReader();
                int i = 20;
                while (jeuEnr.Read())
                {
                    string lettre = (string)jeuEnr["LETTRECATEGORIE"];
                    string libelle = (string)jeuEnr["LIBELLE"];
                    //int idxNoType = jeuEnr.GetOrdinal("NOTYPE"); //Retourne l'index de la colonne "NOTYPE"
                    var uneCategorie = new Categorie(lettre, libelle);
                    //Generation label et textbox
                    TextBox tbx;
                    tbx = new TextBox();
                    tbx.Location = new Point(150, i);
                    tbx.Tag = uneCategorie; // conserve l'objet Categorie
                    tbx.Name = $"tbx{lettre}{libelle}";
                    tbx.Validating += new CancelEventHandler(tbx_Validating);
                    Label lbl;
                    lbl = new Label();
                    lbl.Text = $"{uneCategorie.GetID()} ({uneCategorie.ToString()})";
                    lbl.Name = $"lbl{lettre}{libelle}";
                    lbl.Location = new Point(10, i);
                    lbl.AutoSize = true;
                    gbxCapacite.Controls.Add(tbx);
                    gbxCapacite.Controls.Add(lbl);

                    i += 40;
                }
                jeuEnr.Close();
            }
            catch (MySqlException ex)
            {
                lblMessageBateau.ForeColor = Color.Red;
                lblMessageBateau.Text = ex.Message;
            }
            catch (Exception ex)
            {
                lblMessageBateau.ForeColor = Color.Red;
                lblMessageBateau.Text = ex.Message;
            }
            finally
            {
                if (jeuEnr is object && !jeuEnr.IsClosed)
                {
                    jeuEnr.Close(); // s'il existe et n'est pas déjà fermé
                }

                if (maCnx is object && maCnx.State == ConnectionState.Open)
                {
                    maCnx.Close();
                }
            }
        }

        private void btnAjout_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxNomBateau.Text))
            {
                errorProvider.SetError(tbxNomBateau, "Selectionnez un nom pour le bateau");
                return;
            }
            else
            {
                errorProvider.SetError(tbxNomBateau, "");
            }

            MySqlConnection maCnx;
            maCnx = new MySqlConnection("Server=127.0.0.1;Port=3306;User Id= appuser;Password=mdp;Database=projectatlantik;");
            try
            {
                maCnx.Open();

                // -------- Bateau --------
                string nomBateau = tbxNomBateau.Text;
                var requeteBateau = "INSERT INTO BATEAU (NOM) VALUES (@nomBateau); SELECT LAST_INSERT_ID();";
                var cmdBateau = new MySqlCommand(requeteBateau, maCnx);
                cmdBateau.Parameters.AddWithValue("@nomBateau", nomBateau);
                int noBateau = Convert.ToInt32(cmdBateau.ExecuteScalar());

                foreach (Control c in gbxCapacite.Controls)
                {
                    if (c is TextBox tb && tb.Tag is Categorie categorie)
                    {
                        if (!int.TryParse(tb.Text, out int capacite))
                        {
                            tb.BackColor = Color.Red;
                            continue;
                        }

                        // -------- Contenue --------
                        var requeteContenue = "INSERT INTO CONTENIR (LETTRECATEGORIE, NOBATEAU, CAPACITEMAX) VALUES (@lettreCategorie, @noBateau, @capaciteMax);";
                        var cmdContenue = new MySqlCommand(requeteContenue, maCnx);
                        cmdContenue.Parameters.AddWithValue("@lettreCategorie", categorie.GetID());
                        cmdContenue.Parameters.AddWithValue("@noBateau", noBateau);
                        cmdContenue.Parameters.AddWithValue("@capaciteMax", capacite);
                        cmdContenue.ExecuteNonQuery();
                    }
                }
            }
            catch (MySqlException ex)
            {
                lblMessageBateau.ForeColor = Color.Red;
                lblMessageBateau.Text = ex.Message;
            }
            catch (Exception ex)
            {
                lblMessageBateau.ForeColor = Color.Red;
                lblMessageBateau.Text = ex.Message;
            }
            finally
            {
                if (maCnx is object & maCnx.State == ConnectionState.Open)
                {
                    maCnx.Close();
                }
            }
            lblMessageBateau.ForeColor = Color.Green;
            lblMessageBateau.Text = "Opération réussie";
        }

        private void tbxNomBateau_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var objetRegEx = new Regex("^[a-zA-Zéèêëçàâôù ûïî]*$");
            // Nombre : ^[0-9]*$
            // Alphabétique (sans accent, sans blanc : ^[a-zA-Z]*$
            // Alphabétique (avec accent) : ^[a-zA-Zéèêëçàâôù ûïî]*$

            var résultatTest = objetRegEx.Match(tbxNomBateau.Text);
            if (!résultatTest.Success)
            {
                tbxNomBateau.BackColor = Color.Red;
            }
            else
            {
                tbxNomBateau.BackColor = Color.Green;
            }
        }
        private void tbx_Validating(object sender, CancelEventArgs e)
        {
            var tb = sender as TextBox;
            var objetRegEx = new Regex("^[0-9,.]*$");
            // Nombre : ^[0-9]*$
            // Alphabétique (sans accent, sans blanc : ^[a-zA-Z]*$
            // Alphabétique (avec accent) : ^[a-zA-Zéèêëçàâôù ûïî]*$

            var resultatTest = objetRegEx.Match(tb.Text);
            if (!resultatTest.Success)
            {
                errorProvider.SetError(tb, "Entrée incorrecte");
                tb.BackColor = Color.Red;
            }
            else
            {
                errorProvider.SetError(tb, "");
                tb.BackColor = Color.Green;
            }
        }
    }
}
