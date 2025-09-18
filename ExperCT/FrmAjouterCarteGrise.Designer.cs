namespace ExperCT
{
    partial class FrmAjouterCarteGrise
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
            label6 = new Label();
            label7 = new Label();
            txtNumeroImmatriculation = new TextBox();
            txtMarque = new TextBox();
            txtModel = new TextBox();
            txtCodeVin = new TextBox();
            txtPuissance = new TextBox();
            txtMotorisation = new TextBox();
            btnAjouter = new Button();
            label8 = new Label();
            dateCirculation = new DateTimePicker();
            label9 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(159, 89);
            label1.Name = "label1";
            label1.Size = new Size(184, 20);
            label1.TabIndex = 0;
            label1.Text = "Numero d'immatriculation";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(159, 137);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 1;
            label2.Text = "Marque";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(159, 193);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 2;
            label3.Text = "Modele";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1294, 659);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 3;
            label4.Text = "Code VIN";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(159, 247);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 4;
            label5.Text = "Code VIN";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(159, 299);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 5;
            label6.Text = "Puissance";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(159, 345);
            label7.Name = "label7";
            label7.Size = new Size(94, 20);
            label7.TabIndex = 6;
            label7.Text = "Motorisation";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtNumeroImmatriculation
            // 
            txtNumeroImmatriculation.Location = new Point(359, 86);
            txtNumeroImmatriculation.Name = "txtNumeroImmatriculation";
            txtNumeroImmatriculation.Size = new Size(225, 27);
            txtNumeroImmatriculation.TabIndex = 7;
            // 
            // txtMarque
            // 
            txtMarque.Location = new Point(359, 134);
            txtMarque.Name = "txtMarque";
            txtMarque.Size = new Size(225, 27);
            txtMarque.TabIndex = 8;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(359, 190);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(225, 27);
            txtModel.TabIndex = 9;
            // 
            // txtCodeVin
            // 
            txtCodeVin.Location = new Point(359, 244);
            txtCodeVin.Name = "txtCodeVin";
            txtCodeVin.Size = new Size(225, 27);
            txtCodeVin.TabIndex = 10;
            // 
            // txtPuissance
            // 
            txtPuissance.Location = new Point(359, 292);
            txtPuissance.Name = "txtPuissance";
            txtPuissance.Size = new Size(225, 27);
            txtPuissance.TabIndex = 11;
            // 
            // txtMotorisation
            // 
            txtMotorisation.Location = new Point(359, 338);
            txtMotorisation.Name = "txtMotorisation";
            txtMotorisation.Size = new Size(225, 27);
            txtMotorisation.TabIndex = 12;
            // 
            // btnAjouter
            // 
            btnAjouter.BackColor = SystemColors.HotTrack;
            btnAjouter.FlatStyle = FlatStyle.Flat;
            btnAjouter.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAjouter.ForeColor = SystemColors.ButtonHighlight;
            btnAjouter.Location = new Point(359, 439);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(158, 42);
            btnAjouter.TabIndex = 13;
            btnAjouter.Text = "Ajouter";
            btnAjouter.UseVisualStyleBackColor = false;
            btnAjouter.Click += btnAjouter_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(153, 393);
            label8.Name = "label8";
            label8.Size = new Size(190, 20);
            label8.TabIndex = 14;
            label8.Text = "Date de mise en circulation";
            label8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dateCirculation
            // 
            dateCirculation.Location = new Point(359, 388);
            dateCirculation.Name = "dateCirculation";
            dateCirculation.Size = new Size(225, 27);
            dateCirculation.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(282, 23);
            label9.Name = "label9";
            label9.Size = new Size(216, 25);
            label9.TabIndex = 16;
            label9.Text = "Ajouter une carte grise";
            // 
            // FrmAjouterCarteGrise
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(791, 511);
            Controls.Add(label9);
            Controls.Add(dateCirculation);
            Controls.Add(label8);
            Controls.Add(btnAjouter);
            Controls.Add(txtMotorisation);
            Controls.Add(txtPuissance);
            Controls.Add(txtCodeVin);
            Controls.Add(txtModel);
            Controls.Add(txtMarque);
            Controls.Add(txtNumeroImmatriculation);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmAjouterCarteGrise";
            Text = "Ajouter une carte grise";
            Load += FrmAjouterCarteGrise_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtNumeroImmatriculation;
        private TextBox txtMarque;
        private TextBox txtModel;
        private TextBox txtCodeVin;
        private TextBox txtPuissance;
        private TextBox txtMotorisation;
        private Button btnAjouter;
        private Label label8;
        private DateTimePicker dateCirculation;
        private Label label9;
    }
}