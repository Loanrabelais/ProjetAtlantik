namespace ProjetAtlantik
{
    partial class FormAfficherTraversee
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
            this.components = new System.ComponentModel.Container();
            this.lblMessageTraverse = new System.Windows.Forms.Label();
            this.cmbLiaison = new System.Windows.Forms.ComboBox();
            this.lblLiaison = new System.Windows.Forms.Label();
            this.lblSecteur = new System.Windows.Forms.Label();
            this.lbxSecteur = new System.Windows.Forms.ListBox();
            this.dateSelect = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnAfficher = new System.Windows.Forms.Button();
            this.lvTravervees = new System.Windows.Forms.ListView();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMessageTraverse
            // 
            this.lblMessageTraverse.AutoSize = true;
            this.lblMessageTraverse.Location = new System.Drawing.Point(12, 425);
            this.lblMessageTraverse.Name = "lblMessageTraverse";
            this.lblMessageTraverse.Size = new System.Drawing.Size(0, 16);
            this.lblMessageTraverse.TabIndex = 13;
            // 
            // cmbLiaison
            // 
            this.cmbLiaison.FormattingEnabled = true;
            this.cmbLiaison.Location = new System.Drawing.Point(11, 239);
            this.cmbLiaison.Name = "cmbLiaison";
            this.cmbLiaison.Size = new System.Drawing.Size(188, 24);
            this.cmbLiaison.TabIndex = 12;
            // 
            // lblLiaison
            // 
            this.lblLiaison.AutoSize = true;
            this.lblLiaison.Location = new System.Drawing.Point(12, 219);
            this.lblLiaison.Name = "lblLiaison";
            this.lblLiaison.Size = new System.Drawing.Size(63, 16);
            this.lblLiaison.TabIndex = 11;
            this.lblLiaison.Text = "Liaisons :";
            // 
            // lblSecteur
            // 
            this.lblSecteur.AutoSize = true;
            this.lblSecteur.Location = new System.Drawing.Point(12, 9);
            this.lblSecteur.Name = "lblSecteur";
            this.lblSecteur.Size = new System.Drawing.Size(66, 16);
            this.lblSecteur.TabIndex = 10;
            this.lblSecteur.Text = "Secteurs :";
            // 
            // lbxSecteur
            // 
            this.lbxSecteur.FormattingEnabled = true;
            this.lbxSecteur.ItemHeight = 16;
            this.lbxSecteur.Location = new System.Drawing.Point(11, 28);
            this.lbxSecteur.Name = "lbxSecteur";
            this.lbxSecteur.Size = new System.Drawing.Size(188, 164);
            this.lbxSecteur.TabIndex = 9;
            this.lbxSecteur.SelectedIndexChanged += new System.EventHandler(this.lbxSecteur_SelectedIndexChanged);
            // 
            // dateSelect
            // 
            this.dateSelect.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateSelect.Location = new System.Drawing.Point(500, 28);
            this.dateSelect.Name = "dateSelect";
            this.dateSelect.Size = new System.Drawing.Size(288, 22);
            this.dateSelect.TabIndex = 14;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(452, 33);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(42, 16);
            this.lblDate.TabIndex = 15;
            this.lblDate.Text = "Date :";
            // 
            // btnAfficher
            // 
            this.btnAfficher.Location = new System.Drawing.Point(476, 100);
            this.btnAfficher.Name = "btnAfficher";
            this.btnAfficher.Size = new System.Drawing.Size(323, 23);
            this.btnAfficher.TabIndex = 16;
            this.btnAfficher.Text = "Afficher les Traversées";
            this.btnAfficher.UseVisualStyleBackColor = true;
            this.btnAfficher.Click += new System.EventHandler(this.btnAfficher_Click);
            // 
            // lvTravervees
            // 
            this.lvTravervees.HideSelection = false;
            this.lvTravervees.Location = new System.Drawing.Point(224, 129);
            this.lvTravervees.Name = "lvTravervees";
            this.lvTravervees.Size = new System.Drawing.Size(832, 253);
            this.lvTravervees.TabIndex = 17;
            this.lvTravervees.UseCompatibleStateImageBehavior = false;
            this.lvTravervees.View = System.Windows.Forms.View.Details;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // FormAfficherTraversee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 450);
            this.Controls.Add(this.lvTravervees);
            this.Controls.Add(this.btnAfficher);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dateSelect);
            this.Controls.Add(this.lblMessageTraverse);
            this.Controls.Add(this.cmbLiaison);
            this.Controls.Add(this.lblLiaison);
            this.Controls.Add(this.lblSecteur);
            this.Controls.Add(this.lbxSecteur);
            this.Name = "FormAfficherTraversee";
            this.Text = "FormAfficherTraversee";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessageTraverse;
        private System.Windows.Forms.ComboBox cmbLiaison;
        private System.Windows.Forms.Label lblLiaison;
        private System.Windows.Forms.Label lblSecteur;
        private System.Windows.Forms.ListBox lbxSecteur;
        private System.Windows.Forms.DateTimePicker dateSelect;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnAfficher;
        private System.Windows.Forms.ListView lvTravervees;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}