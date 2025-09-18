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
            label4 = new Label();
            lblDefaillance = new Label();
            label5 = new Label();
            lblPointControle = new Label();
            label6 = new Label();
            label7 = new Label();
            lblCriticite = new Label();
            btnFermer = new Button();
            lblTechnicien = new Label();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(238, 9);
            label1.Name = "label1";
            label1.Size = new Size(150, 20);
            label1.TabIndex = 0;
            label1.Text = "Controle technique :";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblNumRef
            // 
            lblNumRef.AutoSize = true;
            lblNumRef.Font = new Font("Segoe UI", 11.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblNumRef.Location = new Point(475, 9);
            lblNumRef.Name = "lblNumRef";
            lblNumRef.Size = new Size(50, 20);
            lblNumRef.TabIndex = 1;
            lblNumRef.Text = "label2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(238, 46);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(62, 41);
            label4.Name = "label4";
            label4.Size = new Size(94, 20);
            label4.TabIndex = 5;
            label4.Text = "Défaillance :";
            // 
            // lblDefaillance
            // 
            lblDefaillance.AutoSize = true;
            lblDefaillance.Location = new Point(170, 41);
            lblDefaillance.Name = "lblDefaillance";
            lblDefaillance.Size = new Size(50, 20);
            lblDefaillance.TabIndex = 6;
            lblDefaillance.Text = "label2";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(24, 83);
            label5.Name = "label5";
            label5.Size = new Size(137, 20);
            label5.TabIndex = 7;
            label5.Text = "Point de contrôle :";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblPointControle
            // 
            lblPointControle.AutoSize = true;
            lblPointControle.Location = new Point(170, 83);
            lblPointControle.Name = "lblPointControle";
            lblPointControle.Size = new Size(50, 20);
            lblPointControle.TabIndex = 8;
            lblPointControle.Text = "label2";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(343, 41);
            label6.Name = "label6";
            label6.Size = new Size(71, 20);
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
            lblCriticite.Location = new Point(416, 41);
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
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(lblDefaillance);
            groupBox1.Controls.Add(lblCriticite);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(lblPointControle);
            groupBox1.Controls.Add(label6);
            groupBox1.Location = new Point(12, 108);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(862, 141);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Compte-rendu";
            // 
            // FrmClientControleTechnique
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(886, 308);
            Controls.Add(groupBox1);
            Controls.Add(lblTechnicien);
            Controls.Add(btnFermer);
            Controls.Add(label7);
            Controls.Add(lblDatePassage);
            Controls.Add(label2);
            Controls.Add(lblNumRef);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 11F);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmClientControleTechnique";
            Text = "Rapport contrôle technique";
            Load += FrmClientControleTechnique_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblNumRef;
        private Label label2;
        private Label lblDatePassage;
        private Label label4;
        private Label lblDefaillance;
        private Label label5;
        private Label lblPointControle;
        private Label label6;
        private Label label7;
        private Label lblCriticite;
        private Button btnFermer;
        private Label lblTechnicien;
        private GroupBox groupBox1;
    }
}