namespace ExperCT
{
    partial class FrmClientControleTechnique
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
            label1 = new Label();
            lblNumRef = new Label();
            label2 = new Label();
            lblDatePassage = new Label();
            label3 = new Label();
            label4 = new Label();
            lblDefaillance = new Label();
            label5 = new Label();
            lblPointControle = new Label();
            label6 = new Label();
            label7 = new Label();
            lblCriticite = new Label();
            btnFermer = new Button();
            lblTechnicien = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(238, 9);
            label1.Name = "label1";
            label1.Size = new Size(142, 20);
            label1.TabIndex = 0;
            label1.Text = "Controle technique :";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblNumRef
            // 
            lblNumRef.AutoSize = true;
            lblNumRef.Location = new Point(475, 9);
            lblNumRef.Name = "lblNumRef";
            lblNumRef.Size = new Size(50, 20);
            lblNumRef.TabIndex = 1;
            lblNumRef.Text = "label2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(238, 46);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 2;
            label2.Text = "Effectué le :";
            // 
            // lblDatePassage
            // 
            lblDatePassage.AutoSize = true;
            lblDatePassage.Location = new Point(475, 46);
            lblDatePassage.Name = "lblDatePassage";
            lblDatePassage.Size = new Size(50, 20);
            lblDatePassage.TabIndex = 3;
            lblDatePassage.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 134);
            label3.Name = "label3";
            label3.Size = new Size(113, 20);
            label3.TabIndex = 4;
            label3.Text = "Compte-rendu :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 184);
            label4.Name = "label4";
            label4.Size = new Size(91, 20);
            label4.TabIndex = 5;
            label4.Text = "Défaillance :";
            // 
            // lblDefaillance
            // 
            lblDefaillance.AutoSize = true;
            lblDefaillance.Location = new Point(158, 184);
            lblDefaillance.Name = "lblDefaillance";
            lblDefaillance.Size = new Size(50, 20);
            lblDefaillance.TabIndex = 6;
            lblDefaillance.Text = "label2";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 226);
            label5.Name = "label5";
            label5.Size = new Size(129, 20);
            label5.TabIndex = 7;
            label5.Text = "Point de contrôle :";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblPointControle
            // 
            lblPointControle.AutoSize = true;
            lblPointControle.Location = new Point(158, 226);
            lblPointControle.Name = "lblPointControle";
            lblPointControle.Size = new Size(50, 20);
            lblPointControle.TabIndex = 8;
            lblPointControle.Text = "label2";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(331, 184);
            label6.Name = "label6";
            label6.Size = new Size(67, 20);
            label6.TabIndex = 9;
            label6.Text = "Criticité :";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(983, 447);
            label7.Name = "label7";
            label7.Size = new Size(50, 20);
            label7.TabIndex = 10;
            label7.Text = "label2";
            // 
            // lblCriticite
            // 
            lblCriticite.AutoSize = true;
            lblCriticite.Location = new Point(404, 184);
            lblCriticite.Name = "lblCriticite";
            lblCriticite.Size = new Size(50, 20);
            lblCriticite.TabIndex = 11;
            lblCriticite.Text = "label2";
            // 
            // btnFermer
            // 
            btnFermer.Location = new Point(404, 255);
            btnFermer.Name = "btnFermer";
            btnFermer.Size = new Size(100, 29);
            btnFermer.TabIndex = 12;
            btnFermer.Text = "Fermer";
            btnFermer.UseVisualStyleBackColor = true;
            btnFermer.Click += btnFermer_Click;
            // 
            // lblTechnicien
            // 
            lblTechnicien.AutoSize = true;
            lblTechnicien.Location = new Point(745, 9);
            lblTechnicien.Name = "lblTechnicien";
            lblTechnicien.Size = new Size(105, 20);
            lblTechnicien.TabIndex = 13;
            lblTechnicien.Text = "nom - prenom";
            // 
            // FrmClientControleTechnique
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(886, 308);
            Controls.Add(lblTechnicien);
            Controls.Add(btnFermer);
            Controls.Add(lblCriticite);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(lblPointControle);
            Controls.Add(label5);
            Controls.Add(lblDefaillance);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblDatePassage);
            Controls.Add(label2);
            Controls.Add(lblNumRef);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 11F);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmClientControleTechnique";
            Text = "Rapport contrôle technique";
            Load += FrmClientControleTechnique_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblNumRef;
        private Label label2;
        private Label lblDatePassage;
        private Label label3;
        private Label label4;
        private Label lblDefaillance;
        private Label label5;
        private Label lblPointControle;
        private Label label6;
        private Label label7;
        private Label lblCriticite;
        private Button btnFermer;
        private Label lblTechnicien;
    }
}