using System;
using System.Collections.Generic;

namespace AkinsoftExcellOkuma.Persistence;

public partial class PersonelCocuk
{
    public long Blkodu { get; set; }

    public long? Blpersonelkodu { get; set; }

    public string? Adi { get; set; }

    public string? Cinsiyeti { get; set; }

    public DateTime? DogTarihi { get; set; }

    public string? Tahsili { get; set; }

    public string? Aciklama { get; set; }

    public string? Tckimlik { get; set; }

    public string? Uyrugu { get; set; }

    public string? DogumYeri { get; set; }

    public short? AgiUygula { get; set; }

    public string? BabaAdi { get; set; }

    public string? AnaAdi { get; set; }

    public string? AgiAciklama { get; set; }

    public DateTime? OkulKayitTarihi { get; set; }

    public string? OkulAdi { get; set; }

    public string? OkulSinifi { get; set; }

    public short? CocukYardimi { get; set; }
}
