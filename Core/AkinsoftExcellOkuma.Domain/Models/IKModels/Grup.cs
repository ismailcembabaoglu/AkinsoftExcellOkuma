using System;
using System.Collections.Generic;

namespace AkinsoftExcellOkuma.Persistence;

public partial class Grup
{
    public long Blkodu { get; set; }

    public string GrupAdi { get; set; } = null!;

    public string? Aciklama { get; set; }

    public string? Modul { get; set; }

    public string? GrupKodu { get; set; }

    public int? Sira { get; set; }

    public DateTime? KayitTarihi { get; set; }

    public string? Kaydeden { get; set; }

    public string? Degistiren { get; set; }

    public DateTime? DegistirmeTarihi { get; set; }
}
