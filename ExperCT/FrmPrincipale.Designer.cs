namespace ExperCT
{
    partial class FrmPrincipale
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnEspaceClient = new Button();
            btnEspaceTechnicien = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnEspaceClient
            // 
            btnEspaceClient.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnEspaceClient.BackColor = SystemColors.HotTrack;
            btnEspaceClient.FlatAppearance.MouseDownBackColor = Color.LightSteelBlue;
            btnEspaceClient.FlatStyle = FlatStyle.Flat;
            btnEspaceClient.ForeColor = SystemColors.ButtonFace;
            btnEspaceClient.Location = new Point(170, 135);
            btnEspaceClient.Name = "btnEspaceClient";
            btnEspaceClient.Size = new Size(244, 60);
            btnEspaceClient.TabIndex = 0;
            btnEspaceClient.Text = "Espace client";
            btnEspaceClient.UseVisualStyleBackColor = false;
            btnEspaceClient.Click += btnEspaceClient_Click;
            // 
            // btnEspaceTechnicien
            // 
            btnEspaceTechnicien.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnEspaceTechnicien.BackColor = SystemColors.HotTrack;
            btnEspaceTechnicien.FlatAppearance.MouseDownBackColor = Color.LightSteelBlue;
            btnEspaceTechnicien.FlatStyle = FlatStyle.Flat;
            btnEspaceTechnicien.ForeColor = SystemColors.ButtonHighlight;
            btnEspaceTechnicien.Location = new Point(170, 240);
            btnEspaceTechnicien.Name = "btnEspaceTechnicien";
            btnEspaceTechnicien.Size = new Size(244, 57);
            btnEspaceTechnicien.TabIndex = 1;
            btnEspaceTechnicien.Text = "Espace technicien";
            btnEspaceTechnicien.UseVisualStyleBackColor = false;
            btnEspaceTechnicien.Click += btnEspaceTechnicien_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(170, 74);
            label1.Name = "label1";
            label1.Size = new Size(237, 30);
            label1.TabIndex = 2;
            label1.Text = "Bienvenue sur ExperCT";
            // 
            // FrmPrincipale
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(613, 410);
            Controls.Add(label1);
            Controls.Add(btnEspaceTechnicien);
            Controls.Add(btnEspaceClient);
            Font = new Font("Segoe UI", 11F);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmPrincipale";
            Text = "ExperCT";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEspaceClient;
        private Button btnEspaceTechnicien;
        private Label label1;
    }
}
