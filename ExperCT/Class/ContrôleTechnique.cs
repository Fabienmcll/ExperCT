using System;
using System.Collections.Generic;

namespace ExperCT.Models;

public partial class ContrôleTechnique
{
    public override string ToString()
    {
        return NumReference + " " + DatePassage.Day + "/" + DatePassage.Month + "/" + DatePassage.Year;
    }
}
