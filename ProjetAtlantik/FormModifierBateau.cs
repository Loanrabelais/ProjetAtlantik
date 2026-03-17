using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjetAtlantik
{
    public partial class FormModifierBateau : Form
    {
        public FormModifierBateau()
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
                    string libelle = (string)jeuEnr[("LIBELLE")];
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

                // -------- Bateau -------- 
                var requeteBateau = "SELECT NOBATEAU, NOM FROM BATEAU;";
                var cmdBateau = new MySqlCommand(requeteBateau, maCnx);
                jeuEnr = cmdBateau.ExecuteReader();
                while (jeuEnr.Read())
                {
                    int noBateau = (int)jeuEnr[("NOBATEAU")];
                    string nomBateau = (string)jeuEnr[("NOM")];
                    var unBateau = new Bateau(noBateau, nomBateau);
                    cmbBateau.Items.Add(unBateau);
                }
                jeuEnr.Close();
            }
            catch (MySqlException e)
            {
                lblMessageBateau.ForeColor = Color.Red;
                lblMessageBateau.Text = ("SQL Erreur : " + e.Message);
            }
            catch (Exception e)
            {
                lblMessageBateau.ForeColor = Color.Red;
                lblMessageBateau.Text = ("Erreur : " + e.Message);
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

        private void cmbBateau_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBateau.SelectedItem == null) return;
            MySqlConnection maCnx;
            MySqlDataReader jeuEnr = null;
            maCnx = new MySqlConnection("Server=127.0.0.1;Port=3306;User Id= appuser;Password=mdp;Database=projectatlantik;");
            try
            {
                maCnx.Open();
                // -------- Capacite --------
                Bateau bateau = (Bateau)cmbBateau.SelectedItem;
                var requeteCapacite = "SELECT  LETTRECATEGORIE, CAPACITEMAX FROM CONTENIR WHERE NOBATEAU = @noBateau;";
                var cmdCapacite = new MySqlCommand(requeteCapacite, maCnx);
                cmdCapacite.Parameters.AddWithValue("@noBateau", bateau.GetID());
                jeuEnr = cmdCapacite.ExecuteReader();

                while (jeuEnr.Read())
                {
                    foreach (Control c in gbxCapacite.Controls)
                    {
                        if (c is TextBox tb)
                        {
                            Categorie categorie = tb.Tag as Categorie;
                            string lettre = (string)jeuEnr["LETTRECATEGORIE"];
                            int capacite = (int)jeuEnr[("CAPACITEMAX")];
                            if (categorie.GetID() == lettre)
                            {
                                tb.Text = capacite.ToString();
                            }
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                lblMessageBateau.ForeColor = Color.Red;
                lblMessageBateau.Text = ("SQL Erreur : " + ex.Message);
            }
            catch (Exception ex)
            {
                lblMessageBateau.ForeColor = Color.Red;
                lblMessageBateau.Text = ("Erreur : " + ex.Message);
            }
            finally
            {
                if (maCnx is object & maCnx.State == ConnectionState.Open)
                {
                    maCnx.Close();
                }
            }
        }

        private void btnModifer_Click(object sender, EventArgs e)
        {
            if (cmbBateau.SelectedItem == null)
            {
                errorProvider.SetError(cmbBateau, "Séléctionnez un Bateau");
                return;
            }
            else
            { 
                errorProvider.SetError(cmbBateau, "");
            }
            MySqlConnection maCnx;
            maCnx = new MySqlConnection("Server=127.0.0.1;Port=3306;User Id= appuser;Password=mdp;Database=projectatlantik;");
            try
            {
                maCnx.Open();

                foreach (Control c in gbxCapacite.Controls)
                {
                    if (c is TextBox tb)
                    {
                        if (!int.TryParse(tb.Text, out int capacite))
                            continue;

                        var categorie = tb.Tag as Categorie;
                        Bateau bateau = (Bateau)cmbBateau.SelectedItem;

                        var requeteBateau = "UPDATE CONTENIR SET CAPACITEMAX = @capacite WHERE NOBATEAU = @noBateau AND LETTRECATEGORIE = @lettre;";
                        using (var cmdBateau = new MySqlCommand(requeteBateau, maCnx))
                        {
                            cmdBateau.Parameters.AddWithValue("@capacite", capacite);
                            cmdBateau.Parameters.AddWithValue("@noBateau", bateau.GetID());
                            cmdBateau.Parameters.AddWithValue("@lettre", categorie.GetID());

                            cmdBateau.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                lblMessageBateau.ForeColor = Color.Red;
                lblMessageBateau.Text = ("SQL Erreur : " + ex.Message);
            }
            catch (Exception ex)
            {
                lblMessageBateau.ForeColor = Color.Red;
                lblMessageBateau.Text = ("Erreur : " + ex.Message);
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
                errorProvider.SetError(tb, "Entrée incorrect");
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
