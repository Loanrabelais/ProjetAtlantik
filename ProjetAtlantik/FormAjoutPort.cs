using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjetAtlantik
{
    public partial class FormAjoutPort : Form
    {
        public FormAjoutPort()
        {
            InitializeComponent();
        }

        private void btnAjoutPort_Click(object sender, EventArgs e)
        {
            string nomPort = tbxNomPort.Text;

            if (string.IsNullOrWhiteSpace(nomPort))
            {
                errorProvider.SetError(tbxNomPort, "Entrer un nom pour le port.");
                return;
            }
            else
            {
                errorProvider.SetError(tbxNomPort, "");
            }

            MySqlConnection maCnx;
            maCnx = new MySqlConnection("Server=127.0.0.1;Port=3306;User Id= appuser;Password=mdp;Database=projectatlantik;");

            try
            {
                string requête;
                maCnx.Open();
                requête = "Insert into Port(NOM) values (@nomPort); SELECT LAST_INSERT_ID();";
                using (var maCde = new MySqlCommand(requête, maCnx))
                {
                    maCde.Parameters.AddWithValue("@nomPort", nomPort);
                    var result = maCde.ExecuteScalar();

                    if (result == null || result == DBNull.Value)
                    {
                        lblMessagePort.ForeColor = Color.Red;
                        lblMessagePort.Text = "Aucun ID retourné.";
                        return;
                    }

                    int idPortGenere = Convert.ToInt32(result);
                    Console.WriteLine("id Port généré  :" + idPortGenere.ToString());

                    tbxNomPort.Text = string.Empty;
                }
            }
            catch (MySqlException ex)
            {
                lblMessagePort.ForeColor = Color.Red;
                lblMessagePort.Text = ex.Message;
            }
            catch (Exception ex)
            {
                lblMessagePort.ForeColor = Color.Red;
                lblMessagePort.Text = ex.Message;
            }
            finally
            {
                if (maCnx is object && maCnx.State == ConnectionState.Open)
                {
                    maCnx.Close();
                }
            }
            lblMessagePort.ForeColor = Color.Green;
            lblMessagePort.Text = "Opération réussie";
        }

        private void tbxNomPort_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var objetRegEx = new Regex("^[a-zA-Zéèêëçàâôù ûïî]*$");
            // Nombre : ^[0-9]*$
            // Alphabétique (sans accent, sans blanc : ^[a-zA-Z]*$
            // Alphabétique (avec accent) : ^[a-zA-Zéèêëçàâôù ûïî]*$

            var resultatTest = objetRegEx.Match(tbxNomPort.Text);
            if (!resultatTest.Success)
            {
                errorProvider.SetError(tbxNomPort, "Entrée non valide");
                tbxNomPort.BackColor = Color.Red;
            }
            else
            {
                errorProvider.SetError(tbxNomPort, "");
                tbxNomPort.BackColor = Color.Green;
            }
        }
    }
}