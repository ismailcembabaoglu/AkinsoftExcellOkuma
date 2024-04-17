using System;
using System.Collections.Generic;

namespace AkinsoftExcellOkuma.Persistence;

public partial class Egitim
{
    public long Blkodu { get; set; }

    public DateTime? KayitTarihi { get; set; }

    public string? Adi { get; set; }

    public string? Yeri { get; set; }

    public DateTime? Tarihi { get; set; }

    public double? Suresi { get; set; }

    public short? SureTipi { get; set; }

    public string? OzelKodu1 { get; set; }

    public string? OzelKodu2 { get; set; }

    public string? Grubu { get; set; }

    public string? DuzenleyenFirma { get; set; }

    public string? DuzenleyenYetkili { get; set; }

    public string? DuzenleyenTel1 { get; set; }

    public string? DuzenleyenTel2 { get; set; }

    public string? Egitimciler { get; set; }

    public short? Durumu { get; set; }

    public string? Ekbilgi { get; set; }

    public string? EkbilgiOnlineik { get; set; }

    public string? Kaydeden { get; set; }

    public string? Degistiren { get; set; }

    public DateTime? DegistirmeTarihi { get; set; }

    public short? OnlineIk { get; set; }
}
