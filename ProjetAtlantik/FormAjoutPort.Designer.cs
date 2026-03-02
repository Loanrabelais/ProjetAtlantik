namespace ProjetAtlantik
{
    partial class FormAjoutPort
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
            this.lblMessagePort = new System.Windows.Forms.Label();
            this.btnAjoutPort = new System.Windows.Forms.Button();
            this.labelPort = new System.Windows.Forms.Label();
            this.tbxNomPort = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblMessagePort
            // 
            this.lblMessagePort.AutoSize = true;
            this.lblMessagePort.Location = new System.Drawing.Point(445, 208);
            this.lblMessagePort.Name = "lblMessagePort";
            this.lblMessagePort.Size = new System.Drawing.Size(0, 16);
            this.lblMessagePort.TabIndex = 7;
            // 
            // btnAjoutPort
            // 
            this.btnAjoutPort.Location = new System.Drawing.Point(432, 244);
            this.btnAjoutPort.Name = "btnAjoutPort";
            this.btnAjoutPort.Size = new System.Drawing.Size(75, 23);
            this.btnAjoutPort.TabIndex = 6;
            this.btnAjoutPort.Text = "Ajouter";
            this.btnAjoutPort.UseVisualStyleBackColor = true;
            this.btnAjoutPort.Click += new System.EventHandler(this.btnAjoutPort_Click);
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(282, 186);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(107, 16);
            this.labelPort.TabIndex = 5;
            this.labelPort.Text = "Nom du secteur :";
            // 
            // tbxNomPort
            // 
            this.tbxNomPort.Location = new System.Drawing.Point(419, 183);
            this.tbxNomPort.Name = "tbxNomPort";
            this.tbxNomPort.Size = new System.Drawing.Size(100, 22);
            this.tbxNomPort.TabIndex = 4;
            // 
            // FormAjoutPort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMessagePort);
            this.Controls.Add(this.btnAjoutPort);
            this.Controls.Add(this.labelPort);
            this.Controls.Add(this.tbxNomPort);
            this.Name = "FormAjoutPort";
            this.Text = "FormAjoutPort";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessagePort;
        private System.Windows.Forms.Button btnAjoutPort;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.TextBox tbxNomPort;
    }
}