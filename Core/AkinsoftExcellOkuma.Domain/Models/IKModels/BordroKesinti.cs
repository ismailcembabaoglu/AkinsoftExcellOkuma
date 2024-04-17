using System;
using System.Collections.Generic;

namespace AkinsoftExcellOkuma.Persistence;

public partial class BordroKesinti
{
    public long Blkodu { get; set; }

    public long? Blbrkodu { get; set; }

    public string? Kodu { get; set; }

    public string? Kesinti { get; set; }

    public double? Tutari { get; set; }

    public string? HesapKodu { get; set; }

    public short? NetMaasiEtkilesin { get; set; }
}
