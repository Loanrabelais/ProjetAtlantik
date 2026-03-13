namespace ProjetAtlantik
{
    partial class FormAjoutTraverse
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbLiaison = new System.Windows.Forms.ComboBox();
            this.lblLiaison = new System.Windows.Forms.Label();
            this.lblSecteur = new System.Windows.Forms.Label();
            this.lbxSecteur = new System.Windows.Forms.ListBox();
            this.lblMessageTraverse = new System.Windows.Forms.Label();
            this.cmbBateau = new System.Windows.Forms.ComboBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.lblBateau = new System.Windows.Forms.Label();
            this.dateDepart = new System.Windows.Forms.DateTimePicker();
            this.dateArrivee = new System.Windows.Forms.DateTimePicker();
            this.lblDepart = new System.Windows.Forms.Label();
            this.lblArrivee = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbLiaison
            // 
            this.cmbLiaison.FormattingEnabled = true;
            this.cmbLiaison.Location = new System.Drawing.Point(11, 239);
            this.cmbLiaison.Name = "cmbLiaison";
            this.cmbLiaison.Size = new System.Drawing.Size(188, 24);
            this.cmbLiaison.TabIndex = 7;
            // 
            // lblLiaison
            // 
            this.lblLiaison.AutoSize = true;
            this.lblLiaison.Location = new System.Drawing.Point(12, 219);
            this.lblLiaison.Name = "lblLiaison";
            this.lblLiaison.Size = new System.Drawing.Size(63, 16);
            this.lblLiaison.TabIndex = 6;
            this.lblLiaison.Text = "Liaisons :";
            // 
            // lblSecteur
            // 
            this.lblSecteur.AutoSize = true;
            this.lblSecteur.Location = new System.Drawing.Point(12, 9);
            this.lblSecteur.Name = "lblSecteur";
            this.lblSecteur.Size = new System.Drawing.Size(66, 16);
            this.lblSecteur.TabIndex = 5;
            this.lblSecteur.Text = "Secteurs :";
            // 
            // lbxSecteur
            // 
            this.lbxSecteur.FormattingEnabled = true;
            this.lbxSecteur.ItemHeight = 16;
            this.lbxSecteur.Location = new System.Drawing.Point(11, 28);
            this.lbxSecteur.Name = "lbxSecteur";
            this.lbxSecteur.Size = new System.Drawing.Size(188, 84);
            this.lbxSecteur.TabIndex = 4;
            this.lbxSecteur.SelectedIndexChanged += new System.EventHandler(this.lbxSecteur_SelectedIndexChanged);
            // 
            // lblMessageTraverse
            // 
            this.lblMessageTraverse.AutoSize = true;
            this.lblMessageTraverse.Location = new System.Drawing.Point(12, 279);
            this.lblMessageTraverse.Name = "lblMessageTraverse";
            this.lblMessageTraverse.Size = new System.Drawing.Size(0, 16);
            this.lblMessageTraverse.TabIndex = 8;
            // 
            // cmbBateau
            // 
            this.cmbBateau.FormattingEnabled = true;
            this.cmbBateau.Location = new System.Drawing.Point(486, 28);
            this.cmbBateau.Name = "cmbBateau";
            this.cmbBateau.Size = new System.Drawing.Size(121, 24);
            this.cmbBateau.TabIndex = 9;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(532, 240);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 10;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // lblBateau
            // 
            this.lblBateau.AutoSize = true;
            this.lblBateau.Location = new System.Drawing.Point(486, 8);
            this.lblBateau.Name = "lblBateau";
            this.lblBateau.Size = new System.Drawing.Size(106, 16);
            this.lblBateau.TabIndex = 11;
            this.lblBateau.Text = "Nom du Bateau :";
            // 
            // dateDepart
            // 
            this.dateDepart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateDepart.Location = new System.Drawing.Point(407, 90);
            this.dateDepart.Name = "dateDepart";
            this.dateDepart.Size = new System.Drawing.Size(200, 22);
            this.dateDepart.TabIndex = 12;
            // 
            // dateArrivee
            // 
            this.dateArrivee.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateArrivee.Location = new System.Drawing.Point(407, 118);
            this.dateArrivee.Name = "dateArrivee";
            this.dateArrivee.Size = new System.Drawing.Size(200, 22);
            this.dateArrivee.TabIndex = 13;
            // 
            // lblDepart
            // 
            this.lblDepart.AutoSize = true;
            this.lblDepart.Location = new System.Drawing.Point(236, 95);
            this.lblDepart.Name = "lblDepart";
            this.lblDepart.Size = new System.Drawing.Size(157, 16);
            this.lblDepart.TabIndex = 14;
            this.lblDepart.Text = "Date et Heure de départ :";
            // 
            // lblArrivee
            // 
            this.lblArrivee.AutoSize = true;
            this.lblArrivee.Location = new System.Drawing.Point(236, 123);
            this.lblArrivee.Name = "lblArrivee";
            this.lblArrivee.Size = new System.Drawing.Size(153, 16);
            this.lblArrivee.TabIndex = 15;
            this.lblArrivee.Text = "Date et Heure d\'Arrivée :";
            // 
            // FormAjoutTraverse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 304);
            this.Controls.Add(this.lblArrivee);
            this.Controls.Add(this.lblDepart);
            this.Controls.Add(this.dateArrivee);
            this.Controls.Add(this.dateDepart);
            this.Controls.Add(this.lblBateau);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.cmbBateau);
            this.Controls.Add(this.lblMessageTraverse);
            this.Controls.Add(this.cmbLiaison);
            this.Controls.Add(this.lblLiaison);
            this.Controls.Add(this.lblSecteur);
            this.Controls.Add(this.lbxSecteur);
            this.Name = "FormAjoutTraverse";
            this.Text = "FormAjoutTraverse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbLiaison;
        private System.Windows.Forms.Label lblLiaison;
        private System.Windows.Forms.Label lblSecteur;
        private System.Windows.Forms.ListBox lbxSecteur;
        private System.Windows.Forms.Label lblMessageTraverse;
        private System.Windows.Forms.ComboBox cmbBateau;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Label lblBateau;
        private System.Windows.Forms.DateTimePicker dateDepart;
        private System.Windows.Forms.DateTimePicker dateArrivee;
        private System.Windows.Forms.Label lblDepart;
        private System.Windows.Forms.Label lblArrivee;
    }
}