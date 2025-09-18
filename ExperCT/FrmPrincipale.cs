namespace ExperCT
{
    public partial class FrmPrincipale : Form
    {
        public FrmPrincipale()
        {
            InitializeComponent();
        }

        private void btnEspaceClient_Click(object sender, EventArgs e)
        {
            FrmConnexionClient frmConnexionClient = new FrmConnexionClient();
            frmConnexionClient.Show();
            this.Hide();
        }

        private void btnEspaceTechnicien_Click(object sender, EventArgs e)
        {
            FrmConnexionTechnicien frmConnexionTech = new FrmConnexionTechnicien();
            frmConnexionTech.Show();
            this.Hide();
        }
    }
}
