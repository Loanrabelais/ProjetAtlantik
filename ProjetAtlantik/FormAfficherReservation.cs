using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjetAtlantik
{
    public partial class FormAfficherReservation : Form
    {
        public FormAfficherReservation()
        {
            InitializeComponent();

            MySqlConnection maCnx;
            MySqlDataReader jeuEnr = null;
            maCnx = new MySqlConnection("Server=127.0.0.1;Port=3306;User Id=appuser;Password=mdp;Database=projectatlantik;");
            try
            {
                maCnx.Open();
                // -------- Client --------
                var requeteClient = "SELECT NOCLIENT, NOM, PRENOM FROM CLIENT";
                var cmdClient = new MySqlCommand(requeteClient, maCnx);
                jeuEnr = cmdClient.ExecuteReader();
                while (jeuEnr.Read())
                {
                    int noClient = (int)jeuEnr["NOCLIENT"];
                    string nom = (string)jeuEnr["NOM"];
                    string prenom = (string)jeuEnr["PRENOM"];
                    var unClient = new Client(noClient, nom, prenom);
                    cmbClient.Items.Add(unClient);
                }
                jeuEnr.Close();
            }
            catch (MySqlException e)
            {
                lblMessageReservation.ForeColor = Color.Red;
                lblMessageReservation.Text = $"SQL initialisation client: {e.Message}";
            }
            catch (Exception e)
            {
                lblMessageReservation.ForeColor = Color.Red;
                lblMessageReservation.Text = $"Initialisation client: {e.Message}";
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

        private void cmbClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            var client = (Client)cmbClient.SelectedItem;
            if (client == null) return;
            MySqlConnection maCnx;
            MySqlDataReader jeuEnr = null;
            maCnx = new MySqlConnection("Server=127.0.0.1;Port=3306;User Id=appuser;Password=mdp;Database=projectatlantik;");
            try
            {
                maCnx.Open();
                // -------- Reservation --------
                var requeteReservation = @"
                    SELECT R.NORESERVATION, PD.NOM AS NOMPORT_DEPART, PA.NOM AS NOMPORT_ARRIVEE,
                        R.NOTRAVERSEE, R.DATEHEURE
                    FROM RESERVATION R
                    JOIN TRAVERSEE T ON R.NOTRAVERSEE = T.NOTRAVERSEE
                    JOIN LIAISON L ON T.NOLIAISON = L.NOLIAISON
                    JOIN PORT PD ON L.NOPORT_DEPART = PD.NOPORT
                    JOIN PORT PA ON L.NOPORT_ARRIVEE = PA.NOPORT
                    WHERE NOCLIENT = @noClient";
                var cmdReservation = new MySqlCommand(requeteReservation, maCnx);
                cmdReservation.Parameters.AddWithValue("@noClient", client.GetID());
                jeuEnr = cmdReservation.ExecuteReader();
                while (jeuEnr.Read())
                {
                    int noReservation = (int)jeuEnr["NORESERVATION"];
                    string nomPortDepart = (string)jeuEnr["NOMPORT_DEPART"];
                    string nomPortArrivee = (string)jeuEnr["NOMPORT_ARRIVEE"];
                    int noTraversee = (int)jeuEnr["NOTRAVERSEE"];
                    DateTime nomDateHeure = (DateTime)jeuEnr["DATEHEURE"];

                    lvResevation.Clear();
                    lvResevation.Columns.Clear();
                    lvResevation.View = View.Details;
                    lvResevation.GridLines = true; // affiche la grille
                    lvResevation.FullRowSelect = true; // Mode de sélection : ligne
                    lvResevation.Columns.Add("N° réservation", 80);
                    lvResevation.Columns.Add("Liaison", 120);
                    lvResevation.Columns.Add("N° Traversée", 85);
                    lvResevation.Columns.Add("Date départ", 120);

                    string[] tabItem = new string[4];
                    tabItem[0] = noReservation.ToString();
                    tabItem[1] = $"{nomPortDepart} - {nomPortArrivee}";
                    tabItem[2] = noTraversee.ToString();
                    tabItem[3] = nomDateHeure.ToString();
                    lvResevation.Items.Add(new ListViewItem(tabItem));
                }
                jeuEnr.Close();
            }
            catch (MySqlException ex)
            {
                lblMessageReservation.ForeColor = Color.Red;
                lblMessageReservation.Text = ex.Message;
            }
            catch (Exception ex)
            {
                lblMessageReservation.ForeColor = Color.Red;
                lblMessageReservation.Text = ex.Message;
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
        private void lvResevation_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection maCnx;
            MySqlDataReader jeuEnr = null;
            maCnx = new MySqlConnection("Server=127.0.0.1;Port=3306;User Id=appuser;Password=mdp;Database=projectatlantik;");
            try
            {
                maCnx.Open();
                // -------- Details --------
                var requeteDetails = @"
                    SELECT R.MONTANTTOTAL, R.MODEREGLEMENT, T.LIBELLE, QUANTITERESERVEE
                    FROM RESERVATION R
                    JOIN ENREGISTRER E ON R.NORESERVATION = E.NORESERVATION
                    JOIN TYPE T ON E.NOTYPE = T.NOTYPE AND E.LETTRECATEGORIE = T.LETTRECATEGORIE 
                    WHERE NOCLIENT = @noClient";
                var cmdDetails = new MySqlCommand(requeteDetails, maCnx);
                cmdDetails.Parameters.AddWithValue("@noClient", lvResevation.SelectedItems[0].Text);
                jeuEnr = cmdDetails.ExecuteReader();
                int i = 20;
                string ModaliteReglement = "";
                Double montantTotal = -1;
                while (jeuEnr.Read())
                {
                    montantTotal = (Double)jeuEnr["MONTANTTOTAL"];
                    ModaliteReglement = jeuEnr["MODEREGLEMENT"] as string ?? "";
                    string libelle = (string)jeuEnr["LIBELLE"];
                    int quantiteReservee = (int)jeuEnr["QUANTITERESERVEE"];

                    Label lbl;
                    lbl = new Label();
                    lbl.Text = $"{libelle}: {quantiteReservee}";
                    lbl.Name = $"lbl{libelle}{quantiteReservee}";
                    lbl.Location = new Point(10, i);
                    lbl.AutoSize = true;
                    gbxDetails.Controls.Add(lbl);

                    i += 25;
                }
                jeuEnr.Close();
                lblMontant.Text = $"montantTotal: {montantTotal}";
                lblMontant.Location = new Point(10, i);
                lblReglement.Text = $"Moyen de règlement: {ModaliteReglement}";
                lblReglement.Location = new Point(10, i + 25);
            }
            catch (MySqlException ex)
            {
                lblMessageReservation.ForeColor = Color.Red;
                lblMessageReservation.Text = ex.Message;
            }
            catch (Exception ex)
            {
                lblMessageReservation.ForeColor = Color.Red;
                lblMessageReservation.Text = ex.Message;
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
            lblMessageReservation.ForeColor = Color.Green;
            lblMessageReservation.Text = "Opération réussie";
        }
    }
}
