using System;
using System.Collections.Generic;

namespace AkinsoftExcellOkuma.Persistence;

public partial class IkBasvuru
{
    public long Blkodu { get; set; }

    public string? Departman1 { get; set; }

    public string? Departman2 { get; set; }

    public string? Departman3 { get; set; }

    public DateTime? BasvuruTarihi { get; set; }

    public DateTime? EgitimSureci { get; set; }

    public DateTime? DenemeSureci { get; set; }

    public DateTime? IseBaslama { get; set; }

    public short? CalismaSaatleri { get; set; }

    public short? MedeniHali { get; set; }

    public string? DogumYeri { get; set; }

    public DateTime? DogumTarihi { get; set; }

    public string? Uyrugu { get; set; }

    public short? CocukSayisi { get; set; }

    public short? AilesininYaninda { get; set; }

    public string? BabaMeslegi { get; set; }

    public short? KardesSayisi { get; set; }

    public string? Meslegi { get; set; }

    public short? GeliriVarmi { get; set; }

    public double? AylikGeliri { get; set; }

    public short? AskerlikDurumu { get; set; }

    public short? EhliyetVarmi { get; set; }

    public string? EhliyetTipi { get; set; }

    public short? SeyahatProb { get; set; }

    public string? EsAdi { get; set; }

    public string? EsMeslegi { get; set; }

    public string? OncekiSoyadi { get; set; }

    public string? EvTel { get; set; }

    public string? CepTel { get; set; }

    public string? EMail { get; set; }

    public string? Ili { get; set; }

    public string? Ilcesi { get; set; }

    public string? Adresi { get; set; }

    public string? DoktoraYil { get; set; }

    public string? DoktoraOkul { get; set; }

    public string? DoktoraFakulte { get; set; }

    public string? DoktoraBolum { get; set; }

    public string? YuklisansYil { get; set; }

    public string? YuklisansOkul { get; set; }

    public string? YuklisansFakulte { get; set; }

    public string? YuklisansBolum { get; set; }

    public string? LisansYil { get; set; }

    public string? LisansOkul { get; set; }

    public string? LisansFakulte { get; set; }

    public string? LisansBolum { get; set; }

    public string? OnlisansYil { get; set; }

    public string? OnlisansOkul { get; set; }

    public string? OnlisansFakulte { get; set; }

    public string? OnlisansBolum { get; set; }

    public string? LiseYil { get; set; }

    public string? LiseOkul { get; set; }

    public string? LiseFakulte { get; set; }

    public string? LiseBolum { get; set; }

    public string? IlkogrYil { get; set; }

    public string? IlkogrOkul { get; set; }

    public string? IlkogrFakulte { get; set; }

    public string? IlkogrBolum { get; set; }

    public short? EgitimDevam { get; set; }

    public short? EgitimGungece { get; set; }

    public string? EgitimGngcsys { get; set; }

    public string? EgitimKonu { get; set; }

    public string? IsFirma1 { get; set; }

    public string? IsBirim1 { get; set; }

    public string? IsGorev1 { get; set; }

    public string? IsAyrilmatrh1 { get; set; }

    public string? IsCalismasure1 { get; set; }

    public string? IsFirma2 { get; set; }

    public string? IsBirim2 { get; set; }

    public string? IsGorev2 { get; set; }

    public string? IsAyrilmatrh2 { get; set; }

    public string? IsCalismasure2 { get; set; }

    public string? IsFirma3 { get; set; }

    public string? IsBirim3 { get; set; }

    public string? IsGorev3 { get; set; }

    public string? IsAyrilmatrh3 { get; set; }

    public string? IsCalismasure3 { get; set; }

    public string? IsFirma4 { get; set; }

    public string? IsBirim4 { get; set; }

    public string? IsGorev4 { get; set; }

    public string? IsAyrilmatrh4 { get; set; }

    public string? IsCalismasure4 { get; set; }

    public string? Ref1Adsoyad { get; set; }

