using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjetAtlantik
{
    public partial class FormAjoutTraverse : Form
    {
        public FormAjoutTraverse()
        {
            InitializeComponent();
            dateDepart.Format = DateTimePickerFormat.Custom;
            dateDepart.CustomFormat = "yyyy-MM-dd HH:mm";
            dateDepart.ShowUpDown = false;
            DateTime selectedDateDepart = dateDepart.Value;
            dateArrivee.Format = DateTimePickerFormat.Custom;
            dateArrivee.CustomFormat = "yyyy-MM-dd HH:mm";
            dateArrivee.ShowUpDown = false;
            DateTime selectedDateArrivee = dateArrivee.Value;

            MySqlConnection maCnx;
            MySqlDataReader jeuEnr = null;
            maCnx = new MySqlConnection("Server=127.0.0.1;Port=3306;User Id= appuser;Password=mdp;Database=projectatlantik;");
            try
            {
                maCnx.Open();
                {
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
                }

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
            catch (MySqlException ex)
            {
                lblMessageTraverse.ForeColor = Color.Red;
                lblMessageTraverse.Text = ex.Message;
            }
            catch (Exception ex)
            {
                lblMessageTraverse.ForeColor = Color.Red;
                lblMessageTraverse.Text = ex.Message;
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
        private void lbxSecteur_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxSecteur.SelectedItem == null) return;
            cmbLiaison.Items.Clear();
            var typeSel = (Secteur)lbxSecteur.SelectedItem;
            int secteurValeur = typeSel.GetID();

            MySqlConnection maCnx;
            MySqlDataReader jeuEnr = null;
            maCnx = new MySqlConnection("Server=127.0.0.1;Port=3306;User Id= appuser;Password=mdp;Database=projectatlantik;");
            try
            {
                maCnx.Open();
                // -------- Liaison --------
                var requeteLiaison =
                    "SELECT L.NOLIAISON, L.NOPORT_DEPART, L.NOSECTEUR, L.NOPORT_ARRIVEE, " +
                    "PD.NOM AS NOMPORT_DEPART, PA.NOM AS NOMPORT_ARRIVEE " +
                    "FROM LIAISON L " +
                    "INNER JOIN PORT PD ON L.NOPORT_DEPART = PD.NOPORT " +
                    "INNER JOIN PORT PA ON L.NOPORT_ARRIVEE = PA.NOPORT " +
                    "WHERE L.NOSECTEUR = @Secteur";
                using (var cdeLiaison = new MySqlCommand(requeteLiaison, maCnx))
                {
                    cdeLiaison.Parameters.AddWithValue("@Secteur", secteurValeur);

                    using (jeuEnr = cdeLiaison.ExecuteReader())
                    {
                        while (jeuEnr.Read())
                        {
                            int noLiaison = Convert.ToInt32(jeuEnr["NOLIAISON"]);
                            int noPortDepart = Convert.ToInt32(jeuEnr["NOPORT_DEPART"]);
                            int noSecteur = Convert.ToInt32(jeuEnr["NOSECTEUR"]);
                            int noPortArrivee = Convert.ToInt32(jeuEnr["NOPORT_ARRIVEE"]);
                            string nomPortDepart = Convert.ToString(jeuEnr["NOMPORT_DEPART"]);
                            string nomPortArrivee = Convert.ToString(jeuEnr["NOMPORT_ARRIVEE"]);

                            var uneLiaison = new Liaison(noLiaison, nomPortDepart, nomPortArrivee);
                            cmbLiaison.Items.Add(uneLiaison);
                        }
                    }
                }
                jeuEnr.Close();
            }
            catch (MySqlException ex)
            {
                lblMessageTraverse.ForeColor = Color.Red;
                lblMessageTraverse.Text = ex.Message;
            }
            catch (Exception ex)
            {
                lblMessageTraverse.ForeColor = Color.Red;
                lblMessageTraverse.Text = ex.Message;
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

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (lbxSecteur.SelectedItem == null ||
                cmbLiaison.SelectedItem == null ||
                cmbBateau.SelectedItem == null)
            {
                lblMessageTraverse.ForeColor = Color.Red;
                lblMessageTraverse.Text = "Veuillez selectioner toutes les options";
                return;
            }
            else { lblMessageTraverse.Text = null; }
            DateTime depart = dateDepart.Value;
            DateTime arrivee = dateArrivee.Value;
            if (depart >= arrivee)
            {
                lblMessageTraverse.ForeColor = Color.Red;
                lblMessageTraverse.Text = "Veuillez enter des dates valides (Arrivé > Départ)";
                return;
            }
            var liaison = cmbLiaison.SelectedItem as Liaison;
            var bateau = cmbBateau.SelectedItem as Bateau;

            MySqlConnection maCnx;
            maCnx = new MySqlConnection("Server=127.0.0.1;Port=3306;User Id= appuser;Password=mdp;Database=projectatlantik;");
            try
            {
                maCnx.Open();
                var requeteTraversee =
                    "INSERT INTO TRAVERSEE (NOLIAISON, NOBATEAU, DATEHEUREDEPART, DATEHEUREARRIVEE, CLOTUREEMBARQUEMENT)" +
                    "VALUES(@noLiaison, @noBateau, @heureDepart, @heureArrivee, 0)";
                var cdeTraversee = new MySqlCommand(requeteTraversee, maCnx);
                cdeTraversee.Parameters.AddWithValue("@noLiaison", liaison.GetID());
                cdeTraversee.Parameters.AddWithValue("@noBateau", bateau.GetID());
                cdeTraversee.Parameters.AddWithValue("@heureDepart", depart);
                cdeTraversee.Parameters.AddWithValue("@heureArrivee", arrivee);
                cdeTraversee.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                lblMessageTraverse.ForeColor = Color.Red;
                lblMessageTraverse.Text = ex.Message;
            }
            catch (Exception ex)
            {
                lblMessageTraverse.ForeColor = Color.Red;
                lblMessageTraverse.Text = ex.Message;
            }
            finally
            {
                if (maCnx is object & maCnx.State == ConnectionState.Open)
                {
                    maCnx.Close();
                }
            }

            lblMessageTraverse.ForeColor = Color.Green;
            lblMessageTraverse.Text = "Opération réussie";
        }
    }
}
