using System;
using System.Collections.Generic;

namespace AkinsoftExcellOkuma.Persistence;

public partial class PerfDegerSoruDetay
{
    public long Blkodu { get; set; }

    public long? Blsrkodu { get; set; }

    public string? Soru { get; set; }

    public short? Durumu { get; set; }

    public short? Sirano { get; set; }

    public DateTime? KayitTarihi { get; set; }

    public string? Kaydeden { get; set; }

    public string? Degistiren { get; set; }

    public DateTime? DegistirmeTarihi { get; set; }
}
