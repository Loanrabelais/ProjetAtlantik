using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using K4os.Compression.LZ4.Internal;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ProjetAtlantik
{
    public partial class FormModifierParametre : Form
    {
        public FormModifierParametre()
        {
            InitializeComponent();

            MySqlConnection maCnx;
            maCnx = new MySqlConnection("Server=127.0.0.1;Port=3306;User Id=appuser;Password=mdp;Database=projectatlantik;");
            try
            {
                maCnx.Open();
                var requeteParametre = "SELECT * FROM PARAMETRES WHERE NOIDENTIFIANT = 1";
                var cmdParametre = new MySqlCommand(requeteParametre, maCnx);
                var reader = cmdParametre.ExecuteReader();
                if (reader.Read())
                {
                    string site = reader["SITE_PB"] as string;
                    string rang = reader["RANG_PB"] as string;
                    string identifiant = reader["IDENTIFIANT_PB"] as string;
                    string cle = reader["CLEHMAC_PB"] as string;
                    bool production = Convert.ToInt32(reader["ENPRODUCTION"]) != 0;
                    string mel = reader["MELSITE"] as string;

                    txbSite.Text = site;
                    txbRang.Text = rang;
                    txbIdentifiant.Text = identifiant;
                    txbCle.Text = cle;
                    cbxProduction.Checked = production;
                    txbMel.Text = mel;
                }
                reader.Close();
            }
            catch (MySqlException e)
            {
                lblMessageParametre.ForeColor = Color.Red;
                lblMessageParametre.Text = $"Erreur SQL: {e.Message}";
            }
            catch (Exception e)
            {
                lblMessageParametre.ForeColor = Color.Red;
                lblMessageParametre.Text = $"Erreur: {e.Message}";
            }
            finally
            {
                if (maCnx is object && maCnx.State == ConnectionState.Open)
                {
                    maCnx.Close();
                }
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            MySqlConnection maCnx;
            maCnx = new MySqlConnection("Server=127.0.0.1;Port=3306;User Id= appuser;Password=mdp;Database=projectatlantik;");

            try
            {
                string requête;
                maCnx.Open();
                requête = @"
                        UPDATE PARAMETRES
                        SET
                          SITE_PB = @site,
                          RANG_PB = @rang,
                          IDENTIFIANT_PB = @identifiant,
                          CLEHMAC_PB = @cle,
                          ENPRODUCTION = @enproduction,
                          MELSITE = @mel
                        WHERE NOIDENTIFIANT = 1; ";
                var maCde = new MySqlCommand(requête, maCnx);
                maCde.Parameters.AddWithValue("@site", txbSite.Text);
                maCde.Parameters.AddWithValue("@rang", txbRang.Text);
                maCde.Parameters.AddWithValue("@identifiant", txbIdentifiant.Text);
                maCde.Parameters.AddWithValue("@cle", txbCle.Text);
                maCde.Parameters.AddWithValue("@enproduction", cbxProduction.Checked ? 1 : 0);
                maCde.Parameters.AddWithValue("@mel", txbMel.Text);
                maCde.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                lblMessageParametre.ForeColor = Color.Red;
                lblMessageParametre.Text = $"Erreur SQL: {ex.Message}";
            }
            catch (Exception ex)
            {
                lblMessageParametre.ForeColor = Color.Red;
                lblMessageParametre.Text = $"Erreur: {ex.Message}";
            }
            finally
            {
                if (maCnx is object && maCnx.State == ConnectionState.Open)
                {
                    maCnx.Close();
                }
            }
            lblMessageParametre.ForeColor = Color.Green;
            lblMessageParametre.Text = "Opération réussie";
        }
    }
}