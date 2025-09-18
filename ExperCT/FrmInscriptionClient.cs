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
    public partial class FrmInscriptionClient : Form
    {
        public FrmInscriptionClient()
        {
            InitializeComponent();
        }

        private void btnConnecter_Click(object sender, EventArgs e)
        {
            FrmConnexionClient client = new FrmConnexionClient();
            client.Show();
            this.Hide();
        }
    }
}
