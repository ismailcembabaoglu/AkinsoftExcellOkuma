using System;
using System.Collections.Generic;

namespace AkinsoftExcellOkuma.Persistence;

public partial class OtelSalon
{
    public long Blkodu { get; set; }

    public long? Blhesapkodu { get; set; }

    public long? Blkullanimkodu { get; set; }

    public long? Blkapasitekodu { get; set; }

    public string? BolunebilirSalon { get; set; }

    public long? Blanasalonkodu { get; set; }

    public string? SalonAdi { get; set; }

    public string? Aciklama { get; set; }

    public int? MinKapasite { get; set; }

    public int? MaxKapasite { get; set; }

    public short? Paylasilabilir { get; set; }

    public int? SalonToplamBuyukluk { get; set; }

    public int? SalonMaxYukseklik { get; set; }

    public int? SalonMinYukseklik { get; set; }

    public int? SalonGenislik { get; set; }

    public int? SalonUzunluk { get; set; }

    public int? KapiSayisi { get; set; }

    public int? KapiMaxYukseklik { get; set; }

    public int? KapiMinYukseklik { get; set; }

    public int? KapiMaxGenislik { get; set; }

    public int? KapiMinGenislik { get; set; }

    public short? Aktif { get; set; }

    public string? Kaydeden { get; set; }

    public string? Degistiren { get; set; }

    public DateTime? KayitTarihi { get; set; }

    public DateTime? DegistirmeTarihi { get; set; }

    public string? SubeKodu { get; set; }
}
