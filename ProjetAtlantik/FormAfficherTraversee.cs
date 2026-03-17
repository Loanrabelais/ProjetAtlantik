using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Numerics;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjetAtlantik
{
    public partial class FormAfficherTraversee : Form
    {
        public FormAfficherTraversee()
        {
            InitializeComponent();

            MySqlConnection maCnx;
            MySqlDataReader jeuEnr = null;
            maCnx = new MySqlConnection("Server=127.0.0.1;Port=3306;User Id=appuser;Password=mdp;Database=projectatlantik;");
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
            }
            catch (MySqlException e)
            {
                lblMessageTraverse.ForeColor = Color.Red;
                lblMessageTraverse.Text = e.Message;
            }
            catch (Exception e)
            {
                lblMessageTraverse.ForeColor = Color.Red;
                lblMessageTraverse.Text = e.Message;
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
            maCnx = new MySqlConnection("Server=127.0.0.1;Port=3306;User Id=appuser;Password=mdp;Database=projectatlantik;");
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
                            string nomPortDepart = Convert.ToString(jeuEnr["NOMPORT_DEPART"]);
                            string nomPortArrivee = Convert.ToString(jeuEnr["NOMPORT_ARRIVEE"]);

                            var uneLiaison = new Liaison(noLiaison,  nomPortDepart, nomPortArrivee);
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
        private int getQuantiteEnregistree(int notraversee, string lettreCategorie)
        {
            int placesDispo = -1;
            string connStr = "Server=127.0.0.1;Port=3306;User Id=appuser;Password=mdp;Database=projectatlantik;";
            var requeteQuantite = @"
        SELECT SUM(e.quantiteReservee)
        FROM Traversee t
        JOIN Reservation r ON t.NoTraversee = r.NoTraversee
        JOIN Enregistrer e ON r.NoReservation = e.NoReservation
        WHERE e.LettreCategorie = @lettreCategorie AND t.NoTraversee = @noTraversee";

            try
            {
                using (var maCnx = new MySqlConnection(connStr))
                using (var cmdTraversee = new MySqlCommand(requeteQuantite, maCnx))
                {
                    cmdTraversee.Parameters.AddWithValue("@noTraversee", notraversee);
                    cmdTraversee.Parameters.AddWithValue("@lettreCategorie", lettreCategorie);

                    maCnx.Open();
                    var result = cmdTraversee.ExecuteScalar();

                    if (result == null || result == DBNull.Value)
                        placesDispo = 0;
                    else
                        placesDispo = Convert.ToInt32(result);
                }
            }
            catch (MySqlException e)
            {
                lblMessageTraverse.ForeColor = Color.Red;
                lblMessageTraverse.Text = $"Erreur SQL getQuantiteEnregistree : {e.Message}";
            }
            catch (Exception e)
            {
                lblMessageTraverse.ForeColor = Color.Red;
                lblMessageTraverse.Text = $"Erreur getQuantiteEnregistree : {e.Message}";
            }

            return placesDispo;
        }


        private int getCapaciteMaximale(int noTraversee, string lettreCategorie)
        {
            int capaciteMaximale = -1;
            string connStr = "Server=127.0.0.1;Port=3306;User Id=appuser;Password=mdp;Database=projectatlantik;";
            var requeteCapacitee = @"
                SELECT c.CAPACITEMAX
                FROM Traversee t
                JOIN Contenir c ON t.NoBateau = c.NoBateau
                WHERE c.LettreCategorie = @lettreCategorie AND t.NoTraversee = @noTraversee";

            try
            {
                using (var maCnx = new MySqlConnection(connStr))
                using (var cmdTraversee = new MySqlCommand(requeteCapacitee, maCnx))
                {
                    cmdTraversee.Parameters.AddWithValue("@noTraversee", noTraversee);
                    cmdTraversee.Parameters.AddWithValue("@lettreCategorie", lettreCategorie);

                    maCnx.Open();
                    var result = cmdTraversee.ExecuteScalar();

                    if (result == null || result == DBNull.Value)
                    {
                        capaciteMaximale = 0; // valeur par défaut si aucune ligne
                    }
                    else
                    {
                        capaciteMaximale = Convert.ToInt32(result);
                    }
                }
            }
            catch (MySqlException e)
            {
                lblMessageTraverse.ForeColor = Color.Red;
                lblMessageTraverse.Text = $"Erreur getCapaciteMaximale : {e.Message}";
            }
            catch (Exception e)
            {
                lblMessageTraverse.ForeColor = Color.Red;
                lblMessageTraverse.Text = $"Erreur SQL getCapaciteMaximale : {e.Message}";
            }

            return capaciteMaximale;
        }
        private List<Categorie> getLesCategories()
        {
            var lesCategories = new List<Categorie>();
            string connStr = "Server=127.0.0.1;Port=3306;User Id=appuser;Password=mdp;Database=projectatlantik;";
            string requete = "SELECT LETTRECATEGORIE, LIBELLE FROM CATEGORIE";

            try
            {
                using (var cnx = new MySqlConnection(connStr))
                using (var cmd = new MySqlCommand(requete, cnx))
                {
                    cnx.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lesCategories.Add(new Categorie(
                                reader.GetString(reader.GetOrdinal("LETTRECATEGORIE")),
                                reader.GetString(reader.GetOrdinal("LIBELLE"))));
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                lblMessageTraverse.ForeColor = Color.Red;
                lblMessageTraverse.Text = $"Erreur SQL getLesCategories : {ex.Message}";
            }
            catch (Exception ex)
            {
                lblMessageTraverse.ForeColor = Color.Red;
                lblMessageTraverse.Text = $"Erreur getLesCategories : {ex.Message}";
            }

            return lesCategories;
        }
        private List<Traversee> getLesTraverseesBateaux(int noLiaison, DateTime dateTraversee)
        {
            var lesTraversees = new List<Traversee>();
            string connStr = "Server=127.0.0.1;Port=3306;User Id=appuser;Password=mdp;Database=projectatlantik;";
            DateTime debutJour = dateTraversee.Date;
            DateTime finJour = debutJour.AddDays(1);

            var requete = @"
                SELECT T.NOTRAVERSEE, T.DATEHEUREDEPART, B.NOM
                FROM TRAVERSEE T
                JOIN BATEAU B ON T.NOBATEAU = B.NOBATEAU
                WHERE T.NOLIAISON = @noLiaison
                AND T.DATEHEUREDEPART >= @debutJour
                AND T.DATEHEUREDEPART < @finJour;";

            try
            {
                using (var maCnx = new MySqlConnection(connStr))
                using (var cmd = new MySqlCommand(requete, maCnx))
                {
                    cmd.Parameters.AddWithValue("@noLiaison", noLiaison);
                    cmd.Parameters.AddWithValue("@debutJour", debutJour);
                    cmd.Parameters.AddWithValue("@finJour", finJour);

                    maCnx.Open();
                    using (var jeuEnr = cmd.ExecuteReader())
                    {
                        while (jeuEnr.Read())
                        {
                            int noTraversee = jeuEnr.GetInt32(jeuEnr.GetOrdinal("NOTRAVERSEE"));
                            DateTime dtDepart = jeuEnr.GetDateTime(jeuEnr.GetOrdinal("DATEHEUREDEPART"));
                            string nomBateau = jeuEnr.GetString(jeuEnr.GetOrdinal("NOM"));
                            string heure = dtDepart.ToString("HH:mm");
                            lesTraversees.Add(new Traversee(noTraversee, heure, nomBateau));
                        }
                    }
                }
            }
            catch (MySqlException e)
            {
                lblMessageTraverse.ForeColor = Color.Red;
                lblMessageTraverse.Text = $"Erreur SQL getLesTraverseesBateaux : {e.Message}";
            }
            catch (Exception e)
            {
                lblMessageTraverse.ForeColor = Color.Red;
                lblMessageTraverse.Text = $"Erreur getLesTraverseesBateaux : {e.Message}";
            }

            return lesTraversees;
        }
        private void btnAfficher_Click(object sender, EventArgs e)
        {
            if (lbxSecteur.SelectedItem == null)
            { 
                errorProvider.SetError(lbxSecteur, "veuillez selectioner un secteur");
                return;
            }
            errorProvider.SetError(lbxSecteur, "");

            if (cmbLiaison.SelectedItem == null)
            { 
                errorProvider.SetError(cmbLiaison, "veuillez selectioner une liaison");
                return;
            }
            errorProvider.SetError(cmbLiaison, "");

            var liaison = (Liaison)cmbLiaison.SelectedItem;
            int noLiaison = liaison.GetID();
            DateTime date = dateSelect.Value;
            var lesTraversees = getLesTraverseesBateaux(noLiaison, date);
            if (lesTraversees == null || lesTraversees.Count == 0)
            {
                lblMessageTraverse.ForeColor = Color.Red;
                lblMessageTraverse.Text = "Aucune traversée existante pour les valeurs sélectionnées";
                return;
            }

            lvTravervees.Clear();
            lvTravervees.Columns.Clear();
            lvTravervees.View = View.Details;
            lvTravervees.GridLines = true; // affiche la grille
            lvTravervees.FullRowSelect = true; // Mode de sélection : ligne
            lvTravervees.Columns.Add("N°", 80);
            lvTravervees.Columns.Add("Heure", 120);
            lvTravervees.Columns.Add("Bateau", 120);

            var lesCategories = getLesCategories();
            foreach (Categorie c in lesCategories)
            {
                lvTravervees.Columns.Add($"{c.GetID()}: {c.ToString()}", 100);
            }

            foreach (Traversee t in lesTraversees)
            {
                int cols = 3 + lesCategories.Count;
                string[] tabItem = new string[cols];
                tabItem[0] = t.GetID().ToString();
                tabItem[1] = t.GetDateTraversee().ToString();
                tabItem[2] = t.GetNomBateau();

                for (int j = 0; j < lesCategories.Count; j++)
                {
                    var c = lesCategories[j];
                    int placesDisponibles = getCapaciteMaximale(t.GetID(), c.GetID())
                                            - getQuantiteEnregistree(t.GetID(), c.GetID());
                    tabItem[3 + j] = placesDisponibles.ToString();
                }
                lvTravervees.Items.Add(new ListViewItem(tabItem));
            }

            lblMessageTraverse.ForeColor = Color.Green;
            lblMessageTraverse.Text = "Opération réussie";
        }
    }
}
