using ExperCT.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExperCT
{
    public partial class FrmDashboardTechnicien : Form
    {
        public FrmDashboardTechnicien()
        {
            InitializeComponent();
        }

        private void FrmDashboardTechnicien_Load(object sender, EventArgs e)
        {

            try
            {
                lbCarteGrise.Items.Clear();

                using (ExperCtContext db = new ExperCtContext())
                {
                    List<CarteGrise> AllCartesGrises = db.CarteGrises.ToList();

                    foreach (CarteGrise carte in AllCartesGrises)
                    {
                        lbCarteGrise.Items.Add(carte);
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des données : " + ex.Message);
            }

        }

        private void btnNouveauControle_Click(object sender, EventArgs e)
        {
            CarteGrise carteGriseSelectionnee = lbCarteGrise.SelectedItem as CarteGrise;
            FrmNouveauControle frmNouveauControle = new FrmNouveauControle(carteGriseSelectionnee);
            frmNouveauControle.Show();

        }
    }
}
