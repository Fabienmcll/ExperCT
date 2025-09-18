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
    public partial class FrmClientControleTechnique : Form
    {
        ContrôleTechnique controleSelected;
        public FrmClientControleTechnique(ContrôleTechnique contrôleTechnique)
        {
            controleSelected = contrôleTechnique;
            InitializeComponent();
        }

        private void FrmClientControleTechnique_Load(object sender, EventArgs e)
        {
            try
            {
                using (ExperCtContext db = new ExperCtContext())
                {
                    var controle = (from c in db.ContrôleTechniques
                                    join d in db.Defaillances on c.IdDefaillance equals d.IdDefaillance into defGroup
                                    from d in defGroup.DefaultIfEmpty()
                                    join p in db.PointControles on d.IdPointControle equals p.IdPointControle into pcGroup
                                    from p in pcGroup.DefaultIfEmpty()
                                    join cri in db.Criticites on d.IdCriticite equals cri.IdCriticite into criGroup
                                    from cri in criGroup.DefaultIfEmpty()
                                    join tch in db.Techniciens on c.IdTechnicien equals tch.IdTechnicien
                                    where c.NumReference == controleSelected.NumReference
                                    select new
                                    {
                                        c.IdDefaillance,
                                        c.DatePassage,
                                        c.NumReference,
                                        Defaillance = d != null ? d.Nom : null,
                                        PointControle = p != null ? p.Nom : null,
                                        Criticite = cri != null ? cri.Nom : null,
                                        PrenomTechnicien = tch.Prenom,
                                        NomTechnicien = tch.Nom
                                    }).FirstOrDefault();

                    if (controle.IdDefaillance == null)
                    {
                        label6.Visible = false;
                        lblCriticite.Visible = false;
                        lblDefaillance.Text = "Aucune défaillance";
                        lblDatePassage.Text = controle.DatePassage.ToString();
                        lblPointControle.Visible = false;
                        label5.Visible = false;
                        lblNumRef.Text = controleSelected.NumReference.ToString();
                        lblTechnicien.Text = controle.NomTechnicien.ToString() + " " + controle.PrenomTechnicien.ToString();
                    }
                    else
                    {
                        lblCriticite.Text = controle.Criticite.ToString();
                        lblDatePassage.Text = controle.DatePassage.ToString();
                        lblDefaillance.Text = controle.Defaillance.ToString();
                        lblNumRef.Text = controleSelected.NumReference.ToString();
                        lblPointControle.Text = controle.PointControle.ToString();
                        lblTechnicien.Text = controle.NomTechnicien.ToString() + " " + controle.PrenomTechnicien.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
