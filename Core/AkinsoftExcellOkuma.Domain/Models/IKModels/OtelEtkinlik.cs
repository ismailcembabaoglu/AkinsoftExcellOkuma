using System;
using System.Collections.Generic;

namespace AkinsoftExcellOkuma.Persistence;

public partial class OtelEtkinlik
{
    public long Blkodu { get; set; }

    public short? Aktif { get; set; }

    public long? Blmuskodu { get; set; }

    public long? Blkontakmuskodu { get; set; }

    public long? Blacentakodu { get; set; }

    public string? BanketAdiSoyadi { get; set; }

    public long? Blperkodu { get; set; }

    public string? EtkinlikAdi { get; set; }

    public DateTime? BaslangicTarihi { get; set; }

    public DateTime? BitisTarihi { get; set; }

    public short? EtkinlikTuru { get; set; }

    public long? BlpazarSgmkodu { get; set; }

    public long? Blkaynakkodu { get; set; }

    public long? Blstatuskodu { get; set; }

    public string? Kaydeden { get; set; }

    public string? Degistiren { get; set; }

    public DateTime? KayitTarihi { get; set; }

    public DateTime? DegistirmeTarihi { get; set; }

    public string? SubeKodu { get; set; }

    public int? KatilimSayisi { get; set; }

    public DateTime? OpsiyonTarihi { get; set; }

    public DateTime? KontratTarihi { get; set; }

    public DateTime? KesinTarih { get; set; }

    public long? Bletktipkodu { get; set; }

    public string? ParaBirimi { get; set; }

    public short? KontrolEdildi { get; set; }

    public short? Hazir { get; set; }

    public string? KontratNumarasi { get; set; }

    public string? Aciklama { get; set; }

    public string? HesapKodu { get; set; }

    public short? Tamamlandi { get; set; }
}
