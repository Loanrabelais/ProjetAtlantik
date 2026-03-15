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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.actionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUnSecteurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUnPortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUneLiaisonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUnTarifToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUnBateauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierUnBateauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUneTraverseeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherUneTraverseeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherUnDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierUnParametreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(853, 28);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // actionToolStripMenuItem
            // 
            this.actionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUnSecteurToolStripMenuItem,
            this.ajouterUnPortToolStripMenuItem,
            this.ajouterUneLiaisonToolStripMenuItem,
            this.ajouterUnTarifToolStripMenuItem,
            this.ajouterUnBateauToolStripMenuItem,
            this.modifierUnBateauToolStripMenuItem,
            this.ajouterUneTraverseeToolStripMenuItem,
            this.afficherUneTraverseeToolStripMenuItem,
            this.afficherUnDetailToolStripMenuItem,
            this.modifierUnParametreToolStripMenuItem});
            this.actionToolStripMenuItem.Name = "actionToolStripMenuItem";
            this.actionToolStripMenuItem.Size = new System.Drawing.Size(41, 24);
            this.actionToolStripMenuItem.Text = "tre";
            // 
            // ajouterUnSecteurToolStripMenuItem
            // 
            this.ajouterUnSecteurToolStripMenuItem.Name = "ajouterUnSecteurToolStripMenuItem";
            this.ajouterUnSecteurToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.ajouterUnSecteurToolStripMenuItem.Text = "Ajouter un Secteur";
            this.ajouterUnSecteurToolStripMenuItem.Click += new System.EventHandler(this.ajouterUnSecteurToolStripMenuItem_Click);
            // 
            // ajouterUnPortToolStripMenuItem
            // 
            this.ajouterUnPortToolStripMenuItem.Name = "ajouterUnPortToolStripMenuItem";
            this.ajouterUnPortToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.ajouterUnPortToolStripMenuItem.Text = "Ajouter un Port";
            this.ajouterUnPortToolStripMenuItem.Click += new System.EventHandler(this.ajouterUnPortToolStripMenuItem_Click);
            // 
            // ajouterUneLiaisonToolStripMenuItem
            // 
            this.ajouterUneLiaisonToolStripMenuItem.Name = "ajouterUneLiaisonToolStripMenuItem";
            this.ajouterUneLiaisonToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.ajouterUneLiaisonToolStripMenuItem.Text = "Ajouter une liaison";
            this.ajouterUneLiaisonToolStripMenuItem.Click += new System.EventHandler(this.ajouterUneLiaisonToolStripMenuItem_Click);
            // 
            // ajouterUnTarifToolStripMenuItem
            // 
            this.ajouterUnTarifToolStripMenuItem.Name = "ajouterUnTarifToolStripMenuItem";
            this.ajouterUnTarifToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.ajouterUnTarifToolStripMenuItem.Text = "Ajouter un Tarif";
            this.ajouterUnTarifToolStripMenuItem.Click += new System.EventHandler(this.ajouterUnTarifToolStripMenuItem_Click);
            // 
            // ajouterUnBateauToolStripMenuItem
            // 
            this.ajouterUnBateauToolStripMenuItem.Name = "ajouterUnBateauToolStripMenuItem";
            this.ajouterUnBateauToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.ajouterUnBateauToolStripMenuItem.Text = "Ajouter un Bateau";
            this.ajouterUnBateauToolStripMenuItem.Click += new System.EventHandler(this.ajouterUnBateauToolStripMenuItem_Click);
            // 
            // modifierUnBateauToolStripMenuItem
            // 
            this.modifierUnBateauToolStripMenuItem.Name = "modifierUnBateauToolStripMenuItem";
            this.modifierUnBateauToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.modifierUnBateauToolStripMenuItem.Text = "Modifier un Bateau";
            this.modifierUnBateauToolStripMenuItem.Click += new System.EventHandler(this.modifierUnBateauToolStripMenuItem_Click);
            // 
            // ajouterUneTraverseeToolStripMenuItem
            // 
            this.ajouterUneTraverseeToolStripMenuItem.Name = "ajouterUneTraverseeToolStripMenuItem";
            this.ajouterUneTraverseeToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.ajouterUneTraverseeToolStripMenuItem.Text = "Ajouter une Traversée";
            this.ajouterUneTraverseeToolStripMenuItem.Click += new System.EventHandler(this.ajouterUneTraverseeToolStripMenuItem_Click);
            // 
            // afficherUneTraverseeToolStripMenuItem
            // 
            this.afficherUneTraverseeToolStripMenuItem.Name = "afficherUneTraverseeToolStripMenuItem";
            this.afficherUneTraverseeToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.afficherUneTraverseeToolStripMenuItem.Text = "Afficher une Traversée";
            this.afficherUneTraverseeToolStripMenuItem.Click += new System.EventHandler(this.afficherUneTraverseeToolStripMenuItem_Click);
            // 
            // afficherUnDetailToolStripMenuItem
            // 
            this.afficherUnDetailToolStripMenuItem.Name = "afficherUnDetailToolStripMenuItem";
            this.afficherUnDetailToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.afficherUnDetailToolStripMenuItem.Text = "Afficher un détail";
            this.afficherUnDetailToolStripMenuItem.Click += new System.EventHandler(this.afficherUnDetailToolStripMenuItem_Click);
            // 
            // modifierUnParametreToolStripMenuItem
            // 
            this.modifierUnParametreToolStripMenuItem.Name = "modifierUnParametreToolStripMenuItem";
            this.modifierUnParametreToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.modifierUnParametreToolStripMenuItem.Text = "Modifier un Paramètre";
            this.modifierUnParametreToolStripMenuItem.Click += new System.EventHandler(this.modifierUnParametreToolStripMenuItem_Click);
            // 
            // FormAcceuil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 373);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormAcceuil";
            this.Text = "Acceuil";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem actionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnSecteurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnPortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUneLiaisonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnTarifToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnBateauToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierUnBateauToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUneTraverseeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afficherUneTraverseeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afficherUnDetailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierUnParametreToolStripMenuItem;
    }
}

