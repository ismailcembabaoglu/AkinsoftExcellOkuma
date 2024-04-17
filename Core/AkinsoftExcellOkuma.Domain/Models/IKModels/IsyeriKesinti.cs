using System;
using System.Collections.Generic;

namespace AkinsoftExcellOkuma.Persistence;

public partial class IsyeriKesinti
{
    public long Blkodu { get; set; }

    public long? Blisyerikodu { get; set; }

    public string Kodu { get; set; } = null!;

    public string? Kesinti { get; set; }

    public double? Tutari { get; set; }

    public string? MuhKodu { get; set; }

    public short? NetMaasiEtkilesin { get; set; }

    public short? GvIndirimiUygula { get; set; }

    public double? GvIndUstSinir { get; set; }
}
