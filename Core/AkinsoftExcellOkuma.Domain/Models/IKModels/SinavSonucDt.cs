using System;
using System.Collections.Generic;

namespace AkinsoftExcellOkuma.Persistence;

public partial class SinavSonucDt
{
    public long Blkodu { get; set; }

    public long? Blmaskodu { get; set; }

    public short? SoruNo { get; set; }

    public string? Cevap { get; set; }

    public string? Kaydeden { get; set; }

    public string? Degistiren { get; set; }

    public DateTime? DegistirmeTarihi { get; set; }

    public string? CevapAciklama { get; set; }

    public double? Puan { get; set; }
}
