using System;
using System.Collections.Generic;

namespace AkinsoftExcellOkuma.Persistence;

public partial class Isyeri
{
    public long Blkodu { get; set; }

    public string? Adi { get; set; }

    public string Kodu { get; set; } = null!;

    public string? Yetkili { get; set; }

    public string? SskKodu { get; set; }

    public string? CdNo { get; set; }

    public string? SskUnitesi { get; set; }

    public string? BolgeDskodu { get; set; }

    public string? VergiDaire { get; set; }

    public string? VergiNo { get; set; }

    public string? TicSicilno { get; set; }

    public short? TehlikeSinifi { get; set; }

    public double? KazaOrani { get; set; }

    public string? OncelikliBolge { get; set; }

    public DateTime? KurulusTarihi { get; set; }

    public string? Adresi { get; set; }

    public string? Ilce { get; set; }

    public string? Il { get; set; }

    public string? Postakodu { get; set; }

    public string? Telefon1 { get; set; }

    public string? Telefon2 { get; set; }

    public string? Fax { get; set; }

    public string? CepTelefonu { get; set; }

    public string? Web { get; set; }

    public string? EMail { get; set; }

    public string? MuhasebeciAdi { get; set; }

    public string? MuhasebeciSicilno { get; set; }

    public string? MuhasebecoTelefon { get; set; }

    public string? MuhasebeciFax { get; set; }

    public string? IsyeriTuru { get; set; }

    public short? TehlikeDurumu { get; set; }

    public short? OgiBaslangic { get; set; }

    public string? YetkiliTckimlikno { get; set; }

    public string? MuhasebeciVergino { get; set; }

    public string? MuhasebeciTckimlikno { get; set; }

    public string? MuhasebeciEmail { get; set; }

    public string? AraciKodu { get; set; }

    public short? Aktif { get; set; }

    public string? Kullanicilar { get; set; }

    public short? Ziyaretciekrani { get; set; }

    public string? SgkUsername { get; set; }

    public string? SgkUserpwd { get; set; }

    public string? SgkIsyerikodu { get; set; }

    public string? SgkIsyeripwd { get; set; }

    public short? AyarPtkesintitavantip { get; set; }

    public int? AyarPtkesintitavansinir { get; set; }

    public short? AyarOzel { get; set; }

    public string? SgkCalismaKolu { get; set; }

    public double? Tesvik25510Tutar { get; set; }

    public DateTime? Tesvik25510Bittar { get; set; }

    public short? MerkezMi { get; set; }

    public string? AdresKodu { get; set; }

    public string? SskIsyeriKodu { get; set; }

    public string? SskSicilMud { get; set; }

    public short? MulkiyetDurumu { get; set; }

    public DateTime? OtmBesBslTarihi { get; set; }

    public double? OtmBesOrani { get; set; }

    public string? OtmBesFirma { get; set; }

    public string? FaaliyetKodu { get; set; }

    public string? SubeKodu { get; set; }

    public string? IsyeriBolgeKodu { get; set; }
}
