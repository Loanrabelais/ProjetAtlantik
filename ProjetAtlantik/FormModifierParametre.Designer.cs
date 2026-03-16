namespace ProjetAtlantik
{
    partial class FormModifierParametre
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
            this.lblSite = new System.Windows.Forms.Label();
            this.lblRang = new System.Windows.Forms.Label();
            this.lblIdentifiant = new System.Windows.Forms.Label();
            this.lblCle = new System.Windows.Forms.Label();
            this.txbSite = new System.Windows.Forms.TextBox();
            this.txbRang = new System.Windows.Forms.TextBox();
            this.txbIdentifiant = new System.Windows.Forms.TextBox();
            this.txbCle = new System.Windows.Forms.TextBox();
            this.txbMel = new System.Windows.Forms.TextBox();
            this.lblMel = new System.Windows.Forms.Label();
            this.cbxProduction = new System.Windows.Forms.CheckBox();
            this.lblMessageParametre = new System.Windows.Forms.Label();
            this.btnModifier = new System.Windows.Forms.Button();
            this.gbxIdentifiant = new System.Windows.Forms.GroupBox();
            this.gbxIdentifiant.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSite
            // 
            this.lblSite.AutoSize = true;
            this.lblSite.Location = new System.Drawing.Point(21, 35);
            this.lblSite.Name = "lblSite";
            this.lblSite.Size = new System.Drawing.Size(36, 16);
            this.lblSite.TabIndex = 0;
            this.lblSite.Text = "Site :";
            // 
            // lblRang
            // 
            this.lblRang.AutoSize = true;
            this.lblRang.Location = new System.Drawing.Point(21, 63);
            this.lblRang.Name = "lblRang";
            this.lblRang.Size = new System.Drawing.Size(46, 16);
            this.lblRang.TabIndex = 1;
            this.lblRang.Text = "Rang :";
            // 
            // lblIdentifiant
            // 
            this.lblIdentifiant.AutoSize = true;
            this.lblIdentifiant.Location = new System.Drawing.Point(21, 91);
            this.lblIdentifiant.Name = "lblIdentifiant";
            this.lblIdentifiant.Size = new System.Drawing.Size(69, 16);
            this.lblIdentifiant.TabIndex = 2;
            this.lblIdentifiant.Text = "Identifiant :";
            // 
            // lblCle
            // 
            this.lblCle.AutoSize = true;
            this.lblCle.Location = new System.Drawing.Point(21, 119);
            this.lblCle.Name = "lblCle";
            this.lblCle.Size = new System.Drawing.Size(75, 16);
            this.lblCle.TabIndex = 3;
            this.lblCle.Text = "Cle HMAC :";
            // 
            // txbSite
            // 
            this.txbSite.Location = new System.Drawing.Point(132, 35);
            this.txbSite.Name = "txbSite";
            this.txbSite.Size = new System.Drawing.Size(100, 22);
            this.txbSite.TabIndex = 4;
            // 
            // txbRang
            // 
            this.txbRang.Location = new System.Drawing.Point(132, 63);
            this.txbRang.Name = "txbRang";
            this.txbRang.Size = new System.Drawing.Size(46, 22);
            this.txbRang.TabIndex = 5;
            // 
            // txbIdentifiant
            // 
            this.txbIdentifiant.Location = new System.Drawing.Point(132, 91);
            this.txbIdentifiant.Name = "txbIdentifiant";
            this.txbIdentifiant.Size = new System.Drawing.Size(118, 22);
            this.txbIdentifiant.TabIndex = 6;
            // 
            // txbCle
            // 
            this.txbCle.Location = new System.Drawing.Point(132, 119);
            this.txbCle.Multiline = true;
            this.txbCle.Name = "txbCle";
            this.txbCle.Size = new System.Drawing.Size(190, 79);
            this.txbCle.TabIndex = 7;
            // 
            // txbMel
            // 
            this.txbMel.Location = new System.Drawing.Point(209, 266);
            this.txbMel.Name = "txbMel";
            this.txbMel.Size = new System.Drawing.Size(147, 22);
            this.txbMel.TabIndex = 8;
            // 
            // lblMel
            // 
            this.lblMel.AutoSize = true;
            this.lblMel.Location = new System.Drawing.Point(126, 272);
            this.lblMel.Name = "lblMel";
            this.lblMel.Size = new System.Drawing.Size(77, 16);
            this.lblMel.TabIndex = 9;
            this.lblMel.Text = "Mél du site :";
            // 
            // cbxProduction
            // 
            this.cbxProduction.AutoSize = true;
            this.cbxProduction.Location = new System.Drawing.Point(244, 240);
            this.cbxProduction.Name = "cbxProduction";
            this.cbxProduction.Size = new System.Drawing.Size(112, 20);
            this.cbxProduction.TabIndex = 11;
            this.cbxProduction.Text = "En Production";
            this.cbxProduction.UseVisualStyleBackColor = true;
            // 
            // lblMessageParametre
            // 
            this.lblMessageParametre.AutoSize = true;
            this.lblMessageParametre.Location = new System.Drawing.Point(13, 333);
            this.lblMessageParametre.Name = "lblMessageParametre";
            this.lblMessageParametre.Size = new System.Drawing.Size(0, 16);
            this.lblMessageParametre.TabIndex = 12;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(209, 294);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(147, 23);
            this.btnModifier.TabIndex = 13;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // gbxIdentifiant
            // 
            this.gbxIdentifiant.Controls.Add(this.txbSite);
            this.gbxIdentifiant.Controls.Add(this.lblSite);
            this.gbxIdentifiant.Controls.Add(this.txbRang);
            this.gbxIdentifiant.Controls.Add(this.lblRang);
            this.gbxIdentifiant.Controls.Add(this.txbIdentifiant);
            this.gbxIdentifiant.Controls.Add(this.lblIdentifiant);
            this.gbxIdentifiant.Controls.Add(this.txbCle);
            this.gbxIdentifiant.Controls.Add(this.lblCle);
            this.gbxIdentifiant.Location = new System.Drawing.Point(16, 15);
            this.gbxIdentifiant.Name = "gbxIdentifiant";
            this.gbxIdentifiant.Size = new System.Drawing.Size(340, 219);
            this.gbxIdentifiant.TabIndex = 14;
            this.gbxIdentifiant.TabStop = false;
            this.gbxIdentifiant.Text = "Identifiant PayBox";
            // 
            // FormModifierParametre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 361);
            this.Controls.Add(this.gbxIdentifiant);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.lblMessageParametre);
            this.Controls.Add(this.cbxProduction);
            this.Controls.Add(this.lblMel);
            this.Controls.Add(this.txbMel);
            this.Name = "FormModifierParametre";
            this.Text = "FormModifierParametre";
            this.gbxIdentifiant.ResumeLayout(false);
            this.gbxIdentifiant.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSite;
        private System.Windows.Forms.Label lblRang;
        private System.Windows.Forms.Label lblIdentifiant;
        private System.Windows.Forms.Label lblCle;
        private System.Windows.Forms.TextBox txbSite;
        private System.Windows.Forms.TextBox txbRang;
        private System.Windows.Forms.TextBox txbIdentifiant;
        private System.Windows.Forms.TextBox txbCle;
        private System.Windows.Forms.TextBox txbMel;
        private System.Windows.Forms.Label lblMel;
        private System.Windows.Forms.CheckBox cbxProduction;
        private System.Windows.Forms.Label lblMessageParametre;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.GroupBox gbxIdentifiant;
    }
}