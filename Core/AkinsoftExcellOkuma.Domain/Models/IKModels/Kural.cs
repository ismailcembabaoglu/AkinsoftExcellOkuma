using System;
using System.Collections.Generic;

namespace AkinsoftExcellOkuma.Persistence;

public partial class Kural
{
    public long Blkodu { get; set; }

    public string? Tanimi { get; set; }

    public int? KisiSayisi { get; set; }

    public string? Modul { get; set; }

    public long? Blmaskodu { get; set; }

    public string? Aciklama { get; set; }

    public DateTime? KayitTarihi { get; set; }

    public string? Kaydeden { get; set; }

    public string? Degistiren { get; set; }

    public DateTime? DegistirmeTarihi { get; set; }
}
