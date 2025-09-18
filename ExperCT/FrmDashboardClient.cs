using ExperCT.Models;
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
    public partial class FrmDashboardClient : Form
    {
        public FrmDashboardClient()
        {
            InitializeComponent();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            FrmAjouterCarteGrise frmAjouterCarteGrise = new FrmAjouterCarteGrise();
            if (frmAjouterCarteGrise.ShowDialog() == DialogResult.OK)
            {
                LoadCartes();
            }

        }

        private void LoadCartes()
        {
            lsbCarteGrise.Items.Clear();
            using (ExperCtContext db = new ExperCtContext())
            {
                List<CarteGrise> listCartes = db.CarteGrises.Where(o => o.IdClient == SessionManager.CurrentClient.IdClient).ToList();
                foreach (CarteGrise carte in listCartes)
                {
                    lsbCarteGrise.Items.Add(carte);
                }
            }
        }

        private void FrmDashboardClient_Load(object sender, EventArgs e)
        {
            LoadCartes();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {

            FrmAjouterCarteGrise frmModify = new FrmAjouterCarteGrise(lsbCarteGrise.SelectedItem as CarteGrise);
            if (frmModify.ShowDialog() == DialogResult.OK)
            {
                LoadCartes();
            }
        }

        private void lsbCarteGrise_SelectedIndexChanged(object sender, EventArgs e)
        {
            lsbControleTechnique.Items.Clear();
            CarteGrise selectedCarteGrise = lsbCarteGrise.SelectedItem as CarteGrise;
            try
            {
                using (ExperCtContext db = new ExperCtContext())
                {
                    List<ContrôleTechnique> controleTechniques = db.ContrôleTechniques.Where(o => o.IdCarteGrise == selectedCarteGrise.IdCarteGrise).ToList();
                    foreach (ContrôleTechnique controle in controleTechniques)
                    {
                        lsbControleTechnique.Items.Add(controle);
                    }
                }
            }
            catch (Exception erreur)
            {
                MessageBox.Show(erreur.Message);
            }
        }

        private void lsbControleTechnique_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("Double click");
        }
    }
}
