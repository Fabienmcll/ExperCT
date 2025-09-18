namespace ExperCT
{
    partial class FrmInscriptionClient
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
            btnConnexion = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtMotDePasse = new TextBox();
            txtMail = new TextBox();
            label4 = new Label();
            txtNom = new TextBox();
            label5 = new Label();
            txtPrenom = new TextBox();
            btnConnecter = new Button();
            SuspendLayout();
            // 
            // btnConnexion
            // 
            btnConnexion.Location = new Point(145, 185);
            btnConnexion.Name = "btnConnexion";
            btnConnexion.Size = new Size(159, 34);
            btnConnexion.TabIndex = 16;
            btnConnexion.Text = "M'inscrire";
            btnConnexion.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(190, 9);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 15;
            label3.Text = "M'inscrire";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 155);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 14;
            label2.Text = "Mot de passe";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 56);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 13;
            label1.Text = "Email";
            // 
            // txtMotDePasse
            // 
            txtMotDePasse.Location = new Point(129, 152);
            txtMotDePasse.Name = "txtMotDePasse";
            txtMotDePasse.Size = new Size(193, 27);
            txtMotDePasse.TabIndex = 12;
            txtMotDePasse.UseSystemPasswordChar = true;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(129, 53);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(193, 27);
            txtMail.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(67, 89);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 18;
            label4.Text = "Nom";
            // 
            // txtNom
            // 
            txtNom.Location = new Point(129, 86);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(193, 27);
            txtNom.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(49, 122);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 20;
            label5.Text = "Prénom";
            // 
            // txtPrenom
            // 
            txtPrenom.Location = new Point(129, 119);
            txtPrenom.Name = "txtPrenom";
            txtPrenom.Size = new Size(193, 27);
            txtPrenom.TabIndex = 19;
            // 
            // btnConnecter
            // 
            btnConnecter.Font = new Font("Segoe UI", 8F);
            btnConnecter.Location = new Point(295, 6);
            btnConnecter.Name = "btnConnecter";
            btnConnecter.Size = new Size(89, 23);
            btnConnecter.TabIndex = 21;
            btnConnecter.Text = "Me connecter";
            btnConnecter.UseVisualStyleBackColor = true;
            btnConnecter.Click += btnConnecter_Click;
            // 
            // FrmInscriptionClient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(396, 277);
            Controls.Add(btnConnecter);
            Controls.Add(label5);
            Controls.Add(txtPrenom);
            Controls.Add(label4);
            Controls.Add(txtNom);
            Controls.Add(btnConnexion);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtMotDePasse);
            Controls.Add(txtMail);
            Font = new Font("Segoe UI", 11F);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmInscriptionClient";
            Text = "InscriptionClient";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConnexion;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtMotDePasse;
        private TextBox txtMail;
        private Label label4;
        private TextBox txtNom;
        private Label label5;
        private TextBox txtPrenom;
        private Button btnConnecter;
    }
}