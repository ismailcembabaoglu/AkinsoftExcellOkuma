using System;
using System.Collections.Generic;

namespace AkinsoftExcellOkuma.Persistence;

public partial class PerfDegerSoru
{
    public long Blkodu { get; set; }

    public long? Blpdtkodu { get; set; }

    public string? Baslik { get; set; }

    public short? Sirano { get; set; }

    public long? Blkrkodu { get; set; }

    public double? EtkiYuzdesi { get; set; }

    public DateTime? KayitTarihi { get; set; }

    public string? Kaydeden { get; set; }

    public string? Degistiren { get; set; }

    public DateTime? DegistirmeTarihi { get; set; }
}
