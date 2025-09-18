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
            SuspendLayout();
            // 
            // btnEspaceClient
            // 
            btnEspaceClient.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnEspaceClient.Location = new Point(175, 62);
            btnEspaceClient.Name = "btnEspaceClient";
            btnEspaceClient.Size = new Size(110, 34);
            btnEspaceClient.TabIndex = 0;
            btnEspaceClient.Text = "Espace client";
            btnEspaceClient.UseVisualStyleBackColor = true;
            btnEspaceClient.Click += btnEspaceClient_Click;
            // 
            // btnEspaceTechnicien
            // 
            btnEspaceTechnicien.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnEspaceTechnicien.Location = new Point(161, 115);
            btnEspaceTechnicien.Name = "btnEspaceTechnicien";
            btnEspaceTechnicien.Size = new Size(141, 27);
            btnEspaceTechnicien.TabIndex = 1;
            btnEspaceTechnicien.Text = "Espace technicien";
            btnEspaceTechnicien.UseVisualStyleBackColor = true;
            btnEspaceTechnicien.Click += btnEspaceTechnicien_Click;
            // 
            // FrmPrincipale
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 279);
            Controls.Add(btnEspaceTechnicien);
            Controls.Add(btnEspaceClient);
            Font = new Font("Segoe UI", 11F);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmPrincipale";
            Text = "ExperCT";
            ResumeLayout(false);
        }

        #endregion

        private Button btnEspaceClient;
        private Button btnEspaceTechnicien;
    }
}
