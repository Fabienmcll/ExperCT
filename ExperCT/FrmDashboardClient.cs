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
            frmAjouterCarteGrise.Show();
        }
    }
}
