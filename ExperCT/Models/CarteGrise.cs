using System;
using System.Collections.Generic;

namespace ExperCT.Models;

public partial class CarteGrise
{
    public string NumeroImmatriculation { get; set; } = null!;

    public string Marque { get; set; } = null!;

    public string Modele { get; set; } = null!;

    public string CodeVin { get; set; } = null!;

    public int Puissance { get; set; }

    public DateTime DateMiseCirculation { get; set; }

    public string Motorisation { get; set; } = null!;

    public int IdClient { get; set; }

    public int IdCarteGrise { get; set; }

    public virtual Client IdClientNavigation { get; set; } = null!;
}
