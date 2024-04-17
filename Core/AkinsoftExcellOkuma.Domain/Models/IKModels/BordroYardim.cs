using System;
using System.Collections.Generic;

namespace AkinsoftExcellOkuma.Persistence;

public partial class BordroYardim
{
    public long Blkodu { get; set; }

    public long? Blbrkodu { get; set; }

    public string? Yardim { get; set; }

    public double? Tutari { get; set; }

    public short? SskKes { get; set; }

    public double? SskUstsinir { get; set; }

    public short? GvKes { get; set; }

    public double? GvUstsinir { get; set; }

    public short? DmvKes { get; set; }

    public short? Gunluk { get; set; }

    public string? Kodu { get; set; }

    public short? Netbrut { get; set; }

    public double? BrutToplam { get; set; }

    public double? SskKesIsv { get; set; }

    public double? SskKesIsci { get; set; }

    public double? GvKesTut { get; set; }

    public double? DmvKesTut { get; set; }

    public double? NetOdenen { get; set; }

    public double? SskMuafiyet { get; set; }

    public double? GvMuafiyet { get; set; }

    public short? YardimTuru { get; set; }

    public double? DvUstsinir { get; set; }

    public double? DvMuafiyet { get; set; }
}
