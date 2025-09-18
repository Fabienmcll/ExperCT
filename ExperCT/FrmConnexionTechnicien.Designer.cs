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
            txtMail = new TextBox();
            btnConnexion = new Button();
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
            label2.Location = new Point(15, 150);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 8;
            label2.Text = "Mot de passe";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 106);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 7;
            label1.Text = "Email";
            // 
            // txtMotDePasse
            // 
            txtMotDePasse.Location = new Point(129, 147);
            txtMotDePasse.Name = "txtMotDePasse";
            txtMotDePasse.Size = new Size(193, 27);
            txtMotDePasse.TabIndex = 6;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(129, 103);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(193, 27);
            txtMail.TabIndex = 5;
            // 
            // btnConnexion
            // 
            btnConnexion.Location = new Point(145, 180);
            btnConnexion.Name = "btnConnexion";
            btnConnexion.Size = new Size(159, 34);
            btnConnexion.TabIndex = 10;
            btnConnexion.Text = "Me connecter";
            btnConnexion.UseVisualStyleBackColor = true;
            // 
            // FrmConnexionTechnicien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 240);
            Controls.Add(btnConnexion);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtMotDePasse);
            Controls.Add(txtMail);
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
        private TextBox txtMail;
        private Button btnConnexion;
    }
}