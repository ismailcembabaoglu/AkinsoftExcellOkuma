using System;
using System.Collections.Generic;

namespace AkinsoftExcellOkuma.Persistence;

public partial class OtelEnvanter
{
    public long Blkodu { get; set; }

    public long? Blbirimkodu { get; set; }

    public long? Blkategorikodu { get; set; }

    public long? Blhesapkodu { get; set; }

    public string? EnvanterAdi { get; set; }

    public string? Aciklama { get; set; }

    public int? Adeti { get; set; }

    public int? HazirlanmaZamani { get; set; }

    public int? ToplanmaZamani { get; set; }

    public short? RezervasyonEnvanter { get; set; }

    public string? Kaydeden { get; set; }

    public string? Degistiren { get; set; }

    public DateTime? KayitTarihi { get; set; }

    public DateTime? DegistirmeTarihi { get; set; }

    public string? SubeKodu { get; set; }

    public short? Aktif { get; set; }
}
