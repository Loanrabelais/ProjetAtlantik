namespace ProjetAtlantik
{
    partial class FormAcceuil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAjouterSecteur = new System.Windows.Forms.Button();
            this.btnAjoutPort = new System.Windows.Forms.Button();
            this.AjoutLiaison = new System.Windows.Forms.Button();
            this.btnAjoutTarif = new System.Windows.Forms.Button();
            this.btnAjoutBateau = new System.Windows.Forms.Button();
            this.btnAjoutTraverse = new System.Windows.Forms.Button();
            this.btnAfficherTraverse = new System.Windows.Forms.Button();
            this.btnAjoutDetail = new System.Windows.Forms.Button();
            this.btnParamSite = new System.Windows.Forms.Button();
            this.btnModifierBateau = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAjouterSecteur
            // 
            this.btnAjouterSecteur.Location = new System.Drawing.Point(130, 56);
            this.btnAjouterSecteur.Name = "btnAjouterSecteur";
            this.btnAjouterSecteur.Size = new System.Drawing.Size(899, 23);
            this.btnAjouterSecteur.TabIndex = 0;
            this.btnAjouterSecteur.Text = "Ajouter un Secteur";
            this.btnAjouterSecteur.UseVisualStyleBackColor = true;
            this.btnAjouterSecteur.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAjoutPort
            // 
            this.btnAjoutPort.Location = new System.Drawing.Point(130, 85);
            this.btnAjoutPort.Name = "btnAjoutPort";
            this.btnAjoutPort.Size = new System.Drawing.Size(899, 23);
            this.btnAjoutPort.TabIndex = 1;
            this.btnAjoutPort.Text = "Ajouter un Port";
            this.btnAjoutPort.UseVisualStyleBackColor = true;
            this.btnAjoutPort.Click += new System.EventHandler(this.button2_Click);
            // 
            // AjoutLiaison
            // 
            this.AjoutLiaison.Location = new System.Drawing.Point(130, 114);
            this.AjoutLiaison.Name = "AjoutLiaison";
            this.AjoutLiaison.Size = new System.Drawing.Size(899, 23);
            this.AjoutLiaison.TabIndex = 2;
            this.AjoutLiaison.Text = "Ajouter une Liaison";
            this.AjoutLiaison.UseVisualStyleBackColor = true;
            this.AjoutLiaison.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnAjoutTarif
            // 
            this.btnAjoutTarif.Location = new System.Drawing.Point(130, 143);
            this.btnAjoutTarif.Name = "btnAjoutTarif";
            this.btnAjoutTarif.Size = new System.Drawing.Size(899, 23);
            this.btnAjoutTarif.TabIndex = 3;
            this.btnAjoutTarif.Text = "Ajouter un Tarif pour une liaison et une période";
            this.btnAjoutTarif.UseVisualStyleBackColor = true;
            this.btnAjoutTarif.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnAjoutBateau
            // 
            this.btnAjoutBateau.Location = new System.Drawing.Point(130, 172);
            this.btnAjoutBateau.Name = "btnAjoutBateau";
            this.btnAjoutBateau.Size = new System.Drawing.Size(446, 23);
            this.btnAjoutBateau.TabIndex = 4;
            this.btnAjoutBateau.Text = "Ajouter un Bateau";
            this.btnAjoutBateau.UseVisualStyleBackColor = true;
            this.btnAjoutBateau.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnAjoutTraverse
            // 
            this.btnAjoutTraverse.Location = new System.Drawing.Point(130, 201);
            this.btnAjoutTraverse.Name = "btnAjoutTraverse";
            this.btnAjoutTraverse.Size = new System.Drawing.Size(899, 23);
            this.btnAjoutTraverse.TabIndex = 5;
            this.btnAjoutTraverse.Text = "Ajouter une Traversée";
            this.btnAjoutTraverse.UseVisualStyleBackColor = true;
            this.btnAjoutTraverse.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnAfficherTraverse
            // 
            this.btnAfficherTraverse.Location = new System.Drawing.Point(130, 230);
            this.btnAfficherTraverse.Name = "btnAfficherTraverse";
            this.btnAfficherTraverse.Size = new System.Drawing.Size(899, 23);
            this.btnAfficherTraverse.TabIndex = 6;
            this.btnAfficherTraverse.Text = "Afficher une Traversée pour une liaison et une date donné avec place restante par" +
    " catégories";
            this.btnAfficherTraverse.UseVisualStyleBackColor = true;
            this.btnAfficherTraverse.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnAjoutDetail
            // 
            this.btnAjoutDetail.Location = new System.Drawing.Point(130, 259);
            this.btnAjoutDetail.Name = "btnAjoutDetail";
            this.btnAjoutDetail.Size = new System.Drawing.Size(899, 23);
            this.btnAjoutDetail.TabIndex = 7;
            this.btnAjoutDetail.Text = "Ajouter un Detail";
            this.btnAjoutDetail.UseVisualStyleBackColor = true;
            this.btnAjoutDetail.Click += new System.EventHandler(this.button8_Click);
            // 
            // btnParamSite
            // 
            this.btnParamSite.Location = new System.Drawing.Point(130, 288);
            this.btnParamSite.Name = "btnParamSite";
            this.btnParamSite.Size = new System.Drawing.Size(899, 23);
            this.btnParamSite.TabIndex = 8;
            this.btnParamSite.Text = "Modifier les Parametres du site";
            this.btnParamSite.UseVisualStyleBackColor = true;
            this.btnParamSite.Click += new System.EventHandler(this.button9_Click);
            // 
            // btnModifierBateau
            // 
            this.btnModifierBateau.Location = new System.Drawing.Point(582, 172);
            this.btnModifierBateau.Name = "btnModifierBateau";
            this.btnModifierBateau.Size = new System.Drawing.Size(447, 23);
            this.btnModifierBateau.TabIndex = 9;
            this.btnModifierBateau.Text = "Modifier un Bateau";
            this.btnModifierBateau.UseVisualStyleBackColor = true;
            this.btnModifierBateau.Click += new System.EventHandler(this.btnModifierBateau_Click);
            // 
            // FormAcceuil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 391);
            this.Controls.Add(this.btnModifierBateau);
            this.Controls.Add(this.btnParamSite);
            this.Controls.Add(this.btnAjoutDetail);
            this.Controls.Add(this.btnAfficherTraverse);
            this.Controls.Add(this.btnAjoutTraverse);
            this.Controls.Add(this.btnAjoutBateau);
            this.Controls.Add(this.btnAjoutTarif);
            this.Controls.Add(this.AjoutLiaison);
            this.Controls.Add(this.btnAjoutPort);
            this.Controls.Add(this.btnAjouterSecteur);
            this.Name = "FormAcceuil";
            this.Text = "Acceuil";
            this.Load += new System.EventHandler(this.FormAcceuil_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAjouterSecteur;
        private System.Windows.Forms.Button btnAjoutPort;
        private System.Windows.Forms.Button AjoutLiaison;
        private System.Windows.Forms.Button btnAjoutTarif;
        private System.Windows.Forms.Button btnAjoutBateau;
        private System.Windows.Forms.Button btnAjoutTraverse;
        private System.Windows.Forms.Button btnAfficherTraverse;
        private System.Windows.Forms.Button btnAjoutDetail;
        private System.Windows.Forms.Button btnParamSite;
        private System.Windows.Forms.Button btnModifierBateau;
    }
}

