using System;
using System.Collections.Generic;

namespace AkinsoftExcellOkuma.Persistence;

public partial class Personel
{
    public long Blkodu { get; set; }

    public string Kodu { get; set; } = null!;

    public string? IsyeriKodu { get; set; }

    public string? IsyeriAdi { get; set; }

    public string? DeprKodu { get; set; }

    public string? DeprAdi { get; set; }

    public string? Adi { get; set; }

    public string? Soyadi { get; set; }

    public string? SskNo { get; set; }

    public DateTime? SskTarihi { get; set; }

    public DateTime? GirisTarihi { get; set; }

    public DateTime? CikisTarihi { get; set; }

    public DateTime? KidemTarihi { get; set; }

    public string? VergiDr { get; set; }

    public string? VergiNo { get; set; }

    public short? UcretTipi { get; set; }

    public short? HesapTipi { get; set; }

    public double? Ucreti { get; set; }

    public string? SigGrubu { get; set; }

    public short? Sakatlik { get; set; }

    public string? SendikaDrm { get; set; }

    public string? SendikaAdi { get; set; }

    public string? SandikAdi { get; set; }

    public string? SandikNo { get; set; }

    public string? SendikaScno { get; set; }

    public short? Cinsiyeti { get; set; }

    public string? BabaAdi { get; set; }

    public string? AnaAdi { get; set; }

    public string? AnalikSoyadi { get; set; }

    public DateTime? DogTarihi { get; set; }

    public string? DogYeri { get; set; }

    public string? TcNo { get; set; }

    public string? KimlikSeri { get; set; }

    public string? CiltNo { get; set; }

    public string? AileSno { get; set; }

    public string? SiraNo { get; set; }

    public string? VerNedeni { get; set; }

    public DateTime? VerTarihi { get; set; }

    public string? VerYer { get; set; }

    public string? KanGrubu { get; set; }

    public short? MedeniDrm { get; set; }

    public string? KayitliIl { get; set; }

    public string? KayitliIlce { get; set; }

    public string? MahKoy { get; set; }

    public short? Gocmen { get; set; }

    public short? IskanunuMd { get; set; }

    public string? Adres1 { get; set; }

    public string? Adres2 { get; set; }

    public string? Telefon { get; set; }

    public string? CepTel { get; set; }

    public string? EMail { get; set; }

    public string? Web { get; set; }

    public string? Aciklama { get; set; }

    public string? Tahsili { get; set; }

    public string? TahsilNot { get; set; }

    public string? Meslegi { get; set; }

    public string? Gorevi { get; set; }

    public string? YabDil1 { get; set; }

    public string? YabDil1drm { get; set; }

    public string? YabDil2 { get; set; }

    public string? YabDil2drm { get; set; }

    public string? EskiFirma { get; set; }

    public string? EskiFrIl { get; set; }

    public string? EskiFrIlce { get; set; }

    public string? EskiFrTel { get; set; }

    public string? EskiFrAdres { get; set; }

    public string? EskiFrYetkili { get; set; }

    public double? CalistigiSure { get; set; }

    public double? DevrGvMatrahi { get; set; }

    public double? DevrGvTutari { get; set; }

    public string? EskiBagkurNo { get; set; }

    public string? EskiEmNo { get; set; }

    public string? DigerSig { get; set; }

    public string? DigerSigNo { get; set; }

    public string? OzelSig { get; set; }

    public string? OzelSigTipi { get; set; }

    public DateTime? OzelSigTrh { get; set; }

    public string? OzelSigNo { get; set; }

    public double? OzelSigTutari { get; set; }

    public string? EsAdi { get; set; }

    public string? EsBilgi { get; set; }

    public string? BakYukumlu1Adi { get; set; }

    public string? BakYukumlu1Ykn { get; set; }

    public double? ToplamGvMatrahi { get; set; }

    public double? ToplamGvTutari { get; set; }

    public string? BakYukumlu2Adi { get; set; }

    public string? BakYukumlu2Ykn { get; set; }

    public string? CikisNedeni { get; set; }

    public short? AsgariUcret { get; set; }

    public short? CocukYard { get; set; }

    public string? Uyrugu { get; set; }

    public short? GrDurumu { get; set; }

    public short? GorevKodu { get; set; }

    public short? SosguvKodu { get; set; }

    public string? CikisNedeniSsk { get; set; }

    public short? TcEmAylik { get; set; }

    public short? BagkurAylik { get; set; }

    public short? DigerAylik { get; set; }

    public string? IstihdamDrm { get; set; }

    public string? PostaKodu { get; set; }

    public string? EsTckimlik { get; set; }

    public string? EsUyrugu { get; set; }

    public string? EsDogyeri { get; set; }

    public DateTime? EsDogtar { get; set; }

    public string? EsAdres { get; set; }

    public string? EsPkodu { get; set; }

    public string? EsEvtel { get; set; }

    public string? EsCeptel { get; set; }

    public string? Yuk1Tckimlik { get; set; }

    public string? Yuk1Uyrugu { get; set; }

    public string? Yuk1Dogyeri { get; set; }

    public DateTime? Yuk1Dogtar { get; set; }

    public string? Yuk1Adres { get; set; }

    public string? Yuk1Pkodu { get; set; }

    public string? Yuk1Evtel { get; set; }

    public string? Yuk1Ceptel { get; set; }

    public string? Yuk2Tckimlik { get; set; }

    public string? Yuk2Uyrugu { get; set; }

    public string? Yuk2Dogyeri { get; set; }

