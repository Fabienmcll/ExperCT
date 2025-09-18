using System;
using System.Collections.Generic;

namespace ExperCT.Models;

public partial class Technicien
{
    public int IdTechnicien { get; set; }

    public string Nom { get; set; } = null!;

    public string Prenom { get; set; } = null!;

    public string Mdp { get; set; } = null!;

    public virtual ICollection<ContrôleTechnique> ContrôleTechniques { get; set; } = new List<ContrôleTechnique>();
}
