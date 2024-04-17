using System;
using System.Collections.Generic;

namespace AkinsoftExcellOkuma.Persistence;

public partial class SinavSoruDt
{
    public long Blkodu { get; set; }

    public long? Blmaskodu { get; set; }

    public string? Cevap { get; set; }

    public string? Kaydeden { get; set; }

    public string? Degistiren { get; set; }

    public DateTime? DegistirmeTarihi { get; set; }

    public string? Secenek { get; set; }

    public short? Sira { get; set; }

    public short? MetinGirisi { get; set; }
}