    public DateTime? Yuk2Dogtar { get; set; }

    public string? Yuk2Adres { get; set; }

    public string? Yuk2Pkodu { get; set; }

    public string? Yuk2Evtel { get; set; }

    public string? Yuk2Ceptel { get; set; }

    public string? MuhKodu { get; set; }

    public string? IstenCikisSsk2 { get; set; }

    public string? BelgeTuru { get; set; }

    public string? KanunNo { get; set; }

    public string? OzelKodu1 { get; set; }

    public string? OzelKodu2 { get; set; }

    public string? OzelKodu3 { get; set; }

    public string? OzelKodu4 { get; set; }

    public DateTime? Kayittarihi { get; set; }

    public string? Ayakkabino { get; set; }

    public string? Beden { get; set; }

    public string? Servisgrubu { get; set; }

    public string? Servisduragi { get; set; }

    public string? Banka { get; set; }

    public string? Hesapno { get; set; }

    public string? Calismaplani { get; set; }

    public string? Giriskartno { get; set; }

    public short? Cagriyeri { get; set; }

    public string? Mesaj { get; set; }

    public short? Ptsaatucretli { get; set; }

    public long? Blcrkodu { get; set; }

    public double? Devredenizin { get; set; }

    public DateTime? GirisTarihiIk { get; set; }

    public string? Kullaniciadi { get; set; }

    public string? Kullanicisifre { get; set; }

    public short? Ptkesintiyok { get; set; }

    public string? Grubu { get; set; }

    public string? AraGrubu { get; set; }

    public string? AltGrubu { get; set; }

    public short? AskerlikDurumu { get; set; }

    public short? Tahsili2 { get; set; }

    public short? EhliyetVar { get; set; }

    public string? EhliyetSinif { get; set; }

    public string? TahsilOkul { get; set; }

    public string? TahsilBolum { get; set; }

    public short? Ehliyettecrube { get; set; }

    public short? AgiUygula { get; set; }

    public short? EsAgiUygula { get; set; }

    public short? EsIsdurumu { get; set; }

    public short? EsGelirdurumu { get; set; }

    public string? EsGelirAciklama { get; set; }

    public short? BrDevredenYilizin { get; set; }

    public short? SgkAskerlikDrm { get; set; }

    public DateTime? SgkAskerlikBastar { get; set; }

    public DateTime? SgkAskerlikBittar { get; set; }

    public DateTime? TahsilTarihi { get; set; }

    public double? BireyselEmkSigortasi { get; set; }

    public long? Blbasvurukodu { get; set; }

    public short? OgrenimDurumuSonrasi { get; set; }

    public string? BedenOzellik { get; set; }

    public string? Kaydeden { get; set; }

    public string? Degistiren { get; set; }

    public DateTime? DegistirmeTarihi { get; set; }

    public short? EgitimSurecinde { get; set; }

    public DateTime? EgitimSureci { get; set; }

    public DateTime? EgitimSureci2 { get; set; }

    public short? AgiCocukSayisi { get; set; }

    public DateTime? TesvikBasTar { get; set; }

    public DateTime? TesvikBitTar { get; set; }

    public int? TesvikOrtPersSayi { get; set; }

    public string? SskMeslekKodu { get; set; }

    public string? SskMeslekAck { get; set; }

    public string? Aciladsoyad { get; set; }

    public string? Acilyakinlik { get; set; }

    public string? Acililetisim { get; set; }

    public string? IbanNo { get; set; }

    public DateTime? TransferTarihi { get; set; }

    public string? Bulvar { get; set; }

    public string? Cadde { get; set; }

    public string? Sokak { get; set; }

    public string? MahSemt { get; set; }

    public string? DisKapi { get; set; }

    public string? IcKapi { get; set; }

    public string? Il { get; set; }

    public string? Ilce { get; set; }

    public string? Koy { get; set; }

    public string? Ulke { get; set; }

    public short? SgkIstisnaidurum { get; set; }

    public DateTime? TcmbVizeTarihi { get; set; }

    public double? AskerlikBorctutari { get; set; }

    public short? OtmBesKatilim { get; set; }

    public string? OtmBesFirma { get; set; }

    public double? OtmBesTutari { get; set; }

    public double? OtmBesOrani { get; set; }

    public double? GvIndirimOrani { get; set; }

    public string? TahakkukNedeni { get; set; }

    public int? EngellilikOrani { get; set; }

    public string? OrgBasamak1 { get; set; }

    public string? OrgBasamak2 { get; set; }

    public string? OrgBasamak3 { get; set; }

    public string? OrgBasamak4 { get; set; }

    public string? BelgeTuru2 { get; set; }

    public string? GrubuKodu { get; set; }

    public string? AraGrubuKodu { get; set; }

    public string? AltGrubuKodu { get; set; }

    public string? OrgBasamak1Kodu { get; set; }

    public string? OrgBasamak2Kodu { get; set; }

    public string? OrgBasamak3Kodu { get; set; }

    public string? OrgBasamak4Kodu { get; set; }

    public string? ResimMd5 { get; set; }

    public string? EMail2 { get; set; }

    public short? KullanicisifreDurumu { get; set; }

    public short? PerfDegerHaricTut { get; set; }

    public int? OrtGelmedigiGun { get; set; }

    public DateTime? YillikIzinBasTar { get; set; }

    public double? PrimIadeliOzelSigTutari { get; set; }

    public string? ProjeKodu { get; set; }

    public DateTime? ProjeBaslamaTarihi { get; set; }

    public string? ProjeCalisanTuru { get; set; }
}
