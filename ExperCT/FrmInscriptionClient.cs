using ExperCT.Models;
using System.Security.Cryptography;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Dynamic;

namespace ExperCT
{
    public partial class FrmInscriptionClient : Form
    {
        public FrmInscriptionClient()
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

        private void btnConnecter_Click(object sender, EventArgs e)
        {
            FrmConnexionClient client = new FrmConnexionClient();
            client.Show();
            this.Hide();
        }

        private void btnInscription_Click(object sender, EventArgs e)
        {
            if (txtMail.Text == "" || txtMotDePasse.Text == "" || txtNom.Text == "" || txtPrenom.Text == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs");
                return;
            }
            try
            {
                bool mailExist = checkMail(txtMail.Text.Trim());

                if (mailExist)
                {
                    MessageBox.Show("Le mail est déjà utilisé");
                    return;
                }

                Client newClient = new Client();
                newClient.Prenom = txtPrenom.Text.Trim();
                newClient.Nom = txtNom.Text.Trim();
                newClient.Mdp = HashPassword(txtMotDePasse.Text.Trim());
                newClient.Mail = txtMail.Text.Trim();
                
                using (ExperCtContext db = new ExperCtContext())
                {

                    db.Clients.Add(newClient);
                    db.SaveChanges();
                    MessageBox.Show("c'est bon");
                }

            } catch (Exception erreur)
            {
                MessageBox.Show(erreur.Message);
            }
        }

        private bool checkMail(string mail)
        {
            using (ExperCtContext db = new ExperCtContext())
            {
                Client clientWithThisMail = db.Clients.Where(o => o.Mail == mail.Trim()).FirstOrDefault();
                return !(clientWithThisMail == null);
            }
        }
    }
}
