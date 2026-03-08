namespace ProjetAtlantik
{
    partial class FormAjoutBateau
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
            this.gbxCapacite = new System.Windows.Forms.GroupBox();
            this.btnAjout = new System.Windows.Forms.Button();
            this.tbxNomBateau = new System.Windows.Forms.TextBox();
            this.lblNomBateau = new System.Windows.Forms.Label();
            this.lblMessageBateau = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gbxCapacite
            // 
            this.gbxCapacite.Location = new System.Drawing.Point(417, 13);
            this.gbxCapacite.Name = "gbxCapacite";
            this.gbxCapacite.Size = new System.Drawing.Size(371, 367);
            this.gbxCapacite.TabIndex = 0;
            this.gbxCapacite.TabStop = false;
            this.gbxCapacite.Text = "Capacités Maximales";
            // 
            // btnAjout
            // 
            this.btnAjout.Location = new System.Drawing.Point(336, 357);
            this.btnAjout.Name = "btnAjout";
            this.btnAjout.Size = new System.Drawing.Size(75, 23);
            this.btnAjout.TabIndex = 1;
            this.btnAjout.Text = "Ajouter";
            this.btnAjout.UseVisualStyleBackColor = true;
            this.btnAjout.Click += new System.EventHandler(this.btnAjout_Click);
            // 
            // tbxNomBateau
            // 
            this.tbxNomBateau.Location = new System.Drawing.Point(125, 12);
            this.tbxNomBateau.Name = "tbxNomBateau";
            this.tbxNomBateau.Size = new System.Drawing.Size(100, 22);
            this.tbxNomBateau.TabIndex = 2;
            // 
            // lblNomBateau
            // 
            this.lblNomBateau.AutoSize = true;
            this.lblNomBateau.Location = new System.Drawing.Point(13, 18);
            this.lblNomBateau.Name = "lblNomBateau";
            this.lblNomBateau.Size = new System.Drawing.Size(106, 16);
            this.lblNomBateau.TabIndex = 3;
            this.lblNomBateau.Text = "Nom du Bateau :";
            // 
            // lblMessageBateau
            // 
            this.lblMessageBateau.AutoSize = true;
            this.lblMessageBateau.Location = new System.Drawing.Point(16, 422);
            this.lblMessageBateau.Name = "lblMessageBateau";
            this.lblMessageBateau.Size = new System.Drawing.Size(0, 16);
            this.lblMessageBateau.TabIndex = 4;
            // 
            // FormAjoutBateau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMessageBateau);
            this.Controls.Add(this.lblNomBateau);
            this.Controls.Add(this.tbxNomBateau);
            this.Controls.Add(this.btnAjout);
            this.Controls.Add(this.gbxCapacite);
            this.Name = "FormAjoutBateau";
            this.Text = "FormAjoutBateau";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxCapacite;
        private System.Windows.Forms.Button btnAjout;
        private System.Windows.Forms.TextBox tbxNomBateau;
        private System.Windows.Forms.Label lblNomBateau;
        private System.Windows.Forms.Label lblMessageBateau;
    }
}