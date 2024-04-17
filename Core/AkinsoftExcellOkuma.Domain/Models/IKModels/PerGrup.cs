using System;
using System.Collections.Generic;

namespace AkinsoftExcellOkuma.Persistence;

public partial class PerGrup
{
    public long Blkodu { get; set; }

    public short? KesGlvr { get; set; }

    public short? KesDm { get; set; }

    public short? KesIskazalari { get; set; }

    public string Adi { get; set; } = null!;

    public string? NetUcretler { get; set; }

    public string? SskPrimi { get; set; }

    public string? GelirVergisi { get; set; }

    public string? DamgaVergisi { get; set; }

    public string? IssizlikPrimi { get; set; }

    public string? EkKesintiler { get; set; }

    public string? Sgdp { get; set; }

    public string? IsyeriKodu { get; set; }

    public short? Varsayilan { get; set; }

    public double? IsciYaslilikOrani { get; set; }

    public double? IsvYaslilikOrani { get; set; }

    public double? IsciGensaglikOrani { get; set; }

    public double? IsvGensaglikOrani { get; set; }

    public double? IsciIssizlikOrani { get; set; }

    public double? IsvIssizlikOrani { get; set; }

    public double? IsciSgdpOrani { get; set; }

    public double? IsvSgdpOrani { get; set; }

    public double? Isv5510indOrani { get; set; }

    public string? OdemeTurKodu { get; set; }

    public short? DmVrIstisnasi { get; set; }

    public short? GlVrIstisnasi { get; set; }
}
