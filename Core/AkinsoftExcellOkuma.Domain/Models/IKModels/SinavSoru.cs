using System;
using System.Collections.Generic;

namespace AkinsoftExcellOkuma.Persistence;

public partial class SinavSoru
{
    public long Blkodu { get; set; }

    public long? Blmaskodu { get; set; }

    public string? Soru { get; set; }

    public short? SoruNo { get; set; }

    public double? Puan { get; set; }

    public string? Cevap { get; set; }

    public string? Kaydeden { get; set; }

    public string? Degistiren { get; set; }

    public DateTime? DegistirmeTarihi { get; set; }

    public short? SoruSira { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public short? Cevaptipi { get; set; }
}
