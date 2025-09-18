namespace ExperCT
{
    partial class FrmConnexionTechnicien
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
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtMotDePasse = new TextBox();
            txtNom = new TextBox();
            btnConnexion = new Button();
            label4 = new Label();
            txtPrenom = new TextBox();
            SuspendLayout();
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(67, 31);
            label3.Name = "label3";
            label3.Size = new Size(271, 20);
            label3.TabIndex = 9;
            label3.Text = "Me connecter à mon compte technicien";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 177);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 8;
            label2.Text = "Mot de passe";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 103);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 7;
            label1.Text = "Nom";
            // 
            // txtMotDePasse
            // 
            txtMotDePasse.Location = new Point(129, 174);
            txtMotDePasse.Name = "txtMotDePasse";
            txtMotDePasse.Size = new Size(193, 27);
            txtMotDePasse.TabIndex = 6;
            txtMotDePasse.UseSystemPasswordChar = true;
            // 
            // txtNom
            // 
            txtNom.Location = new Point(129, 103);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(193, 27);
            txtNom.TabIndex = 5;
            // 
            // btnConnexion
            // 
            btnConnexion.Location = new Point(143, 233);
            btnConnexion.Name = "btnConnexion";
            btnConnexion.Size = new Size(159, 34);
            btnConnexion.TabIndex = 10;
            btnConnexion.Text = "Me connecter";
            btnConnexion.UseVisualStyleBackColor = true;
            btnConnexion.Click += btnConnexion_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(53, 148);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 12;
            label4.Text = "Prénom";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtPrenom
            // 
            txtPrenom.Location = new Point(129, 141);
            txtPrenom.Name = "txtPrenom";
            txtPrenom.Size = new Size(193, 27);
            txtPrenom.TabIndex = 11;
            // 
            // FrmConnexionTechnicien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 326);
            Controls.Add(label4);
            Controls.Add(txtPrenom);
            Controls.Add(btnConnexion);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtMotDePasse);
            Controls.Add(txtNom);
            Font = new Font("Segoe UI", 11F);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmConnexionTechnicien";
            Text = "FrmConnexionTechnicien";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtMotDePasse;
        private TextBox txtNom;
        private Button btnConnexion;
        private Label label4;
        private TextBox txtPrenom;
    }
}