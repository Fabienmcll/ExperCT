using ExperCT.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExperCT
{
    public partial class FrmNouveauControle : Form
    {
        CarteGrise selectedCarteGrise;
        public FrmNouveauControle(CarteGrise carteGrise)
        {
            selectedCarteGrise = carteGrise;
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FrmNouveauControle_Load(object sender, EventArgs e)
        {
            txCarteGrise.Text = selectedCarteGrise.NumeroImmatriculation;
            txtTechnicien.Text = SessionManager.CurrentTechnicien.Nom + ' ' + SessionManager.CurrentTechnicien.Prenom;
            rbAucuneDefaillance.Checked = true;
            groupBox.Visible = false;

            DateTime dateTime = DateTime.Now;
            string numeroReference = "REF-" + dateTime.Day + dateTime.Month + dateTime.Year + dateTime.Ticks;
            txtReference.Text = numeroReference;

            try
            {
                using (ExperCtContext db = new ExperCtContext())
                {
                    List<Defaillance> allDefaillance = db.Defaillances.ToList();
                    foreach (Defaillance defaillance in allDefaillance)
                    {
                        cbDefaliance.Items.Add(defaillance);
                    }
                }
            }
            catch (Exception ex)

            {
            }



        }

        private void txCarteGrise_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTechnicien_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbDefaillance_CheckedChanged(object sender, EventArgs e)
        {
            groupBox.Visible = true;
        }

        private void rbAucuneDefaillance_CheckedChanged(object sender, EventArgs e)
        {
            groupBox.Visible = false;

        }

        private void cbDefaliance_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (ExperCtContext db = new ExperCtContext())
                {

                    Defaillance defaillance = cbDefaliance.SelectedItem as Defaillance;
                    PointControle pointControle = db.PointControles.Where(o => o.IdPointControle == defaillance.IdPointControle).FirstOrDefault();
                    txPointControle.Text = pointControle.Nom;

                }
            }
            catch (Exception ex)

            {
            }
        }

        private void btnCreer_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbAucuneDefaillance.Checked)
                {
                    using (ExperCtContext db = new ExperCtContext())
                    {
                        Defaillance defaillance = cbDefaliance.SelectedItem as Defaillance;
                        ContrôleTechnique controleTechnique = new ContrôleTechnique();
                        controleTechnique.DatePassage = datePassage.Value;
                        controleTechnique.NumReference = txtReference.Text;
                        controleTechnique.IdCarteGrise = selectedCarteGrise.IdCarteGrise;
                        controleTechnique.IdTechnicien = SessionManager.CurrentTechnicien.IdTechnicien;

                        db.ContrôleTechniques.Add(controleTechnique);
                        db.SaveChanges();
                        MessageBox.Show("Contrôle technique créer !");
                    }
                }
                else
                {
                    using (ExperCtContext db = new ExperCtContext())
                    {
                        Defaillance defaillance = cbDefaliance.SelectedItem as Defaillance;
                        ContrôleTechnique controleTechnique = new ContrôleTechnique();
                        controleTechnique.DatePassage = datePassage.Value;
                        controleTechnique.NumReference = txtReference.Text;
                        controleTechnique.IdDefaillance = defaillance.IdDefaillance;
                        controleTechnique.IdCarteGrise = selectedCarteGrise.IdCarteGrise;
                        controleTechnique.IdTechnicien = SessionManager.CurrentTechnicien.IdTechnicien;

                        db.ContrôleTechniques.Add(controleTechnique);
                        db.SaveChanges();
                        MessageBox.Show("Contrôle technique créer !");
                    }
                }
                this.Close();

            }
            catch (Exception erreur)
            {
                MessageBox.Show("Erreur chef " + erreur.Message);
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
