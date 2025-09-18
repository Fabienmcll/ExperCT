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
            using (ExperCtContext db = new ExperCtContext())
            {
                var controle = (from c in db.ContrôleTechniques
                                join d in db.Defaillances on c.IdDefaillance equals d.IdDefaillance
                                join p in db.PointControles on d.IdPointControle equals p.IdPointControle
                                join cri in db.Criticites on d.IdCriticite equals cri.IdCriticite
                                join tch in db.Techniciens on c.IdTechnicien equals tch.IdTechnicien
                                where c.NumReference == controleSelected.NumReference
                                select new
                                {
                                    c.DatePassage,
                                    c.NumReference,
                                    Defaillance = d.Nom,
                                    PointControle = p.Nom,
                                    Criticite = cri.Nom,
                                    PrenomTechnicien = tch.Prenom,
                                    NomTechnicien = tch.Nom
                                }).FirstOrDefault();
                lblCriticite.Text = controle.Criticite.ToString();
                lblDatePassage.Text = controle.DatePassage.ToString();
                lblDefaillance.Text = controle.Defaillance.ToString();
                lblNumRef.Text = controleSelected.NumReference.ToString();
                lblPointControle.Text = controle.PointControle.ToString();
                lblTechnicien.Text = controle.NomTechnicien.ToString() + " " + controle.PrenomTechnicien.ToString();
            }
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
