namespace ProjetAtlantik
{
    partial class FormAjoutSecteur
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
            this.tbxNomSecteur = new System.Windows.Forms.TextBox();
            this.labelSecteur = new System.Windows.Forms.Label();
            this.lblMessageSecteur = new System.Windows.Forms.Label();
            this.btnAjout = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxNomSecteur
            // 
            this.tbxNomSecteur.Location = new System.Drawing.Point(352, 116);
            this.tbxNomSecteur.Name = "tbxNomSecteur";
            this.tbxNomSecteur.Size = new System.Drawing.Size(100, 22);
            this.tbxNomSecteur.TabIndex = 0;
            this.tbxNomSecteur.Validating += new System.ComponentModel.CancelEventHandler(this.tbxNomSecteur_Validating);
            // 
            // labelSecteur
            // 
            this.labelSecteur.AutoSize = true;
            this.labelSecteur.Location = new System.Drawing.Point(215, 119);
            this.labelSecteur.Name = "labelSecteur";
            this.labelSecteur.Size = new System.Drawing.Size(107, 16);
            this.labelSecteur.TabIndex = 1;
            this.labelSecteur.Text = "Nom du secteur :";
            // 
            // lblMessageSecteur
            // 
            this.lblMessageSecteur.AutoSize = true;
            this.lblMessageSecteur.ForeColor = System.Drawing.Color.Green;
            this.lblMessageSecteur.Location = new System.Drawing.Point(378, 141);
            this.lblMessageSecteur.Name = "lblMessageSecteur";
            this.lblMessageSecteur.Size = new System.Drawing.Size(0, 16);
            this.lblMessageSecteur.TabIndex = 3;
            // 
            // btnAjout
            // 
            this.btnAjout.Location = new System.Drawing.Point(365, 160);
            this.btnAjout.Name = "btnAjout";
            this.btnAjout.Size = new System.Drawing.Size(75, 23);
            this.btnAjout.TabIndex = 4;
            this.btnAjout.Text = "Ajouter";
            this.btnAjout.UseVisualStyleBackColor = true;
            this.btnAjout.Click += new System.EventHandler(this.btnAjout_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // FormAjoutSecteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 392);
            this.Controls.Add(this.btnAjout);
            this.Controls.Add(this.lblMessageSecteur);
            this.Controls.Add(this.labelSecteur);
            this.Controls.Add(this.tbxNomSecteur);
            this.Name = "FormAjoutSecteur";
            this.Text = "FormAjoutSecteur";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxNomSecteur;
        private System.Windows.Forms.Label labelSecteur;
        private System.Windows.Forms.Label lblMessageSecteur;
        private System.Windows.Forms.Button btnAjout;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}