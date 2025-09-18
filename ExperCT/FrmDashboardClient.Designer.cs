namespace ExperCT
{
    partial class FrmDashboardClient
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
            lsbCarteGrise = new ListBox();
            label2 = new Label();
            lsbControleTechnique = new ListBox();
            label3 = new Label();
            btnAjouter = new Button();
            btnModifier = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(384, 9);
            label1.Name = "label1";
            label1.Size = new Size(156, 25);
            label1.TabIndex = 0;
            label1.Text = "Tableau de bord";
            // 
            // lsbCarteGrise
            // 
            lsbCarteGrise.FormattingEnabled = true;
            lsbCarteGrise.ItemHeight = 20;
            lsbCarteGrise.Location = new Point(236, 156);
            lsbCarteGrise.Name = "lsbCarteGrise";
            lsbCarteGrise.Size = new Size(248, 324);
            lsbCarteGrise.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.Location = new Point(236, 124);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 2;
            label2.Text = "Carte grise";
            // 
            // lsbControleTechnique
            // 
            lsbControleTechnique.FormattingEnabled = true;
            lsbControleTechnique.ItemHeight = 20;
            lsbControleTechnique.Location = new Point(633, 156);
            lsbControleTechnique.Name = "lsbControleTechnique";
            lsbControleTechnique.Size = new Size(187, 324);
            lsbControleTechnique.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label3.Location = new Point(633, 124);
            label3.Name = "label3";
            label3.Size = new Size(144, 20);
            label3.TabIndex = 4;
            label3.Text = "Controle Technique";
            // 
            // btnAjouter
            // 
            btnAjouter.Location = new Point(86, 178);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(75, 35);
            btnAjouter.TabIndex = 5;
            btnAjouter.Text = "Ajouter";
            btnAjouter.UseVisualStyleBackColor = true;
            btnAjouter.Click += btnAjouter_Click;
            // 
            // btnModifier
            // 
            btnModifier.Location = new Point(65, 233);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new Size(117, 35);
            btnModifier.TabIndex = 6;
            btnModifier.Text = "Modifier";
            btnModifier.UseVisualStyleBackColor = true;
            // 
            // FrmDashboardClient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 524);
            Controls.Add(btnModifier);
            Controls.Add(btnAjouter);
            Controls.Add(label3);
            Controls.Add(lsbControleTechnique);
            Controls.Add(label2);
            Controls.Add(lsbCarteGrise);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmDashboardClient";
            Text = "Dashboard";
            Load += FrmDashboardClient_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lsbCarteGrise;
        private Label label2;
        private ListBox lsbControleTechnique;
        private Label label3;
        private Button btnAjouter;
        private Button btnModifier;
    }
}