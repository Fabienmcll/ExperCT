using System;
using System.Collections.Generic;

namespace ExperCT.Models;

public partial class Client
{
    public int IdClient { get; set; }

    public string Nom { get; set; } = null!;

    public string Mdp { get; set; } = null!;

    public string Prenom { get; set; } = null!;

    public string Mail { get; set; } = null!;

    public virtual ICollection<CarteGrise> CarteGrises { get; set; } = new List<CarteGrise>();
}
