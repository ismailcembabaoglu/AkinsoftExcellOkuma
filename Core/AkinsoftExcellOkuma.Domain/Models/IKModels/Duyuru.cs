using System;
using System.Collections.Generic;

namespace AkinsoftExcellOkuma.Persistence;

public partial class Duyuru
{
    public long Blkodu { get; set; }

    public string? Tanim { get; set; }

    public DateTime? KayitTarihi { get; set; }

    public DateTime? YayinTarihi { get; set; }

    public DateTime? BitisTarihi { get; set; }

    public string? Icerik { get; set; }

    public string? Siralama { get; set; }

    public string? Kaydeden { get; set; }

    public string? Degistiren { get; set; }

    public DateTime? DegistirmeTarihi { get; set; }

    public short? Durumu { get; set; }

    public short? YetkiDurumu { get; set; }

    public string? Yetkililer { get; set; }

    public string? Modul { get; set; }
}
