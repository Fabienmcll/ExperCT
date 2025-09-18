using System;
using System.Collections.Generic;

namespace ExperCT.Models;

public partial class ContrôleTechnique
{
    public int IdControleTechnique { get; set; }

    public DateTime DatePassage { get; set; }

    public string NumReference { get; set; } = null!;

    public int IdDefaillance { get; set; }

    public int IdCarteGrise { get; set; }

    public int IdTechnicien { get; set; }

    public virtual CarteGrise IdCarteGriseNavigation { get; set; } = null!;

    public virtual Defaillance IdDefaillanceNavigation { get; set; } = null!;

    public virtual Technicien IdTechnicienNavigation { get; set; } = null!;
}
