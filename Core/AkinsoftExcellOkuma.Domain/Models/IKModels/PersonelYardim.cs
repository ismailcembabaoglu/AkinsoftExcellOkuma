using System;
using System.Collections.Generic;

namespace AkinsoftExcellOkuma.Persistence;

public partial class PersonelYardim
{
    public long Blkodu { get; set; }

    public long? Blpersonelkodu { get; set; }

    public string? Yardim { get; set; }

    public double? Tutari { get; set; }

    public string? Kodu { get; set; }

    public short? SskKesintisi { get; set; }

    public double? SskUstsinir { get; set; }

    public short? GvKesintisi { get; set; }

    public double? GvUstsinir { get; set; }

    public short? DmvKesintisi { get; set; }

    public short? Gunluk { get; set; }

    public short? Netbrut { get; set; }

    public double? SskMuafiyet { get; set; }

    public double? GvMuafiyet { get; set; }

    public short? YardimTuru { get; set; }

    public double? DvUstsinir { get; set; }

    public double? DvMuafiyet { get; set; }
}
