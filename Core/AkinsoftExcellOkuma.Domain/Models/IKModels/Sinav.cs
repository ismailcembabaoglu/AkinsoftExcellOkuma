using System;
using System.Collections.Generic;

namespace AkinsoftExcellOkuma.Persistence;

public partial class Sinav
{
    public long Blkodu { get; set; }

    public short? SinavAnket { get; set; }

    public string? SinavKodu { get; set; }

    public string Adi { get; set; } = null!;

    public string? OzelKodu { get; set; }

    public string? Aciklama { get; set; }

    public short? Suresi { get; set; }

    public string? Kaydeden { get; set; }

    public string? Degistiren { get; set; }

    public DateTime? DegistirmeTarihi { get; set; }

    public string? YetkiSeviyesi { get; set; }

    public short? Aktif { get; set; }

    public DateTime? BslTarihi { get; set; }

    public DateTime? BtsTarihi { get; set; }

    public short? WebdeGorunsun { get; set; }

    public DateTime? OlusturmaTarihi { get; set; }

    public short? YetkiDurumu { get; set; }

    public string? Yetkililer { get; set; }
}
