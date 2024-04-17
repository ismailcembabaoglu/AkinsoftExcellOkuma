using System;
using System.Collections.Generic;

namespace AkinsoftExcellOkuma.Persistence;

public partial class Aciklama
{
    public long Blkodu { get; set; }

    public long? Blmaskodu { get; set; }

    public DateTime? KayitTarih { get; set; }

    public string? Aciklama1 { get; set; }

    public string? AckKodu { get; set; }

    public string? Kaydeden { get; set; }

    public string? Degistiren { get; set; }

    public string? Modul { get; set; }

    public DateTime? DegistirmeTarihi { get; set; }

    public DateTime? Randevutarihi { get; set; }

    public string? OzelKodu1 { get; set; }

    public string? OzelKodu2 { get; set; }

    public short? YoneticiOnay { get; set; }
}
