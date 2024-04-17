using System;
using System.Collections.Generic;

namespace AkinsoftExcellOkuma.Persistence;

public partial class SinavSonuc
{
    public long Blkodu { get; set; }

    public long? Blsnkodu { get; set; }

    public string? SinavAdi { get; set; }

    public short? SinavAnket { get; set; }

    public long? Personelkodu { get; set; }

    public string? AdiSoyadi { get; set; }

    public string? EkBilgiler { get; set; }

    public DateTime? Tarihi { get; set; }

    public DateTime? BaslSaati { get; set; }

    public DateTime? BitisSaati { get; set; }

    public double? PuanKatsy { get; set; }

    public string? Kaydeden { get; set; }

    public string? Degistiren { get; set; }

    public DateTime? DegistirmeTarihi { get; set; }
}
