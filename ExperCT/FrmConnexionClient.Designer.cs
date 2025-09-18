namespace ExperCT
{
    partial class FrmConnexionClient
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
            txtMail = new TextBox();
            txtMotDePasse = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnConnexion = new Button();
            btnInscrire = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtMail
            // 
            txtMail.Location = new Point(198, 129);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(193, 27);
            txtMail.TabIndex = 0;
            // 
            // txtMotDePasse
            // 
            txtMotDePasse.Location = new Point(198, 189);
            txtMotDePasse.Name = "txtMotDePasse";
            txtMotDePasse.Size = new Size(193, 27);
            txtMotDePasse.TabIndex = 1;
            txtMotDePasse.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(198, 106);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 2;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(198, 166);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 3;
            label2.Text = "Mot de passe";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(123, 318);
            label3.Name = "label3";
            label3.Size = new Size(235, 20);
            label3.TabIndex = 4;
            label3.Text = "Me connecter à mon espace client";
            // 
            // btnConnexion
            // 
            btnConnexion.BackColor = SystemColors.HotTrack;
            btnConnexion.FlatStyle = FlatStyle.Flat;
            btnConnexion.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConnexion.ForeColor = Color.White;
            btnConnexion.Location = new Point(210, 240);
            btnConnexion.Name = "btnConnexion";
            btnConnexion.Size = new Size(159, 49);
            btnConnexion.TabIndex = 5;
            btnConnexion.Text = "Me connecter";
            btnConnexion.UseVisualStyleBackColor = false;
            btnConnexion.Click += btnConnexion_Click;
            // 
            // btnInscrire
            // 
            btnInscrire.Font = new Font("Segoe UI", 8F);
            btnInscrire.Location = new Point(364, 318);
            btnInscrire.Name = "btnInscrire";
            btnInscrire.Size = new Size(75, 23);
            btnInscrire.TabIndex = 6;
            btnInscrire.Text = "M'inscrire";
            btnInscrire.UseVisualStyleBackColor = true;
            btnInscrire.Click += btnInscrire_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(226, 47);
            label4.Name = "label4";
            label4.Size = new Size(110, 25);
            label4.TabIndex = 7;
            label4.Text = "Connexion";
            // 
            // FrmConnexionClient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(594, 399);
            Controls.Add(label4);
            Controls.Add(btnInscrire);
            Controls.Add(btnConnexion);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtMotDePasse);
            Controls.Add(txtMail);
            Font = new Font("Segoe UI", 11F);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmConnexionClient";
            Text = "FrmConnexionClient";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMail;
        private TextBox txtMotDePasse;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnConnexion;
        private Button btnInscrire;
        private Label label4;
    }
}