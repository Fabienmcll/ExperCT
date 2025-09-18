namespace ExperCT
{
    partial class FrmDashboardTechnicien
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
            lbCarteGrise = new ListBox();
            btnNouveauControle = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(27, 118);
            label1.Name = "label1";
            label1.Size = new Size(346, 25);
            label1.TabIndex = 0;
            label1.Text = "Carte grise des véhicules a controler : ";
            // 
            // lbCarteGrise
            // 
            lbCarteGrise.FormattingEnabled = true;
            lbCarteGrise.ItemHeight = 20;
            lbCarteGrise.Location = new Point(27, 153);
            lbCarteGrise.Name = "lbCarteGrise";
            lbCarteGrise.Size = new Size(606, 324);
            lbCarteGrise.TabIndex = 1;
            // 
            // btnNouveauControle
            // 
            btnNouveauControle.BackColor = SystemColors.HotTrack;
            btnNouveauControle.FlatStyle = FlatStyle.Flat;
            btnNouveauControle.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNouveauControle.ForeColor = SystemColors.ButtonFace;
            btnNouveauControle.Location = new Point(662, 153);
            btnNouveauControle.Name = "btnNouveauControle";
            btnNouveauControle.Size = new Size(155, 47);
            btnNouveauControle.TabIndex = 2;
            btnNouveauControle.Text = "Nouveau contrôle technique";
            btnNouveauControle.UseVisualStyleBackColor = false;
            btnNouveauControle.Click += btnNouveauControle_Click;
            // 
            // FrmDashboardTechnicien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(892, 547);
            Controls.Add(btnNouveauControle);
            Controls.Add(lbCarteGrise);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmDashboardTechnicien";
            Text = "Dashboard technicien";
            Load += FrmDashboardTechnicien_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lbCarteGrise;
        private Button btnNouveauControle;
    }
}