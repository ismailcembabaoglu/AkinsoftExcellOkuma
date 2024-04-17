using System;
using System.Collections.Generic;

namespace AkinsoftExcellOkuma.Persistence;

public partial class Mazerettanim
{
    public long Blkodu { get; set; }

    public string Tanimi { get; set; } = null!;

    public short? Ucretli { get; set; }

    public short? Fmvar { get; set; }

    public double? Mesaiyuzde { get; set; }

    public double? Ekmesaiyuzde { get; set; }

    public string? Mazeretaciklama { get; set; }

    public short? Turu { get; set; }

    public string? Puantajcetkodu { get; set; }
}
