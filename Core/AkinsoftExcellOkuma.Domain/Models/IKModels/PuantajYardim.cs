using System;
using System.Collections.Generic;

namespace AkinsoftExcellOkuma.Persistence;

public partial class PuantajYardim
{
    public long Blkodu { get; set; }

    public long? Blpnkodu { get; set; }

    public string? Yardim { get; set; }

    public double? Tutari { get; set; }

    public string? SskKes { get; set; }

    public double? SskUstsinir { get; set; }

    public string? GvKes { get; set; }

    public double? GvUstsinir { get; set; }

    public string? DmvKes { get; set; }

    public string? Gunluk { get; set; }

    public string? Kodu { get; set; }

    public short? Netbrut { get; set; }

    public double? SskMuafiyet { get; set; }

    public double? GvMuafiyet { get; set; }

    public short? YardimTuru { get; set; }

    public double? DvUstsinir { get; set; }

    public double? DvMuafiyet { get; set; }

    public string? AktarimYeri { get; set; }
}