    public string? Ref1Kurum { get; set; }

    public string? Ref1Tel { get; set; }

    public string? Ref1Gorev { get; set; }

    public string? Ref2Adsoyad { get; set; }

    public string? Ref2Kurum { get; set; }

    public string? Ref2Tel { get; set; }

    public string? Ref2Gorev { get; set; }

    public string? Ref3Adsoyad { get; set; }

    public string? Ref3Kurum { get; set; }

    public string? Ref3Tel { get; set; }

    public string? Ref3Gorev { get; set; }

    public string? SaglikDurumu { get; set; }

    public double? DusAylikUcret { get; set; }

    public short? SigaraKul { get; set; }

    public short? YoneticiDuzeyi { get; set; }

    public short? Durumu { get; set; }

    public short? Cinsiyeti { get; set; }

    public short? DurumuPrmd { get; set; }

    public short? OgrenimDurumu { get; set; }

    public DateTime? EgitimSureci2 { get; set; }

    public DateTime? DenemeSureci2 { get; set; }

    public DateTime? IstenAyrTrh { get; set; }

    public string? Kaydeden { get; set; }

    public string? Degistiren { get; set; }

    public DateTime? DegistirmeTarihi { get; set; }

    public string? TecilTarihi { get; set; }

    public string? TecilNedeni { get; set; }

    public string? Beklentiler { get; set; }

    public string? OzelKodu { get; set; }

    public string? Referansno { get; set; }

    public string? Web { get; set; }

    public string? Aciklama { get; set; }

    public short? Dahaoncecalisti { get; set; }

    public string? Dahaoncedurum { get; set; }

    public short? Silindi { get; set; }

    public string? Adi { get; set; }

    public string? Soyadi { get; set; }

    public string? Basvurukaynak { get; set; }

    public string? Gorusler { get; set; }

    public string? Babaadi { get; set; }

    public string? Anaadi { get; set; }

    public short? SurusTecrubesi { get; set; }

    public short? WebdeGorunsun { get; set; }

    public string? IsyeriAdi { get; set; }

    public string? IsyeriKodu { get; set; }

    public short? OgrenimDurumuSonrasi { get; set; }

    public long? Blperkodu { get; set; }

    public string? DepartmanUygun { get; set; }

    public string? TckimlikNo { get; set; }

    public string? Kangrubu { get; set; }

    public string? Aranacakadisoyadi { get; set; }

    public string? Aranacaktelno { get; set; }

    public string? Kendinitanit { get; set; }

    public string? IsAyrilmanedeni1 { get; set; }

    public string? IsAyrilmanedeni2 { get; set; }

    public string? IsAyrilmanedeni3 { get; set; }

    public string? IsAyrilmanedeni4 { get; set; }

    public string? SeminerTanimi1 { get; set; }

    public string? SeminerBastar1 { get; set; }

    public string? SeminerBittar1 { get; set; }

    public string? SeminerAciklama1 { get; set; }

    public string? SeminerTanimi2 { get; set; }

    public string? SeminerBastar2 { get; set; }

    public string? SeminerBittar2 { get; set; }

    public string? SeminerAciklama2 { get; set; }

    public string? SeminerTanimi3 { get; set; }

    public string? SeminerBastar3 { get; set; }

    public string? SeminerBittar3 { get; set; }

    public string? SeminerAciklama3 { get; set; }

    public string? Onlisans2Yil { get; set; }

    public string? Onlisans2Okul { get; set; }

    public string? Onlisans2Fakulte { get; set; }

    public string? Onlisans2Bolum { get; set; }

    public string? Lisans2Yil { get; set; }

    public string? Lisans2Okul { get; set; }

    public string? Lisans2Fakulte { get; set; }

    public string? Lisans2Bolum { get; set; }

    public short? SabikakaydiVarmi { get; set; }

    public short? FirmadayakiniVarmi { get; set; }

    public string? EkgelirAciklamasi { get; set; }
}
