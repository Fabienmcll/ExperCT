using ExperCT.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExperCT
{
    public partial class FrmConnexionTechnicien : Form
    {
        public FrmConnexionTechnicien()
        {
            InitializeComponent();
        }

        public static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder sb = new StringBuilder();
                foreach (byte b in bytes)
                    sb.Append(b.ToString("x2")); // hexadécimal
                return sb.ToString();
            }
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            if (txtNom.Text == "" || txtPrenom.Text == "" || txtMotDePasse.Text == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs");
                return;
            }
            try
            {
                Technicien technicienExist = checkUserExist(txtPrenom.Text.Trim(), txtNom.Text.Trim());
                if (technicienExist == null)
                {
                    MessageBox.Show("Cet utilisateur n'existe pas");
                    return;
                }
                string mdpHash = HashPassword(txtMotDePasse.Text.Trim());
                if (mdpHash == technicienExist.Mdp)
                {
                    SessionManager.LoginTechnicien(technicienExist);
                    FrmDashboardTechnicien frmDashboardTechnicien = new FrmDashboardTechnicien();
                    frmDashboardTechnicien.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Mot de passe incorrect");
                }

            }
            catch (Exception erreur)
            {
                MessageBox.Show(erreur.Message);
            }
        }

        private Technicien checkUserExist(string prenom, string nom)
        {
            using (ExperCtContext db = new ExperCtContext())
            {
                Technicien technicienToCheck = db.Techniciens.Where(o => o.Prenom == prenom && o.Nom == nom).FirstOrDefault();
                return technicienToCheck;
            }
        }
    }
}
