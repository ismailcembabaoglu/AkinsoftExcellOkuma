using System;
using System.Collections.Generic;

namespace AkinsoftExcellOkuma.Persistence;

public partial class PerfDegerTanimi
{
    public long Blkodu { get; set; }

    public string? Baslik { get; set; }

    public string? Aciklama { get; set; }

    public short? Durumu { get; set; }

    public DateTime? BaslamaTarihi { get; set; }

    public DateTime? BitisTarihi { get; set; }

    public short? Kendisi { get; set; }

    public short? Ustu { get; set; }

    public short? UstuMin { get; set; }

    public short? UstuMax { get; set; }

    public short? Asti { get; set; }

    public short? AstiMin { get; set; }

    public short? AstiMax { get; set; }

    public short? Diger { get; set; }

    public short? DigerMin { get; set; }

    public short? DigerMax { get; set; }

    public int? PuanMin { get; set; }

    public int? PuanMax { get; set; }

    public short? AgirlikliPuanKullan { get; set; }

    public double? AgirlikliPuan { get; set; }

    public string? IsyeriKodu { get; set; }

    public long? Sorumlusu { get; set; }

    public string? BilgimetniBlob { get; set; }

    public DateTime? KayitTarihi { get; set; }

    public string? Kaydeden { get; set; }

    public string? Degistiren { get; set; }

    public DateTime? DegistirmeTarihi { get; set; }
}
