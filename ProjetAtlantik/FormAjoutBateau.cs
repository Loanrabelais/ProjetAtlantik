using System;
using System.Data;
using System.Drawing;
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
                using (var cmdType = new MySqlCommand(requeteType, maCnx))
                {
                    jeuEnr = cmdType.ExecuteReader();
                    int i = 20;
                    while (jeuEnr.Read())
                    {
                        string lettre = (string)jeuEnr["LETTRECATEGORIE"];
                        string libelle = (string)jeuEnr[("LIBELLE")];
                        var uneCategorie = new Categorie(lettre, libelle);
                        //Generation label et textbox
                        TextBox tbx;
                        tbx = new TextBox();
                        tbx.Location = new Point(150, i);
                        tbx.Tag = uneCategorie; // conserve l'objet Categorie
                        tbx.Name = $"tbx{lettre}{libelle}";
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
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("SQL Erreur : " + ex.ToString());
                lblMessageBateau.ForeColor = Color.Red;
                lblMessageBateau.Text = ex.Message;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur : " + ex.ToString());
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
            MySqlConnection maCnx;
            maCnx = new MySqlConnection("Server=127.0.0.1;Port=3306;User Id= appuser;Password=mdp;Database=projectatlantik;");
            try
            {
                maCnx.Open();

                // -------- Bateau --------
                string nomBateau = tbxNomBateau.Text;
                int noBateau;
                var requeteBateau = "INSERT INTO BATEAU (NOM) VALUES (@nomBateau); SELECT LAST_INSERT_ID();";
                using (var cmdBateau = new MySqlCommand(requeteBateau, maCnx))
                {
                    cmdBateau.Parameters.AddWithValue("@nomBateau", nomBateau);
                    noBateau = Convert.ToInt32(cmdBateau.ExecuteScalar());
                }

                foreach (Control c in gbxCapacite.Controls)
                {
                    if (c is TextBox tb && tb.Tag is Categorie categorie)
                    {
                        if (!int.TryParse(tb.Text.Replace('.', ','), out int capacite))
                        {
                            continue;
                        }

                        // -------- Contenue --------
                        var requeteContenue = "INSERT INTO CONTENIR (LETTRECATEGORIE, NOBATEAU, CAPACITEMAX) VALUES (@lettreCategorie, @noBateau, @capaciteMax);";
                        using (var cmdContenue = new MySqlCommand(requeteContenue, maCnx))
                        {
                            cmdContenue.Parameters.AddWithValue("@lettreCategorie", categorie.GetID());
                            cmdContenue.Parameters.AddWithValue("@noBateau", noBateau);
                            cmdContenue.Parameters.AddWithValue("@capaciteMax", capacite);
                            cmdContenue.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Erreur " + ex.ToString());
                lblMessageBateau.ForeColor = Color.Red;
                lblMessageBateau.Text = ex.Message;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur " + ex.ToString());
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
    }
}
