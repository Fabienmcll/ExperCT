using System;
using System.Collections.Generic;

namespace ExperCT.Models;

public partial class Defaillance
{
    public int IdDefaillance { get; set; }

    public string Nom { get; set; } = null!;

    public int IdPointControle { get; set; }

    public int IdCriticite { get; set; }

    public virtual ICollection<ContrôleTechnique> ContrôleTechniques { get; set; } = new List<ContrôleTechnique>();

    public virtual Criticite IdCriticiteNavigation { get; set; } = null!;

    public virtual PointControle IdPointControleNavigation { get; set; } = null!;
}
