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
    public partial class FrmConnexionClient : Form
    {
        public FrmConnexionClient()
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

        private void btnInscrire_Click(object sender, EventArgs e)
        {
            FrmInscriptionClient inscriptionClient = new FrmInscriptionClient();
            inscriptionClient.Show();
            this.Hide();
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            if (txtMail.Text == "" || txtMotDePasse.Text == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs");
                return;
            }
            try
            {
                Client clientExist = checkUserExist(txtMail.Text.Trim());
                if(clientExist == null)
                {
                    MessageBox.Show("Cet utilisateur n'existe pas");
                    return;
                }
                string mdpHash = HashPassword(txtMotDePasse.Text.Trim());
                if (mdpHash == clientExist.Mdp)
                {
                    SessionManager.LoginClient(clientExist);
                    FrmDashboardClient frmDashboardClient = new FrmDashboardClient();
                    frmDashboardClient.Show();
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

        private Client checkUserExist (string mail)
        {
            using (ExperCtContext db = new ExperCtContext())
            {
                Client clientToCheck = db.Clients.Where(o => o.Mail == mail).FirstOrDefault();
                return clientToCheck;
            }
        }
    }
}
