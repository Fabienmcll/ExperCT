using System;
using System.Collections.Generic;

namespace ExperCT.Models;

public partial class CarteGrise
{
    public override string ToString()
    {
        return NumeroImmatriculation + " " + Marque + " " + Modele + " " + Puissance + " Ch";
    }
}
