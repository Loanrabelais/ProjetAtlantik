namespace ProjetAtlantik
{
    partial class FormAfficherReservation
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
            this.lblNomPrenom = new System.Windows.Forms.Label();
            this.lblMessageReservation = new System.Windows.Forms.Label();
            this.gbxDetails = new System.Windows.Forms.GroupBox();
            this.lvResevation = new System.Windows.Forms.ListView();
            this.cmbClient = new System.Windows.Forms.ComboBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomPrenom
            // 
            this.lblNomPrenom.AutoSize = true;
            this.lblNomPrenom.Location = new System.Drawing.Point(13, 13);
            this.lblNomPrenom.Name = "lblNomPrenom";
            this.lblNomPrenom.Size = new System.Drawing.Size(92, 16);
            this.lblNomPrenom.TabIndex = 0;
            this.lblNomPrenom.Text = "Nom, Prénom:";
            // 
            // lblMessageReservation
            // 
            this.lblMessageReservation.AutoSize = true;
            this.lblMessageReservation.Location = new System.Drawing.Point(16, 422);
            this.lblMessageReservation.Name = "lblMessageReservation";
            this.lblMessageReservation.Size = new System.Drawing.Size(0, 16);
            this.lblMessageReservation.TabIndex = 3;
            // 
            // gbxDetails
            // 
            this.gbxDetails.Location = new System.Drawing.Point(239, 186);
            this.gbxDetails.Name = "gbxDetails";
            this.gbxDetails.Size = new System.Drawing.Size(549, 287);
            this.gbxDetails.TabIndex = 5;
            this.gbxDetails.TabStop = false;
            this.gbxDetails.Text = "Détails de la réservation";
            // 
            // lvResevation
            // 
            this.lvResevation.HideSelection = false;
            this.lvResevation.Location = new System.Drawing.Point(239, 12);
            this.lvResevation.Name = "lvResevation";
            this.lvResevation.Size = new System.Drawing.Size(549, 168);
            this.lvResevation.TabIndex = 6;
            this.lvResevation.UseCompatibleStateImageBehavior = false;
            this.lvResevation.View = System.Windows.Forms.View.Details;
            this.lvResevation.SelectedIndexChanged += new System.EventHandler(this.lvResevation_SelectedIndexChanged);
            // 
            // cmbClient
            // 
            this.cmbClient.FormattingEnabled = true;
            this.cmbClient.Location = new System.Drawing.Point(112, 13);
            this.cmbClient.Name = "cmbClient";
            this.cmbClient.Size = new System.Drawing.Size(121, 24);
            this.cmbClient.TabIndex = 7;
            this.cmbClient.SelectedIndexChanged += new System.EventHandler(this.cmbClient_SelectedIndexChanged);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // FormAfficherReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.cmbClient);
            this.Controls.Add(this.lvResevation);
            this.Controls.Add(this.gbxDetails);
            this.Controls.Add(this.lblMessageReservation);
            this.Controls.Add(this.lblNomPrenom);
            this.Name = "FormAfficherReservation";
            this.Text = "FormAfficherReservation";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomPrenom;
        private System.Windows.Forms.Label lblMessageReservation;
        private System.Windows.Forms.GroupBox gbxDetails;
        private System.Windows.Forms.ListView lvResevation;
        private System.Windows.Forms.ComboBox cmbClient;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}