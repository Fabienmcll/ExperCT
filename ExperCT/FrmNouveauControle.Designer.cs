namespace ExperCT
{
    partial class FrmNouveauControle
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txCarteGrise = new TextBox();
            datePassage = new DateTimePicker();
            txtReference = new TextBox();
            cbDefaliance = new ComboBox();
            label6 = new Label();
            txPointControle = new TextBox();
            rbDefaillance = new RadioButton();
            rbAucuneDefaillance = new RadioButton();
            txtTechnicien = new TextBox();
            btnCreer = new Button();
            btnAnnuler = new Button();
            groupBox = new GroupBox();
            groupBox.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 83);
            label1.Name = "label1";
            label1.Size = new Size(131, 20);
            label1.TabIndex = 0;
            label1.Text = "Date de passage : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 145);
            label2.Name = "label2";
            label2.Size = new Size(150, 20);
            label2.TabIndex = 1;
            label2.Text = "Numero de réference";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 72);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 2;
            label3.Text = "Défaillance";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 39);
            label4.Name = "label4";
            label4.Size = new Size(114, 20);
            label4.TabIndex = 3;
            label4.Text = "Immatriculation";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 386);
            label5.Name = "label5";
            label5.Size = new Size(78, 20);
            label5.TabIndex = 4;
            label5.Text = "Technicien";
            // 
            // txCarteGrise
            // 
            txCarteGrise.Enabled = false;
            txCarteGrise.Location = new Point(197, 32);
            txCarteGrise.Name = "txCarteGrise";
            txCarteGrise.Size = new Size(202, 27);
            txCarteGrise.TabIndex = 5;
            txCarteGrise.TextChanged += txCarteGrise_TextChanged;
            // 
            // datePassage
            // 
            datePassage.Location = new Point(200, 83);
            datePassage.Name = "datePassage";
            datePassage.Size = new Size(200, 27);
            datePassage.TabIndex = 6;
            // 
            // txtReference
            // 
            txtReference.Enabled = false;
            txtReference.Location = new Point(199, 142);
            txtReference.Name = "txtReference";
            txtReference.Size = new Size(305, 27);
            txtReference.TabIndex = 7;
            // 
            // cbDefaliance
            // 
            cbDefaliance.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDefaliance.FormattingEnabled = true;
            cbDefaliance.Location = new Point(135, 72);
            cbDefaliance.Name = "cbDefaliance";
            cbDefaliance.Size = new Size(293, 28);
            cbDefaliance.TabIndex = 8;
            cbDefaliance.SelectedIndexChanged += cbDefaliance_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(434, 72);
            label6.Name = "label6";
            label6.Size = new Size(122, 20);
            label6.TabIndex = 9;
            label6.Text = "Point de controle";
            // 
            // txPointControle
            // 
            txPointControle.Enabled = false;
            txPointControle.Location = new Point(573, 70);
            txPointControle.Name = "txPointControle";
            txPointControle.Size = new Size(202, 27);
            txPointControle.TabIndex = 10;
            // 
            // rbDefaillance
            // 
            rbDefaillance.AutoSize = true;
            rbDefaillance.Location = new Point(41, 208);
            rbDefaillance.Name = "rbDefaillance";
            rbDefaillance.Size = new Size(102, 24);
            rbDefaillance.TabIndex = 11;
            rbDefaillance.TabStop = true;
            rbDefaillance.Text = "Défalliance";
            rbDefaillance.UseVisualStyleBackColor = true;
            rbDefaillance.CheckedChanged += rbDefaillance_CheckedChanged;
            // 
            // rbAucuneDefaillance
            // 
            rbAucuneDefaillance.AutoSize = true;
            rbAucuneDefaillance.Location = new Point(199, 208);
            rbAucuneDefaillance.Name = "rbAucuneDefaillance";
            rbAucuneDefaillance.Size = new Size(157, 24);
            rbAucuneDefaillance.TabIndex = 12;
            rbAucuneDefaillance.TabStop = true;
            rbAucuneDefaillance.Text = "Aucune défailliance";
            rbAucuneDefaillance.UseVisualStyleBackColor = true;
            rbAucuneDefaillance.CheckedChanged += rbAucuneDefaillance_CheckedChanged;
            // 
            // txtTechnicien
            // 
            txtTechnicien.Enabled = false;
            txtTechnicien.Location = new Point(163, 379);
            txtTechnicien.Name = "txtTechnicien";
            txtTechnicien.Size = new Size(200, 27);
            txtTechnicien.TabIndex = 13;
            txtTechnicien.TextChanged += txtTechnicien_TextChanged;
            // 
            // btnCreer
            // 
            btnCreer.Location = new Point(683, 425);
            btnCreer.Name = "btnCreer";
            btnCreer.Size = new Size(140, 45);
            btnCreer.TabIndex = 14;
            btnCreer.Text = "Créer";
            btnCreer.UseVisualStyleBackColor = true;
            btnCreer.Click += btnCreer_Click;
            // 
            // btnAnnuler
            // 
            btnAnnuler.Location = new Point(41, 425);
            btnAnnuler.Name = "btnAnnuler";
            btnAnnuler.Size = new Size(140, 45);
            btnAnnuler.TabIndex = 15;
            btnAnnuler.Text = "Annuler";
            btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // groupBox
            // 
            groupBox.Controls.Add(label3);
            groupBox.Controls.Add(cbDefaliance);
            groupBox.Controls.Add(label6);
            groupBox.Controls.Add(txPointControle);
            groupBox.Location = new Point(41, 254);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(796, 119);
            groupBox.TabIndex = 16;
            groupBox.TabStop = false;
            groupBox.Text = "groupBox1";
            // 
            // FrmNouveauControle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(849, 504);
            Controls.Add(groupBox);
            Controls.Add(btnAnnuler);
            Controls.Add(btnCreer);
            Controls.Add(txtTechnicien);
            Controls.Add(rbAucuneDefaillance);
            Controls.Add(rbDefaillance);
            Controls.Add(txtReference);
            Controls.Add(datePassage);
            Controls.Add(txCarteGrise);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmNouveauControle";
            Text = "Nouveau contrôle technique";
            Load += FrmNouveauControle_Load;
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txCarteGrise;
        private DateTimePicker datePassage;
        private TextBox txtReference;
        private ComboBox cbDefaliance;
        private Label label6;
        private TextBox txPointControle;
        private RadioButton rbDefaillance;
        private RadioButton rbAucuneDefaillance;
        private TextBox txtTechnicien;
        private Button btnCreer;
        private Button btnAnnuler;
        private GroupBox groupBox;
    }
}