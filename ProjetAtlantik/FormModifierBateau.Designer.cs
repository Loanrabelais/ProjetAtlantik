namespace ProjetAtlantik
{
    partial class FormModifierBateau
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
            this.btnModifer = new System.Windows.Forms.Button();
            this.lblNomBateau = new System.Windows.Forms.Label();
            this.cmbBateau = new System.Windows.Forms.ComboBox();
            this.lblMessageBateau = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gbxCapacite
            // 
            this.gbxCapacite.Location = new System.Drawing.Point(486, 13);
            this.gbxCapacite.Name = "gbxCapacite";
            this.gbxCapacite.Size = new System.Drawing.Size(302, 382);
            this.gbxCapacite.TabIndex = 0;
            this.gbxCapacite.TabStop = false;
            this.gbxCapacite.Text = "Capacités Maximales";
            // 
            // btnModifer
            // 
            this.btnModifer.Location = new System.Drawing.Point(405, 372);
            this.btnModifer.Name = "btnModifer";
            this.btnModifer.Size = new System.Drawing.Size(75, 23);
            this.btnModifer.TabIndex = 1;
            this.btnModifer.Text = "Modifer";
            this.btnModifer.UseVisualStyleBackColor = true;
            this.btnModifer.Click += new System.EventHandler(this.btnModifer_Click);
            // 
            // lblNomBateau
            // 
            this.lblNomBateau.AutoSize = true;
            this.lblNomBateau.Location = new System.Drawing.Point(14, 16);
            this.lblNomBateau.Name = "lblNomBateau";
            this.lblNomBateau.Size = new System.Drawing.Size(87, 16);
            this.lblNomBateau.TabIndex = 2;
            this.lblNomBateau.Text = "Nom bateau :";
            // 
            // cmbBateau
            // 
            this.cmbBateau.FormattingEnabled = true;
            this.cmbBateau.Location = new System.Drawing.Point(107, 13);
            this.cmbBateau.Name = "cmbBateau";
            this.cmbBateau.Size = new System.Drawing.Size(190, 24);
            this.cmbBateau.TabIndex = 3;
            this.cmbBateau.SelectedIndexChanged += new System.EventHandler(this.cmbBateau_SelectedIndexChanged);
            // 
            // lblMessageBateau
            // 
            this.lblMessageBateau.AutoSize = true;
            this.lblMessageBateau.Location = new System.Drawing.Point(13, 422);
            this.lblMessageBateau.Name = "lblMessageBateau";
            this.lblMessageBateau.Size = new System.Drawing.Size(0, 16);
            this.lblMessageBateau.TabIndex = 4;
            // 
            // FormModifierBateau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMessageBateau);
            this.Controls.Add(this.cmbBateau);
            this.Controls.Add(this.lblNomBateau);
            this.Controls.Add(this.btnModifer);
            this.Controls.Add(this.gbxCapacite);
            this.Name = "FormModifierBateau";
            this.Text = "FormModifierBateau";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxCapacite;
        private System.Windows.Forms.Button btnModifer;
        private System.Windows.Forms.Label lblNomBateau;
        private System.Windows.Forms.ComboBox cmbBateau;
        private System.Windows.Forms.Label lblMessageBateau;
    }
}