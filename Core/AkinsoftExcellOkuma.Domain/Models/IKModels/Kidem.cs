using System;
using System.Collections.Generic;

namespace AkinsoftExcellOkuma.Persistence;

public partial class Kidem
{
    public long Blkodu { get; set; }

    public string? IsyeriKodu { get; set; }

    public string? IsyeriAdi { get; set; }

    public double? YillikEkgelir { get; set; }

    public double? Ucreti { get; set; }

    public double? TplEkgelirler { get; set; }

    public double? TplAylikucret { get; set; }

    public int? YilCalisma { get; set; }

    public int? YilDevir { get; set; }

    public int? YilAskerlik { get; set; }

    public int? YilUcretsiz { get; set; }

    public int? YilRaporlu { get; set; }

    public int? YilToplam { get; set; }

    public int? AyCalisma { get; set; }

    public int? AyDevir { get; set; }

    public int? AyAskerlik { get; set; }

    public int? AyUcretsiz { get; set; }

    public int? AyRaporlu { get; set; }

    public int? AyToplam { get; set; }

    public int? GunCalisma { get; set; }

    public int? GunDevir { get; set; }

    public int? GunAskerlik { get; set; }

    public int? GunUcretsiz { get; set; }

    public int? GunRaporlu { get; set; }

    public int? GunToplam { get; set; }

    public double? KidemTazminati { get; set; }

    public double? DamgaVergisi { get; set; }

    public double? NetOdenen { get; set; }

    public long? Blperskodu { get; set; }
}
