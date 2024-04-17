using System;
using System.Collections.Generic;

namespace AkinsoftExcellOkuma.Persistence;

public partial class DrRapor
{
    public long Blkodu { get; set; }

    public long Blperkodu { get; set; }

    public long? Blbetkodu { get; set; }

    public DateTime? ViziteTarihi { get; set; }

    public string? SaglikTesisi { get; set; }

    public string? Poliklinik { get; set; }

    public short? IsKazasi { get; set; }

    public short? MeslekHastaligi { get; set; }

    public short? Hastalik { get; set; }

    public short? Analik { get; set; }

    public short? PeriyodikKontrol { get; set; }

    public string? Teshis { get; set; }

    public DateTime? PoliklinikTarihi { get; set; }

    public int? PoliklinikDefterSn { get; set; }

    public string? HekimAdisoyadi { get; set; }

    public string? HekimSicilno { get; set; }

    public string? HekimDiploma { get; set; }

    public string? HekimTescilno { get; set; }

    public DateTime? HastaneyeYatisTarihi { get; set; }

    public DateTime? HastanedenCikisTarihi { get; set; }

    public DateTime? IstirahatBaslangicTarihi { get; set; }

    public DateTime? IstirahatBitisTarihi { get; set; }

    public DateTime? CalismayaBaslamaTarihi { get; set; }

    public DateTime? SonrakiKontrolTarihi { get; set; }

    public string? Aciklama { get; set; }

    public string? Kaydeden { get; set; }

    public string? Degistiren { get; set; }

    public DateTime? DegistirmeTarihi { get; set; }
}
