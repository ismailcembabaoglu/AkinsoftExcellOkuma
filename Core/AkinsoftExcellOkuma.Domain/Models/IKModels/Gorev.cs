using System;
using System.Collections.Generic;

namespace AkinsoftExcellOkuma.Persistence;

public partial class Gorev
{
    public long Blkodu { get; set; }

    public long Blperkodu { get; set; }

    public DateTime? KayitTarihi { get; set; }

    public string? Tanimi { get; set; }

    public string? GorevVeren { get; set; }

    public DateTime? BasTarihi { get; set; }

    public DateTime? BitTarihi { get; set; }

    public DateTime? TamamlanmaTarihi { get; set; }

    public string? OzelKodu1 { get; set; }

    public string? OzelKodu2 { get; set; }

    public string? Aciklama { get; set; }

    public short? Durumu { get; set; }

    public double? KanaatNotu { get; set; }

    public string? Grubu { get; set; }

    public string? Kaydeden { get; set; }

    public string? Degistiren { get; set; }

    public DateTime? DegistirmeTarihi { get; set; }
}
