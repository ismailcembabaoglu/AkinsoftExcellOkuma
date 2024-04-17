using System;
using System.Collections.Generic;

namespace AkinsoftExcellOkuma.Persistence;

public partial class BasvuruIlan
{
    public long Blilankodu { get; set; }

    public string? Pozisyon { get; set; }

    public string? Referansno { get; set; }

    public DateTime? Kayittarihi { get; set; }

    public DateTime? Sonbasvurutarihi { get; set; }

    public short? Siralama { get; set; }

    public string? Kaydeden { get; set; }

    public DateTime? DegistirmeTarihi { get; set; }

    public short? Aktif { get; set; }

    public string? Aciklama { get; set; }

    public string? Degistiren { get; set; }

    public string? Gazete { get; set; }

    public string? Internet { get; set; }

    public string? Radio { get; set; }

    public string? Tv { get; set; }
}
