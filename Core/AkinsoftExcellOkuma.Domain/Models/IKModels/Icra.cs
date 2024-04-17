using System;
using System.Collections.Generic;

namespace AkinsoftExcellOkuma.Persistence;

public partial class Icra
{
    public long Blkodu { get; set; }

    public long Perblkodu { get; set; }

    public string? Alacakli { get; set; }

    public DateTime? Tarihi { get; set; }

    public string? AliciIbanNo { get; set; }

    public int? SiraNo { get; set; }

    public string? DosyaNo { get; set; }

    public double? ToplamBorc { get; set; }

    public string? OzelKodu { get; set; }

    public string? Durumu { get; set; }

    public string? Aciklama { get; set; }

    public DateTime? KayitTarihi { get; set; }

    public string? MahkemeAdi { get; set; }

    public string? IcraDairesi { get; set; }

    public string? BankaAdi { get; set; }

    public string? SubeAdi { get; set; }

    public string? HesapNumarasi { get; set; }

    public short? KesintiTuru { get; set; }

    public double? KesintiOrani1 { get; set; }

    public double? KesintiOrani2 { get; set; }

    public double? KesintiTutari { get; set; }

    public short? AgiDahil { get; set; }

    public short? BaslangicYil { get; set; }

    public short? BaslangicAykodu { get; set; }

    public int? OncelikSirasi { get; set; }

    public short? OtokesintiKullan { get; set; }

    public double? OncOdenentutar { get; set; }
}
