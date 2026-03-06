using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjetAtlantik
{
    public partial class FormAjoutTarif : Form
    {
        public FormAjoutTarif()
        {
            InitializeComponent();

            MySqlConnection maCnx;
            MySqlDataReader jeuEnr = null;
            maCnx = new MySqlConnection("Server=127.0.0.1;Port=3306;User Id= appuser;Password=mdp;Database=projectatlantik;");
            try
            {
                maCnx.Open();

                // -------- Type Generation dynamique --------
                var requeteType = "SELECT LETTRECATEGORIE, NOTYPE, LIBELLE FROM TYPE";
                using (var cmdType = new MySqlCommand(requeteType, maCnx))
                {
                    jeuEnr = cmdType.ExecuteReader();
                    int i = 20;
                    while (jeuEnr.Read())
                    {
                        string lettre = (string)jeuEnr["LETTRECATEGORIE"];
                        int idxNoType = jeuEnr.GetOrdinal("NOTYPE"); //Retourne l'index de la colonne "NOTYPE"
                        int no = (int)jeuEnr.GetInt16(idxNoType); //Effectue la conversion du Int16 retourné vers int
                        string nom = (string)jeuEnr["LIBELLE"];
                        var unType = new Type(lettre, no, nom);
                        //Generation label et textbox
                        TextBox tbx;
                        tbx = new TextBox();
                        tbx.Location = new Point(150, i);
                        tbx.Tag = unType; // conserve l'objet Type
                        tbx.Name = $"tbx{lettre}{no}";
                        Label lbl;
                        lbl = new Label();
                        lbl.Text = unType.GetID() + " - " + unType.ToString();
                        lbl.Name = $"lbl{lettre}{no}";
                        lbl.Location = new Point(10, i);
                        lbl.AutoSize = true;
                        gbxTarif.Controls.Add(tbx);
                        gbxTarif.Controls.Add(lbl);

                        i += 25;
                    }
                    jeuEnr.Close();

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
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Erreur " + ex.ToString());
                lblMessageTarif.ForeColor = Color.Red;
                lblMessageTarif.Text = ex.Message;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur " + ex.ToString());
                lblMessageTarif.ForeColor = Color.Red;
                lblMessageTarif.Text = ex.Message;
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

                            var uneLiaison = new Liaison(noLiaison, noPortDepart, noSecteur,
                                noPortArrivee, nomPortDepart, nomPortArrivee);
                            cmbLiaison.Items.Add(uneLiaison);
                        }
                    }
                }
                jeuEnr.Close();
                // -------- Periode --------
                var requetePeriode = "SELECT NOPERIODE, DATEDEBUT, DATEFIN FROM PERIODE";
                var cdePeriode = new MySqlCommand(requetePeriode, maCnx);

                    jeuEnr = cdePeriode.ExecuteReader();
                cmbPeriode.Items.Clear();
                while (jeuEnr.Read())
                {
                    int noPeriode = Convert.ToInt32(jeuEnr["NOPERIODE"]);
                    DateTime dateDebut = jeuEnr.GetDateTime(jeuEnr.GetOrdinal("DATEDEBUT"));
                    DateTime dateFin = jeuEnr.GetDateTime(jeuEnr.GetOrdinal("DATEFIN"));

                    var unePeriode = new Periode(noPeriode, dateDebut, dateFin);
                    cmbPeriode.Items.Add(unePeriode);
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Erreur " + ex.ToString());
                lblMessageTarif.ForeColor = Color.Red;
                lblMessageTarif.Text = ex.Message;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur " + ex.ToString());
                lblMessageTarif.ForeColor = Color.Red;
                lblMessageTarif.Text = ex.Message;
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
            if (lbxSecteur.SelectedItem == null || cmbLiaison.SelectedItem == null || cmbPeriode.SelectedItem == null)
            {
                lblMessageTarif.ForeColor = Color.Red;
                lblMessageTarif.Text = "Erreur : veuillez selectioner toutes les options";
                return;
            }
            else { lblMessageTarif.Text = null; }

            var periode = (Periode)cmbPeriode.SelectedItem;
            int noPeriode = periode.GetID();
            var liaison = (Liaison)cmbLiaison.SelectedItem;
            int noLiaison = liaison.GetID();

            MySqlConnection maCnx;
            maCnx = new MySqlConnection("Server=127.0.0.1;Port=3306;User Id= appuser;Password=mdp;Database=projectatlantik;");
            try
            {
                maCnx.Open();
                foreach (Control c in gbxTarif.Controls)
                {
                    if (c is TextBox tb && tb.Tag is Type type)
                    {
                        string typeID = type.GetID();
                        string lettreCategorie = typeID.Substring(0, 1);
                        int noType = int.Parse(typeID.Substring(1));
                        if (!double.TryParse(tb.Text.Replace('.', ','), out double tarif))
                        {
                            continue;
                        }

                        // -------- Tarifs --------
                        var requeteLiaison =
                            "INSERT INTO tarifer (NOPERIODE, LETTRECATEGORIE, NOTYPE, NOLIAISON, TARIF)" +
                            "VALUES(@noPer, @lettre, @noType, @noLiaison, @tarif)";
                        using (var cdeLiaison = new MySqlCommand(requeteLiaison, maCnx))
                        {
                            cdeLiaison.Parameters.AddWithValue("@noPer", noPeriode);
                            cdeLiaison.Parameters.AddWithValue("@lettre", lettreCategorie);
                            cdeLiaison.Parameters.AddWithValue("@noType", noType);
                            cdeLiaison.Parameters.AddWithValue("@noLiaison", noLiaison);
                            cdeLiaison.Parameters.AddWithValue("@tarif", tarif);
                            cdeLiaison.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Erreur " + ex.ToString());
                lblMessageTarif.Text = ex.Message;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur " + ex.ToString());
                lblMessageTarif.Text = ex.Message;
            }
            finally
            {
                if (maCnx is object & maCnx.State == ConnectionState.Open)
                {
                    maCnx.Close();
                }
            }
            lblMessageTarif.ForeColor = Color.Green;
            lblMessageTarif.Text = "Opération réussie";
        }
    }
}
