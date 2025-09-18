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
    public partial class FrmAjouterCarteGrise : Form
    {
        bool isModify = false;
        CarteGrise carteSelected;
        public FrmAjouterCarteGrise()
        {
            InitializeComponent();
        }

        public FrmAjouterCarteGrise(CarteGrise carteGriseSelected)
        {
            InitializeComponent();
            isModify = true;
            carteSelected = carteGriseSelected;
            txtCodeVin.Text = carteSelected.CodeVin.ToString();
            txtMarque.Text = carteSelected.Marque.ToString();
            txtModel.Text = carteSelected.Modele.ToString();
            txtMotorisation.Text = carteSelected.Motorisation.ToString();
            txtNumeroImmatriculation.Text = carteSelected.NumeroImmatriculation.ToString();
            txtPuissance.Text = carteSelected.Puissance.ToString();
            dateCirculation.Value = carteSelected.DateMiseCirculation;

            btnAjouter.Text = "Modifier";

        }

        private void FrmAjouterCarteGrise_Load(object sender, EventArgs e)
        {

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (isModify)
            {
                modifyCarte();
            }
            else
            {
                createCarte();
            }
        }

        private void modifyCarte()
        {
            if (txtCodeVin.Text.Trim() == "" || txtMarque.Text.Trim() == "" || txtModel.Text.Trim() == "" || txtMotorisation.Text.Trim() == "" || txtNumeroImmatriculation.Text.Trim() == "" || txtPuissance.Text.Trim() == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs");
                return;
            }
            try
            {
                using (ExperCtContext db = new ExperCtContext())
                {
                    CarteGrise carteToModify = db.CarteGrises.Where(o => o.IdCarteGrise == carteSelected.IdCarteGrise).FirstOrDefault();
                    carteToModify.Marque = txtMarque.Text.Trim();
                    carteToModify.NumeroImmatriculation = txtNumeroImmatriculation.Text.Trim();
                    carteToModify.Modele = txtModel.Text.Trim();
                    carteToModify.CodeVin = txtCodeVin.Text.Trim();
                    if (int.TryParse(txtPuissance.Text.Trim(), out int puissance))
                    {
                        carteToModify.Puissance = puissance;
                    }
                    else
                    {
                        MessageBox.Show("Vérifiez le format de la puissance");
                        return;
                    }
                    carteToModify.DateMiseCirculation = dateCirculation.Value;
                    carteToModify.Motorisation = txtMotorisation.Text.Trim();
                    db.SaveChanges();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception erreur)
            {
                MessageBox.Show(erreur.Message);
            }
            
        }

        private void createCarte()
        {
            if (txtCodeVin.Text.Trim() == "" || txtMarque.Text.Trim() == "" || txtModel.Text.Trim() == "" || txtMotorisation.Text.Trim() == "" || txtNumeroImmatriculation.Text.Trim() == "" || txtPuissance.Text.Trim() == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs");
                return;
            }
            CarteGrise carteGrise = new CarteGrise
            {
                CodeVin = txtCodeVin.Text.Trim(),
                Marque = txtMarque.Text.Trim(),
                Modele = txtModel.Text.Trim(),
                Motorisation = txtMotorisation.Text.Trim(),
                NumeroImmatriculation = txtNumeroImmatriculation.Text.Trim(),
                IdClient = SessionManager.CurrentClient.IdClient,
                DateMiseCirculation = dateCirculation.Value
            };
            if (int.TryParse(txtPuissance.Text.Trim(), out int puissance))
            {
                carteGrise.Puissance = puissance;
            }
            else
            {
                MessageBox.Show("Vérifiez le format de la puissance");
                return;
            }
            try
            {
                using (ExperCtContext db = new ExperCtContext())
                {
                    db.CarteGrises.Add(carteGrise);
                    db.SaveChanges();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception erreur)
            {
                MessageBox.Show(erreur.Message);
            }

        }
    }
}
