using System;
using System.Collections.Generic;

namespace ExperCT.Models;

public partial class PointControle
{
    public int IdPointControle { get; set; }

    public string Nom { get; set; } = null!;

    public virtual ICollection<Defaillance> Defaillances { get; set; } = new List<Defaillance>();
}
