using System;
using System.Collections.Generic;
using AkinsoftExcellOkuma.Persistence;
using Microsoft.EntityFrameworkCore;

namespace AkinsoftExcellOkuma.Persistence.Contexts;

public partial class Wolvox80012024IkaynakContext : DbContext
{
  

    public Wolvox80012024IkaynakContext(DbContextOptions<Wolvox80012024IkaynakContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Aciklama> Aciklamas { get; set; }

    public virtual DbSet<AciklamaKodu> AciklamaKodus { get; set; }

    public virtual DbSet<Agi> Agis { get; set; }

    public virtual DbSet<Ayar> Ayars { get; set; }

    public virtual DbSet<BasvuruIlan> BasvuruIlans { get; set; }

    public virtual DbSet<BioCihaz> BioCihazs { get; set; }

    public virtual DbSet<Bordro> Bordros { get; set; }

    public virtual DbSet<BordroDepartman> BordroDepartmen { get; set; }

    public virtual DbSet<BordroEvrakTakip> BordroEvrakTakips { get; set; }

    public virtual DbSet<BordroKesinti> BordroKesintis { get; set; }

    public virtual DbSet<BordroYardim> BordroYardims { get; set; }

    public virtual DbSet<CalismaPlaniPersonel> CalismaPlaniPersonels { get; set; }

    public virtual DbSet<Calismagunleri> Calismagunleris { get; set; }

    public virtual DbSet<Calismaplan> Calismaplans { get; set; }

    public virtual DbSet<DegisimLog> DegisimLogs { get; set; }

    public virtual DbSet<DrRapor> DrRapors { get; set; }

    public virtual DbSet<Duyuru> Duyurus { get; set; }

    public virtual DbSet<Egitim> Egitims { get; set; }

    public virtual DbSet<EgitimDetay> EgitimDetays { get; set; }

    public virtual DbSet<Entegrasyon> Entegrasyons { get; set; }

    public virtual DbSet<ErpKesintiKod> ErpKesintiKods { get; set; }

    public virtual DbSet<Evraksabit> Evraksabits { get; set; }

    public virtual DbSet<GenIdt> GenIdts { get; set; }

    public virtual DbSet<Girisciki> Giriscikis { get; set; }

    public virtual DbSet<Gorev> Gorevs { get; set; }

    public virtual DbSet<Grup> Grups { get; set; }

    public virtual DbSet<GrupAlt> GrupAlts { get; set; }

    public virtual DbSet<GrupAlt2> GrupAlt2s { get; set; }

    public virtual DbSet<GrupAra> GrupAras { get; set; }

    public virtual DbSet<Icmal> Icmals { get; set; }

    public virtual DbSet<Icra> Icras { get; set; }

    public virtual DbSet<IcraHrk> IcraHrks { get; set; }

    public virtual DbSet<Ihbar> Ihbars { get; set; }

    public virtual DbSet<IkBasvuru> IkBasvurus { get; set; }

    public virtual DbSet<IkBasvuruAciklama> IkBasvuruAciklamas { get; set; }

    public virtual DbSet<IkBasvuruOzellik> IkBasvuruOzelliks { get; set; }

    public virtual DbSet<IkBasvuruOzellikEslestir> IkBasvuruOzellikEslestirs { get; set; }

    public virtual DbSet<IkBasvuruOzellikTanim> IkBasvuruOzellikTanims { get; set; }

    public virtual DbSet<IkDurum> IkDurums { get; set; }

    public virtual DbSet<IstekOneri> IstekOneris { get; set; }

    public virtual DbSet<Isyeri> Isyeris { get; set; }

    public virtual DbSet<IsyeriKesinti> IsyeriKesintis { get; set; }

    public virtual DbSet<IsyeriProje> IsyeriProjes { get; set; }

    public virtual DbSet<IsyeriYardim> IsyeriYardims { get; set; }

    public virtual DbSet<Kidem> Kidems { get; set; }

    public virtual DbSet<KullaniciOzelrapor> KullaniciOzelrapors { get; set; }

    public virtual DbSet<Kural> Kurals { get; set; }

    public virtual DbSet<KuralDetay> KuralDetays { get; set; }

    public virtual DbSet<LangCustomize> LangCustomizes { get; set; }

    public virtual DbSet<MailSmsLog> MailSmsLogs { get; set; }

    public virtual DbSet<Mazerettanim> Mazerettanims { get; set; }

    public virtual DbSet<Offline> Offlines { get; set; }

    public virtual DbSet<Ogi> Ogis { get; set; }

    public virtual DbSet<OtelDephaberHr> OtelDephaberHrs { get; set; }

    public virtual DbSet<OtelDephaberTanim> OtelDephaberTanims { get; set; }

    public virtual DbSet<OtelEnvanter> OtelEnvanters { get; set; }

    public virtual DbSet<OtelEnvanterFiyat> OtelEnvanterFiyats { get; set; }

    public virtual DbSet<OtelEnvanterHareket> OtelEnvanterHarekets { get; set; }

    public virtual DbSet<OtelEtkinlik> OtelEtkinliks { get; set; }

    public virtual DbSet<OtelSalon> OtelSalons { get; set; }

    public virtual DbSet<OtelSalonBakim> OtelSalonBakims { get; set; }

    public virtual DbSet<OtelSalonDuzen> OtelSalonDuzens { get; set; }

    public virtual DbSet<OtelSalonFiyat> OtelSalonFiyats { get; set; }

    public virtual DbSet<OtelSalonIletisim> OtelSalonIletisims { get; set; }

    public virtual DbSet<OtelSalonhr> OtelSalonhrs { get; set; }

    public virtual DbSet<OtelSantralAyar> OtelSantralAyars { get; set; }

    public virtual DbSet<Ozelalangrup> Ozelalangrups { get; set; }

    public virtual DbSet<Ozelalantanim> Ozelalantanims { get; set; }

    public virtual DbSet<PerGrup> PerGrups { get; set; }

    public virtual DbSet<PerfDeger> PerfDegers { get; set; }

    public virtual DbSet<PerfDegerPuanAgirligi> PerfDegerPuanAgirligis { get; set; }

    public virtual DbSet<PerfDegerPuanEtkiyuzdesi> PerfDegerPuanEtkiyuzdesis { get; set; }

    public virtual DbSet<PerfDegerPuanlama> PerfDegerPuanlamas { get; set; }

    public virtual DbSet<PerfDegerSoru> PerfDegerSorus { get; set; }

    public virtual DbSet<PerfDegerSoruDetay> PerfDegerSoruDetays { get; set; }

    public virtual DbSet<PerfDegerTanimi> PerfDegerTanimis { get; set; }

    public virtual DbSet<Personel> Personels { get; set; }

    public virtual DbSet<PersonelAvan> PersonelAvans { get; set; }

    public virtual DbSet<PersonelAylikYetki> PersonelAylikYetkis { get; set; }

    public virtual DbSet<PersonelCocuk> PersonelCocuks { get; set; }

    public virtual DbSet<PersonelDevredenSpm> PersonelDevredenSpms { get; set; }

    public virtual DbSet<PersonelEvrak> PersonelEvraks { get; set; }

    public virtual DbSet<PersonelIkramiyeharcirah> PersonelIkramiyeharcirahs { get; set; }

    public virtual DbSet<PersonelIsyeriNakil> PersonelIsyeriNakils { get; set; }

    public virtual DbSet<PersonelKesinti> PersonelKesintis { get; set; }

    public virtual DbSet<PersonelTransferLog> PersonelTransferLogs { get; set; }

    public virtual DbSet<PersonelUstPersonel> PersonelUstPersonels { get; set; }

    public virtual DbSet<PersonelYardim> PersonelYardims { get; set; }

    public virtual DbSet<PersonelYilizsayilmayangun> PersonelYilizsayilmayanguns { get; set; }

    public virtual DbSet<Puantaj> Puantajs { get; set; }

    public virtual DbSet<PuantajCetveli> PuantajCetvelis { get; set; }

    public virtual DbSet<PuantajKesinti> PuantajKesintis { get; set; }

    public virtual DbSet<PuantajYardim> PuantajYardims { get; set; }

    public virtual DbSet<Sgkislemsonuc> Sgkislemsonucs { get; set; }

    public virtual DbSet<Sinav> Sinavs { get; set; }

    public virtual DbSet<SinavSonuc> SinavSonucs { get; set; }

    public virtual DbSet<SinavSonucDt> SinavSonucDts { get; set; }

    public virtual DbSet<SinavSoru> SinavSorus { get; set; }

    public virtual DbSet<SinavSoruDt> SinavSoruDts { get; set; }

    public virtual DbSet<Sqlcreate> Sqlcreates { get; set; }

    public virtual DbSet<SskTesvikTanim> SskTesvikTanims { get; set; }

    public virtual DbSet<Vardiyasabit> Vardiyasabits { get; set; }

    public virtual DbSet<Yemekhanegiris> Yemekhanegirises { get; set; }

    public virtual DbSet<Yillikizin> Yillikizins { get; set; }

    public virtual DbSet<YillikizinPlan> YillikizinPlans { get; set; }

    public virtual DbSet<Ysayar> Ysayars { get; set; }

    public virtual DbSet<Ziyaretci> Ziyaretcis { get; set; }

    public virtual DbSet<Ziyaretcikart> Ziyaretcikarts { get; set; }

    public virtual DbSet<ZorunluAlanlar> ZorunluAlanlars { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Turkish_CI_AI");

        modelBuilder.Entity<Aciklama>(entity =>
        {
            entity.HasKey(e => e.Blkodu).HasName("PK__ACIKLAMA__24967F26AD7B07BE");

            entity.ToTable("ACIKLAMA");

            entity.HasIndex(e => e.Blmaskodu, "ACK_BLMASKODU");

            entity.HasIndex(e => e.Modul, "ACK_MODUL");

            entity.Property(e => e.Blkodu)
                .ValueGeneratedNever()
                .HasColumnName("BLKODU");
            entity.Property(e => e.Aciklama1)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.AckKodu)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ACK_KODU");
            entity.Property(e => e.Blmaskodu).HasColumnName("BLMASKODU");
            entity.Property(e => e.Degistiren)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DEGISTIREN");
            entity.Property(e => e.DegistirmeTarihi)
                .HasColumnType("datetime")
                .HasColumnName("DEGISTIRME_TARIHI");
            entity.Property(e => e.Kaydeden)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KAYDEDEN");
            entity.Property(e => e.KayitTarih)
                .HasColumnType("datetime")
                .HasColumnName("KAYIT_TARIH");
            entity.Property(e => e.Modul)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MODUL");
            entity.Property(e => e.OzelKodu1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OZEL_KODU_1");
            entity.Property(e => e.OzelKodu2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OZEL_KODU_2");
            entity.Property(e => e.Randevutarihi)
                .HasColumnType("datetime")
                .HasColumnName("RANDEVUTARIHI");
            entity.Property(e => e.YoneticiOnay).HasColumnName("YONETICI_ONAY");
        });

        modelBuilder.Entity<AciklamaKodu>(entity =>
        {
            entity.HasKey(e => e.Blaciklamakodu).HasName("PK__ACIKLAMA__BF40220274DB04E0");

            entity.ToTable("ACIKLAMA_KODU");

            entity.HasIndex(e => e.Kodu, "UQ__ACIKLAMA__BF69F8F628161DB3").IsUnique();

            entity.Property(e => e.Blaciklamakodu)
                .ValueGeneratedNever()
                .HasColumnName("BLACIKLAMAKODU");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Degistiren)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DEGISTIREN");
            entity.Property(e => e.DegistirmeTarihi)
                .HasColumnType("datetime")
                .HasColumnName("DEGISTIRME_TARIHI");
            entity.Property(e => e.Kaydeden)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KAYDEDEN");
            entity.Property(e => e.Kodu)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("KODU");
            entity.Property(e => e.Modul)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MODUL");
        });

        modelBuilder.Entity<Agi>(entity =>
        {
            entity.HasKey(e => e.Blkodu).HasName("PK__AGI__24967F26B14F53E0");

            entity.ToTable("AGI");

            entity.Property(e => e.Blkodu)
                .ValueGeneratedNever()
                .HasColumnName("BLKODU");
            entity.Property(e => e.AgiAylikTutar).HasColumnName("AGI_AYLIK_TUTAR");
            entity.Property(e => e.AgiEsasTutar).HasColumnName("AGI_ESAS_TUTAR");
            entity.Property(e => e.AgiOrani).HasColumnName("AGI_ORANI");
            entity.Property(e => e.Blprkodu).HasColumnName("BLPRKODU");
            entity.Property(e => e.BrutUcret).HasColumnName("BRUT_UCRET");
            entity.Property(e => e.TutarAgu).HasColumnName("TUTAR_AGU");
            entity.Property(e => e.TutarAra).HasColumnName("TUTAR_ARA");
            entity.Property(e => e.TutarEki).HasColumnName("TUTAR_EKI");
            entity.Property(e => e.TutarEyl).HasColumnName("TUTAR_EYL");
            entity.Property(e => e.TutarHaz).HasColumnName("TUTAR_HAZ");
            entity.Property(e => e.TutarKas).HasColumnName("TUTAR_KAS");
            entity.Property(e => e.TutarMar).HasColumnName("TUTAR_MAR");
            entity.Property(e => e.TutarMay).HasColumnName("TUTAR_MAY");
            entity.Property(e => e.TutarNis).HasColumnName("TUTAR_NIS");
            entity.Property(e => e.TutarOca).HasColumnName("TUTAR_OCA");
            entity.Property(e => e.TutarSub).HasColumnName("TUTAR_SUB");
            entity.Property(e => e.TutarTem).HasColumnName("TUTAR_TEM");
        });

        modelBuilder.Entity<Ayar>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AYAR");

            entity.Property(e => e.AvansiOmAl).HasColumnName("AVANSI_OM_AL");
            entity.Property(e => e.Blkodu).HasColumnName("BLKODU");
            entity.Property(e => e.BordroYuvarlama).HasColumnName("BORDRO_YUVARLAMA");
            entity.Property(e => e.Cikistayuvarlama).HasColumnName("CIKISTAYUVARLAMA");
            entity.Property(e => e.Cikistayuvarlamatipi).HasColumnName("CIKISTAYUVARLAMATIPI");
            entity.Property(e => e.ClyiliKont).HasColumnName("CLYILI_KONT");
            entity.Property(e => e.DegisimLog).HasColumnName("DEGISIM_LOG");
            entity.Property(e => e.DoggunHatirlat).HasColumnName("DOGGUN_HATIRLAT");
            entity.Property(e => e.DoggunHatirlatGun).HasColumnName("DOGGUN_HATIRLAT_GUN");
            entity.Property(e => e.Drraporeksikgunkodu)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("DRRAPOREKSIKGUNKODU");
            entity.Property(e => e.Dvmzeksikgunkodu)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("DVMZEKSIKGUNKODU");
            entity.Property(e => e.EgitimsuresibitenHatirlat).HasColumnName("EGITIMSURESIBITEN_HATIRLAT");
            entity.Property(e => e.EgitimsuresibitenHatirlatGun).HasColumnName("EGITIMSURESIBITEN_HATIRLAT_GUN");
            entity.Property(e => e.Erpkestanim)
                .HasDefaultValueSql("((0))")
                .HasColumnName("ERPKESTANIM");
            entity.Property(e => e.GelismisIsbasOzellikleri).HasColumnName("GELISMIS_ISBAS_OZELLIKLERI");
            entity.Property(e => e.GenelBlob)
                .IsUnicode(false)
                .HasColumnName("GENEL_BLOB");
            entity.Property(e => e.Gircikopsiyon).HasColumnName("GIRCIKOPSIYON");
            entity.Property(e => e.Giristeyuvarlama).HasColumnName("GIRISTEYUVARLAMA");
            entity.Property(e => e.Giristeyuvarlamatipi).HasColumnName("GIRISTEYUVARLAMATIPI");
            entity.Property(e => e.Hshaketmesuresi).HasColumnName("HSHAKETMESURESI");
            entity.Property(e => e.IndexLastRebuild)
                .HasColumnType("datetime")
                .HasColumnName("INDEX_LAST_REBUILD");
            entity.Property(e => e.IzintalepHatirlat).HasColumnName("IZINTALEP_HATIRLAT");
            entity.Property(e => e.KapiKameraadet).HasColumnName("KAPI_KAMERAADET");
            entity.Property(e => e.KapiKameraaktif).HasColumnName("KAPI_KAMERAAKTIF");
            entity.Property(e => e.KapiOtomatikCikis).HasColumnName("KAPI_OTOMATIK_CIKIS");
            entity.Property(e => e.KapiOtomatikCikisSure).HasColumnName("KAPI_OTOMATIK_CIKIS_SURE");
            entity.Property(e => e.KapiOtomatikGiris).HasColumnName("KAPI_OTOMATIK_GIRIS");
            entity.Property(e => e.KapiOtomatikGirisSure).HasColumnName("KAPI_OTOMATIK_GIRIS_SURE");
            entity.Property(e => e.Maasminkesintisaat).HasColumnName("MAASMINKESINTISAAT");
            entity.Property(e => e.Maasminkesintiyuzde).HasColumnName("MAASMINKESINTIYUZDE");
            entity.Property(e => e.MaxGtmesai).HasColumnName("MAX_GTMESAI");
            entity.Property(e => e.MaxGtmesaigece).HasColumnName("MAX_GTMESAIGECE");
            entity.Property(e => e.MaxHimesai).HasColumnName("MAX_HIMESAI");
            entity.Property(e => e.MaxHimesaigece).HasColumnName("MAX_HIMESAIGECE");
            entity.Property(e => e.MaxHsmesai).HasColumnName("MAX_HSMESAI");
            entity.Property(e => e.MaxHsmesaigece).HasColumnName("MAX_HSMESAIGECE");
            entity.Property(e => e.Maxziaretcifoto).HasColumnName("MAXZIARETCIFOTO");
            entity.Property(e => e.MinFazlamesaiDk).HasColumnName("MIN_FAZLAMESAI_DK");
            entity.Property(e => e.Minimumkesintitipi).HasColumnName("MINIMUMKESINTITIPI");
            entity.Property(e => e.OfflineOtomatikCikis).HasColumnName("OFFLINE_OTOMATIK_CIKIS");
            entity.Property(e => e.OfflineOtomatikCikisSure).HasColumnName("OFFLINE_OTOMATIK_CIKIS_SURE");
            entity.Property(e => e.OfflineOtomatikGiris).HasColumnName("OFFLINE_OTOMATIK_GIRIS");
            entity.Property(e => e.OfflineOtomatikGirisSure).HasColumnName("OFFLINE_OTOMATIK_GIRIS_SURE");
            entity.Property(e => e.OnayTarihi)
                .HasColumnType("datetime")
                .HasColumnName("ONAY_TARIHI");
            entity.Property(e => e.OnayTarihiDrm).HasColumnName("ONAY_TARIHI_DRM");
            entity.Property(e => e.OtoGiriscikisAktifgunualma).HasColumnName("OTO_GIRISCIKIS_AKTIFGUNUALMA");
            entity.Property(e => e.ParaBirimi)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("PARA_BIRIMI");
            entity.Property(e => e.ParaHassasiyeti).HasColumnName("PARA_HASSASIYETI");
            entity.Property(e => e.ParaKucukBirimi)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("PARA_KUCUK_BIRIMI");
            entity.Property(e => e.ParaKucukSimge)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("PARA_KUCUK_SIMGE");
            entity.Property(e => e.ParaOran).HasColumnName("PARA_ORAN");
            entity.Property(e => e.ParaSimgesi)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("PARA_SIMGESI");
            entity.Property(e => e.PersDegAckkodlari)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("PERS_DEG_ACKKODLARI");
            entity.Property(e => e.PersonelBasamakSayisi).HasColumnName("PERSONEL_BASAMAK_SAYISI");
            entity.Property(e => e.PersonelBasinaEkle)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PERSONEL_BASINA_EKLE");
            entity.Property(e => e.PersonelOtoNumara).HasColumnName("PERSONEL_OTO_NUMARA");
            entity.Property(e => e.PersonelSonunaEkle)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PERSONEL_SONUNA_EKLE");
            entity.Property(e => e.Ptkesintitavansinir).HasColumnName("PTKESINTITAVANSINIR");
            entity.Property(e => e.Ptkesintitavantip).HasColumnName("PTKESINTITAVANTIP");
            entity.Property(e => e.PtmaashesapPrimharic).HasColumnName("PTMAASHESAP_PRIMHARIC");
            entity.Property(e => e.Ptmaashesaplamasi).HasColumnName("PTMAASHESAPLAMASI");
            entity.Property(e => e.PtucretAgiharic).HasColumnName("PTUCRET_AGIHARIC");
            entity.Property(e => e.Tatilsuresinitopla).HasColumnName("TATILSURESINITOPLA");
            entity.Property(e => e.Tesvik6111).HasColumnName("TESVIK6111");
            entity.Property(e => e.Ucretsizizineksikgunkodu)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("UCRETSIZIZINEKSIKGUNKODU");
            entity.Property(e => e.YildonumuHatirlat).HasColumnName("YILDONUMU_HATIRLAT");
            entity.Property(e => e.YildonumuHatirlatGun).HasColumnName("YILDONUMU_HATIRLAT_GUN");
            entity.Property(e => e.YiplanBastarihi)
                .HasColumnType("datetime")
                .HasColumnName("YIPLAN_BASTARIHI");
            entity.Property(e => e.YiplanBittarihi)
                .HasColumnType("datetime")
                .HasColumnName("YIPLAN_BITTARIHI");
            entity.Property(e => e.ZiyaretciBaslik1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ZIYARETCI_BASLIK1");
            entity.Property(e => e.ZiyaretciBaslik2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ZIYARETCI_BASLIK2");
            entity.Property(e => e.ZiyaretciBaslik3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ZIYARETCI_BASLIK3");
            entity.Property(e => e.ZiyaretciKayitSekli)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ZIYARETCI_KAYIT_SEKLI");
        });

        modelBuilder.Entity<BasvuruIlan>(entity =>
        {
            entity.HasKey(e => e.Blilankodu).HasName("PK__BASVURU___F70661A9F97A2FDC");

            entity.ToTable("BASVURU_ILAN");

            entity.Property(e => e.Blilankodu)
                .ValueGeneratedNever()
                .HasColumnName("BLILANKODU");
            entity.Property(e => e.Aciklama)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Aktif).HasColumnName("AKTIF");
            entity.Property(e => e.Degistiren)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DEGISTIREN");
            entity.Property(e => e.DegistirmeTarihi)
                .HasColumnType("datetime")
                .HasColumnName("DEGISTIRME_TARIHI");
            entity.Property(e => e.Gazete)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("GAZETE");
            entity.Property(e => e.Internet)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("INTERNET");
            entity.Property(e => e.Kaydeden)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KAYDEDEN");
            entity.Property(e => e.Kayittarihi)
                .HasColumnType("datetime")
                .HasColumnName("KAYITTARIHI");
            entity.Property(e => e.Pozisyon)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("POZISYON");
            entity.Property(e => e.Radio)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RADIO");
            entity.Property(e => e.Referansno)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("REFERANSNO");
            entity.Property(e => e.Siralama).HasColumnName("SIRALAMA");
            entity.Property(e => e.Sonbasvurutarihi)
                .HasColumnType("datetime")
                .HasColumnName("SONBASVURUTARIHI");
            entity.Property(e => e.Tv)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("TV");
        });

        modelBuilder.Entity<BioCihaz>(entity =>
        {
            entity.HasKey(e => e.Blkodu).HasName("PK__BIO_CIHA__24967F2644D4D0EC");

            entity.ToTable("BIO_CIHAZ");

            entity.HasIndex(e => e.Cihazid, "BIO_CIHAZ_IDX1");

            entity.Property(e => e.Blkodu)
                .ValueGeneratedNever()
                .HasColumnName("BLKODU");
            entity.Property(e => e.CekilecekVeriTuru).HasColumnName("CEKILECEK_VERI_TURU");
            entity.Property(e => e.CihazTipi).HasColumnName("CIHAZ_TIPI");
            entity.Property(e => e.Cihazid)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CIHAZID");
            entity.Property(e => e.Clsmod).HasColumnName("CLSMOD");
            entity.Property(e => e.Comport)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COMPORT");
            entity.Property(e => e.Hiz).HasColumnName("HIZ");
            entity.Property(e => e.Iletisim).HasColumnName("ILETISIM");
            entity.Property(e => e.ImportAfter).HasColumnName("IMPORT_AFTER");
            entity.Property(e => e.Ip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IP");
            entity.Property(e => e.IsyeriKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ISYERI_KODU");
            entity.Property(e => e.Pasif)
                .HasDefaultValueSql("((0))")
                .HasColumnName("PASIF");
            entity.Property(e => e.Port).HasColumnName("PORT");
            entity.Property(e => e.Tanim)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("TANIM");
        });

        modelBuilder.Entity<Bordro>(entity =>
        {
            entity.HasKey(e => e.Blkodu).HasName("PK__BORDRO__24967F26121F1B52");

            entity.ToTable("BORDRO", tb => tb.HasTrigger("BORDRO_ONDELETE"));

            entity.HasIndex(e => e.Aykodu, "BRD_AYKODU");

            entity.HasIndex(e => e.Blperskodu, "BRD_BLPERSKODU");

            entity.HasIndex(e => e.IsyeriKodu, "BRD_ISYERIKODU");

            entity.Property(e => e.Blkodu)
                .ValueGeneratedNever()
                .HasColumnName("BLKODU");
            entity.Property(e => e.AgiTutari).HasColumnName("AGI_TUTARI");
            entity.Property(e => e.AgiTutariNet).HasColumnName("AGI_TUTARI_NET");
            entity.Property(e => e.AsgariUcret).HasColumnName("ASGARI_UCRET");
            entity.Property(e => e.AvansTutari).HasColumnName("AVANS_TUTARI");
            entity.Property(e => e.Aykodu).HasColumnName("AYKODU");
            entity.Property(e => e.AylikBrucret).HasColumnName("AYLIK_BRUCRET");
            entity.Property(e => e.AylikUcretNet).HasColumnName("AYLIK_UCRET_NET");
            entity.Property(e => e.BYil).HasColumnName("B_YIL");
            entity.Property(e => e.BayramSaat).HasColumnName("BAYRAM_SAAT");
            entity.Property(e => e.BayramSaatGece).HasColumnName("BAYRAM_SAAT_GECE");
            entity.Property(e => e.BireyselEmkSigortasiB).HasColumnName("BIREYSEL_EMK_SIGORTASI_B");
            entity.Property(e => e.Blperskodu).HasColumnName("BLPERSKODU");
            entity.Property(e => e.BrutUcret).HasColumnName("BRUT_UCRET");
            entity.Property(e => e.CalismaGunu).HasColumnName("CALISMA_GUNU");
            entity.Property(e => e.CalismaSaati).HasColumnName("CALISMA_SAATI");
            entity.Property(e => e.CocukSayisi).HasColumnName("COCUK_SAYISI");
            entity.Property(e => e.CocukYrd).HasColumnName("COCUK_YRD");
            entity.Property(e => e.DevrVrMt).HasColumnName("DEVR_VR_MT");
            entity.Property(e => e.DmvIstisnasi).HasColumnName("DMV_ISTISNASI");
            entity.Property(e => e.DmvKs).HasColumnName("DMV_KS");
            entity.Property(e => e.DmvKs2).HasColumnName("DMV_KS2");
            entity.Property(e => e.DmvMatrahi).HasColumnName("DMV_MATRAHI");
            entity.Property(e => e.DvrAsgUcrMatrahi).HasColumnName("DVR_ASG_UCR_MATRAHI");
            entity.Property(e => e.EkKesintiler).HasColumnName("EK_KESINTILER");
            entity.Property(e => e.EkKesintiler2).HasColumnName("EK_KESINTILER2");
            entity.Property(e => e.EkglTutari).HasColumnName("EKGL_TUTARI");
            entity.Property(e => e.EkglTutariNet).HasColumnName("EKGL_TUTARI_NET");
            entity.Property(e => e.EksikGun)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("EKSIK_GUN");
            entity.Property(e => e.FmBayram).HasColumnName("FM_BAYRAM");
            entity.Property(e => e.FmBayramNet).HasColumnName("FM_BAYRAM_NET");
            entity.Property(e => e.FmHici).HasColumnName("FM_HICI");
            entity.Property(e => e.FmHiciNet).HasColumnName("FM_HICI_NET");
            entity.Property(e => e.FmHsonu).HasColumnName("FM_HSONU");
            entity.Property(e => e.FmHsonuNet).HasColumnName("FM_HSONU_NET");
            entity.Property(e => e.GocmenIndirimi).HasColumnName("GOCMEN_INDIRIMI");
            entity.Property(e => e.GunGentatil).HasColumnName("GUN_GENTATIL");
            entity.Property(e => e.GunlukUcret).HasColumnName("GUNLUK_UCRET");
            entity.Property(e => e.GvAskerlikIndirimi).HasColumnName("GV_ASKERLIK_INDIRIMI");
            entity.Property(e => e.GvBrutucret).HasColumnName("GV_BRUTUCRET");
            entity.Property(e => e.GvIndSendika).HasColumnName("GV_IND_SENDIKA");
            entity.Property(e => e.GvIstisnasi).HasColumnName("GV_ISTISNASI");
            entity.Property(e => e.GvKs).HasColumnName("GV_KS");
            entity.Property(e => e.GvKs2).HasColumnName("GV_KS2");
            entity.Property(e => e.GvMatrahi).HasColumnName("GV_MATRAHI");
            entity.Property(e => e.HarcTutari).HasColumnName("HARC_TUTARI");
            entity.Property(e => e.HarcTutariNet).HasColumnName("HARC_TUTARI_NET");
            entity.Property(e => e.Hassasiyet).HasColumnName("HASSASIYET");
            entity.Property(e => e.HesapTipi).HasColumnName("HESAP_TIPI");
            entity.Property(e => e.HesaplamaTarihi)
                .HasColumnType("datetime")
                .HasColumnName("HESAPLAMA_TARIHI");
            entity.Property(e => e.HiciSaat).HasColumnName("HICI_SAAT");
            entity.Property(e => e.HiciSaatGece).HasColumnName("HICI_SAAT_GECE");
            entity.Property(e => e.HsonuSaat).HasColumnName("HSONU_SAAT");
            entity.Property(e => e.HsonuSaatGece).HasColumnName("HSONU_SAAT_GECE");
            entity.Property(e => e.IhbarTutari).HasColumnName("IHBAR_TUTARI");
            entity.Property(e => e.IhbarTutariNet).HasColumnName("IHBAR_TUTARI_NET");
            entity.Property(e => e.IkrTutari).HasColumnName("IKR_TUTARI");
            entity.Property(e => e.IkrTutariNet).HasColumnName("IKR_TUTARI_NET");
            entity.Property(e => e.IssizIshis).HasColumnName("ISSIZ_ISHIS");
            entity.Property(e => e.IsyeriAdi)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("ISYERI_ADI");
            entity.Property(e => e.IsyeriKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ISYERI_KODU");
            entity.Property(e => e.KanunNo)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("KANUN_NO");
            entity.Property(e => e.Kcbr)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("KCBR");
            entity.Property(e => e.KesintilerToplami).HasColumnName("KESINTILER_TOPLAMI");
            entity.Property(e => e.KidemTazminati).HasColumnName("KIDEM_TAZMINATI");
            entity.Property(e => e.KidemTazminatiNet).HasColumnName("KIDEM_TAZMINATI_NET");
            entity.Property(e => e.NetMaas).HasColumnName("NET_MAAS");
            entity.Property(e => e.NetOdenen).HasColumnName("NET_ODENEN");
            entity.Property(e => e.Onay).HasColumnName("ONAY");
            entity.Property(e => e.Oran).HasColumnName("ORAN");
            entity.Property(e => e.OtmBesTutari).HasColumnName("OTM_BES_TUTARI");
            entity.Property(e => e.OzelSigorta).HasColumnName("OZEL_SIGORTA");
            entity.Property(e => e.Prbr)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("PRBR");
            entity.Property(e => e.PrimGunu).HasColumnName("PRIM_GUNU");
            entity.Property(e => e.PrimTutari).HasColumnName("PRIM_TUTARI");
            entity.Property(e => e.PrimTutariNet).HasColumnName("PRIM_TUTARI_NET");
            entity.Property(e => e.RaporluGun).HasColumnName("RAPORLU_GUN");
            entity.Property(e => e.RaporluSaat).HasColumnName("RAPORLU_SAAT");
            entity.Property(e => e.SaatGenTatil).HasColumnName("SAAT_GEN_TATIL");
            entity.Property(e => e.SakatlikIndirimi).HasColumnName("SAKATLIK_INDIRIMI");
            entity.Property(e => e.SgPrMatrahi).HasColumnName("SG_PR_MATRAHI");
            entity.Property(e => e.Spm1ayoncesi).HasColumnName("SPM_1AYONCESI");
            entity.Property(e => e.Spm2ayoncesi).HasColumnName("SPM_2AYONCESI");
            entity.Property(e => e.SskIshis).HasColumnName("SSK_ISHIS");
            entity.Property(e => e.TatilGunu).HasColumnName("TATIL_GUNU");
            entity.Property(e => e.TatilSaati).HasColumnName("TATIL_SAATI");
            entity.Property(e => e.UcretGunu).HasColumnName("UCRET_GUNU");
            entity.Property(e => e.UcretSaati).HasColumnName("UCRET_SAATI");
            entity.Property(e => e.Ucreti).HasColumnName("UCRETI");
            entity.Property(e => e.UcretliGun).HasColumnName("UCRETLI_GUN");
            entity.Property(e => e.UcretliSaat).HasColumnName("UCRETLI_SAAT");
            entity.Property(e => e.UcsizGun).HasColumnName("UCSIZ_GUN");
            entity.Property(e => e.UcsizSaat).HasColumnName("UCSIZ_SAAT");
            entity.Property(e => e.UzaktanCalismaGunu).HasColumnName("UZAKTAN_CALISMA_GUNU");
            entity.Property(e => e.Yil).HasColumnName("YIL");
            entity.Property(e => e.YilizinGun).HasColumnName("YILIZIN_GUN");
            entity.Property(e => e.YilizinSaat).HasColumnName("YILIZIN_SAAT");
        });

        modelBuilder.Entity<BordroDepartman>(entity =>
        {
            entity.HasKey(e => e.Blkodu).HasName("PK__BORDRO_D__24967F2600AED399");

            entity.ToTable("BORDRO_DEPARTMAN");

            entity.Property(e => e.Blkodu)
                .ValueGeneratedNever()
                .HasColumnName("BLKODU");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Adi)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ADI");
            entity.Property(e => e.AylikUcretler)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("AYLIK_UCRETLER");
            entity.Property(e => e.CocukParasi)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("COCUK_PARASI");
            entity.Property(e => e.DamgaVergisi)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DAMGA_VERGISI");
            entity.Property(e => e.EkGelirler)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("EK_GELIRLER");
            entity.Property(e => e.EkKesintiler)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("EK_KESINTILER");
            entity.Property(e => e.FazlaMesailar)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FAZLA_MESAILAR");
            entity.Property(e => e.GelirVergisi)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("GELIR_VERGISI");
            entity.Property(e => e.IhbarHeskodu)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("IHBAR_HESKODU");
            entity.Property(e => e.IssizlikPrimi)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ISSIZLIK_PRIMI");
            entity.Property(e => e.IsverenIssizlik)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ISVEREN_ISSIZLIK");
            entity.Property(e => e.IsverenSgdp)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ISVEREN_SGDP");
            entity.Property(e => e.IsverenSsk)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ISVEREN_SSK");
            entity.Property(e => e.IsyeriKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ISYERI_KODU");
            entity.Property(e => e.KidemHeskodu)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("KIDEM_HESKODU");
            entity.Property(e => e.Kodu)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("KODU");
            entity.Property(e => e.NetUcretler)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NET_UCRETLER");
            entity.Property(e => e.Nitelikleri)
                .IsUnicode(false)
                .HasColumnName("NITELIKLERI");
            entity.Property(e => e.Sgdp)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SGDP");
            entity.Property(e => e.SskPrimi)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SSK_PRIMI");
            entity.Property(e => e.Yonetmelikler)
                .IsUnicode(false)
                .HasColumnName("YONETMELIKLER");
        });

        modelBuilder.Entity<BordroEvrakTakip>(entity =>
        {
            entity.HasKey(e => e.Blkodu).HasName("PK__BORDRO_E__24967F26D550F140");

            entity.ToTable("BORDRO_EVRAK_TAKIP");

            entity.Property(e => e.Blkodu)
                .ValueGeneratedNever()
                .HasColumnName("BLKODU");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Blperskodu).HasColumnName("BLPERSKODU");
            entity.Property(e => e.EvrakTipi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EVRAK_TIPI");
            entity.Property(e => e.IsyeriAdi)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("ISYERI_ADI");
            entity.Property(e => e.IsyeriKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ISYERI_KODU");
            entity.Property(e => e.Tarihi)
                .HasColumnType("datetime")
                .HasColumnName("TARIHI");
        });

        modelBuilder.Entity<BordroKesinti>(entity =>
        {
            entity.HasKey(e => e.Blkodu).HasName("PK__BORDRO_K__24967F2620389656");

            entity.ToTable("BORDRO_KESINTI");

            entity.Property(e => e.Blkodu)
                .ValueGeneratedNever()
                .HasColumnName("BLKODU");
            entity.Property(e => e.Blbrkodu).HasColumnName("BLBRKODU");
            entity.Property(e => e.HesapKodu)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("HESAP_KODU");
            entity.Property(e => e.Kesinti)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("KESINTI");
            entity.Property(e => e.Kodu)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("KODU");
            entity.Property(e => e.NetMaasiEtkilesin).HasColumnName("NET_MAASI_ETKILESIN");
            entity.Property(e => e.Tutari).HasColumnName("TUTARI");
        });

        modelBuilder.Entity<BordroYardim>(entity =>
        {
            entity.HasKey(e => e.Blkodu).HasName("PK__BORDRO_Y__24967F264B1A98E3");

            entity.ToTable("BORDRO_YARDIM");

            entity.Property(e => e.Blkodu)
                .ValueGeneratedNever()
                .HasColumnName("BLKODU");
            entity.Property(e => e.Blbrkodu).HasColumnName("BLBRKODU");
            entity.Property(e => e.BrutToplam).HasColumnName("BRUT_TOPLAM");
            entity.Property(e => e.DmvKes).HasColumnName("DMV_KES");
            entity.Property(e => e.DmvKesTut).HasColumnName("DMV_KES_TUT");
            entity.Property(e => e.DvMuafiyet).HasColumnName("DV_MUAFIYET");
            entity.Property(e => e.DvUstsinir).HasColumnName("DV_USTSINIR");
            entity.Property(e => e.Gunluk).HasColumnName("GUNLUK");
            entity.Property(e => e.GvKes).HasColumnName("GV_KES");
            entity.Property(e => e.GvKesTut).HasColumnName("GV_KES_TUT");
            entity.Property(e => e.GvMuafiyet).HasColumnName("GV_MUAFIYET");
            entity.Property(e => e.GvUstsinir).HasColumnName("GV_USTSINIR");
            entity.Property(e => e.Kodu)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("KODU");
            entity.Property(e => e.NetOdenen).HasColumnName("NET_ODENEN");
            entity.Property(e => e.Netbrut).HasColumnName("NETBRUT");
            entity.Property(e => e.SskKes).HasColumnName("SSK_KES");
            entity.Property(e => e.SskKesIsci).HasColumnName("SSK_KES_ISCI");
            entity.Property(e => e.SskKesIsv).HasColumnName("SSK_KES_ISV");
            entity.Property(e => e.SskMuafiyet).HasColumnName("SSK_MUAFIYET");
            entity.Property(e => e.SskUstsinir).HasColumnName("SSK_USTSINIR");
            entity.Property(e => e.Tutari).HasColumnName("TUTARI");
            entity.Property(e => e.Yardim)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("YARDIM");
            entity.Property(e => e.YardimTuru).HasColumnName("YARDIM_TURU");
        });

        modelBuilder.Entity<CalismaPlaniPersonel>(entity =>
        {
            entity.HasKey(e => e.Blkodu).HasName("PK__CALISMA___24967F260B167221");

            entity.ToTable("CALISMA_PLANI_PERSONEL");

            entity.Property(e => e.Blkodu)
                .ValueGeneratedNever()
                .HasColumnName("BLKODU");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.BasTar)
                .HasColumnType("datetime")
                .HasColumnName("BAS_TAR");
            entity.Property(e => e.BitTar)
                .HasColumnType("datetime")
                .HasColumnName("BIT_TAR");
            entity.Property(e => e.Blperkodu).HasColumnName("BLPERKODU");
            entity.Property(e => e.Blplankodu).HasColumnName("BLPLANKODU");
            entity.Property(e => e.Degistiren)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DEGISTIREN");
            entity.Property(e => e.DegistirmeTarihi)
                .HasColumnType("datetime")
                .HasColumnName("DEGISTIRME_TARIHI");
            entity.Property(e => e.Kaydeden)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KAYDEDEN");
            entity.Property(e => e.KayitTarihi)
                .HasColumnType("datetime")
                .HasColumnName("KAYIT_TARIHI");
        });

        modelBuilder.Entity<Calismagunleri>(entity =>
        {
            entity.HasKey(e => e.Blkodu).HasName("PK__CALISMAG__24967F26D984747B");

            entity.ToTable("CALISMAGUNLERI");

            entity.HasIndex(e => e.Baslama, "BASLAMA_IND");

            entity.HasIndex(e => e.Baslama21, "CLSGN_BASLAMA");

            entity.HasIndex(e => e.Tarih2, "CLSGN_TARIH2");

            entity.HasIndex(e => e.Tarih, "TARIH_IND");

            entity.Property(e => e.Blkodu)
                .ValueGeneratedNever()
                .HasColumnName("BLKODU");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Aylikekdakika).HasColumnName("AYLIKEKDAKIKA");
            entity.Property(e => e.Baslama)
                .HasColumnType("datetime")
                .HasColumnName("BASLAMA");
            entity.Property(e => e.Baslama2)
                .HasColumnType("datetime")
                .HasColumnName("BASLAMA_2");
            entity.Property(e => e.Baslama21)
                .HasComputedColumnSql("(dateadd(day,datediff(day,(0),[BASLAMA]),(0)))", false)
                .HasColumnType("datetime")
                .HasColumnName("BASLAMA2");
            entity.Property(e => e.Bitis)
                .HasColumnType("datetime")
                .HasColumnName("BITIS");
            entity.Property(e => e.Bitis2)
                .HasColumnType("datetime")
                .HasColumnName("BITIS_2");
            entity.Property(e => e.Fazlamesai).HasColumnName("FAZLAMESAI");
            entity.Property(e => e.Fazlamesai2).HasColumnName("FAZLAMESAI_2");
            entity.Property(e => e.Fmbaslama)
                .HasColumnType("datetime")
                .HasColumnName("FMBASLAMA");
            entity.Property(e => e.Fmbaslama2)
                .HasColumnType("datetime")
                .HasColumnName("FMBASLAMA_2");
            entity.Property(e => e.Fmbitis)
                .HasColumnType("datetime")
                .HasColumnName("FMBITIS");
            entity.Property(e => e.Fmbitis2)
                .HasColumnType("datetime")
                .HasColumnName("FMBITIS_2");
            entity.Property(e => e.Fmkatsayi).HasColumnName("FMKATSAYI");
            entity.Property(e => e.Fmkatsayi2).HasColumnName("FMKATSAYI_2");
            entity.Property(e => e.Gcizinverme).HasColumnName("GCIZINVERME");
            entity.Property(e => e.Gcizinverme2).HasColumnName("GCIZINVERME_2");
            entity.Property(e => e.Ikincimesaivar).HasColumnName("IKINCIMESAIVAR");
            entity.Property(e => e.Mola1).HasColumnName("MOLA_1");
            entity.Property(e => e.Mola2).HasColumnName("MOLA_2");
            entity.Property(e => e.Nmkaysayi).HasColumnName("NMKAYSAYI");
            entity.Property(e => e.Nmkaysayi2).HasColumnName("NMKAYSAYI_2");
            entity.Property(e => e.Normalmesai).HasColumnName("NORMALMESAI");
            entity.Property(e => e.Normalmesai2).HasColumnName("NORMALMESAI_2");
            entity.Property(e => e.Resmitatil).HasColumnName("RESMITATIL");
            entity.Property(e => e.Resmitatil2).HasColumnName("RESMITATIL_2");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
            entity.Property(e => e.Tarih2)
                .HasComputedColumnSql("(dateadd(day,datediff(day,(0),[TARIH]),(0)))", false)
                .HasColumnType("datetime")
                .HasColumnName("TARIH2");
            entity.Property(e => e.Tatil).HasColumnName("TATIL");
            entity.Property(e => e.Tatil2).HasColumnName("TATIL_2");
            entity.Property(e => e.Vardiyaadi)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("VARDIYAADI");
            entity.Property(e => e.Yemekbaslama)
                .HasColumnType("datetime")
                .HasColumnName("YEMEKBASLAMA");
            entity.Property(e => e.Yemekbaslama2)
                .HasColumnType("datetime")
                .HasColumnName("YEMEKBASLAMA_2");
            entity.Property(e => e.Yemekbitis)
                .HasColumnType("datetime")
                .HasColumnName("YEMEKBITIS");
            entity.Property(e => e.Yemekbitis2)
                .HasColumnType("datetime")
                .HasColumnName("YEMEKBITIS_2");
        });

        modelBuilder.Entity<Calismaplan>(entity =>
        {
            entity.HasKey(e => e.Blkodu).HasName("PK__CALISMAP__24967F2685153777");

            entity.ToTable("CALISMAPLAN");

            entity.HasIndex(e => e.Planadi, "UQ__CALISMAP__F83DD12D0B7E3F14").IsUnique();

            entity.Property(e => e.Blkodu)
                .ValueGeneratedNever()
                .HasColumnName("BLKODU");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Aylikkesinti).HasColumnName("AYLIKKESINTI");
            entity.Property(e => e.Ayliktolerans).HasColumnName("AYLIKTOLERANS");
            entity.Property(e => e.Ayliktoleransdk).HasColumnName("AYLIKTOLERANSDK");
            entity.Property(e => e.Geckalmacezasi).HasColumnName("GECKALMACEZASI");
            entity.Property(e => e.Geckalmafazlamesai).HasColumnName("GECKALMAFAZLAMESAI");
            entity.Property(e => e.Geckalmatolaransi).HasColumnName("GECKALMATOLARANSI");
            entity.Property(e => e.Gelmemeceza).HasColumnName("GELMEMECEZA");
            entity.Property(e => e.Planadi)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("PLANADI");
        });

        modelBuilder.Entity<DegisimLog>(entity =>
        {
            entity.HasKey(e => e.Blkodu).HasName("PK__DEGISIM___24967F267107FEFD");

            entity.ToTable("DEGISIM_LOG");

            entity.HasIndex(e => e.Blmaskodu, "DEGLOG_BLMASKODU");

            entity.HasIndex(e => e.Tarihi, "DEGLOG_TARIHI1");

            entity.HasIndex(e => e.Tarihi2, "DEGLOG_TARIHI2");

            entity.HasIndex(e => e.Tarihi, "DEGLOG_TARIHI_DESC").IsDescending();

            entity.Property(e => e.Blkodu).HasColumnName("BLKODU");
            entity.Property(e => e.Blmaskodu).HasColumnName("BLMASKODU");
            entity.Property(e => e.DegisimLogu)
                .IsUnicode(false)
                .HasColumnName("DEGISIM_LOGU");
            entity.Property(e => e.Kullanici)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KULLANICI");
            entity.Property(e => e.MakineId)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("MAKINE_ID");
            entity.Property(e => e.TabloAdi)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("TABLO_ADI");
            entity.Property(e => e.Tarihi)
                .HasColumnType("datetime")
                .HasColumnName("TARIHI");
            entity.Property(e => e.Tarihi2)
                .HasComputedColumnSql("(dateadd(day,datediff(day,(0),[TARIHI]),(0)))", false)
                .HasColumnType("datetime")
                .HasColumnName("TARIHI2");
            entity.Property(e => e.Uygulama)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UYGULAMA");
        });

        modelBuilder.Entity<DrRapor>(entity =>
        {
            entity.HasKey(e => e.Blkodu).HasName("PK__DR_RAPOR__24967F26E1318AAB");

            entity.ToTable("DR_RAPOR");

            entity.Property(e => e.Blkodu)
                .ValueGeneratedNever()
                .HasColumnName("BLKODU");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Analik).HasColumnName("ANALIK");
            entity.Property(e => e.Blbetkodu).HasColumnName("BLBETKODU");
            entity.Property(e => e.Blperkodu).HasColumnName("BLPERKODU");
            entity.Property(e => e.CalismayaBaslamaTarihi)
                .HasColumnType("datetime")
                .HasColumnName("CALISMAYA_BASLAMA_TARIHI");
            entity.Property(e => e.Degistiren)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DEGISTIREN");
            entity.Property(e => e.DegistirmeTarihi)
                .HasColumnType("datetime")
                .HasColumnName("DEGISTIRME_TARIHI");
            entity.Property(e => e.Hastalik).HasColumnName("HASTALIK");
            entity.Property(e => e.HastanedenCikisTarihi)
                .HasColumnType("datetime")
                .HasColumnName("HASTANEDEN_CIKIS_TARIHI");
            entity.Property(e => e.HastaneyeYatisTarihi)
                .HasColumnType("datetime")
                .HasColumnName("HASTANEYE_YATIS_TARIHI");
            entity.Property(e => e.HekimAdisoyadi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("HEKIM_ADISOYADI");
            entity.Property(e => e.HekimDiploma)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("HEKIM_DIPLOMA");
            entity.Property(e => e.HekimSicilno)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("HEKIM_SICILNO");
            entity.Property(e => e.HekimTescilno)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("HEKIM_TESCILNO");
            entity.Property(e => e.IsKazasi).HasColumnName("IS_KAZASI");
            entity.Property(e => e.IstirahatBaslangicTarihi)
                .HasColumnType("datetime")
                .HasColumnName("ISTIRAHAT_BASLANGIC_TARIHI");
            entity.Property(e => e.IstirahatBitisTarihi)
                .HasColumnType("datetime")
                .HasColumnName("ISTIRAHAT_BITIS_TARIHI");
            entity.Property(e => e.Kaydeden)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KAYDEDEN");
            entity.Property(e => e.MeslekHastaligi).HasColumnName("MESLEK_HASTALIGI");
            entity.Property(e => e.PeriyodikKontrol).HasColumnName("PERIYODIK_KONTROL");
            entity.Property(e => e.Poliklinik)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("POLIKLINIK");
            entity.Property(e => e.PoliklinikDefterSn).HasColumnName("POLIKLINIK_DEFTER_SN");
            entity.Property(e => e.PoliklinikTarihi)
                .HasColumnType("datetime")
                .HasColumnName("POLIKLINIK_TARIHI");
            entity.Property(e => e.SaglikTesisi)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SAGLIK_TESISI");
            entity.Property(e => e.SonrakiKontrolTarihi)
                .HasColumnType("datetime")
                .HasColumnName("SONRAKI_KONTROL_TARIHI");
            entity.Property(e => e.Teshis)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("TESHIS");
            entity.Property(e => e.ViziteTarihi)
                .HasColumnType("datetime")
                .HasColumnName("VIZITE_TARIHI");
        });

        modelBuilder.Entity<Duyuru>(entity =>
        {
            entity.HasKey(e => e.Blkodu).HasName("PK__DUYURU__24967F26B56CBF17");

            entity.ToTable("DUYURU");

            entity.Property(e => e.Blkodu)
                .ValueGeneratedNever()
                .HasColumnName("BLKODU");
            entity.Property(e => e.BitisTarihi)
                .HasColumnType("datetime")
                .HasColumnName("BITIS_TARIHI");
            entity.Property(e => e.Degistiren)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DEGISTIREN");
            entity.Property(e => e.DegistirmeTarihi)
                .HasColumnType("datetime")
                .HasColumnName("DEGISTIRME_TARIHI");
            entity.Property(e => e.Durumu).HasColumnName("DURUMU");
            entity.Property(e => e.Icerik)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("ICERIK");
            entity.Property(e => e.Kaydeden)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KAYDEDEN");
            entity.Property(e => e.KayitTarihi)
                .HasColumnType("datetime")
                .HasColumnName("KAYIT_TARIHI");
            entity.Property(e => e.Modul)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MODUL");
            entity.Property(e => e.Siralama)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("SIRALAMA");
            entity.Property(e => e.Tanim)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TANIM");
            entity.Property(e => e.YayinTarihi)
                .HasColumnType("datetime")
                .HasColumnName("YAYIN_TARIHI");
            entity.Property(e => e.YetkiDurumu).HasColumnName("YETKI_DURUMU");
            entity.Property(e => e.Yetkililer)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("YETKILILER");
        });

        modelBuilder.Entity<Egitim>(entity =>
        {
            entity.HasKey(e => e.Blkodu).HasName("PK__EGITIM__24967F26DB012D14");

            entity.ToTable("EGITIM");

            entity.Property(e => e.Blkodu)
                .ValueGeneratedNever()
                .HasColumnName("BLKODU");
            entity.Property(e => e.Adi)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ADI");
            entity.Property(e => e.Degistiren)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DEGISTIREN");
            entity.Property(e => e.DegistirmeTarihi)
                .HasColumnType("datetime")
                .HasColumnName("DEGISTIRME_TARIHI");
            entity.Property(e => e.Durumu).HasColumnName("DURUMU");
            entity.Property(e => e.DuzenleyenFirma)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("DUZENLEYEN_FIRMA");
            entity.Property(e => e.DuzenleyenTel1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DUZENLEYEN_TEL1");
            entity.Property(e => e.DuzenleyenTel2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DUZENLEYEN_TEL2");
            entity.Property(e => e.DuzenleyenYetkili)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DUZENLEYEN_YETKILI");
            entity.Property(e => e.Egitimciler)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("EGITIMCILER");
            entity.Property(e => e.Ekbilgi)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("EKBILGI");
            entity.Property(e => e.EkbilgiOnlineik)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("EKBILGI_ONLINEIK");
            entity.Property(e => e.Grubu)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GRUBU");
            entity.Property(e => e.Kaydeden)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KAYDEDEN");
            entity.Property(e => e.KayitTarihi)
                .HasColumnType("datetime")
                .HasColumnName("KAYIT_TARIHI");
            entity.Property(e => e.OnlineIk).HasColumnName("ONLINE_IK");
            entity.Property(e => e.OzelKodu1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("OZEL_KODU_1");
            entity.Property(e => e.OzelKodu2)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("OZEL_KODU_2");
            entity.Property(e => e.SureTipi).HasColumnName("SURE_TIPI");
            entity.Property(e => e.Suresi).HasColumnName("SURESI");
            entity.Property(e => e.Tarihi)
                .HasColumnType("datetime")
                .HasColumnName("TARIHI");
            entity.Property(e => e.Yeri)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("YERI");
        });

        modelBuilder.Entity<EgitimDetay>(entity =>
        {
            entity.HasKey(e => e.Blkodu).HasName("PK__EGITIM_D__24967F2658880C49");

            entity.ToTable("EGITIM_DETAY");

            entity.Property(e => e.Blkodu)
                .ValueGeneratedNever()
                .HasColumnName("BLKODU");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Adi)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADI");
            entity.Property(e => e.Blegtkodu).HasColumnName("BLEGTKODU");
            entity.Property(e => e.Blkisikodu).HasColumnName("BLKISIKODU");
            entity.Property(e => e.Katildi).HasColumnName("KATILDI");
            entity.Property(e => e.Kodu)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("KODU");
            entity.Property(e => e.Modul)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODUL");
            entity.Property(e => e.Onay).HasColumnName("ONAY");
            entity.Property(e => e.OzelKodu1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("OZEL_KODU_1");
            entity.Property(e => e.Puani).HasColumnName("PUANI");
            entity.Property(e => e.Soyadi)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SOYADI");
            entity.Property(e => e.Tarihi)
                .HasColumnType("datetime")
                .HasColumnName("TARIHI");
            entity.Property(e => e.TcNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TC_NO");
        });

        modelBuilder.Entity<Entegrasyon>(entity =>
        {
            entity.HasKey(e => e.Blkodu).HasName("PK__ENTEGRAS__24967F26908264BE");

            entity.ToTable("ENTEGRASYON");

            entity.Property(e => e.Blkodu)
                .ValueGeneratedNever()
                .HasColumnName("BLKODU");
            entity.Property(e => e.AciklamaTanim)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA_TANIM");
            entity.Property(e => e.AgiMahsubu)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("AGI_MAHSUBU");
            entity.Property(e => e.AlacakTipi).HasColumnName("ALACAK_TIPI");
            entity.Property(e => e.AylikUcretler)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("AYLIK_UCRETLER");
            entity.Property(e => e.BelgeTuruDiger)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("BELGE_TURU_DIGER");
            entity.Property(e => e.BorcTipi).HasColumnName("BORC_TIPI");
            entity.Property(e => e.CocukParasi)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("COCUK_PARASI");
            entity.Property(e => e.DamgaVergisi)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("DAMGA_VERGISI");
            entity.Property(e => e.EkGelirler)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("EK_GELIRLER");
            entity.Property(e => e.EkKesintiler)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("EK_KESINTILER");
            entity.Property(e => e.FazlaMesailer)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("FAZLA_MESAILER");
            entity.Property(e => e.GelirVergisi)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("GELIR_VERGISI");
            entity.Property(e => e.IdAylikUcretler)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ID_AYLIK_UCRETLER");
            entity.Property(e => e.IdIsverenIssizlik)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ID_ISVEREN_ISSIZLIK");
            entity.Property(e => e.IdIsverenSgdp)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ID_ISVEREN_SGDP");
            entity.Property(e => e.IdIsverenSsk)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ID_ISVEREN_SSK");
            entity.Property(e => e.IhbarHeskodu)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("IHBAR_HESKODU");
            entity.Property(e => e.Indirim4447)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("INDIRIM_4447");
            entity.Property(e => e.Indirim4857)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("INDIRIM_4857");
            entity.Property(e => e.Indirim5510)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("INDIRIM_5510");
            entity.Property(e => e.Indirim6111)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("INDIRIM_6111");
            entity.Property(e => e.IssizlikPrimi)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ISSIZLIK_PRIMI");
            entity.Property(e => e.IsverenIssizlik)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ISVEREN_ISSIZLIK");
            entity.Property(e => e.IsverenSgdp)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ISVEREN_SGDP");
            entity.Property(e => e.IsverenSsk)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ISVEREN_SSK");
            entity.Property(e => e.IsyeriAdi)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("ISYERI_ADI");
            entity.Property(e => e.IsyeriKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ISYERI_KODU");
            entity.Property(e => e.KidemHeskodu)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("KIDEM_HESKODU");
            entity.Property(e => e.NetUcretler)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("NET_UCRETLER");
            entity.Property(e => e.Sgdp)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SGDP");
            entity.Property(e => e.SskPrimi)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SSK_PRIMI");
            entity.Property(e => e.YuvarlamaAlacak)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("YUVARLAMA_ALACAK");
            entity.Property(e => e.YuvarlamaBorc)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("YUVARLAMA_BORC");
        });

        modelBuilder.Entity<ErpKesintiKod>(entity =>
        {
            entity.HasKey(e => e.Blkodu).HasName("PK__ERP_KESI__24967F263DDD530C");

            entity.ToTable("ERP_KESINTI_KOD");

            entity.Property(e => e.Blkodu)
                .ValueGeneratedNever()
                .HasColumnName("BLKODU");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.HesapKodu)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("HESAP_KODU");
            entity.Property(e => e.Kod)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("KOD");
        });

        modelBuilder.Entity<Evraksabit>(entity =>
        {
            entity.HasKey(e => e.Blkodu).HasName("PK__EVRAKSAB__24967F26DC5E58DD");

            entity.ToTable("EVRAKSABIT");

            entity.Property(e => e.Blkodu)
                .ValueGeneratedNever()
                .HasColumnName("BLKODU");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Gecerliliksuresi).HasColumnName("GECERLILIKSURESI");
            entity.Property(e => e.Siralama)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("SIRALAMA");
        });

        modelBuilder.Entity<GenIdt>(entity =>
        {
            entity.HasKey(e => e.Blkodu).HasName("PK__GEN_IDT__24967F264ECF572B");

            entity.ToTable("GEN_IDT");

            entity.Property(e => e.Blkodu).HasColumnName("BLKODU");
            entity.Property(e => e.GenDescription)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("GEN_DESCRIPTION");
            entity.Property(e => e.GenName)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("GEN_NAME");
            entity.Property(e => e.GenValue).HasColumnName("GEN_VALUE");
        });

        modelBuilder.Entity<Girisciki>(entity =>
        {
            entity.HasKey(e => e.Blkodu).HasName("PK__GIRISCIK__24967F26F79D7795");

            entity.ToTable("GIRISCIKIS");

            entity.HasIndex(e => e.Cikistarihi, "CIKISTARIHI_IND");

            entity.HasIndex(e => e.Giristarihi, "GIRISTARIHI_IND");

            entity.HasIndex(e => e.Blpersonelkodu, "GRSCKS_BLPERSONELKODU");

            entity.HasIndex(e => e.Cikistarihi2, "GRSCKS_CIKISTARIHI2");

            entity.HasIndex(e => e.Giristarihi2, "GRSCKS_GIRISTARIHI2");

            entity.HasIndex(e => e.Yillikizinmiktari, "GRSCKS_YILLIKIZINMIKTARI");

            entity.HasIndex(e => e.Mazerettanimi, "MAZARETTANIMI_IND");

            entity.Property(e => e.Blkodu)
                .ValueGeneratedNever()
                .HasColumnName("BLKODU");
            entity.Property(e => e.Blpersonelkodu).HasColumnName("BLPERSONELKODU");
            entity.Property(e => e.Cikiskapi)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CIKISKAPI");
            entity.Property(e => e.Cikistarihi)
                .HasColumnType("datetime")
                .HasColumnName("CIKISTARIHI");
            entity.Property(e => e.Cikistarihi2)
                .HasComputedColumnSql("(dateadd(day,datediff(day,(0),[CIKISTARIHI]),(0)))", false)
                .HasColumnType("datetime")
                .HasColumnName("CIKISTARIHI2");
            entity.Property(e => e.Duzenleyen)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DUZENLEYEN");
            entity.Property(e => e.EditIp)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("EDIT_IP");
            entity.Property(e => e.EditOrtam).HasColumnName("EDIT_ORTAM");
            entity.Property(e => e.EditZaman)
                .HasColumnType("datetime")
                .HasColumnName("EDIT_ZAMAN");
            entity.Property(e => e.Giriskapi)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("GIRISKAPI");
            entity.Property(e => e.Giristarihi)
                .HasColumnType("datetime")
                .HasColumnName("GIRISTARIHI");
            entity.Property(e => e.Giristarihi2)
                .HasComputedColumnSql("(dateadd(day,datediff(day,(0),[GIRISTARIHI]),(0)))", false)
                .HasColumnType("datetime")
                .HasColumnName("GIRISTARIHI2");
            entity.Property(e => e.InsIp)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("INS_IP");
            entity.Property(e => e.InsOrtam).HasColumnName("INS_ORTAM");
            entity.Property(e => e.InsZaman)
                .HasColumnType("datetime")
                .HasColumnName("INS_ZAMAN");
            entity.Property(e => e.Kaydeden)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KAYDEDEN");
            entity.Property(e => e.Mazerettanimi)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("MAZERETTANIMI");
            entity.Property(e => e.Ocikistarihi)
                .HasColumnType("datetime")
                .HasColumnName("OCIKISTARIHI");
            entity.Property(e => e.Ogiristarihi)
                .HasColumnType("datetime")
                .HasColumnName("OGIRISTARIHI");
            entity.Property(e => e.Puantoraciklama)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasColumnName("PUANTORACIKLAMA");
            entity.Property(e => e.Tip).HasColumnName("TIP");
            entity.Property(e => e.Yillikizinmiktari).HasColumnName("YILLIKIZINMIKTARI");
        });

        modelBuilder.Entity<Gorev>(entity =>
        {
            entity.HasKey(e => e.Blkodu).HasName("PK__GOREV__24967F264C554A09");

            entity.ToTable("GOREV");

            entity.Property(e => e.Blkodu)
                .ValueGeneratedNever()
                .HasColumnName("BLKODU");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.BasTarihi)
                .HasColumnType("datetime")
                .HasColumnName("BAS_TARIHI");
            entity.Property(e => e.BitTarihi)
                .HasColumnType("datetime")
                .HasColumnName("BIT_TARIHI");
            entity.Property(e => e.Blperkodu).HasColumnName("BLPERKODU");
            entity.Property(e => e.Degistiren)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DEGISTIREN");
            entity.Property(e => e.DegistirmeTarihi)
                .HasColumnType("datetime")
                .HasColumnName("DEGISTIRME_TARIHI");
            entity.Property(e => e.Durumu).HasColumnName("DURUMU");
            entity.Property(e => e.GorevVeren)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("GOREV_VEREN");
            entity.Property(e => e.Grubu)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GRUBU");
            entity.Property(e => e.KanaatNotu).HasColumnName("KANAAT_NOTU");
            entity.Property(e => e.Kaydeden)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KAYDEDEN");
            entity.Property(e => e.KayitTarihi)
                .HasColumnType("datetime")
                .HasColumnName("KAYIT_TARIHI");
            entity.Property(e => e.OzelKodu1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OZEL_KODU_1");
            entity.Property(e => e.OzelKodu2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OZEL_KODU_2");
            entity.Property(e => e.TamamlanmaTarihi)
                .HasColumnType("datetime")
                .HasColumnName("TAMAMLANMA_TARIHI");
            entity.Property(e => e.Tanimi)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("TANIMI");
        });

        modelBuilder.Entity<Grup>(entity =>
        {
            entity.HasKey(e => e.Blkodu).HasName("PK__GRUP__24967F2663881468");

            entity.ToTable("GRUP");

            entity.Property(e => e.Blkodu)
                .ValueGeneratedNever()
                .HasColumnName("BLKODU");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Degistiren)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DEGISTIREN");
            entity.Property(e => e.DegistirmeTarihi)
                .HasColumnType("datetime")
                .HasColumnName("DEGISTIRME_TARIHI");
            entity.Property(e => e.GrupAdi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GRUP_ADI");
            entity.Property(e => e.GrupKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("GRUP_KODU");
            entity.Property(e => e.Kaydeden)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KAYDEDEN");
            entity.Property(e => e.KayitTarihi)
                .HasColumnType("datetime")
                .HasColumnName("KAYIT_TARIHI");
            entity.Property(e => e.Modul)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MODUL");
            entity.Property(e => e.Sira).HasColumnName("SIRA");
        });

        modelBuilder.Entity<GrupAlt>(entity =>
        {
            entity.HasKey(e => e.Blkodu).HasName("PK__GRUP_ALT__24967F263EABB19B");

            entity.ToTable("GRUP_ALT");

            entity.Property(e => e.Blkodu)
                .ValueGeneratedNever()
                .HasColumnName("BLKODU");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Blmaskodu).HasColumnName("BLMASKODU");
            entity.Property(e => e.Degistiren)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DEGISTIREN");
            entity.Property(e => e.DegistirmeTarihi)
                .HasColumnType("datetime")
                .HasColumnName("DEGISTIRME_TARIHI");
            entity.Property(e => e.GrupAdi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GRUP_ADI");
            entity.Property(e => e.GrupKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("GRUP_KODU");
            entity.Property(e => e.Kaydeden)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KAYDEDEN");
            entity.Property(e => e.KayitTarihi)
                .HasColumnType("datetime")
                .HasColumnName("KAYIT_TARIHI");
            entity.Property(e => e.Modul)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MODUL");
            entity.Property(e => e.UstGrupAdi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UST_GRUP_ADI");
            entity.Property(e => e.UstGrupAdi2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UST_GRUP_ADI2");
        });

        modelBuilder.Entity<GrupAlt2>(entity =>
        {
            entity.HasKey(e => e.Blkodu).HasName("PK__GRUP_ALT__24967F2667340D8D");

            entity.ToTable("GRUP_ALT2");

            entity.Property(e => e.Blkodu)
                .ValueGeneratedNever()
                .HasColumnName("BLKODU");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Blmaskodu).HasColumnName("BLMASKODU");
            entity.Property(e => e.Degistiren)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DEGISTIREN");
            entity.Property(e => e.DegistirmeTarihi)
                .HasColumnType("datetime")
                .HasColumnName("DEGISTIRME_TARIHI");
            entity.Property(e => e.DevirHiziDahilEtme).HasColumnName("DEVIR_HIZI_DAHIL_ETME");
            entity.Property(e => e.GrupAdi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GRUP_ADI");
            entity.Property(e => e.GrupKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("GRUP_KODU");
            entity.Property(e => e.Kapasite).HasColumnName("KAPASITE");
            entity.Property(e => e.Kaydeden)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KAYDEDEN");
            entity.Property(e => e.KayitTarihi)
                .HasColumnType("datetime")
                .HasColumnName("KAYIT_TARIHI");
            entity.Property(e => e.Modul)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MODUL");
            entity.Property(e => e.UstGrupAdi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UST_GRUP_ADI");
            entity.Property(e => e.UstGrupAdi2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UST_GRUP_ADI2");
            entity.Property(e => e.UstGrupAdi3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UST_GRUP_ADI3");
        });

        modelBuilder.Entity<GrupAra>(entity =>
        {
            entity.HasKey(e => e.Blkodu).HasName("PK__GRUP_ARA__24967F26BC53CBF2");

            entity.ToTable("GRUP_ARA");

            entity.Property(e => e.Blkodu)
                .ValueGeneratedNever()
                .HasColumnName("BLKODU");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Blmaskodu).HasColumnName("BLMASKODU");
            entity.Property(e => e.Degistiren)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DEGISTIREN");
            entity.Property(e => e.DegistirmeTarihi)
                .HasColumnType("datetime")
                .HasColumnName("DEGISTIRME_TARIHI");
            entity.Property(e => e.GrupAdi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GRUP_ADI");
            entity.Property(e => e.GrupKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("GRUP_KODU");
            entity.Property(e => e.Kaydeden)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KAYDEDEN");
            entity.Property(e => e.KayitTarihi)
                .HasColumnType("datetime")
                .HasColumnName("KAYIT_TARIHI");
            entity.Property(e => e.Modul)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MODUL");
            entity.Property(e => e.OrgsemaDahilEtme).HasColumnName("ORGSEMA_DAHIL_ETME");
            entity.Property(e => e.UstGrupAdi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UST_GRUP_ADI");
        });

        modelBuilder.Entity<Icmal>(entity =>
        {
            entity.HasKey(e => e.Blkodu).HasName("PK__ICMAL__24967F266C5A9D49");

            entity.ToTable("ICMAL");

            entity.HasIndex(e => e.Aykodu, "ICM_AYKODU");

            entity.HasIndex(e => e.Blperskodu, "ICM_BLPERSKODU");

            entity.HasIndex(e => e.IsyeriKodu, "ICM_ISYERIKODU");

            entity.Property(e => e.Blkodu)
                .ValueGeneratedNever()
                .HasColumnName("BLKODU");
            entity.Property(e => e.AgiMahsubu).HasColumnName("AGI_MAHSUBU");
            entity.Property(e => e.Aykodu).HasColumnName("AYKODU");
            entity.Property(e => e.AylikBrucret).HasColumnName("AYLIK_BRUCRET");
            entity.Property(e => e.AylikUcretler).HasColumnName("AYLIK_UCRETLER");
            entity.Property(e => e.Blperskodu).HasColumnName("BLPERSKODU");
            entity.Property(e => e.BrutUcret).HasColumnName("BRUT_UCRET");
            entity.Property(e => e.CocukParasi).HasColumnName("COCUK_PARASI");
            entity.Property(e => e.CocukYrd).HasColumnName("COCUK_YRD");
            entity.Property(e => e.DamgaVergisi).HasColumnName("DAMGA_VERGISI");
            entity.Property(e => e.DmvIstisnasi).HasColumnName("DMV_ISTISNASI");
            entity.Property(e => e.EkGelirler).HasColumnName("EK_GELIRLER");
            entity.Property(e => e.FazlaMesailer).HasColumnName("FAZLA_MESAILER");
            entity.Property(e => e.GelirVergisi).HasColumnName("GELIR_VERGISI");
            entity.Property(e => e.GlvrMatrahi).HasColumnName("GLVR_MATRAHI");
            entity.Property(e => e.GvIstisnasi).HasColumnName("GV_ISTISNASI");
            entity.Property(e => e.IhbarTazminati).HasColumnName("IHBAR_TAZMINATI");
            entity.Property(e => e.IssizlikSig).HasColumnName("ISSIZLIK_SIG");
            entity.Property(e => e.Isv06645Indirimi).HasColumnName("ISV_06645_INDIRIMI");
            entity.Property(e => e.Isv16322Indirimi).HasColumnName("ISV_16322_INDIRIMI");
            entity.Property(e => e.Isv25510Indirimi).HasColumnName("ISV_25510_INDIRIMI");
            entity.Property(e => e.Isv4857Indirimi).HasColumnName("ISV_4857_INDIRIMI");
            entity.Property(e => e.Isv5510Indirimi).HasColumnName("ISV_5510_INDIRIMI");
            entity.Property(e => e.Isv6111Indirimi).HasColumnName("ISV_6111_INDIRIMI");
            entity.Property(e => e.IsvDvIndirimi).HasColumnName("ISV_DV_INDIRIMI");
            entity.Property(e => e.IsvGvIndirimi).HasColumnName("ISV_GV_INDIRIMI");
            entity.Property(e => e.IsvIndirimToplami).HasColumnName("ISV_INDIRIM_TOPLAMI");
            entity.Property(e => e.IsvIndirimi6486).HasColumnName("ISV_INDIRIMI_6486");
            entity.Property(e => e.IsvIsshis).HasColumnName("ISV_ISSHIS");
            entity.Property(e => e.IsvSgdp).HasColumnName("ISV_SGDP");
            entity.Property(e => e.IsvSskIndirimi).HasColumnName("ISV_SSK_INDIRIMI");
            entity.Property(e => e.IsvSskIndirimiIssizlik).HasColumnName("ISV_SSK_INDIRIMI_ISSIZLIK");
            entity.Property(e => e.IsvSskIndirimiNrm).HasColumnName("ISV_SSK_INDIRIMI_NRM");
            entity.Property(e => e.IsvSskhis).HasColumnName("ISV_SSKHIS");
            entity.Property(e => e.IsvTesvikPrimi).HasColumnName("ISV_TESVIK_PRIMI");
            entity.Property(e => e.IsyeriKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ISYERI_KODU");
            entity.Property(e => e.KidemTazminati).HasColumnName("KIDEM_TAZMINATI");
            entity.Property(e => e.NetOdenen).HasColumnName("NET_ODENEN");
            entity.Property(e => e.NetUcretler).HasColumnName("NET_UCRETLER");
            entity.Property(e => e.OdenecekSgdp).HasColumnName("ODENECEK_SGDP");
            entity.Property(e => e.PrimGunu).HasColumnName("PRIM_GUNU");
            entity.Property(e => e.SairKesintiler).HasColumnName("SAIR_KESINTILER");
            entity.Property(e => e.SairOdemeler).HasColumnName("SAIR_ODEMELER");
            entity.Property(e => e.SgPrMatrahi).HasColumnName("SG_PR_MATRAHI");
            entity.Property(e => e.SskPrimi).HasColumnName("SSK_PRIMI");
            entity.Property(e => e.UcrIzin).HasColumnName("UCR_IZIN");
        });

        modelBuilder.Entity<Icra>(entity =>
        {
            entity.HasKey(e => e.Blkodu).HasName("PK__ICRA__24967F26503D4469");

            entity.ToTable("ICRA");

            entity.Property(e => e.Blkodu)
                .ValueGeneratedNever()
                .HasColumnName("BLKODU");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.AgiDahil).HasColumnName("AGI_DAHIL");
            entity.Property(e => e.Alacakli)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ALACAKLI");
            entity.Property(e => e.AliciIbanNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ALICI_IBAN_NO");
            entity.Property(e => e.BankaAdi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BANKA_ADI");
            entity.Property(e => e.BaslangicAykodu).HasColumnName("BASLANGIC_AYKODU");
            entity.Property(e => e.BaslangicYil).HasColumnName("BASLANGIC_YIL");
            entity.Property(e => e.DosyaNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DOSYA_NO");
            entity.Property(e => e.Durumu)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("DURUMU");
            entity.Property(e => e.HesapNumarasi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("HESAP_NUMARASI");
            entity.Property(e => e.IcraDairesi)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ICRA_DAIRESI");
            entity.Property(e => e.KayitTarihi)
                .HasColumnType("datetime")
                .HasColumnName("KAYIT_TARIHI");
            entity.Property(e => e.KesintiOrani1).HasColumnName("KESINTI_ORANI1");
            entity.Property(e => e.KesintiOrani2).HasColumnName("KESINTI_ORANI2");
            entity.Property(e => e.KesintiTuru).HasColumnName("KESINTI_TURU");
            entity.Property(e => e.KesintiTutari).HasColumnName("KESINTI_TUTARI");
            entity.Property(e => e.MahkemeAdi)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("MAHKEME_ADI");
            entity.Property(e => e.OncOdenentutar).HasColumnName("ONC_ODENENTUTAR");
            entity.Property(e => e.OncelikSirasi).HasColumnName("ONCELIK_SIRASI");
            entity.Property(e => e.OtokesintiKullan).HasColumnName("OTOKESINTI_KULLAN");
            entity.Property(e => e.OzelKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("OZEL_KODU");
            entity.Property(e => e.Perblkodu).HasColumnName("PERBLKODU");
            entity.Property(e => e.SiraNo).HasColumnName("SIRA_NO");
            entity.Property(e => e.SubeAdi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SUBE_ADI");
            entity.Property(e => e.Tarihi)
                .HasColumnType("datetime")
                .HasColumnName("TARIHI");
            entity.Property(e => e.ToplamBorc).HasColumnName("TOPLAM_BORC");
        });

        modelBuilder.Entity<IcraHrk>(entity =>
        {
            entity.HasKey(e => e.Blkodu).HasName("PK__ICRA_HRK__24967F26670C90D3");

            entity.ToTable("ICRA_HRK");

            entity.Property(e => e.Blkodu)
                .ValueGeneratedNever()
                .HasColumnName("BLKODU");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.BordroAy).HasColumnName("BORDRO_AY");
            entity.Property(e => e.BordroYil).HasColumnName("BORDRO_YIL");
            entity.Property(e => e.Icrablkodu).HasColumnName("ICRABLKODU");
            entity.Property(e => e.OdemeTutari).HasColumnName("ODEME_TUTARI");
            entity.Property(e => e.Perblkodu).HasColumnName("PERBLKODU");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
        });

        modelBuilder.Entity<Ihbar>(entity =>
        {
            entity.HasKey(e => e.Blkodu).HasName("PK__IHBAR__24967F268769DBD9");

            entity.ToTable("IHBAR");

            entity.Property(e => e.Blkodu)
                .ValueGeneratedNever()
                .HasColumnName("BLKODU");
            entity.Property(e => e.AylikEkgelirler).HasColumnName("AYLIK_EKGELIRLER");
            entity.Property(e => e.AylikUcreti).HasColumnName("AYLIK_UCRETI");
            entity.Property(e => e.BirikimMatrahi).HasColumnName("BIRIKIM_MATRAHI");
            entity.Property(e => e.Blperskodu).HasColumnName("BLPERSKODU");
            entity.Property(e => e.CalismaSuresi).HasColumnName("CALISMA_SURESI");
            entity.Property(e => e.DamgaVergisi).HasColumnName("DAMGA_VERGISI");
            entity.Property(e => e.GelirVergisi).HasColumnName("GELIR_VERGISI");
            entity.Property(e => e.HafEkgelirler).HasColumnName("HAF_EKGELIRLER");
            entity.Property(e => e.HafToplami).HasColumnName("HAF_TOPLAMI");
            entity.Property(e => e.HafUcret).HasColumnName("HAF_UCRET");
            entity.Property(e => e.HaftaSayisi).HasColumnName("HAFTA_SAYISI");
            entity.Property(e => e.IhbarTazminati).HasColumnName("IHBAR_TAZMINATI");
            entity.Property(e => e.IsyeriAdi)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("ISYERI_ADI");
            entity.Property(e => e.IsyeriKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ISYERI_KODU");
            entity.Property(e => e.NetTazminat).HasColumnName("NET_TAZMINAT");
        });

        modelBuilder.Entity<IkBasvuru>(entity =>
        {
            entity.HasKey(e => e.Blkodu).HasName("PK__IK_BASVU__24967F2617137C4F");

            entity.ToTable("IK_BASVURU");

            entity.Property(e => e.Blkodu)
                .ValueGeneratedNever()
                .HasColumnName("BLKODU");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Adi)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("ADI");
            entity.Property(e => e.Adresi)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ADRESI");
            entity.Property(e => e.AilesininYaninda).HasColumnName("AILESININ_YANINDA");
            entity.Property(e => e.Anaadi)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ANAADI");
            entity.Property(e => e.Aranacakadisoyadi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ARANACAKADISOYADI");
            entity.Property(e => e.Aranacaktelno)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ARANACAKTELNO");
            entity.Property(e => e.AskerlikDurumu).HasColumnName("ASKERLIK_DURUMU");
            entity.Property(e => e.AylikGeliri).HasColumnName("AYLIK_GELIRI");
            entity.Property(e => e.BabaMeslegi)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("BABA_MESLEGI");
            entity.Property(e => e.Babaadi)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("BABAADI");
            entity.Property(e => e.BasvuruTarihi)
                .HasColumnType("datetime")
                .HasColumnName("BASVURU_TARIHI");
            entity.Property(e => e.Basvurukaynak)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("BASVURUKAYNAK");
            entity.Property(e => e.Beklentiler)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("BEKLENTILER");
            entity.Property(e => e.Blperkodu).HasColumnName("BLPERKODU");
            entity.Property(e => e.CalismaSaatleri).HasColumnName("CALISMA_SAATLERI");
            entity.Property(e => e.CepTel)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CEP_TEL");
            entity.Property(e => e.Cinsiyeti).HasColumnName("CINSIYETI");
            entity.Property(e => e.CocukSayisi).HasColumnName("COCUK_SAYISI");
            entity.Property(e => e.Dahaoncecalisti).HasColumnName("DAHAONCECALISTI");
            entity.Property(e => e.Dahaoncedurum)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DAHAONCEDURUM");
            entity.Property(e => e.Degistiren)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DEGISTIREN");
            entity.Property(e => e.DegistirmeTarihi)
                .HasColumnType("datetime")
                .HasColumnName("DEGISTIRME_TARIHI");
            entity.Property(e => e.DenemeSureci)
                .HasColumnType("datetime")
                .HasColumnName("DENEME_SURECI");
            entity.Property(e => e.DenemeSureci2)
                .HasColumnType("datetime")
                .HasColumnName("DENEME_SURECI_2");
            entity.Property(e => e.Departman1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DEPARTMAN_1");
            entity.Property(e => e.Departman2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DEPARTMAN_2");
            entity.Property(e => e.Departman3)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DEPARTMAN_3");
            entity.Property(e => e.DepartmanUygun)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DEPARTMAN_UYGUN");
            entity.Property(e => e.DogumTarihi)
                .HasColumnType("datetime")
                .HasColumnName("DOGUM_TARIHI");
            entity.Property(e => e.DogumYeri)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("DOGUM_YERI");
            entity.Property(e => e.DoktoraBolum)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("DOKTORA_BOLUM");
            entity.Property(e => e.DoktoraFakulte)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("DOKTORA_FAKULTE");
            entity.Property(e => e.DoktoraOkul)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("DOKTORA_OKUL");
            entity.Property(e => e.DoktoraYil)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("DOKTORA_YIL");
            entity.Property(e => e.Durumu).HasColumnName("DURUMU");
            entity.Property(e => e.DurumuPrmd).HasColumnName("DURUMU_PRMD");
            entity.Property(e => e.DusAylikUcret).HasColumnName("DUS_AYLIK_UCRET");
            entity.Property(e => e.EMail)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("E_MAIL");
            entity.Property(e => e.EgitimDevam).HasColumnName("EGITIM_DEVAM");
            entity.Property(e => e.EgitimGngcsys)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("EGITIM_GNGCSYS");
            entity.Property(e => e.EgitimGungece).HasColumnName("EGITIM_GUNGECE");
            entity.Property(e => e.EgitimKonu)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("EGITIM_KONU");
            entity.Property(e => e.EgitimSureci)
                .HasColumnType("datetime")
                .HasColumnName("EGITIM_SURECI");
            entity.Property(e => e.EgitimSureci2)
                .HasColumnType("datetime")
                .HasColumnName("EGITIM_SURECI_2");
            entity.Property(e => e.EhliyetTipi)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("EHLIYET_TIPI");
            entity.Property(e => e.EhliyetVarmi).HasColumnName("EHLIYET_VARMI");
            entity.Property(e => e.EkgelirAciklamasi)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EKGELIR_ACIKLAMASI");
            entity.Property(e => e.EsAdi)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ES_ADI");
            entity.Property(e => e.EsMeslegi)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ES_MESLEGI");
            entity.Property(e => e.EvTel)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("EV_TEL");
            entity.Property(e => e.FirmadayakiniVarmi).HasColumnName("FIRMADAYAKINI_VARMI");
            entity.Property(e => e.GeliriVarmi).HasColumnName("GELIRI_VARMI");
            entity.Property(e => e.Gorusler)
                .IsUnicode(false)
                .HasColumnName("GORUSLER");
            entity.Property(e => e.Ilcesi)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ILCESI");
            entity.Property(e => e.Ili)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ILI");
            entity.Property(e => e.IlkogrBolum)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ILKOGR_BOLUM");
            entity.Property(e => e.IlkogrFakulte)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ILKOGR_FAKULTE");
            entity.Property(e => e.IlkogrOkul)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ILKOGR_OKUL");
            entity.Property(e => e.IlkogrYil)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ILKOGR_YIL");
            entity.Property(e => e.IsAyrilmanedeni1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("IS_AYRILMANEDENI1");
            entity.Property(e => e.IsAyrilmanedeni2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("IS_AYRILMANEDENI2");
            entity.Property(e => e.IsAyrilmanedeni3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("IS_AYRILMANEDENI3");
            entity.Property(e => e.IsAyrilmanedeni4)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("IS_AYRILMANEDENI4");
            entity.Property(e => e.IsAyrilmatrh1)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("IS_AYRILMATRH1");
            entity.Property(e => e.IsAyrilmatrh2)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("IS_AYRILMATRH2");
            entity.Property(e => e.IsAyrilmatrh3)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("IS_AYRILMATRH3");
            entity.Property(e => e.IsAyrilmatrh4)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("IS_AYRILMATRH4");
            entity.Property(e => e.IsBirim1)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("IS_BIRIM1");
            entity.Property(e => e.IsBirim2)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("IS_BIRIM2");
            entity.Property(e => e.IsBirim3)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("IS_BIRIM3");
            entity.Property(e => e.IsBirim4)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("IS_BIRIM4");
            entity.Property(e => e.IsCalismasure1)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("IS_CALISMASURE1");
            entity.Property(e => e.IsCalismasure2)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("IS_CALISMASURE2");
            entity.Property(e => e.IsCalismasure3)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("IS_CALISMASURE3");
            entity.Property(e => e.IsCalismasure4)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("IS_CALISMASURE4");
            entity.Property(e => e.IsFirma1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("IS_FIRMA1");
            entity.Property(e => e.IsFirma2)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("IS_FIRMA2");
            entity.Property(e => e.IsFirma3)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("IS_FIRMA3");
            entity.Property(e => e.IsFirma4)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("IS_FIRMA4");
            entity.Property(e => e.IsGorev1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("IS_GOREV1");
            entity.Property(e => e.IsGorev2)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("IS_GOREV2");
            entity.Property(e => e.IsGorev3)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("IS_GOREV3");
            entity.Property(e => e.IsGorev4)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("IS_GOREV4");
            entity.Property(e => e.IseBaslama)
                .HasColumnType("datetime")
                .HasColumnName("ISE_BASLAMA");
            entity.Property(e => e.IstenAyrTrh)
                .HasColumnType("datetime")
                .HasColumnName("ISTEN_AYR_TRH");
            entity.Property(e => e.IsyeriAdi)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("ISYERI_ADI");
            entity.Property(e => e.IsyeriKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ISYERI_KODU");
            entity.Property(e => e.Kangrubu)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("KANGRUBU");
            entity.Property(e => e.KardesSayisi).HasColumnName("KARDES_SAYISI");
            entity.Property(e => e.Kaydeden)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KAYDEDEN");
            entity.Property(e => e.Kendinitanit)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("KENDINITANIT");
            entity.Property(e => e.Lisans2Bolum)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("LISANS2_BOLUM");
            entity.Property(e => e.Lisans2Fakulte)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("LISANS2_FAKULTE");
            entity.Property(e => e.Lisans2Okul)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("LISANS2_OKUL");
            entity.Property(e => e.Lisans2Yil)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("LISANS2_YIL");
            entity.Property(e => e.LisansBolum)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("LISANS_BOLUM");
            entity.Property(e => e.LisansFakulte)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("LISANS_FAKULTE");
            entity.Property(e => e.LisansOkul)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("LISANS_OKUL");
            entity.Property(e => e.LisansYil)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("LISANS_YIL");
            entity.Property(e => e.LiseBolum)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("LISE_BOLUM");
            entity.Property(e => e.LiseFakulte)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("LISE_FAKULTE");
            entity.Property(e => e.LiseOkul)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("LISE_OKUL");
            entity.Property(e => e.LiseYil)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("LISE_YIL");
            entity.Property(e => e.MedeniHali).HasColumnName("MEDENI_HALI");
            entity.Property(e => e.Meslegi)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("MESLEGI");
            entity.Property(e => e.OgrenimDurumu).HasColumnName("OGRENIM_DURUMU");
            entity.Property(e => e.OgrenimDurumuSonrasi).HasColumnName("OGRENIM_DURUMU_SONRASI");
            entity.Property(e => e.OncekiSoyadi)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ONCEKI_SOYADI");
            entity.Property(e => e.Onlisans2Bolum)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ONLISANS2_BOLUM");
            entity.Property(e => e.Onlisans2Fakulte)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ONLISANS2_FAKULTE");
            entity.Property(e => e.Onlisans2Okul)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ONLISANS2_OKUL");
            entity.Property(e => e.Onlisans2Yil)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ONLISANS2_YIL");
            entity.Property(e => e.OnlisansBolum)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ONLISANS_BOLUM");
            entity.Property(e => e.OnlisansFakulte)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ONLISANS_FAKULTE");
            entity.Property(e => e.OnlisansOkul)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ONLISANS_OKUL");
            entity.Property(e => e.OnlisansYil)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ONLISANS_YIL");
            entity.Property(e => e.OzelKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("OZEL_KODU");
            entity.Property(e => e.Ref1Adsoyad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("REF1_ADSOYAD");
            entity.Property(e => e.Ref1Gorev)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("REF1_GOREV");
            entity.Property(e => e.Ref1Kurum)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("REF1_KURUM");
            entity.Property(e => e.Ref1Tel)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("REF1_TEL");
            entity.Property(e => e.Ref2Adsoyad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("REF2_ADSOYAD");
            entity.Property(e => e.Ref2Gorev)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("REF2_GOREV");
            entity.Property(e => e.Ref2Kurum)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("REF2_KURUM");
            entity.Property(e => e.Ref2Tel)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("REF2_TEL");
            entity.Property(e => e.Ref3Adsoyad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("REF3_ADSOYAD");
            entity.Property(e => e.Ref3Gorev)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("REF3_GOREV");
            entity.Property(e => e.Ref3Kurum)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("REF3_KURUM");
            entity.Property(e => e.Ref3Tel)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("REF3_TEL");
            entity.Property(e => e.Referansno)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("REFERANSNO");
            entity.Property(e => e.SabikakaydiVarmi).HasColumnName("SABIKAKAYDI_VARMI");
            entity.Property(e => e.SaglikDurumu)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SAGLIK_DURUMU");
            entity.Property(e => e.SeminerAciklama1)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("SEMINER_ACIKLAMA1");
            entity.Property(e => e.SeminerAciklama2)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("SEMINER_ACIKLAMA2");
            entity.Property(e => e.SeminerAciklama3)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("SEMINER_ACIKLAMA3");
            entity.Property(e => e.SeminerBastar1)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("SEMINER_BASTAR1");
            entity.Property(e => e.SeminerBastar2)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("SEMINER_BASTAR2");
            entity.Property(e => e.SeminerBastar3)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("SEMINER_BASTAR3");
            entity.Property(e => e.SeminerBittar1)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("SEMINER_BITTAR1");
            entity.Property(e => e.SeminerBittar2)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("SEMINER_BITTAR2");
            entity.Property(e => e.SeminerBittar3)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("SEMINER_BITTAR3");
            entity.Property(e => e.SeminerTanimi1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SEMINER_TANIMI1");
            entity.Property(e => e.SeminerTanimi2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SEMINER_TANIMI2");
            entity.Property(e => e.SeminerTanimi3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SEMINER_TANIMI3");
            entity.Property(e => e.SeyahatProb).HasColumnName("SEYAHAT_PROB");
            entity.Property(e => e.SigaraKul).HasColumnName("SIGARA_KUL");
            entity.Property(e => e.Silindi).HasColumnName("SILINDI");
            entity.Property(e => e.Soyadi)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("SOYADI");
            entity.Property(e => e.SurusTecrubesi).HasColumnName("SURUS_TECRUBESI");
            entity.Property(e => e.TckimlikNo)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("TCKIMLIK_NO");
            entity.Property(e => e.TecilNedeni)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("TECIL_NEDENI");
            entity.Property(e => e.TecilTarihi)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TECIL_TARIHI");
            entity.Property(e => e.Uyrugu)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("UYRUGU");
            entity.Property(e => e.Web)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("WEB");
            entity.Property(e => e.WebdeGorunsun).HasColumnName("WEBDE_GORUNSUN");
            entity.Property(e => e.YoneticiDuzeyi).HasColumnName("YONETICI_DUZEYI");
            entity.Property(e => e.YuklisansBolum)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("YUKLISANS_BOLUM");
            entity.Property(e => e.YuklisansFakulte)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("YUKLISANS_FAKULTE");
            entity.Property(e => e.YuklisansOkul)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("YUKLISANS_OKUL");
            entity.Property(e => e.YuklisansYil)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("YUKLISANS_YIL");
        });

        modelBuilder.Entity<IkBasvuruAciklama>(entity =>
        {
            entity.HasKey(e => e.Blkodu).HasName("PK__IK_BASVU__24967F26F727231A");

            entity.ToTable("IK_BASVURU_ACIKLAMA");

            entity.Property(e => e.Blkodu)
                .ValueGeneratedNever()
                .HasColumnName("BLKODU");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.AckKodu)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ACK_KODU");
            entity.Property(e => e.Blbasvurukodu).HasColumnName("BLBASVURUKODU");
            entity.Property(e => e.Degistiren)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DEGISTIREN");
            entity.Property(e => e.DegistirmeTarihi)
                .HasColumnType("datetime")
                .HasColumnName("DEGISTIRME_TARIHI");
            entity.Property(e => e.Kaydeden)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KAYDEDEN");
            entity.Property(e => e.KayitTarih)
                .HasColumnType("datetime")
                .HasColumnName("KAYIT_TARIH");
        });

        modelBuilder.Entity<IkBasvuruOzellik>(entity =>
        {
            entity.HasKey(e => e.Blkodu).HasName("PK__IK_BASVU__24967F262117F5A7");

            entity.ToTable("IK_BASVURU_OZELLIK");

            entity.HasIndex(e => e.Blbaskodu, "BASVURU_BLKODU");

            entity.Property(e => e.Blkodu)
                .ValueGeneratedNever()
                .HasColumnName("BLKODU");
            entity.Property(e => e.Blbaskodu).HasColumnName("BLBASKODU");
            entity.Property(e => e.Bldpkodu).HasColumnName("BLDPKODU");
            entity.Property(e => e.Blotkodu).HasColumnName("BLOTKODU");
            entity.Property(e => e.MetinGirisi).HasColumnName("METIN_GIRISI");
            entity.Property(e => e.OzellikTanimi)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("OZELLIK_TANIMI");
            entity.Property(e => e.Yetenek).HasColumnName("YETENEK");
        });

        modelBuilder.Entity<IkBasvuruOzellikEslestir>(entity =>
        {
            entity.HasKey(e => e.Blkodu).HasName("PK__IK_BASVU__24967F268BFC4600");

            entity.ToTable("IK_BASVURU_OZELLIK_ESLESTIR");

            entity.Property(e => e.Blkodu)
                .ValueGeneratedNever()
                .HasColumnName("BLKODU");
            entity.Property(e => e.Bldpkodu).HasColumnName("BLDPKODU");
            entity.Property(e => e.Blotkodu).HasColumnName("BLOTKODU");
            entity.Property(e => e.SiraNo).HasColumnName("SIRA_NO");
        });

        modelBuilder.Entity<IkBasvuruOzellikTanim>(entity =>
        {
            entity.HasKey(e => e.Blkodu).HasName("PK__IK_BASVU__24967F26BE5A4330");

            entity.ToTable("IK_BASVURU_OZELLIK_TANIM");

            entity.Property(e => e.Blkodu)
                .ValueGeneratedNever()
                .HasColumnName("BLKODU");
            entity.Property(e => e.Aktif).HasColumnName("AKTIF");
            entity.Property(e => e.Kodu)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("KODU");
            entity.Property(e => e.MetinGirisi).HasColumnName("METIN_GIRISI");
            entity.Property(e => e.Tanimi)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("TANIMI");
        });

        modelBuilder.Entity<IkDurum>(entity =>
        {
            entity.HasKey(e => e.Blkodu).HasName("PK__IK_DURUM__24967F266266A22E");

            entity.ToTable("IK_DURUM");

            entity.Property(e => e.Blkodu)
                .ValueGeneratedNever()
                .HasColumnName("BLKODU");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Kodu).HasColumnName("KODU");
            entity.Property(e => e.Modul)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MODUL");
            entity.Property(e => e.Tanimi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TANIMI");
            entity.Property(e => e.Varsayilan).HasColumnName("VARSAYILAN");
        });

        modelBuilder.Entity<IstekOneri>(entity =>
        {
            entity.HasKey(e => e.Blkodu).HasName("PK__ISTEK_ON__24967F26485ACC4A");

            entity.ToTable("ISTEK_ONERI");

            entity.Property(e => e.Blkodu)
                .ValueGeneratedNever()
                .HasColumnName("BLKODU");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(2500)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.AdiSoyadi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ADI_SOYADI");
            entity.Property(e => e.Blpersonelkodu).HasColumnName("BLPERSONELKODU");
            entity.Property(e => e.Cevap)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("CEVAP");
            entity.Property(e => e.Cevaplayan)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CEVAPLAYAN");
            entity.Property(e => e.Durum).HasColumnName("DURUM");
            entity.Property(e => e.Konu)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("KONU");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
        });

        modelBuilder.Entity<Isyeri>(entity =>
        {
            entity.HasKey(e => e.Blkodu).HasName("PK__ISYERI__24967F26BE39BB27");

            entity.ToTable("ISYERI");

            entity.HasIndex(e => e.Kodu, "UQ__ISYERI__BF69F8F6F836CFBB").IsUnique();

            entity.Property(e => e.Blkodu)
                .ValueGeneratedNever()
                .HasColumnName("BLKODU");
            entity.Property(e => e.Adi)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("ADI");
            entity.Property(e => e.AdresKodu)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ADRES_KODU");
            entity.Property(e => e.Adresi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ADRESI");
            entity.Property(e => e.Aktif).HasColumnName("AKTIF");
            entity.Property(e => e.AraciKodu)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ARACI_KODU");
            entity.Property(e => e.AyarOzel).HasColumnName("AYAR_OZEL");
            entity.Property(e => e.AyarPtkesintitavansinir).HasColumnName("AYAR_PTKESINTITAVANSINIR");
            entity.Property(e => e.AyarPtkesintitavantip).HasColumnName("AYAR_PTKESINTITAVANTIP");
            entity.Property(e => e.BolgeDskodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("BOLGE_DSKODU");
            entity.Property(e => e.CdNo)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("CD_NO");
            entity.Property(e => e.CepTelefonu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CEP_TELEFONU");
            entity.Property(e => e.EMail)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("E_MAIL");
            entity.Property(e => e.FaaliyetKodu)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("FAALIYET_KODU");
            entity.Property(e => e.Fax)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FAX");
            entity.Property(e => e.Il)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IL");
            entity.Property(e => e.Ilce)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ILCE");
            entity.Property(e => e.IsyeriBolgeKodu)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("ISYERI_BOLGE_KODU");
            entity.Property(e => e.IsyeriTuru)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("ISYERI_TURU");
            entity.Property(e => e.KazaOrani).HasColumnName("KAZA_ORANI");
            entity.Property(e => e.Kodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KODU");
            entity.Property(e => e.Kullanicilar)
                .IsUnicode(false)
                .HasColumnName("KULLANICILAR");
            entity.Property(e => e.KurulusTarihi)
                .HasColumnType("datetime")
                .HasColumnName("KURULUS_TARIHI");
            entity.Property(e => e.MerkezMi).HasColumnName("MERKEZ_MI");
            entity.Property(e => e.MuhasebeciAdi)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("MUHASEBECI_ADI");
            entity.Property(e => e.MuhasebeciEmail)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("MUHASEBECI_EMAIL");
            entity.Property(e => e.MuhasebeciFax)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MUHASEBECI_FAX");
            entity.Property(e => e.MuhasebeciSicilno)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MUHASEBECI_SICILNO");
            entity.Property(e => e.MuhasebeciTckimlikno)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MUHASEBECI_TCKIMLIKNO");
            entity.Property(e => e.MuhasebeciVergino)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MUHASEBECI_VERGINO");
            entity.Property(e => e.MuhasebecoTelefon)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MUHASEBECO_TELEFON");
            entity.Property(e => e.MulkiyetDurumu).HasColumnName("MULKIYET_DURUMU");
            entity.Property(e => e.OgiBaslangic).HasColumnName("OGI_BASLANGIC");
            entity.Property(e => e.OncelikliBolge)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ONCELIKLI_BOLGE");
            entity.Property(e => e.OtmBesBslTarihi)
                .HasColumnType("datetime")
                .HasColumnName("OTM_BES_BSL_TARIHI");
            entity.Property(e => e.OtmBesFirma)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("OTM_BES_FIRMA");
            entity.Property(e => e.OtmBesOrani).HasColumnName("OTM_BES_ORANI");
            entity.Property(e => e.Postakodu)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("POSTAKODU");
            entity.Property(e => e.SgkCalismaKolu)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SGK_CALISMA_KOLU");
            entity.Property(e => e.SgkIsyerikodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SGK_ISYERIKODU");
            entity.Property(e => e.SgkIsyeripwd)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SGK_ISYERIPWD");
            entity.Property(e => e.SgkUsername)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SGK_USERNAME");
            entity.Property(e => e.SgkUserpwd)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SGK_USERPWD");
            entity.Property(e => e.SskIsyeriKodu)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("SSK_ISYERI_KODU");
            entity.Property(e => e.SskKodu)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("SSK_KODU");
            entity.Property(e => e.SskSicilMud)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SSK_SICIL_MUD");
            entity.Property(e => e.SskUnitesi)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("SSK_UNITESI");
            entity.Property(e => e.SubeKodu)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SUBE_KODU");
            entity.Property(e => e.TehlikeDurumu).HasColumnName("TEHLIKE_DURUMU");
            entity.Property(e => e.TehlikeSinifi).HasColumnName("TEHLIKE_SINIFI");
            entity.Property(e => e.Telefon1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TELEFON1");
            entity.Property(e => e.Telefon2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TELEFON2");
            entity.Property(e => e.Tesvik25510Bittar)
                .HasColumnType("datetime")
                .HasColumnName("TESVIK_25510_BITTAR");
            entity.Property(e => e.Tesvik25510Tutar).HasColumnName("TESVIK_25510_TUTAR");
            entity.Property(e => e.TicSicilno)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TIC_SICILNO");
            entity.Property(e => e.VergiDaire)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("VERGI_DAIRE");
            entity.Property(e => e.VergiNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("VERGI_NO");
            entity.Property(e => e.Web)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("WEB");
            entity.Property(e => e.Yetkili)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("YETKILI");
            entity.Property(e => e.YetkiliTckimlikno)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("YETKILI_TCKIMLIKNO");
            entity.Property(e => e.Ziyaretciekrani).HasColumnName("ZIYARETCIEKRANI");
        });

        modelBuilder.Entity<IsyeriKesinti>(entity =>
        {
            entity.HasKey(e => e.Blkodu).HasName("PK__ISYERI_K__24967F2624B8CD3D");

            entity.ToTable("ISYERI_KESINTI");

            entity.HasIndex(e => e.Kodu, "UQ__ISYERI_K__BF69F8F610BEF048").IsUnique();

            entity.Property(e => e.Blkodu)
                .ValueGeneratedNever()
                .HasColumnName("BLKODU");
            entity.Property(e => e.Blisyerikodu).HasColumnName("BLISYERIKODU");
            entity.Property(e => e.GvIndUstSinir).HasColumnName("GV_IND_UST_SINIR");
            entity.Property(e => e.GvIndirimiUygula).HasColumnName("GV_INDIRIMI_UYGULA");
            entity.Property(e => e.Kesinti)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("KESINTI");
            entity.Property(e => e.Kodu)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("KODU");
            entity.Property(e => e.MuhKodu)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("MUH_KODU");
            entity.Property(e => e.NetMaasiEtkilesin).HasColumnName("NET_MAASI_ETKILESIN");
            entity.Property(e => e.Tutari).HasColumnName("TUTARI");
        });

        modelBuilder.Entity<IsyeriProje>(entity =>
        {
            entity.HasKey(e => e.Blkodu).HasName("PK__ISYERI_P__24967F26B012287B");

            entity.ToTable("ISYERI_PROJE");

            entity.Property(e => e.Blkodu)
                .ValueGeneratedNever()
                .HasColumnName("BLKODU");
            entity.Property(e => e.Blisyerikodu).HasColumnName("BLISYERIKODU");
            entity.Property(e => e.ProjeAdi)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PROJE_ADI");
            entity.Property(e => e.ProjeKodu)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PROJE_KODU");
        });

        modelBuilder.Entity<IsyeriYardim>(entity =>
        {
            entity.HasKey(e => e.Blkodu).HasName("PK__ISYERI_Y__24967F2667F9CD6C");

            entity.ToTable("ISYERI_YARDIM");

            entity.HasIndex(e => e.Kodu, "UQ__ISYERI_Y__BF69F8F65AFD22CC").IsUnique();

            entity.Property(e => e.Blkodu)
                .ValueGeneratedNever()
                .HasColumnName("BLKODU");
            entity.Property(e => e.Blisyerikodu).HasColumnName("BLISYERIKODU");
            entity.Property(e => e.DmvKesintisi).HasColumnName("DMV_KESINTISI");
            entity.Property(e => e.DvMuafiyet).HasColumnName("DV_MUAFIYET");
            entity.Property(e => e.DvUstsinir).HasColumnName("DV_USTSINIR");
            entity.Property(e => e.Gunluk).HasColumnName("GUNLUK");
            entity.Property(e => e.GvKesintisi).HasColumnName("GV_KESINTISI");
            entity.Property(e => e.GvMuafiyet).HasColumnName("GV_MUAFIYET");
            entity.Property(e => e.GvUstsinir).HasColumnName("GV_USTSINIR");
            entity.Property(e => e.Kodu)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("KODU");
            entity.Property(e => e.Netbrut).HasColumnName("NETBRUT");
            entity.Property(e => e.SskKesintisi).HasColumnName("SSK_KESINTISI");
            entity.Property(e => e.SskMuafiyet).HasColumnName("SSK_MUAFIYET");
            entity.Property(e => e.SskUstsinir).HasColumnName("SSK_USTSINIR");
            entity.Property(e => e.Tutari).HasColumnName("TUTARI");
            entity.Property(e => e.Yardim)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("YARDIM");
            entity.Property(e => e.YardimTuru).HasColumnName("YARDIM_TURU");
        });

        modelBuilder.Entity<Kidem>(entity =>
        {
            entity.HasKey(e => e.Blkodu).HasName("PK__KIDEM__24967F268683DBA7");

            entity.ToTable("KIDEM");

            entity.Property(e => e.Blkodu)
                .ValueGeneratedNever()
                .HasColumnName("BLKODU");
            entity.Property(e => e.AyAskerlik).HasColumnName("AY_ASKERLIK");
            entity.Property(e => e.AyCalisma).HasColumnName("AY_CALISMA");
            entity.Property(e => e.AyDevir).HasColumnName("AY_DEVIR");
            entity.Property(e => e.AyRaporlu).HasColumnName("AY_RAPORLU");
            entity.Property(e => e.AyToplam).HasColumnName("AY_TOPLAM");
            entity.Property(e => e.AyUcretsiz).HasColumnName("AY_UCRETSIZ");
            entity.Property(e => e.Blperskodu).HasColumnName("BLPERSKODU");
            entity.Property(e => e.DamgaVergisi).HasColumnName("DAMGA_VERGISI");
            entity.Property(e => e.GunAskerlik).HasColumnName("GUN_ASKERLIK");
            entity.Property(e => e.GunCalisma).HasColumnName("GUN_CALISMA");
            entity.Property(e => e.GunDevir).HasColumnName("GUN_DEVIR");
            entity.Property(e => e.GunRaporlu).HasColumnName("GUN_RAPORLU");
            entity.Property(e => e.GunToplam).HasColumnName("GUN_TOPLAM");
            entity.Property(e => e.GunUcretsiz).HasColumnName("GUN_UCRETSIZ");
            entity.Property(e => e.IsyeriAdi)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("ISYERI_ADI");
            entity.Property(e => e.IsyeriKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ISYERI_KODU");
            entity.Property(e => e.KidemTazminati).HasColumnName("KIDEM_TAZMINATI");
            entity.Property(e => e.NetOdenen).HasColumnName("NET_ODENEN");
            entity.Property(e => e.TplAylikucret).HasColumnName("TPL_AYLIKUCRET");
            entity.Property(e => e.TplEkgelirler).HasColumnName("TPL_EKGELIRLER");
            entity.Property(e => e.Ucreti).HasColumnName("UCRETI");
            entity.Property(e => e.YilAskerlik).HasColumnName("YIL_ASKERLIK");
            entity.Property(e => e.YilCalisma).HasColumnName("YIL_CALISMA");
            entity.Property(e => e.YilDevir).HasColumnName("YIL_DEVIR");
            entity.Property(e => e.YilRaporlu).HasColumnName("YIL_RAPORLU");
            entity.Property(e => e.YilToplam).HasColumnName("YIL_TOPLAM");
            entity.Property(e => e.YilUcretsiz).HasColumnName("YIL_UCRETSIZ");
            entity.Property(e => e.YillikEkgelir).HasColumnName("YILLIK_EKGELIR");
        });

        modelBuilder.Entity<KullaniciOzelrapor>(entity =>
        {
            entity.HasKey(e => e.Blkodu).HasName("PK__KULLANIC__24967F2612C52570");

            entity.ToTable("KULLANICI_OZELRAPOR");

            entity.Property(e => e.Blkodu)
                .ValueGeneratedNever()
                .HasColumnName("BLKODU");
            entity.Property(e => e.Dbindex).HasColumnName("DBINDEX");
            entity.Property(e => e.Degistiren)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DEGISTIREN");
            entity.Property(e => e.DegistirmeTarihi)
                .HasColumnType("datetime")
                .HasColumnName("DEGISTIRME_TARIHI");
            entity.Property(e => e.Griddblclick)
                .HasColumnType("text")
                .HasColumnName("GRIDDBLCLICK");
            entity.Property(e => e.Kaydeden)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KAYDEDEN");
            entity.Property(e => e.KayitTarihi)
                .HasColumnType("datetime")
                .HasColumnName("KAYIT_TARIHI");
            entity.Property(e => e.Oncalcfields)
                .HasColumnType("text")
                .HasColumnName("ONCALCFIELDS");
            entity.Property(e => e.Ongetcellparams)
                .HasColumnType("text")
                .HasColumnName("ONGETCELLPARAMS");
            entity.Property(e => e.Params)
                .HasColumnType("text")
                .HasColumnName("PARAMS");
            entity.Property(e => e.Paramstype)
                .HasColumnType("text")
                .HasColumnName("PARAMSTYPE");
            entity.Property(e => e.Prgkodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PRGKODU");
            entity.Property(e => e.Psscript).HasColumnName("PSSCRIPT");
            entity.Property(e => e.Raporadi)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("RAPORADI");
            entity.Property(e => e.Sql)
                .HasColumnType("text")
                .HasColumnName("SQL");
            entity.Property(e => e.Surum).HasColumnName("SURUM");
            entity.Property(e => e.Yetkiler)
                .HasColumnType("text")
                .HasColumnName("YETKILER");
        });

        modelBuilder.Entity<Kural>(entity =>
        {
            entity.HasKey(e => e.Blkodu).HasName("PK__KURAL__24967F26359A0D5D");

            entity.ToTable("KURAL");

            entity.HasIndex(e => e.Blmaskodu, "KURAL_BLMASKODU");

            entity.Property(e => e.Blkodu)
                .ValueGeneratedNever()
                .HasColumnName("BLKODU");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Blmaskodu).HasColumnName("BLMASKODU");
            entity.Property(e => e.Degistiren)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DEGISTIREN");
            entity.Property(e => e.DegistirmeTarihi)
                .HasColumnType("datetime")
                .HasColumnName("DEGISTIRME_TARIHI");
            entity.Property(e => e.Kaydeden)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KAYDEDEN");
            entity.Property(e => e.KayitTarihi)
                .HasColumnType("datetime")
                .HasColumnName("KAYIT_TARIHI");
            entity.Property(e => e.KisiSayisi).HasColumnName("KISI_SAYISI");
            entity.Property(e => e.Modul)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MODUL");
            entity.Property(e => e.Tanimi)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("TANIMI");
        });

        modelBuilder.Entity<KuralDetay>(entity =>
        {
            entity.HasKey(e => e.Blkodu).HasName("PK__KURAL_DE__24967F26CBFABC0D");

            entity.ToTable("KURAL_DETAY");

            entity.HasIndex(e => e.Blkrkodu, "KURAL_DETAY_BLKRKODU");

            entity.Property(e => e.Blkodu)
                .ValueGeneratedNever()
                .HasColumnName("BLKODU");
            entity.Property(e => e.Alandegeri1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ALANDEGERI1");
            entity.Property(e => e.Alandegeri2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ALANDEGERI2");
            entity.Property(e => e.Alandegeri3)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ALANDEGERI3");
            entity.Property(e => e.Alandegeri4)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ALANDEGERI4");
            entity.Property(e => e.Alandegeri5)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ALANDEGERI5");
            entity.Property(e => e.AndorBaglaci1)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ANDOR_BAGLACI1");
            entity.Property(e => e.AndorBaglaci2)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ANDOR_BAGLACI2");
            entity.Property(e => e.AndorBaglaci3)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ANDOR_BAGLACI3");
            entity.Property(e => e.AndorBaglaci4)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ANDOR_BAGLACI4");
            entity.Property(e => e.Blkrkodu).HasColumnName("BLKRKODU");
            entity.Property(e => e.Degistiren)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DEGISTIREN");
            entity.Property(e => e.DegistirmeTarihi)
                .HasColumnType("datetime")
                .HasColumnName("DEGISTIRME_TARIHI");
            entity.Property(e => e.FieldName1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("FIELD_NAME1");
            entity.Property(e => e.FieldName2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("FIELD_NAME2");
            entity.Property(e => e.FieldName3)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("FIELD_NAME3");
            entity.Property(e => e.FieldName4)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("FIELD_NAME4");
            entity.Property(e => e.FieldName5)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("FIELD_NAME5");
            entity.Property(e => e.Karsilastirma1)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("KARSILASTIRMA1");
            entity.Property(e => e.Karsilastirma2)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("KARSILASTIRMA2");
            entity.Property(e => e.Karsilastirma3)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("KARSILASTIRMA3");
            entity.Property(e => e.Karsilastirma4)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("KARSILASTIRMA4");
            entity.Property(e => e.Karsilastirma5)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("KARSILASTIRMA5");
            entity.Property(e => e.Kaydeden)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KAYDEDEN");
            entity.Property(e => e.KayitTarihi)
                .HasColumnType("datetime")
                .HasColumnName("KAYIT_TARIHI");
            entity.Property(e => e.Oncelik).HasColumnName("ONCELIK");
            entity.Property(e => e.PersKartindanAl1).HasColumnName("PERS_KARTINDAN_AL1");
            entity.Property(e => e.PersKartindanAl2).HasColumnName("PERS_KARTINDAN_AL2");
            entity.Property(e => e.PersKartindanAl3).HasColumnName("PERS_KARTINDAN_AL3");
            entity.Property(e => e.PersKartindanAl4).HasColumnName("PERS_KARTINDAN_AL4");
            entity.Property(e => e.PersKartindanAl5).HasColumnName("PERS_KARTINDAN_AL5");
        });

        modelBuilder.Entity<LangCustomize>(entity =>
        {
            entity.HasKey(e => e.Blkodu).HasName("PK__LANG_CUS__24967F262068372A");

            entity.ToTable("LANG_CUSTOMIZE");

            entity.Property(e => e.Blkodu)
                .ValueGeneratedNever()
                .HasColumnName("BLKODU");
            entity.Property(e => e.OrjText)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ORJ_TEXT");
            entity.Property(e => e.TrsText)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("TRS_TEXT");
        });

        modelBuilder.Entity<MailSmsLog>(entity =>
        {
            entity.HasKey(e => e.Blkodu).HasName("PK__MAIL_SMS__24967F264BDB7550");

            entity.ToTable("MAIL_SMS_LOG");

            entity.HasIndex(e => e.Blmaskodu, "MLSMLOG_BLMASKODU");

            entity.Property(e => e.Blkodu)
                .ValueGeneratedNever()
                .HasColumnName("BLKODU");
            entity.Property(e => e.AliciAdres)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasColumnName("ALICI_ADRES");
            entity.Property(e => e.Blmaskodu).HasColumnName("BLMASKODU");
            entity.Property(e => e.Blmaskodu2).HasColumnName("BLMASKODU2");
            entity.Property(e => e.GonderimTipi).HasColumnName("GONDERIM_TIPI");
            entity.Property(e => e.Kaydeden)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KAYDEDEN");
            entity.Property(e => e.Konu)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("KONU");
            entity.Property(e => e.Mesaj)
                .IsUnicode(false)
                .HasColumnName("MESAJ");
            entity.Property(e => e.Modul)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("MODUL");
            entity.Property(e => e.Modul2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MODUL2");
            entity.Property(e => e.Tarihi)
                .HasColumnType("datetime")
                .HasColumnName("TARIHI");
        });

        modelBuilder.Entity<Mazerettanim>(entity =>
        {
            entity.HasKey(e => e.Blkodu).HasName("PK__MAZERETT__24967F2638B6D53C");

            entity.ToTable("MAZERETTANIM");

            entity.HasIndex(e => e.Tanimi, "TANIMI_IND");

            entity.HasIndex(e => e.Tanimi, "UQ__MAZERETT__49C09A84E16AF6D9").IsUnique();

            entity.Property(e => e.Blkodu)
                .ValueGeneratedNever()
                .HasColumnName("BLKODU");
            entity.Property(e => e.Ekmesaiyuzde).HasColumnName("EKMESAIYUZDE");
            entity.Property(e => e.Fmvar).HasColumnName("FMVAR");
            entity.Property(e => e.Mazeretaciklama)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MAZERETACIKLAMA");
            entity.Property(e => e.Mesaiyuzde).HasColumnName("MESAIYUZDE");
            entity.Property(e => e.Puantajcetkodu)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("PUANTAJCETKODU");
            entity.Property(e => e.Tanimi)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TANIMI");
            entity.Property(e => e.Turu)
                .HasDefaultValueSql("((0))")
                .HasColumnName("TURU");
            entity.Property(e => e.Ucretli).HasColumnName("UCRETLI");
        });

        modelBuilder.Entity<Offline>(entity =>
        {
            entity.HasKey(e => e.Blkodu).HasName("PK__OFFLINE__24967F263A61B0DB");

            entity.ToTable("OFFLINE");

            entity.Property(e => e.Blkodu)
                .ValueGeneratedNever()
                .HasColumnName("BLKODU");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Emakineno).HasColumnName("EMAKINENO");
            entity.Property(e => e.Giriscikis).HasColumnName("GIRISCIKIS");
            entity.Property(e => e.Islendi).HasColumnName("ISLENDI");
            entity.Property(e => e.Kaynak).HasColumnName("KAYNAK");
            entity.Property(e => e.Makineno).HasColumnName("MAKINENO");
            entity.Property(e => e.MesaiBaslama)
                .HasColumnType("datetime")
                .HasColumnName("MESAI_BASLAMA");
            entity.Property(e => e.MesaiBitis)
                .HasColumnType("datetime")
                .HasColumnName("MESAI_BITIS");
            entity.Property(e => e.Personelno).HasColumnName("PERSONELNO");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
            entity.Property(e => e.Tip).HasColumnName("TIP");
            entity.Property(e => e.Verifymode).HasColumnName("VERIFYMODE");
        });

        modelBuilder.Entity<Ogi>(entity =>
        {
            entity.HasKey(e => e.Blkodu).HasName("PK__OGI__24967F26998AEED9");

            entity.ToTable("OGI");

            entity.Property(e => e.Blkodu)
                .ValueGeneratedNever()
                .HasColumnName("BLKODU");
            entity.Property(e => e.Ay1).HasColumnName("AY1");
            entity.Property(e => e.Ay2).HasColumnName("AY2");
            entity.Property(e => e.Ay3).HasColumnName("AY3");
            entity.Property(e => e.Ay4).HasColumnName("AY4");
            entity.Property(e => e.Ay5).HasColumnName("AY5");
            entity.Property(e => e.Ay6).HasColumnName("AY6");
            entity.Property(e => e.Blperskodu).HasColumnName("BLPERSKODU");
            entity.Property(e => e.FisToplami).HasColumnName("FIS_TOPLAMI");
            entity.Property(e => e.GecerliTutar).HasColumnName("GECERLI_TUTAR");
            entity.Property(e => e.GvMatrah).HasColumnName("GV_MATRAH");
            entity.Property(e => e.HesTutar).HasColumnName("HES_TUTAR");
            entity.Property(e => e.HesapYil).HasColumnName("HESAP_YIL");
            entity.Property(e => e.IsyeriAdi)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("ISYERI_ADI");
            entity.Property(e => e.IsyeriKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ISYERI_KODU");
            entity.Property(e => e.SonGlvr).HasColumnName("SON_GLVR");
        });

        modelBuilder.Entity<OtelDephaberHr>(entity =>
        {
            entity.HasKey(e => e.Blkodu).HasName("PK__OTEL_DEP__24967F2617962337");

            entity.ToTable("OTEL_DEPHABER_HR");

            entity.Property(e => e.Blkodu)
                .ValueGeneratedNever()
                .HasColumnName("BLKODU");
            entity.Property(e => e.Aktif).HasColumnName("AKTIF");
            entity.Property(e => e.Degistiren)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DEGISTIREN");
            entity.Property(e => e.DegistirmeTarihi)
                .HasColumnType("datetime")
                .HasColumnName("DEGISTIRME_TARIHI");
            entity.Property(e => e.Departman).HasColumnName("DEPARTMAN");
            entity.Property(e => e.Kaydeden)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KAYDEDEN");
            entity.Property(e => e.KayitTarihi)
                .HasColumnType("datetime")
                .HasColumnName("KAYIT_TARIHI");
            entity.Property(e => e.Mesaj)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("MESAJ");
            entity.Property(e => e.SubeKodu)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SUBE_KODU");
        });

        modelBuilder.Entity<OtelDephaberTanim>(entity =>
        {
            entity.HasKey(e => e.Blkodu).HasName("PK__OTEL_DEP__24967F26B53C0E95");

            entity.ToTable("OTEL_DEPHABER_TANIM");

            entity.Property(e => e.Blkodu)
                .ValueGeneratedNever()
                .HasColumnName("BLKODU");
            entity.Property(e => e.Blperkodu).HasColumnName("BLPERKODU");
            entity.Property(e => e.Departman)
                .IsUnicode(false)
                .HasColumnName("DEPARTMAN");
        });

        modelBuilder.Entity<OtelEnvanter>(entity =>
        {
            entity.HasKey(e => e.Blkodu).HasName("PK__OTEL_ENV__24967F261190AED6");

            entity.ToTable("OTEL_ENVANTER");

            entity.Property(e => e.Blkodu)
                .ValueGeneratedNever()
                .HasColumnName("BLKODU");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Adeti).HasColumnName("ADETI");
            entity.Property(e => e.Aktif).HasColumnName("AKTIF");
            entity.Property(e => e.Blbirimkodu).HasColumnName("BLBIRIMKODU");
            entity.Property(e => e.Blhesapkodu).HasColumnName("BLHESAPKODU");
            entity.Property(e => e.Blkategorikodu).HasColumnName("BLKATEGORIKODU");
            entity.Property(e => e.Degistiren)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DEGISTIREN");
            entity.Property(e => e.DegistirmeTarihi)
                .HasColumnType("datetime")
                .HasColumnName("DEGISTIRME_TARIHI");
            entity.Property(e => e.EnvanterAdi)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ENVANTER_ADI");
            entity.Property(e => e.HazirlanmaZamani).HasColumnName("HAZIRLANMA_ZAMANI");
            entity.Property(e => e.Kaydeden)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KAYDEDEN");
            entity.Property(e => e.KayitTarihi)
                .HasColumnType("datetime")
                .HasColumnName("KAYIT_TARIHI");
            entity.Property(e => e.RezervasyonEnvanter).HasColumnName("REZERVASYON_ENVANTER");
            entity.Property(e => e.SubeKodu)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SUBE_KODU");
            entity.Property(e => e.ToplanmaZamani).HasColumnName("TOPLANMA_ZAMANI");
        });

        modelBuilder.Entity<OtelEnvanterFiyat>(entity =>
        {
            entity.HasKey(e => e.Blkodu).HasName("PK__OTEL_ENV__24967F266B11A3B9");

            entity.ToTable("OTEL_ENVANTER_FIYAT");

            entity.Property(e => e.Blkodu)
                .ValueGeneratedNever()
                .HasColumnName("BLKODU");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Aktif).HasColumnName("AKTIF");
            entity.Property(e => e.BaslangicTarihi)
                .HasColumnType("datetime")
                .HasColumnName("BASLANGIC_TARIHI");
            entity.Property(e => e.BitisTarihi)
                .HasColumnType("datetime")
                .HasColumnName("BITIS_TARIHI");
            entity.Property(e => e.Blenvanterkodu).HasColumnName("BLENVANTERKODU");
            entity.Property(e => e.Blfiyatgrupkodu).HasColumnName("BLFIYATGRUPKODU");
            entity.Property(e => e.Fiyati).HasColumnName("FIYATI");
            entity.Property(e => e.SaatlikCalistir).HasColumnName("SAATLIK_CALISTIR");
        });

        modelBuilder.Entity<OtelEnvanterHareket>(entity =>
        {
            entity.HasKey(e => e.Blkodu).HasName("PK__OTEL_ENV__24967F26B2697DBA");

            entity.ToTable("OTEL_ENVANTER_HAREKET");

            entity.Property(e => e.Blkodu)
                .ValueGeneratedNever()
                .HasColumnName("BLKODU");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Adet).HasColumnName("ADET");
            entity.Property(e => e.BaslamaTarihi)
                .HasColumnType("datetime")
                .HasColumnName("BASLAMA_TARIHI");
            entity.Property(e => e.BitisTarihi)
                .HasColumnType("datetime")
                .HasColumnName("BITIS_TARIHI");
            entity.Property(e => e.Blenvanterkodu).HasColumnName("BLENVANTERKODU");
            entity.Property(e => e.Blhesapkodu).HasColumnName("BLHESAPKODU");
            entity.Property(e => e.EntegrasyonAdi)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ENTEGRASYON_ADI");
            entity.Property(e => e.EntegrasyonKodu).HasColumnName("ENTEGRASYON_KODU");
            entity.Property(e => e.Fiyati).HasColumnName("FIYATI");
            entity.Property(e => e.SaatlikCalistir).HasColumnName("SAATLIK_CALISTIR");
            entity.Property(e => e.Sabit).HasColumnName("SABIT");
        });

        modelBuilder.Entity<OtelEtkinlik>(entity =>
        {
            entity.HasKey(e => e.Blkodu).HasName("PK__OTEL_ETK__24967F2698726275");

            entity.ToTable("OTEL_ETKINLIK");

            entity.Property(e => e.Blkodu)
                .ValueGeneratedNever()
                .HasColumnName("BLKODU");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Aktif).HasColumnName("AKTIF");
            entity.Property(e => e.BanketAdiSoyadi)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("BANKET_ADI_SOYADI");
            entity.Property(e => e.BaslangicTarihi)
                .HasColumnType("datetime")
                .HasColumnName("BASLANGIC_TARIHI");
            entity.Property(e => e.BitisTarihi)
                .HasColumnType("datetime")
                .HasColumnName("BITIS_TARIHI");
            entity.Property(e => e.Blacentakodu).HasColumnName("BLACENTAKODU");
            entity.Property(e => e.Bletktipkodu).HasColumnName("BLETKTIPKODU");
            entity.Property(e => e.Blkaynakkodu).HasColumnName("BLKAYNAKKODU");
            entity.Property(e => e.Blkontakmuskodu).HasColumnName("BLKONTAKMUSKODU");
            entity.Property(e => e.Blmuskodu).HasColumnName("BLMUSKODU");
            entity.Property(e => e.BlpazarSgmkodu).HasColumnName("BLPAZAR_SGMKODU");
            entity.Property(e => e.Blperkodu).HasColumnName("BLPERKODU");
            entity.Property(e => e.Blstatuskodu).HasColumnName("BLSTATUSKODU");
            entity.Property(e => e.Degistiren)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DEGISTIREN");
            entity.Property(e => e.DegistirmeTarihi)
                .HasColumnType("datetime")
                .HasColumnName("DEGISTIRME_TARIHI");
            entity.Property(e => e.EtkinlikAdi)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ETKINLIK_ADI");
            entity.Property(e => e.EtkinlikTuru).HasColumnName("ETKINLIK_TURU");
            entity.Property(e => e.Hazir).HasColumnName("HAZIR");
            entity.Property(e => e.HesapKodu)
                .IsUnicode(false)
                .HasColumnName("HESAP_KODU");
            entity.Property(e => e.KatilimSayisi).HasColumnName("KATILIM_SAYISI");
            entity.Property(e => e.Kaydeden)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KAYDEDEN");
            entity.Property(e => e.KayitTarihi)
                .HasColumnType("datetime")
                .HasColumnName("KAYIT_TARIHI");
            entity.Property(e => e.KesinTarih)
                .HasColumnType("datetime")
                .HasColumnName("KESIN_TARIH");
            entity.Property(e => e.KontratNumarasi)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("KONTRAT_NUMARASI");
            entity.Property(e => e.KontratTarihi)
                .HasColumnType("datetime")
                .HasColumnName("KONTRAT_TARIHI");
            entity.Property(e => e.KontrolEdildi).HasColumnName("KONTROL_EDILDI");
            entity.Property(e => e.OpsiyonTarihi)
                .HasColumnType("datetime")
                .HasColumnName("OPSIYON_TARIHI");
            entity.Property(e => e.ParaBirimi)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("PARA_BIRIMI");
            entity.Property(e => e.SubeKodu)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SUBE_KODU");
            entity.Property(e => e.Tamamlandi).HasColumnName("TAMAMLANDI");
        });

        modelBuilder.Entity<OtelSalon>(entity =>
        {
            entity.HasKey(e => e.Blkodu).HasName("PK__OTEL_SAL__24967F2651D1D923");

            entity.ToTable("OTEL_SALON");

            entity.Property(e => e.Blkodu)
                .ValueGeneratedNever()
                .HasColumnName("BLKODU");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Aktif).HasColumnName("AKTIF");
            entity.Property(e => e.Blanasalonkodu).HasColumnName("BLANASALONKODU");
            entity.Property(e => e.Blhesapkodu).HasColumnName("BLHESAPKODU");
            entity.Property(e => e.Blkapasitekodu).HasColumnName("BLKAPASITEKODU");
            entity.Property(e => e.Blkullanimkodu).HasColumnName("BLKULLANIMKODU");
            entity.Property(e => e.BolunebilirSalon)
                .IsUnicode(false)
                .HasColumnName("BOLUNEBILIR_SALON");
            entity.Property(e => e.Degistiren)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DEGISTIREN");
            entity.Property(e => e.DegistirmeTarihi)
                .HasColumnType("datetime")
                .HasColumnName("DEGISTIRME_TARIHI");
            entity.Property(e => e.KapiMaxGenislik).HasColumnName("KAPI_MAX_GENISLIK");
            entity.Property(e => e.KapiMaxYukseklik).HasColumnName("KAPI_MAX_YUKSEKLIK");
            entity.Property(e => e.KapiMinGenislik).HasColumnName("KAPI_MIN_GENISLIK");
            entity.Property(e => e.KapiMinYukseklik).HasColumnName("KAPI_MIN_YUKSEKLIK");
            entity.Property(e => e.KapiSayisi).HasColumnName("KAPI_SAYISI");
            entity.Property(e => e.Kaydeden)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KAYDEDEN");
            entity.Property(e => e.KayitTarihi)
                .HasColumnType("datetime")
                .HasColumnName("KAYIT_TARIHI");
            entity.Property(e => e.MaxKapasite).HasColumnName("MAX_KAPASITE");
            entity.Property(e => e.MinKapasite).HasColumnName("MIN_KAPASITE");
            entity.Property(e => e.Paylasilabilir).HasColumnName("PAYLASILABILIR");
            entity.Property(e => e.SalonAdi)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SALON_ADI");
            entity.Property(e => e.SalonGenislik).HasColumnName("SALON_GENISLIK");
            entity.Property(e => e.SalonMaxYukseklik).HasColumnName("SALON_MAX_YUKSEKLIK");
            entity.Property(e => e.SalonMinYukseklik).HasColumnName("SALON_MIN_YUKSEKLIK");
            entity.Property(e => e.SalonToplamBuyukluk).HasColumnName("SALON_TOPLAM_BUYUKLUK");
            entity.Property(e => e.SalonUzunluk).HasColumnName("SALON_UZUNLUK");
            entity.Property(e => e.SubeKodu)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SUBE_KODU");
        });

        modelBuilder.Entity<OtelSalonBakim>(entity =>
        {
            entity.HasKey(e => e.Blkodu).HasName("PK__OTEL_SAL__24967F26D7320EA1");

            entity.ToTable("OTEL_SALON_BAKIM");

            entity.Property(e => e.Blkodu)
                .ValueGeneratedNever()
                .HasColumnName("BLKODU");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.BaslangicTarihi)
                .HasColumnType("datetime")
                .HasColumnName("BASLANGIC_TARIHI");
            entity.Property(e => e.BitisTarihi)
                .HasColumnType("datetime")
                .HasColumnName("BITIS_TARIHI");
            entity.Property(e => e.Blsalonkodu).HasColumnName("BLSALONKODU");
        });

        modelBuilder.Entity<OtelSalonDuzen>(entity =>
        {
            entity.HasKey(e => e.Blkodu).HasName("PK__OTEL_SAL__24967F266E7CDBDF");

            entity.ToTable("OTEL_SALON_DUZEN");

            entity.Property(e => e.Blkodu)
                .ValueGeneratedNever()
                .HasColumnName("BLKODU");
            entity.Property(e => e.Aktif).HasColumnName("AKTIF");
            entity.Property(e => e.Bloturmaduzenikodu).HasColumnName("BLOTURMADUZENIKODU");
            entity.Property(e => e.Blsalonkodu).HasColumnName("BLSALONKODU");
            entity.Property(e => e.HazirlanmaZamani).HasColumnName("HAZIRLANMA_ZAMANI");
            entity.Property(e => e.MaxKapasite).HasColumnName("MAX_KAPASITE");
            entity.Property(e => e.MinKapasite).HasColumnName("MIN_KAPASITE");
            entity.Property(e => e.ToplanmaZamani).HasColumnName("TOPLANMA_ZAMANI");
            entity.Property(e => e.Varsayilan).HasColumnName("VARSAYILAN");
        });

        modelBuilder.Entity<OtelSalonFiyat>(entity =>
        {
            entity.HasKey(e => e.Blkodu).HasName("PK__OTEL_SAL__24967F260041F01B");

            entity.ToTable("OTEL_SALON_FIYAT");

            entity.Property(e => e.Blkodu)
                .ValueGeneratedNever()
                .HasColumnName("BLKODU");
            entity.Property(e => e.Aktif).HasColumnName("AKTIF");
            entity.Property(e => e.BaslangicTarihi)
                .HasColumnType("datetime")
                .HasColumnName("BASLANGIC_TARIHI");
            entity.Property(e => e.BitisTarihi)
                .HasColumnType("datetime")
                .HasColumnName("BITIS_TARIHI");
            entity.Property(e => e.Blfiyatgrupkodu).HasColumnName("BLFIYATGRUPKODU");
            entity.Property(e => e.Blsalonkodu).HasColumnName("BLSALONKODU");
            entity.Property(e => e.Fiyati).HasColumnName("FIYATI");
            entity.Property(e => e.SaatlikCalistir).HasColumnName("SAATLIK_CALISTIR");
            entity.Property(e => e.Varsayilan).HasColumnName("VARSAYILAN");
        });

        modelBuilder.Entity<OtelSalonIletisim>(entity =>
        {
            entity.HasKey(e => e.Blkodu).HasName("PK__OTEL_SAL__24967F26596DD7D3");

            entity.ToTable("OTEL_SALON_ILETISIM");

            entity.Property(e => e.Blkodu)
                .ValueGeneratedNever()
                .HasColumnName("BLKODU");
            entity.Property(e => e.Bliletisimturukodu).HasColumnName("BLILETISIMTURUKODU");
            entity.Property(e => e.Blsalonkodu).HasColumnName("BLSALONKODU");
            entity.Property(e => e.Numara)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("NUMARA");
        });

        modelBuilder.Entity<OtelSalonhr>(entity =>
        {
            entity.HasKey(e => e.Blkodu).HasName("PK__OTEL_SAL__24967F26D3249BD1");

            entity.ToTable("OTEL_SALONHR");

            entity.Property(e => e.Blkodu)
                .ValueGeneratedNever()
                .HasColumnName("BLKODU");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.BaslamaTarihi)
                .HasColumnType("datetime")
                .HasColumnName("BASLAMA_TARIHI");
            entity.Property(e => e.BitisTarihi)
                .HasColumnType("datetime")
                .HasColumnName("BITIS_TARIHI");
            entity.Property(e => e.Bletkinlikkodu).HasColumnName("BLETKINLIKKODU");
            entity.Property(e => e.Blfiyatkodu).HasColumnName("BLFIYATKODU");
            entity.Property(e => e.Bloturmaduzeni).HasColumnName("BLOTURMADUZENI");
            entity.Property(e => e.Blsalonkodu).HasColumnName("BLSALONKODU");
            entity.Property(e => e.Fiyati).HasColumnName("FIYATI");
            entity.Property(e => e.SaatlikCalistir).HasColumnName("SAATLIK_CALISTIR");
        });

        modelBuilder.Entity<OtelSantralAyar>(entity =>
        {
            entity.HasKey(e => e.Blkodu).HasName("PK__OTEL_SAN__24967F26DA617E7D");

            entity.ToTable("OTEL_SANTRAL_AYAR");

            entity.Property(e => e.Blkodu)
                .ValueGeneratedNever()
                .HasColumnName("BLKODU");
            entity.Property(e => e.SantralAktif).HasColumnName("SANTRAL_AKTIF");
            entity.Property(e => e.SantralDatabase)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("SANTRAL_DATABASE");
            entity.Property(e => e.SantralDbUsername)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SANTRAL_DB_USERNAME");
            entity.Property(e => e.SantralDbUserpass)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SANTRAL_DB_USERPASS");
            entity.Property(e => e.SantralKontrol).HasColumnName("SANTRAL_KONTROL");
            entity.Property(e => e.SantralServer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SANTRAL_SERVER");
            entity.Property(e => e.SantralTur).HasColumnName("SANTRAL_TUR");
            entity.Property(e => e.SubeKodu)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SUBE_KODU");
        });

        modelBuilder.Entity<Ozelalangrup>(entity =>
        {
            entity.HasKey(e => e.Blkodu).HasName("PK__OZELALAN__24967F265C815578");

            entity.ToTable("OZELALANGRUP");

            entity.Property(e => e.Blkodu)
                .ValueGeneratedNever()
                .HasColumnName("BLKODU");
            entity.Property(e => e.Aktif).HasColumnName("AKTIF");
            entity.Property(e => e.Baslik)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("BASLIK");
            entity.Property(e => e.Modul)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("MODUL");
            entity.Property(e => e.Siralama).HasColumnName("SIRALAMA");
        });

        modelBuilder.Entity<Ozelalantanim>(entity =>
        {
            entity.HasKey(e => e.Blkodu).HasName("PK__OZELALAN__24967F26AB47931A");

            entity.ToTable("OZELALANTANIM");

            entity.Property(e => e.Blkodu)
                .ValueGeneratedNever()
                .HasColumnName("BLKODU");
            entity.Property(e => e.Aktif).HasColumnName("AKTIF");
            entity.Property(e => e.Baslik)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("BASLIK");
            entity.Property(e => e.Blgrupkodu).HasColumnName("BLGRUPKODU");
            entity.Property(e => e.ComboReadonly).HasColumnName("COMBO_READONLY");
            entity.Property(e => e.Displayformat)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DISPLAYFORMAT");
            entity.Property(e => e.Filtrelemeaktif).HasColumnName("FILTRELEMEAKTIF");
            entity.Property(e => e.Secenekler)
                .IsUnicode(false)
                .HasColumnName("SECENEKLER");
            entity.Property(e => e.Siralama).HasColumnName("SIRALAMA");
            entity.Property(e => e.Uzunluk).HasColumnName("UZUNLUK");
            entity.Property(e => e.Veritipi).HasColumnName("VERITIPI");
        });

        modelBuilder.Entity<PerGrup>(entity =>
        {
            entity.HasKey(e => e.Blkodu).HasName("PK__PER_GRUP__24967F26EEAD731E");

            entity.ToTable("PER_GRUP");

            entity.Property(e => e.Blkodu)
                .ValueGeneratedNever()
                .HasColumnName("BLKODU");
            entity.Property(e => e.Adi)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ADI");
            entity.Property(e => e.DamgaVergisi)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DAMGA_VERGISI");
            entity.Property(e => e.DmVrIstisnasi).HasColumnName("DM_VR_ISTISNASI");
            entity.Property(e => e.EkKesintiler)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("EK_KESINTILER");
            entity.Property(e => e.GelirVergisi)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("GELIR_VERGISI");
            entity.Property(e => e.GlVrIstisnasi).HasColumnName("GL_VR_ISTISNASI");
            entity.Property(e => e.IsciGensaglikOrani).HasColumnName("ISCI_GENSAGLIK_ORANI");
            entity.Property(e => e.IsciIssizlikOrani).HasColumnName("ISCI_ISSIZLIK_ORANI");
            entity.Property(e => e.IsciSgdpOrani).HasColumnName("ISCI_SGDP_ORANI");
            entity.Property(e => e.IsciYaslilikOrani).HasColumnName("ISCI_YASLILIK_ORANI");
            entity.Property(e => e.IssizlikPrimi)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ISSIZLIK_PRIMI");
            entity.Property(e => e.Isv5510indOrani).HasColumnName("ISV_5510IND_ORANI");
            entity.Property(e => e.IsvGensaglikOrani).HasColumnName("ISV_GENSAGLIK_ORANI");
            entity.Property(e => e.IsvIssizlikOrani).HasColumnName("ISV_ISSIZLIK_ORANI");
            entity.Property(e => e.IsvSgdpOrani).HasColumnName("ISV_SGDP_ORANI");
            entity.Property(e => e.IsvYaslilikOrani).HasColumnName("ISV_YASLILIK_ORANI");
            entity.Property(e => e.IsyeriKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ISYERI_KODU");
            entity.Property(e => e.KesDm).HasColumnName("KES_DM");
            entity.Property(e => e.KesGlvr).HasColumnName("KES_GLVR");
            entity.Property(e => e.KesIskazalari).HasColumnName("KES_ISKAZALARI");
            entity.Property(e => e.NetUcretler)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NET_UCRETLER");
            entity.Property(e => e.OdemeTurKodu)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("ODEME_TUR_KODU");
            entity.Property(e => e.Sgdp)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SGDP");
            entity.Property(e => e.SskPrimi)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SSK_PRIMI");
            entity.Property(e => e.Varsayilan).HasColumnName("VARSAYILAN");
        });

        modelBuilder.Entity<PerfDeger>(entity =>
        {
            entity.HasKey(e => e.Blkodu).HasName("PK__PERF_DEG__24967F264C7FB30F");

            entity.ToTable("PERF_DEGER");

            entity.HasIndex(e => e.Blpdtkodu, "PERF_DEGER_BLPDTKODU");

            entity.HasIndex(e => e.Blprkodu, "PERF_DEGER_BLPRKODU");

            entity.Property(e => e.Blkodu)
                .ValueGeneratedNever()
                .HasColumnName("BLKODU");
            entity.Property(e => e.AstperBlkodu)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("ASTPER_BLKODU");
            entity.Property(e => e.AstperMax).HasColumnName("ASTPER_MAX");
            entity.Property(e => e.AstperMin).HasColumnName("ASTPER_MIN");
            entity.Property(e => e.AstperSayisi).HasColumnName("ASTPER_SAYISI");
            entity.Property(e => e.BilgimetniOnay).HasColumnName("BILGIMETNI_ONAY");
            entity.Property(e => e.Blpdtkodu).HasColumnName("BLPDTKODU");
            entity.Property(e => e.Blprkodu).HasColumnName("BLPRKODU");
            entity.Property(e => e.Degerlendir).HasColumnName("DEGERLENDIR");
            entity.Property(e => e.DigerperBlkodu)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("DIGERPER_BLKODU");
            entity.Property(e => e.DigerperMax).HasColumnName("DIGERPER_MAX");
            entity.Property(e => e.DigerperMin).HasColumnName("DIGERPER_MIN");
            entity.Property(e => e.DigerperSayisi).HasColumnName("DIGERPER_SAYISI");
            entity.Property(e => e.Kendisi).HasColumnName("KENDISI");
            entity.Property(e => e.KuralBlkodu)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("KURAL_BLKODU");
            entity.Property(e => e.KuralKisisayisi).HasColumnName("KURAL_KISISAYISI");
            entity.Property(e => e.PuanlamaYapildi).HasColumnName("PUANLAMA_YAPILDI");
            entity.Property(e => e.SecimYapildi).HasColumnName("SECIM_YAPILDI");
            entity.Property(e => e.Sirano).HasColumnName("SIRANO");
            entity.Property(e => e.UstperBlkodu)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("USTPER_BLKODU");
            entity.Property(e => e.UstperMax).HasColumnName("USTPER_MAX");
            entity.Property(e => e.UstperMin).HasColumnName("USTPER_MIN");
            entity.Property(e => e.UstperSayisi).HasColumnName("USTPER_SAYISI");
            entity.Property(e => e.YetkinlikPuani).HasColumnName("YETKINLIK_PUANI");
        });

        modelBuilder.Entity<PerfDegerPuanAgirligi>(entity =>
        {
            entity.HasKey(e => e.Blkodu).HasName("PK__PERF_DEG__24967F26B73A9404");

            entity.ToTable("PERF_DEGER_PUAN_AGIRLIGI");

            entity.HasIndex(e => e.Blkrkodu, "PD_PUAN_AGIRLIGI_BLKRKODU");

            entity.HasIndex(e => e.Blpdtkodu, "PD_PUAN_AGIRLIGI_BLPDTKODU");

            entity.Property(e => e.Blkodu)
                .ValueGeneratedNever()
                .HasColumnName("BLKODU");
            entity.Property(e => e.Alandegeri1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ALANDEGERI1");
            entity.Property(e => e.Alandegeri2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ALANDEGERI2");
            entity.Property(e => e.Alandegeri3)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ALANDEGERI3");
            entity.Property(e => e.AndorBaglaci1)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ANDOR_BAGLACI1");
            entity.Property(e => e.AndorBaglaci2)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ANDOR_BAGLACI2");
            entity.Property(e => e.Blkrkodu).HasColumnName("BLKRKODU");
            entity.Property(e => e.Blpdtkodu).HasColumnName("BLPDTKODU");
            entity.Property(e => e.Degistiren)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DEGISTIREN");
            entity.Property(e => e.DegistirmeTarihi)
                .HasColumnType("datetime")
                .HasColumnName("DEGISTIRME_TARIHI");
            entity.Property(e => e.EtkiYuzdesi).HasColumnName("ETKI_YUZDESI");
            entity.Property(e => e.FieldName1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("FIELD_NAME1");
            entity.Property(e => e.FieldName2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("FIELD_NAME2");
            entity.Property(e => e.FieldName3)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("FIELD_NAME3");
            entity.Property(e => e.Karsilastirma1)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("KARSILASTIRMA1");
            entity.Property(e => e.Karsilastirma2)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("KARSILASTIRMA2");
            entity.Property(e => e.Karsilastirma3)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("KARSILASTIRMA3");
            entity.Property(e => e.Kaydeden)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KAYDEDEN");
            entity.Property(e => e.KayitTarihi)
                .HasColumnType("datetime")
                .HasColumnName("KAYIT_TARIHI");
            entity.Property(e => e.Oncelik).HasColumnName("ONCELIK");
            entity.Property(e => e.PersKartindanAl1).HasColumnName("PERS_KARTINDAN_AL1");
            entity.Property(e => e.PersKartindanAl2).HasColumnName("PERS_KARTINDAN_AL2");
            entity.Property(e => e.PersKartindanAl3).HasColumnName("PERS_KARTINDAN_AL3");
        });

        modelBuilder.Entity<PerfDegerPuanEtkiyuzdesi>(entity =>
        {
            entity.HasKey(e => e.Blkodu).HasName("PK__PERF_DEG__24967F2644CBB8B4");

            entity.ToTable("PERF_DEGER_PUAN_ETKIYUZDESI");

            entity.HasIndex(e => e.Blpdtkodu, "PD_PE_BLPDTKODU");

            entity.HasIndex(e => e.BlpdPuanalanKodu, "PD_PE_BLPD_PUANALAN_KODU");

            entity.HasIndex(e => e.BlprPuanverenKodu, "PD_PE_BLPR_PUANVEREN_KODU");

            entity.Property(e => e.Blkodu)
                .ValueGeneratedNever()
                .HasColumnName("BLKODU");
            entity.Property(e => e.BlpdPuanalanKodu).HasColumnName("BLPD_PUANALAN_KODU");
            entity.Property(e => e.Blpdtkodu).HasColumnName("BLPDTKODU");
            entity.Property(e => e.BlprPuanverenKodu).HasColumnName("BLPR_PUANVEREN_KODU");
            entity.Property(e => e.EtkiYuzdesi).HasColumnName("ETKI_YUZDESI");
        });

        modelBuilder.Entity<PerfDegerPuanlama>(entity =>
        {
            entity.HasKey(e => e.Blkodu).HasName("PK__PERF_DEG__24967F2646D8474F");

            entity.ToTable("PERF_DEGER_PUANLAMA");

            entity.HasIndex(e => e.Blpdtkodu, "PD_PUANLAMA_BLPDTKODU");

            entity.HasIndex(e => e.BlpdPuanalanKodu, "PD_PUANLAMA_BLPD_PUANALAN_KODU");

            entity.HasIndex(e => e.BlprPuanverenKodu, "PD_PUANLAMA_BLPR_PUANVEREN_KODU");

            entity.HasIndex(e => e.Blsrdtkodu, "PD_PUANLAMA_BLSRDTKODU");

            entity.HasIndex(e => e.Blsrkodu, "PD_PUANLAMA_BLSRKODU");

            entity.Property(e => e.Blkodu)
                .ValueGeneratedNever()
                .HasColumnName("BLKODU");
            entity.Property(e => e.BlpdPuanalanKodu).HasColumnName("BLPD_PUANALAN_KODU");
            entity.Property(e => e.Blpdtkodu).HasColumnName("BLPDTKODU");
            entity.Property(e => e.BlprPuanverenKodu).HasColumnName("BLPR_PUANVEREN_KODU");
            entity.Property(e => e.Blsrdtkodu).HasColumnName("BLSRDTKODU");
            entity.Property(e => e.Blsrkodu).HasColumnName("BLSRKODU");
            entity.Property(e => e.Puan).HasColumnName("PUAN");
        });

        modelBuilder.Entity<PerfDegerSoru>(entity =>
        {
            entity.HasKey(e => e.Blkodu).HasName("PK__PERF_DEG__24967F26653C35B3");

            entity.ToTable("PERF_DEGER_SORU");

            entity.HasIndex(e => e.Blkrkodu, "PERF_DEGER_SORU_BLKRKODU");

            entity.HasIndex(e => e.Blpdtkodu, "PERF_DEGER_SORU_BLPDTKODU");

            entity.Property(e => e.Blkodu)
                .ValueGeneratedNever()
                .HasColumnName("BLKODU");
            entity.Property(e => e.Baslik)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("BASLIK");
            entity.Property(e => e.Blkrkodu).HasColumnName("BLKRKODU");
            entity.Property(e => e.Blpdtkodu).HasColumnName("BLPDTKODU");
            entity.Property(e => e.Degistiren)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DEGISTIREN");
            entity.Property(e => e.DegistirmeTarihi)
                .HasColumnType("datetime")
                .HasColumnName("DEGISTIRME_TARIHI");
            entity.Property(e => e.EtkiYuzdesi).HasColumnName("ETKI_YUZDESI");
            entity.Property(e => e.Kaydeden)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KAYDEDEN");
            entity.Property(e => e.KayitTarihi)
                .HasColumnType("datetime")
                .HasColumnName("KAYIT_TARIHI");
            entity.Property(e => e.Sirano).HasColumnName("SIRANO");
        });

        modelBuilder.Entity<PerfDegerSoruDetay>(entity =>
        {
            entity.HasKey(e => e.Blkodu).HasName("PK__PERF_DEG__24967F26899B6224");

            entity.ToTable("PERF_DEGER_SORU_DETAY");

            entity.HasIndex(e => e.Blsrkodu, "PERF_DEGER_SORU_DETAY_BLSRKODU");

            entity.Property(e => e.Blkodu)
                .ValueGeneratedNever()
                .HasColumnName("BLKODU");
            entity.Property(e => e.Blsrkodu).HasColumnName("BLSRKODU");
            entity.Property(e => e.Degistiren)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DEGISTIREN");
            entity.Property(e => e.DegistirmeTarihi)
                .HasColumnType("datetime")
                .HasColumnName("DEGISTIRME_TARIHI");
            entity.Property(e => e.Durumu).HasColumnName("DURUMU");
            entity.Property(e => e.Kaydeden)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KAYDEDEN");
            entity.Property(e => e.KayitTarihi)
                .HasColumnType("datetime")
                .HasColumnName("KAYIT_TARIHI");
            entity.Property(e => e.Sirano).HasColumnName("SIRANO");
            entity.Property(e => e.Soru)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("SORU");
        });

        modelBuilder.Entity<PerfDegerTanimi>(entity =>
        {
            entity.HasKey(e => e.Blkodu).HasName("PK__PERF_DEG__24967F26EFCFCDDF");

            entity.ToTable("PERF_DEGER_TANIMI");

            entity.Property(e => e.Blkodu)
                .ValueGeneratedNever()
                .HasColumnName("BLKODU");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.AgirlikliPuan).HasColumnName("AGIRLIKLI_PUAN");
            entity.Property(e => e.AgirlikliPuanKullan).HasColumnName("AGIRLIKLI_PUAN_KULLAN");
            entity.Property(e => e.Asti).HasColumnName("ASTI");
            entity.Property(e => e.AstiMax).HasColumnName("ASTI_MAX");
            entity.Property(e => e.AstiMin).HasColumnName("ASTI_MIN");
            entity.Property(e => e.BaslamaTarihi)
                .HasColumnType("datetime")
                .HasColumnName("BASLAMA_TARIHI");
            entity.Property(e => e.Baslik)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("BASLIK");
            entity.Property(e => e.BilgimetniBlob)
                .IsUnicode(false)
                .HasColumnName("BILGIMETNI_BLOB");
            entity.Property(e => e.BitisTarihi)
                .HasColumnType("datetime")
                .HasColumnName("BITIS_TARIHI");
            entity.Property(e => e.Degistiren)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DEGISTIREN");
            entity.Property(e => e.DegistirmeTarihi)
                .HasColumnType("datetime")
                .HasColumnName("DEGISTIRME_TARIHI");
            entity.Property(e => e.Diger).HasColumnName("DIGER");
            entity.Property(e => e.DigerMax).HasColumnName("DIGER_MAX");
            entity.Property(e => e.DigerMin).HasColumnName("DIGER_MIN");
            entity.Property(e => e.Durumu).HasColumnName("DURUMU");
            entity.Property(e => e.IsyeriKodu)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("ISYERI_KODU");
            entity.Property(e => e.Kaydeden)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KAYDEDEN");
            entity.Property(e => e.KayitTarihi)
                .HasColumnType("datetime")
                .HasColumnName("KAYIT_TARIHI");
            entity.Property(e => e.Kendisi).HasColumnName("KENDISI");
            entity.Property(e => e.PuanMax).HasColumnName("PUAN_MAX");
            entity.Property(e => e.PuanMin).HasColumnName("PUAN_MIN");
            entity.Property(e => e.Sorumlusu).HasColumnName("SORUMLUSU");
            entity.Property(e => e.Ustu).HasColumnName("USTU");
            entity.Property(e => e.UstuMax).HasColumnName("USTU_MAX");
            entity.Property(e => e.UstuMin).HasColumnName("USTU_MIN");
        });

        modelBuilder.Entity<Personel>(entity =>
        {
            entity.HasKey(e => e.Blkodu).HasName("PK__PERSONEL__24967F2639A2EEFF");

            entity.ToTable("PERSONEL");

            entity.HasIndex(e => e.Adi, "ADI_IND");

            entity.HasIndex(e => e.Calismaplani, "CALISMAPLANI_IND");

            entity.HasIndex(e => e.DeprKodu, "DERPKODU_IND");

            entity.HasIndex(e => e.IsyeriKodu, "ISYERIKODU_IND");

            entity.HasIndex(e => e.CikisTarihi, "PRS_CIKIS_TARIHI");

            entity.HasIndex(e => e.OrgBasamak1, "PRS_ORG_BASAMAK1");

            entity.HasIndex(e => e.Soyadi, "SOYADI_IND");

            entity.HasIndex(e => e.Kodu, "UQ__PERSONEL__BF69F8F6A3B40118").IsUnique();

            entity.Property(e => e.Blkodu)
                .ValueGeneratedNever()
                .HasColumnName("BLKODU");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Aciladsoyad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ACILADSOYAD");
            entity.Property(e => e.Acililetisim)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ACILILETISIM");
            entity.Property(e => e.Acilyakinlik)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ACILYAKINLIK");
            entity.Property(e => e.Adi)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ADI");
            entity.Property(e => e.Adres1)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("ADRES1");
            entity.Property(e => e.Adres2)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("ADRES2");
            entity.Property(e => e.AgiCocukSayisi).HasColumnName("AGI_COCUK_SAYISI");
            entity.Property(e => e.AgiUygula).HasColumnName("AGI_UYGULA");
            entity.Property(e => e.AileSno)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("AILE_SNO");
            entity.Property(e => e.AltGrubu)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ALT_GRUBU");
            entity.Property(e => e.AltGrubuKodu)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ALT_GRUBU_KODU");
            entity.Property(e => e.AnaAdi)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ANA_ADI");
            entity.Property(e => e.AnalikSoyadi)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ANALIK_SOYADI");
            entity.Property(e => e.AraGrubu)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ARA_GRUBU");
            entity.Property(e => e.AraGrubuKodu)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ARA_GRUBU_KODU");
            entity.Property(e => e.AsgariUcret).HasColumnName("ASGARI_UCRET");
            entity.Property(e => e.AskerlikBorctutari).HasColumnName("ASKERLIK_BORCTUTARI");
            entity.Property(e => e.AskerlikDurumu).HasColumnName("ASKERLIK_DURUMU");
            entity.Property(e => e.Ayakkabino)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("AYAKKABINO");
            entity.Property(e => e.BabaAdi)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("BABA_ADI");
            entity.Property(e => e.BagkurAylik).HasColumnName("BAGKUR_AYLIK");
            entity.Property(e => e.BakYukumlu1Adi)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("BAK_YUKUMLU_1_ADI");
            entity.Property(e => e.BakYukumlu1Ykn)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("BAK_YUKUMLU_1_YKN");
            entity.Property(e => e.BakYukumlu2Adi)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("BAK_YUKUMLU_2_ADI");
            entity.Property(e => e.BakYukumlu2Ykn)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("BAK_YUKUMLU_2_YKN");
            entity.Property(e => e.Banka)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("BANKA");
            entity.Property(e => e.Beden)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("BEDEN");
            entity.Property(e => e.BedenOzellik)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("BEDEN_OZELLIK");
            entity.Property(e => e.BelgeTuru)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("BELGE_TURU");
            entity.Property(e => e.BelgeTuru2)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("BELGE_TURU2");
            entity.Property(e => e.BireyselEmkSigortasi).HasColumnName("BIREYSEL_EMK_SIGORTASI");
            entity.Property(e => e.Blbasvurukodu).HasColumnName("BLBASVURUKODU");
            entity.Property(e => e.Blcrkodu).HasColumnName("BLCRKODU");
            entity.Property(e => e.BrDevredenYilizin).HasColumnName("BR_DEVREDEN_YILIZIN");
            entity.Property(e => e.Bulvar)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("BULVAR");
            entity.Property(e => e.Cadde)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CADDE");
            entity.Property(e => e.Cagriyeri).HasColumnName("CAGRIYERI");
            entity.Property(e => e.Calismaplani)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("CALISMAPLANI");
            entity.Property(e => e.CalistigiSure).HasColumnName("CALISTIGI_SURE");
            entity.Property(e => e.CepTel)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CEP_TEL");
            entity.Property(e => e.CikisNedeni)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CIKIS_NEDENI");
            entity.Property(e => e.CikisNedeniSsk)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("CIKIS_NEDENI_SSK");
            entity.Property(e => e.CikisTarihi)
                .HasColumnType("datetime")
                .HasColumnName("CIKIS_TARIHI");
            entity.Property(e => e.CiltNo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("CILT_NO");
            entity.Property(e => e.Cinsiyeti).HasColumnName("CINSIYETI");
            entity.Property(e => e.CocukYard).HasColumnName("COCUK_YARD");
            entity.Property(e => e.Degistiren)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DEGISTIREN");
            entity.Property(e => e.DegistirmeTarihi)
                .HasColumnType("datetime")
                .HasColumnName("DEGISTIRME_TARIHI");
            entity.Property(e => e.DeprAdi)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DEPR_ADI");
            entity.Property(e => e.DeprKodu)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("DEPR_KODU");
            entity.Property(e => e.DevrGvMatrahi).HasColumnName("DEVR_GV_MATRAHI");
            entity.Property(e => e.DevrGvTutari).HasColumnName("DEVR_GV_TUTARI");
            entity.Property(e => e.Devredenizin).HasColumnName("DEVREDENIZIN");
            entity.Property(e => e.DigerAylik).HasColumnName("DIGER_AYLIK");
            entity.Property(e => e.DigerSig)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("DIGER_SIG");
            entity.Property(e => e.DigerSigNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DIGER_SIG_NO");
            entity.Property(e => e.DisKapi)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("DIS_KAPI");
            entity.Property(e => e.DogTarihi)
                .HasColumnType("datetime")
                .HasColumnName("DOG_TARIHI");
            entity.Property(e => e.DogYeri)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("DOG_YERI");
            entity.Property(e => e.EMail)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("E_MAIL");
            entity.Property(e => e.EMail2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("E_MAIL2");
            entity.Property(e => e.EgitimSureci)
                .HasColumnType("datetime")
                .HasColumnName("EGITIM_SURECI");
            entity.Property(e => e.EgitimSureci2)
                .HasColumnType("datetime")
                .HasColumnName("EGITIM_SURECI_2");
            entity.Property(e => e.EgitimSurecinde).HasColumnName("EGITIM_SURECINDE");
            entity.Property(e => e.EhliyetSinif)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("EHLIYET_SINIF");
            entity.Property(e => e.EhliyetVar).HasColumnName("EHLIYET_VAR");
            entity.Property(e => e.Ehliyettecrube).HasColumnName("EHLIYETTECRUBE");
            entity.Property(e => e.EngellilikOrani).HasColumnName("ENGELLILIK_ORANI");
            entity.Property(e => e.EsAdi)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ES_ADI");
            entity.Property(e => e.EsAdres)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ES_ADRES");
            entity.Property(e => e.EsAgiUygula).HasColumnName("ES_AGI_UYGULA");
            entity.Property(e => e.EsBilgi)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ES_BILGI");
            entity.Property(e => e.EsCeptel)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ES_CEPTEL");
            entity.Property(e => e.EsDogtar)
                .HasColumnType("datetime")
                .HasColumnName("ES_DOGTAR");
            entity.Property(e => e.EsDogyeri)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ES_DOGYERI");
            entity.Property(e => e.EsEvtel)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ES_EVTEL");
            entity.Property(e => e.EsGelirAciklama)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("ES_GELIR_ACIKLAMA");
            entity.Property(e => e.EsGelirdurumu).HasColumnName("ES_GELIRDURUMU");
            entity.Property(e => e.EsIsdurumu).HasColumnName("ES_ISDURUMU");
            entity.Property(e => e.EsPkodu)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ES_PKODU");
            entity.Property(e => e.EsTckimlik)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("ES_TCKIMLIK");
            entity.Property(e => e.EsUyrugu)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ES_UYRUGU");
            entity.Property(e => e.EskiBagkurNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ESKI_BAGKUR_NO");
            entity.Property(e => e.EskiEmNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ESKI_EM_NO");
            entity.Property(e => e.EskiFirma)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ESKI_FIRMA");
            entity.Property(e => e.EskiFrAdres)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("ESKI_FR_ADRES");
            entity.Property(e => e.EskiFrIl)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ESKI_FR_IL");
            entity.Property(e => e.EskiFrIlce)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ESKI_FR_ILCE");
            entity.Property(e => e.EskiFrTel)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ESKI_FR_TEL");
            entity.Property(e => e.EskiFrYetkili)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ESKI_FR_YETKILI");
            entity.Property(e => e.GirisTarihi)
                .HasColumnType("datetime")
                .HasColumnName("GIRIS_TARIHI");
            entity.Property(e => e.GirisTarihiIk)
                .HasColumnType("datetime")
                .HasColumnName("GIRIS_TARIHI_IK");
            entity.Property(e => e.Giriskartno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("GIRISKARTNO");
            entity.Property(e => e.Gocmen).HasColumnName("GOCMEN");
            entity.Property(e => e.GorevKodu).HasColumnName("GOREV_KODU");
            entity.Property(e => e.Gorevi)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("GOREVI");
            entity.Property(e => e.GrDurumu).HasColumnName("GR_DURUMU");
            entity.Property(e => e.Grubu)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GRUBU");
            entity.Property(e => e.GrubuKodu)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GRUBU_KODU");
            entity.Property(e => e.GvIndirimOrani).HasColumnName("GV_INDIRIM_ORANI");
            entity.Property(e => e.HesapTipi).HasColumnName("HESAP_TIPI");
            entity.Property(e => e.Hesapno)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("HESAPNO");
            entity.Property(e => e.IbanNo)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("IBAN_NO");
            entity.Property(e => e.IcKapi)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("IC_KAPI");
            entity.Property(e => e.Il)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("IL");
            entity.Property(e => e.Ilce)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("ILCE");
            entity.Property(e => e.IskanunuMd).HasColumnName("ISKANUNU_MD");
            entity.Property(e => e.IstenCikisSsk2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ISTEN_CIKIS_SSK2");
            entity.Property(e => e.IstihdamDrm)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ISTIHDAM_DRM");
            entity.Property(e => e.IsyeriAdi)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("ISYERI_ADI");
            entity.Property(e => e.IsyeriKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ISYERI_KODU");
            entity.Property(e => e.KanGrubu)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("KAN_GRUBU");
            entity.Property(e => e.KanunNo)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("KANUN_NO");
            entity.Property(e => e.Kaydeden)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KAYDEDEN");
            entity.Property(e => e.KayitliIl)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("KAYITLI_IL");
            entity.Property(e => e.KayitliIlce)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("KAYITLI_ILCE");
            entity.Property(e => e.Kayittarihi)
                .HasColumnType("datetime")
                .HasColumnName("KAYITTARIHI");
            entity.Property(e => e.KidemTarihi)
                .HasColumnType("datetime")
                .HasColumnName("KIDEM_TARIHI");
            entity.Property(e => e.KimlikSeri)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("KIMLIK_SERI");
            entity.Property(e => e.Kodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KODU");
            entity.Property(e => e.Koy)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KOY");
            entity.Property(e => e.Kullaniciadi)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KULLANICIADI");
            entity.Property(e => e.Kullanicisifre)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("KULLANICISIFRE");
            entity.Property(e => e.KullanicisifreDurumu).HasColumnName("KULLANICISIFRE_DURUMU");
            entity.Property(e => e.MahKoy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MAH_KOY");
            entity.Property(e => e.MahSemt)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MAH_SEMT");
            entity.Property(e => e.MedeniDrm).HasColumnName("MEDENI_DRM");
            entity.Property(e => e.Mesaj)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("MESAJ");
            entity.Property(e => e.Meslegi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MESLEGI");
            entity.Property(e => e.MuhKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MUH_KODU");
            entity.Property(e => e.OgrenimDurumuSonrasi).HasColumnName("OGRENIM_DURUMU_SONRASI");
            entity.Property(e => e.OrgBasamak1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ORG_BASAMAK1");
            entity.Property(e => e.OrgBasamak1Kodu)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ORG_BASAMAK1_KODU");
            entity.Property(e => e.OrgBasamak2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ORG_BASAMAK2");
            entity.Property(e => e.OrgBasamak2Kodu)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ORG_BASAMAK2_KODU");
            entity.Property(e => e.OrgBasamak3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ORG_BASAMAK3");
            entity.Property(e => e.OrgBasamak3Kodu)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ORG_BASAMAK3_KODU");
            entity.Property(e => e.OrgBasamak4)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ORG_BASAMAK4");
            entity.Property(e => e.OrgBasamak4Kodu)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ORG_BASAMAK4_KODU");
            entity.Property(e => e.OrtGelmedigiGun).HasColumnName("ORT_GELMEDIGI_GUN");
            entity.Property(e => e.OtmBesFirma)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("OTM_BES_FIRMA");
            entity.Property(e => e.OtmBesKatilim).HasColumnName("OTM_BES_KATILIM");
            entity.Property(e => e.OtmBesOrani).HasColumnName("OTM_BES_ORANI");
            entity.Property(e => e.OtmBesTutari).HasColumnName("OTM_BES_TUTARI");
            entity.Property(e => e.OzelKodu1)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("OZEL_KODU1");
            entity.Property(e => e.OzelKodu2)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("OZEL_KODU2");
            entity.Property(e => e.OzelKodu3)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("OZEL_KODU3");
            entity.Property(e => e.OzelKodu4)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("OZEL_KODU4");
            entity.Property(e => e.OzelSig)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("OZEL_SIG");
            entity.Property(e => e.OzelSigNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("OZEL_SIG_NO");
            entity.Property(e => e.OzelSigTipi)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("OZEL_SIG_TIPI");
            entity.Property(e => e.OzelSigTrh)
                .HasColumnType("datetime")
                .HasColumnName("OZEL_SIG_TRH");
            entity.Property(e => e.OzelSigTutari).HasColumnName("OZEL_SIG_TUTARI");
            entity.Property(e => e.PerfDegerHaricTut).HasColumnName("PERF_DEGER_HARIC_TUT");
            entity.Property(e => e.PostaKodu)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("POSTA_KODU");
            entity.Property(e => e.PrimIadeliOzelSigTutari).HasColumnName("PRIM_IADELI_OZEL_SIG_TUTARI");
            entity.Property(e => e.ProjeBaslamaTarihi)
                .HasColumnType("datetime")
                .HasColumnName("PROJE_BASLAMA_TARIHI");
            entity.Property(e => e.ProjeCalisanTuru)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("PROJE_CALISAN_TURU");
            entity.Property(e => e.ProjeKodu)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PROJE_KODU");
            entity.Property(e => e.Ptkesintiyok).HasColumnName("PTKESINTIYOK");
            entity.Property(e => e.Ptsaatucretli).HasColumnName("PTSAATUCRETLI");
            entity.Property(e => e.ResimMd5)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RESIM_MD5");
            entity.Property(e => e.Sakatlik).HasColumnName("SAKATLIK");
            entity.Property(e => e.SandikAdi)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SANDIK_ADI");
            entity.Property(e => e.SandikNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SANDIK_NO");
            entity.Property(e => e.SendikaAdi)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SENDIKA_ADI");
            entity.Property(e => e.SendikaDrm)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SENDIKA_DRM");
            entity.Property(e => e.SendikaScno)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SENDIKA_SCNO");
            entity.Property(e => e.Servisduragi)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SERVISDURAGI");
            entity.Property(e => e.Servisgrubu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SERVISGRUBU");
            entity.Property(e => e.SgkAskerlikBastar)
                .HasColumnType("datetime")
                .HasColumnName("SGK_ASKERLIK_BASTAR");
            entity.Property(e => e.SgkAskerlikBittar)
                .HasColumnType("datetime")
                .HasColumnName("SGK_ASKERLIK_BITTAR");
            entity.Property(e => e.SgkAskerlikDrm).HasColumnName("SGK_ASKERLIK_DRM");
            entity.Property(e => e.SgkIstisnaidurum).HasColumnName("SGK_ISTISNAIDURUM");
            entity.Property(e => e.SigGrubu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SIG_GRUBU");
            entity.Property(e => e.SiraNo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("SIRA_NO");
            entity.Property(e => e.Sokak)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SOKAK");
            entity.Property(e => e.SosguvKodu).HasColumnName("SOSGUV_KODU");
            entity.Property(e => e.Soyadi)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SOYADI");
            entity.Property(e => e.SskMeslekAck)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SSK_MESLEK_ACK");
            entity.Property(e => e.SskMeslekKodu)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SSK_MESLEK_KODU");
            entity.Property(e => e.SskNo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SSK_NO");
            entity.Property(e => e.SskTarihi)
                .HasColumnType("datetime")
                .HasColumnName("SSK_TARIHI");
            entity.Property(e => e.TahakkukNedeni)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("TAHAKKUK_NEDENI");
            entity.Property(e => e.TahsilBolum)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TAHSIL_BOLUM");
            entity.Property(e => e.TahsilNot)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("TAHSIL_NOT");
            entity.Property(e => e.TahsilOkul)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TAHSIL_OKUL");
            entity.Property(e => e.TahsilTarihi)
                .HasColumnType("datetime")
                .HasColumnName("TAHSIL_TARIHI");
            entity.Property(e => e.Tahsili)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TAHSILI");
            entity.Property(e => e.Tahsili2).HasColumnName("TAHSILI_2");
            entity.Property(e => e.TcEmAylik).HasColumnName("TC_EM_AYLIK");
            entity.Property(e => e.TcNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TC_NO");
            entity.Property(e => e.TcmbVizeTarihi)
                .HasColumnType("datetime")
                .HasColumnName("TCMB_VIZE_TARIHI");
            entity.Property(e => e.Telefon)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TELEFON");
            entity.Property(e => e.TesvikBasTar)
                .HasColumnType("datetime")
                .HasColumnName("TESVIK_BAS_TAR");
            entity.Property(e => e.TesvikBitTar)
                .HasColumnType("datetime")
                .HasColumnName("TESVIK_BIT_TAR");
            entity.Property(e => e.TesvikOrtPersSayi).HasColumnName("TESVIK_ORT_PERS_SAYI");
            entity.Property(e => e.ToplamGvMatrahi).HasColumnName("TOPLAM_GV_MATRAHI");
            entity.Property(e => e.ToplamGvTutari).HasColumnName("TOPLAM_GV_TUTARI");
            entity.Property(e => e.TransferTarihi)
                .HasColumnType("datetime")
                .HasColumnName("TRANSFER_TARIHI");
            entity.Property(e => e.UcretTipi).HasColumnName("UCRET_TIPI");
            entity.Property(e => e.Ucreti).HasColumnName("UCRETI");
            entity.Property(e => e.Ulke)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ULKE");
            entity.Property(e => e.Uyrugu)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("UYRUGU");
            entity.Property(e => e.VerNedeni)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("VER_NEDENI");
            entity.Property(e => e.VerTarihi)
                .HasColumnType("datetime")
                .HasColumnName("VER_TARIHI");
            entity.Property(e => e.VerYer)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("VER_YER");
            entity.Property(e => e.VergiDr)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("VERGI_DR");
            entity.Property(e => e.VergiNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("VERGI_NO");
            entity.Property(e => e.Web)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("WEB");
            entity.Property(e => e.YabDil1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("YAB_DIL_1");
            entity.Property(e => e.YabDil1drm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("YAB_DIL_1DRM");
            entity.Property(e => e.YabDil2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("YAB_DIL_2");
            entity.Property(e => e.YabDil2drm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("YAB_DIL_2DRM");
            entity.Property(e => e.YillikIzinBasTar)
                .HasColumnType("datetime")
                .HasColumnName("YILLIK_IZIN_BAS_TAR");
            entity.Property(e => e.Yuk1Adres)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("YUK1_ADRES");
            entity.Property(e => e.Yuk1Ceptel)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("YUK1_CEPTEL");
            entity.Property(e => e.Yuk1Dogtar)
                .HasColumnType("datetime")
                .HasColumnName("YUK1_DOGTAR");
            entity.Property(e => e.Yuk1Dogyeri)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("YUK1_DOGYERI");
            entity.Property(e => e.Yuk1Evtel)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("YUK1_EVTEL");
            entity.Property(e => e.Yuk1Pkodu)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("YUK1_PKODU");
            entity.Property(e => e.Yuk1Tckimlik)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("YUK1_TCKIMLIK");
            entity.Property(e => e.Yuk1Uyrugu)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("YUK1_UYRUGU");
            entity.Property(e => e.Yuk2Adres)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("YUK2_ADRES");
            entity.Property(e => e.Yuk2Ceptel)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("YUK2_CEPTEL");
            entity.Property(e => e.Yuk2Dogtar)
                .HasColumnType("datetime")
                .HasColumnName("YUK2_DOGTAR");
            entity.Property(e => e.Yuk2Dogyeri)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("YUK2_DOGYERI");
            entity.Property(e => e.Yuk2Evtel)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("YUK2_EVTEL");
            entity.Property(e => e.Yuk2Pkodu)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("YUK2_PKODU");
            entity.Property(e => e.Yuk2Tckimlik)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("YUK2_TCKIMLIK");
            entity.Property(e => e.Yuk2Uyrugu)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("YUK2_UYRUGU");
        });

        modelBuilder.Entity<PersonelAvan>(entity =>
        {
            entity.HasKey(e => e.Blkodu).HasName("PK__PERSONEL__24967F26D9556FAD");

            entity.ToTable("PERSONEL_AVANS");

            entity.Property(e => e.Blkodu)
                .ValueGeneratedNever()
                .HasColumnName("BLKODU");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Blmaskodu).HasColumnName("BLMASKODU");
            entity.Property(e => e.PuantajAyi).HasColumnName("PUANTAJ_AYI");
            entity.Property(e => e.PuantajYili).HasColumnName("PUANTAJ_YILI");
            entity.Property(e => e.Tarihi)
                .HasColumnType("datetime")
                .HasColumnName("TARIHI");
            entity.Property(e => e.Tutari).HasColumnName("TUTARI");
        });

        modelBuilder.Entity<PersonelAylikYetki>(entity =>
        {
            entity.HasKey(e => e.Blkodu).HasName("PK__PERSONEL__24967F26F3045A3A");

            entity.ToTable("PERSONEL_AYLIK_YETKI");

            entity.HasIndex(e => e.Blperkodu, "PERSONEL_AYLIK_YETKI_BLPERKODU");

            entity.HasIndex(e => e.Tablo, "PERSONEL_AYLIK_YETKI_TABLO");

            entity.Property(e => e.Blkodu)
                .ValueGeneratedNever()
                .HasColumnName("BLKODU");
            entity.Property(e => e.Agustos).HasColumnName("AGUSTOS");
            entity.Property(e => e.Aralik).HasColumnName("ARALIK");
            entity.Property(e => e.Blperkodu).HasColumnName("BLPERKODU");
            entity.Property(e => e.Degistiren)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DEGISTIREN");
            entity.Property(e => e.DegistirmeTarihi)
                .HasColumnType("datetime")
                .HasColumnName("DEGISTIRME_TARIHI");
            entity.Property(e => e.Ekim).HasColumnName("EKIM");
            entity.Property(e => e.Eylul).HasColumnName("EYLUL");
            entity.Property(e => e.Haziran).HasColumnName("HAZIRAN");
            entity.Property(e => e.Kasim).HasColumnName("KASIM");
            entity.Property(e => e.Kaydeden)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KAYDEDEN");
            entity.Property(e => e.KayitTarihi)
                .HasColumnType("datetime")
                .HasColumnName("KAYIT_TARIHI");
            entity.Property(e => e.Mart).HasColumnName("MART");
            entity.Property(e => e.Mayis).HasColumnName("MAYIS");
            entity.Property(e => e.Nisan).HasColumnName("NISAN");
            entity.Property(e => e.Ocak).HasColumnName("OCAK");
            entity.Property(e => e.Subat).HasColumnName("SUBAT");
            entity.Property(e => e.Tablo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TABLO");
            entity.Property(e => e.Temmuz).HasColumnName("TEMMUZ");
        });

        modelBuilder.Entity<PersonelCocuk>(entity =>
        {
            entity.HasKey(e => e.Blkodu).HasName("PK__PERSONEL__24967F26BF8B601D");

            entity.ToTable("PERSONEL_COCUK");

            entity.Property(e => e.Blkodu)
                .ValueGeneratedNever()
                .HasColumnName("BLKODU");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Adi)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADI");
            entity.Property(e => e.AgiAciklama)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("AGI_ACIKLAMA");
            entity.Property(e => e.AgiUygula).HasColumnName("AGI_UYGULA");
            entity.Property(e => e.AnaAdi)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ANA_ADI");
            entity.Property(e => e.BabaAdi)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("BABA_ADI");
            entity.Property(e => e.Blpersonelkodu).HasColumnName("BLPERSONELKODU");
            entity.Property(e => e.Cinsiyeti)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CINSIYETI");
            entity.Property(e => e.CocukYardimi).HasColumnName("COCUK_YARDIMI");
            entity.Property(e => e.DogTarihi)
                .HasColumnType("datetime")
                .HasColumnName("DOG_TARIHI");
            entity.Property(e => e.DogumYeri)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DOGUM_YERI");
            entity.Property(e => e.OkulAdi)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("OKUL_ADI");
            entity.Property(e => e.OkulKayitTarihi)
                .HasColumnType("datetime")
                .HasColumnName("OKUL_KAYIT_TARIHI");
            entity.Property(e => e.OkulSinifi)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("OKUL_SINIFI");
            entity.Property(e => e.Tahsili)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("TAHSILI");
            entity.Property(e => e.Tckimlik)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("TCKIMLIK");
            entity.Property(e => e.Uyrugu)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("UYRUGU");
        });

        modelBuilder.Entity<PersonelDevredenSpm>(entity =>
        {
            entity.HasKey(e => e.Blkodu).HasName("PK__PERSONEL__24967F26611AE2F5");

            entity.ToTable("PERSONEL_DEVREDEN_SPM");

            entity.Property(e => e.Blkodu)
                .ValueGeneratedNever()
                .HasColumnName("BLKODU");
            entity.Property(e => e.Aykodu).HasColumnName("AYKODU");
            entity.Property(e => e.Blmaskodu).HasColumnName("BLMASKODU");
            entity.Property(e => e.Bordrodan).HasColumnName("BORDRODAN");
            entity.Property(e => e.SpmDevreden).HasColumnName("SPM_DEVREDEN");
            entity.Property(e => e.SpmKullanilan).HasColumnName("SPM_KULLANILAN");
            entity.Property(e => e.Yilkodu).HasColumnName("YILKODU");
        });

        modelBuilder.Entity<PersonelEvrak>(entity =>
        {
            entity.HasKey(e => e.Blkodu).HasName("PK__PERSONEL__24967F26675F30C6");

            entity.ToTable("PERSONEL_EVRAK");

            entity.HasIndex(e => e.Blpersonelkodu, "PEREV_BLPERSONELKODU");

            entity.Property(e => e.Blkodu)
                .ValueGeneratedNever()
                .HasColumnName("BLKODU");
            entity.Property(e => e.Blevraksabitkodu).HasColumnName("BLEVRAKSABITKODU");
            entity.Property(e => e.Blpersonelkodu).HasColumnName("BLPERSONELKODU");
            entity.Property(e => e.Durum).HasColumnName("DURUM");
            entity.Property(e => e.Evraktarihi)
                .HasColumnType("datetime")
                .HasColumnName("EVRAKTARIHI");
        });

        modelBuilder.Entity<PersonelIkramiyeharcirah>(entity =>
        {
            entity.HasKey(e => e.Blkodu).HasName("PK__PERSONEL__24967F263A61B533");

            entity.ToTable("PERSONEL_IKRAMIYEHARCIRAH");

            entity.HasIndex(e => e.Blpersonelkodu, "PERIKHR_BLPERSKODU");

            entity.Property(e => e.Blkodu)
                .ValueGeneratedNever()
                .HasColumnName("BLKODU");
            entity.Property(e => e.AguTutar).HasColumnName("AGU_TUTAR");
            entity.Property(e => e.AguTutarIsleme).HasColumnName("AGU_TUTAR_ISLEME");
            entity.Property(e => e.AraTutar).HasColumnName("ARA_TUTAR");
            entity.Property(e => e.AraTutarIsleme).HasColumnName("ARA_TUTAR_ISLEME");
            entity.Property(e => e.Blpersonelkodu).HasColumnName("BLPERSONELKODU");
            entity.Property(e => e.EkiTutar).HasColumnName("EKI_TUTAR");
            entity.Property(e => e.EkiTutarIsleme).HasColumnName("EKI_TUTAR_ISLEME");
            entity.Property(e => e.EylTutar).HasColumnName("EYL_TUTAR");
            entity.Property(e => e.EylTutarIsleme).HasColumnName("EYL_TUTAR_ISLEME");
            entity.Property(e => e.HazTutar).HasColumnName("HAZ_TUTAR");
            entity.Property(e => e.HazTutarIsleme).HasColumnName("HAZ_TUTAR_ISLEME");
            entity.Property(e => e.KasTutar).HasColumnName("KAS_TUTAR");
            entity.Property(e => e.KasTutarIsleme).HasColumnName("KAS_TUTAR_ISLEME");
            entity.Property(e => e.MarTutar).HasColumnName("MAR_TUTAR");
            entity.Property(e => e.MarTutarIsleme).HasColumnName("MAR_TUTAR_ISLEME");
            entity.Property(e => e.MayTutar).HasColumnName("MAY_TUTAR");
            entity.Property(e => e.MayTutarIsleme).HasColumnName("MAY_TUTAR_ISLEME");
            entity.Property(e => e.NisTutar).HasColumnName("NIS_TUTAR");
            entity.Property(e => e.NisTutarIsleme).HasColumnName("NIS_TUTAR_ISLEME");
            entity.Property(e => e.OcaTutar).HasColumnName("OCA_TUTAR");
            entity.Property(e => e.OcaTutarIsleme).HasColumnName("OCA_TUTAR_ISLEME");
            entity.Property(e => e.SubTutar).HasColumnName("SUB_TUTAR");
            entity.Property(e => e.SubTutarIsleme).HasColumnName("SUB_TUTAR_ISLEME");
            entity.Property(e => e.TemTutar).HasColumnName("TEM_TUTAR");
            entity.Property(e => e.TemTutarIsleme).HasColumnName("TEM_TUTAR_ISLEME");
            entity.Property(e => e.Tipi)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("TIPI");
        });

        modelBuilder.Entity<PersonelIsyeriNakil>(entity =>
        {
            entity.HasKey(e => e.Blkodu).HasName("PK__PERSONEL__24967F2613E828F2");

            entity.ToTable("PERSONEL_ISYERI_NAKIL");

            entity.Property(e => e.Blkodu)
                .ValueGeneratedNever()
                .HasColumnName("BLKODU");
            entity.Property(e => e.Blperkodu).HasColumnName("BLPERKODU");
            entity.Property(e => e.EskiIsyerikodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ESKI_ISYERIKODU");
            entity.Property(e => e.Tarihi)
                .HasColumnType("datetime")
                .HasColumnName("TARIHI");
            entity.Property(e => e.YeniIsyerikodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("YENI_ISYERIKODU");
        });

        modelBuilder.Entity<PersonelKesinti>(entity =>
        {
            entity.HasKey(e => e.Blkodu).HasName("PK__PERSONEL__24967F26AA5AE2C2");

            entity.ToTable("PERSONEL_KESINTI");

            entity.Property(e => e.Blkodu)
                .ValueGeneratedNever()
                .HasColumnName("BLKODU");
            entity.Property(e => e.Blpersonelkodu).HasColumnName("BLPERSONELKODU");
            entity.Property(e => e.GvIndUstSinir).HasColumnName("GV_IND_UST_SINIR");
            entity.Property(e => e.GvIndirimiUygula).HasColumnName("GV_INDIRIMI_UYGULA");
            entity.Property(e => e.Kesinti)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("KESINTI");
            entity.Property(e => e.Kodu)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("KODU");
            entity.Property(e => e.MuhKodu)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("MUH_KODU");
            entity.Property(e => e.NetMaasiEtkilesin).HasColumnName("NET_MAASI_ETKILESIN");
            entity.Property(e => e.Tutari).HasColumnName("TUTARI");
        });

        modelBuilder.Entity<PersonelTransferLog>(entity =>
        {
            entity.HasKey(e => e.Blkodu).HasName("PK__PERSONEL__24967F261F96C0FC");

            entity.ToTable("PERSONEL_TRANSFER_LOG");

            entity.Property(e => e.Blkodu)
                .ValueGeneratedNever()
                .HasColumnName("BLKODU");
            entity.Property(e => e.Adisoyadi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ADISOYADI");
            entity.Property(e => e.Blperkodu).HasColumnName("BLPERKODU");
            entity.Property(e => e.Kaydeden)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KAYDEDEN");
            entity.Property(e => e.Oncekidepadi)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ONCEKIDEPADI");
            entity.Property(e => e.Oncekiisyeriadi)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("ONCEKIISYERIADI");
            entity.Property(e => e.Oncekiisyerikodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ONCEKIISYERIKODU");
            entity.Property(e => e.Oncekisirketadi)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ONCEKISIRKETADI");
            entity.Property(e => e.Transfertarihi)
                .HasColumnType("datetime")
                .HasColumnName("TRANSFERTARIHI");
            entity.Property(e => e.Yenidepadi)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("YENIDEPADI");
            entity.Property(e => e.Yeniisyeriadi)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("YENIISYERIADI");
            entity.Property(e => e.Yeniisyerikodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("YENIISYERIKODU");
            entity.Property(e => e.Yenisirketadi)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("YENISIRKETADI");
        });

        modelBuilder.Entity<PersonelUstPersonel>(entity =>
        {
            entity.HasKey(e => e.Blkodu).HasName("PK__PERSONEL__24967F2623250965");

            entity.ToTable("PERSONEL_UST_PERSONEL");

            entity.HasIndex(e => e.Blperkodu, "PERS_UST_PERS_BLPERKODU");

            entity.Property(e => e.Blkodu)
                .ValueGeneratedNever()
                .HasColumnName("BLKODU");
            entity.Property(e => e.Blperkodu).HasColumnName("BLPERKODU");
            entity.Property(e => e.Blustperkodu).HasColumnName("BLUSTPERKODU");
            entity.Property(e => e.Departman)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("DEPARTMAN");
            entity.Property(e => e.Grubu)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("GRUBU");
        });

        modelBuilder.Entity<PersonelYardim>(entity =>
        {
            entity.HasKey(e => e.Blkodu).HasName("PK__PERSONEL__24967F2609053020");

            entity.ToTable("PERSONEL_YARDIM");

            entity.Property(e => e.Blkodu)
                .ValueGeneratedNever()
                .HasColumnName("BLKODU");
            entity.Property(e => e.Blpersonelkodu).HasColumnName("BLPERSONELKODU");
            entity.Property(e => e.DmvKesintisi).HasColumnName("DMV_KESINTISI");
            entity.Property(e => e.DvMuafiyet).HasColumnName("DV_MUAFIYET");
            entity.Property(e => e.DvUstsinir).HasColumnName("DV_USTSINIR");
            entity.Property(e => e.Gunluk).HasColumnName("GUNLUK");
            entity.Property(e => e.GvKesintisi).HasColumnName("GV_KESINTISI");
            entity.Property(e => e.GvMuafiyet).HasColumnName("GV_MUAFIYET");
            entity.Property(e => e.GvUstsinir).HasColumnName("GV_USTSINIR");
            entity.Property(e => e.Kodu)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("KODU");
            entity.Property(e => e.Netbrut).HasColumnName("NETBRUT");
            entity.Property(e => e.SskKesintisi).HasColumnName("SSK_KESINTISI");
            entity.Property(e => e.SskMuafiyet).HasColumnName("SSK_MUAFIYET");
            entity.Property(e => e.SskUstsinir).HasColumnName("SSK_USTSINIR");
            entity.Property(e => e.Tutari).HasColumnName("TUTARI");
            entity.Property(e => e.Yardim)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("YARDIM");
            entity.Property(e => e.YardimTuru).HasColumnName("YARDIM_TURU");
        });

        modelBuilder.Entity<PersonelYilizsayilmayangun>(entity =>
        {
            entity.HasKey(e => e.Blkodu).HasName("PK__PERSONEL__24967F260AB09179");

            entity.ToTable("PERSONEL_YILIZSAYILMAYANGUN");

            entity.Property(e => e.Blkodu)
                .ValueGeneratedNever()
                .HasColumnName("BLKODU");
            entity.Property(e => e.Blperkodu).HasColumnName("BLPERKODU");
            entity.Property(e => e.IzinBastar)
                .HasColumnType("datetime")
                .HasColumnName("IZIN_BASTAR");
            entity.Property(e => e.IzinBittar)
                .HasColumnType("datetime")
                .HasColumnName("IZIN_BITTAR");
            entity.Property(e => e.IzinGun).HasColumnName("IZIN_GUN");
        });

        modelBuilder.Entity<Puantaj>(entity =>
        {
            entity.HasKey(e => e.Blkodu).HasName("PK__PUANTAJ__24967F261C43EA5E");

            entity.ToTable("PUANTAJ");

            entity.HasIndex(e => e.Aykodu, "PNT_AYKODU");

            entity.HasIndex(e => e.Blperskodu, "PNT_BLPERSKODU");

            entity.HasIndex(e => e.IsyeriKodu, "PNT_ISYERIKODU");

            entity.Property(e => e.Blkodu)
                .ValueGeneratedNever()
                .HasColumnName("BLKODU");
            entity.Property(e => e.Aykodu).HasColumnName("AYKODU");
            entity.Property(e => e.BireyselEmkSigortasi).HasColumnName("BIREYSEL_EMK_SIGORTASI");
            entity.Property(e => e.Blperskodu).HasColumnName("BLPERSKODU");
            entity.Property(e => e.CocukIlk).HasColumnName("COCUK_ILK");
            entity.Property(e => e.CocukLise).HasColumnName("COCUK_LISE");
            entity.Property(e => e.CocukOkm).HasColumnName("COCUK_OKM");
            entity.Property(e => e.CocukUnv).HasColumnName("COCUK_UNV");
            entity.Property(e => e.EksikGun)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("EKSIK_GUN");
            entity.Property(e => e.GlvrMatrahi).HasColumnName("GLVR_MATRAHI");
            entity.Property(e => e.Gocmen).HasColumnName("GOCMEN");
            entity.Property(e => e.GunCalisma).HasColumnName("GUN_CALISMA");
            entity.Property(e => e.GunGentatil).HasColumnName("GUN_GENTATIL");
            entity.Property(e => e.GunRaporlu).HasColumnName("GUN_RAPORLU");
            entity.Property(e => e.GunTatil).HasColumnName("GUN_TATIL");
            entity.Property(e => e.GunUcretli).HasColumnName("GUN_UCRETLI");
            entity.Property(e => e.GunUcretsiz).HasColumnName("GUN_UCRETSIZ");
            entity.Property(e => e.GunUzaktanCalisma).HasColumnName("GUN_UZAKTAN_CALISMA");
            entity.Property(e => e.GunYillik).HasColumnName("GUN_YILLIK");
            entity.Property(e => e.HarcTutari).HasColumnName("HARC_TUTARI");
            entity.Property(e => e.HesapTipi).HasColumnName("HESAP_TIPI");
            entity.Property(e => e.IhbarGvkes).HasColumnName("IHBAR_GVKES");
            entity.Property(e => e.IhbarTutari).HasColumnName("IHBAR_TUTARI");
            entity.Property(e => e.IkramiyeTutari).HasColumnName("IKRAMIYE_TUTARI");
            entity.Property(e => e.IsyeriAdi)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("ISYERI_ADI");
            entity.Property(e => e.IsyeriKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ISYERI_KODU");
            entity.Property(e => e.KidemTazminatiTutari).HasColumnName("KIDEM_TAZMINATI_TUTARI");
            entity.Property(e => e.MesaiByrm).HasColumnName("MESAI_BYRM");
            entity.Property(e => e.MesaiByrmGece).HasColumnName("MESAI_BYRM_GECE");
            entity.Property(e => e.MesaiHfici).HasColumnName("MESAI_HFICI");
            entity.Property(e => e.MesaiHficiGece).HasColumnName("MESAI_HFICI_GECE");
            entity.Property(e => e.MesaiHfsn).HasColumnName("MESAI_HFSN");
            entity.Property(e => e.MesaiHfsnGece).HasColumnName("MESAI_HFSN_GECE");
            entity.Property(e => e.OzelSigorta).HasColumnName("OZEL_SIGORTA");
            entity.Property(e => e.PrimGunu).HasColumnName("PRIM_GUNU");
            entity.Property(e => e.PrimTutari).HasColumnName("PRIM_TUTARI");
            entity.Property(e => e.SaatCalisma).HasColumnName("SAAT_CALISMA");
            entity.Property(e => e.SaatGenTatil).HasColumnName("SAAT_GEN_TATIL");
            entity.Property(e => e.SaatRaporlu).HasColumnName("SAAT_RAPORLU");
            entity.Property(e => e.SaatTatil).HasColumnName("SAAT_TATIL");
            entity.Property(e => e.SaatUcretli).HasColumnName("SAAT_UCRETLI");
            entity.Property(e => e.SaatUcretsiz).HasColumnName("SAAT_UCRETSIZ");
            entity.Property(e => e.SaatYillik).HasColumnName("SAAT_YILLIK");
            entity.Property(e => e.Sakatlik).HasColumnName("SAKATLIK");
            entity.Property(e => e.SendikaDrm)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SENDIKA_DRM");
            entity.Property(e => e.UcretGunu).HasColumnName("UCRET_GUNU");
            entity.Property(e => e.UcretSaati).HasColumnName("UCRET_SAATI");
            entity.Property(e => e.UcretTipi).HasColumnName("UCRET_TIPI");
            entity.Property(e => e.Ucreti).HasColumnName("UCRETI");
        });

        modelBuilder.Entity<PuantajCetveli>(entity =>
        {
            entity.HasKey(e => e.Blkodu).HasName("PK__PUANTAJ___24967F26D361A84D");

            entity.ToTable("PUANTAJ_CETVELI");

            entity.Property(e => e.Blkodu)
                .ValueGeneratedNever()
                .HasColumnName("BLKODU");
            entity.Property(e => e.Aykodu).HasColumnName("AYKODU");
            entity.Property(e => e.Blperskodu).HasColumnName("BLPERSKODU");
            entity.Property(e => e.EksikGun)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("EKSIK_GUN");
            entity.Property(e => e.Gun01)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("GUN01");
            entity.Property(e => e.Gun02)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("GUN02");
            entity.Property(e => e.Gun03)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("GUN03");
            entity.Property(e => e.Gun04)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("GUN04");
            entity.Property(e => e.Gun05)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("GUN05");
            entity.Property(e => e.Gun06)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("GUN06");
            entity.Property(e => e.Gun07)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("GUN07");
            entity.Property(e => e.Gun08)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("GUN08");
            entity.Property(e => e.Gun09)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("GUN09");
            entity.Property(e => e.Gun10)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("GUN10");
            entity.Property(e => e.Gun11)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("GUN11");
            entity.Property(e => e.Gun12)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("GUN12");
            entity.Property(e => e.Gun13)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("GUN13");
            entity.Property(e => e.Gun14)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("GUN14");
            entity.Property(e => e.Gun15)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("GUN15");
            entity.Property(e => e.Gun16)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("GUN16");
            entity.Property(e => e.Gun17)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("GUN17");
            entity.Property(e => e.Gun18)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("GUN18");
            entity.Property(e => e.Gun19)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("GUN19");
            entity.Property(e => e.Gun20)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("GUN20");
            entity.Property(e => e.Gun21)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("GUN21");
            entity.Property(e => e.Gun22)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("GUN22");
            entity.Property(e => e.Gun23)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("GUN23");
            entity.Property(e => e.Gun24)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("GUN24");
            entity.Property(e => e.Gun25)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("GUN25");
            entity.Property(e => e.Gun26)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("GUN26");
            entity.Property(e => e.Gun27)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("GUN27");
            entity.Property(e => e.Gun28)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("GUN28");
            entity.Property(e => e.Gun29)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("GUN29");
            entity.Property(e => e.Gun30)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("GUN30");
            entity.Property(e => e.Gun31)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("GUN31");
            entity.Property(e => e.IsyeriAdi)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("ISYERI_ADI");
            entity.Property(e => e.IsyeriKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ISYERI_KODU");
            entity.Property(e => e.MesaiByrmGecePnc).HasColumnName("MESAI_BYRM_GECE_PNC");
            entity.Property(e => e.MesaiByrmPnc).HasColumnName("MESAI_BYRM_PNC");
            entity.Property(e => e.MesaiHficiGecePnc).HasColumnName("MESAI_HFICI_GECE_PNC");
            entity.Property(e => e.MesaiHficiPnc).HasColumnName("MESAI_HFICI_PNC");
            entity.Property(e => e.MesaiHfsnGecePnc).HasColumnName("MESAI_HFSN_GECE_PNC");
            entity.Property(e => e.MesaiHfsnPnc).HasColumnName("MESAI_HFSN_PNC");
            entity.Property(e => e.ToplamPrimgunu).HasColumnName("TOPLAM_PRIMGUNU");
            entity.Property(e => e.ToplamUcretgunu).HasColumnName("TOPLAM_UCRETGUNU");
            entity.Property(e => e.ToplamUzaktanCalisma).HasColumnName("TOPLAM_UZAKTAN_CALISMA");
        });

        modelBuilder.Entity<PuantajKesinti>(entity =>
        {
            entity.HasKey(e => e.Blkodu).HasName("PK__PUANTAJ___24967F260E61BB76");

            entity.ToTable("PUANTAJ_KESINTI");

            entity.Property(e => e.Blkodu)
                .ValueGeneratedNever()
                .HasColumnName("BLKODU");
            entity.Property(e => e.Blpnkodu).HasColumnName("BLPNKODU");
            entity.Property(e => e.GvIndUstSinir).HasColumnName("GV_IND_UST_SINIR");
            entity.Property(e => e.GvIndirimiUygula).HasColumnName("GV_INDIRIMI_UYGULA");
            entity.Property(e => e.HesapKodu)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("HESAP_KODU");
            entity.Property(e => e.Kesinti)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("KESINTI");
            entity.Property(e => e.Kodu)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("KODU");
            entity.Property(e => e.NetMaasiEtkilesin).HasColumnName("NET_MAASI_ETKILESIN");
            entity.Property(e => e.Tutari).HasColumnName("TUTARI");
        });

        modelBuilder.Entity<PuantajYardim>(entity =>
        {
            entity.HasKey(e => e.Blkodu).HasName("PK__PUANTAJ___24967F26DF9FBF67");

            entity.ToTable("PUANTAJ_YARDIM");

            entity.Property(e => e.Blkodu)
                .ValueGeneratedNever()
                .HasColumnName("BLKODU");
            entity.Property(e => e.AktarimYeri)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("AKTARIM_YERI");
            entity.Property(e => e.Blpnkodu).HasColumnName("BLPNKODU");
            entity.Property(e => e.DmvKes)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("DMV_KES");
            entity.Property(e => e.DvMuafiyet).HasColumnName("DV_MUAFIYET");
            entity.Property(e => e.DvUstsinir).HasColumnName("DV_USTSINIR");
            entity.Property(e => e.Gunluk)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("GUNLUK");
            entity.Property(e => e.GvKes)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("GV_KES");
            entity.Property(e => e.GvMuafiyet).HasColumnName("GV_MUAFIYET");
            entity.Property(e => e.GvUstsinir).HasColumnName("GV_USTSINIR");
            entity.Property(e => e.Kodu)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("KODU");
            entity.Property(e => e.Netbrut).HasColumnName("NETBRUT");
            entity.Property(e => e.SskKes)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("SSK_KES");
            entity.Property(e => e.SskMuafiyet).HasColumnName("SSK_MUAFIYET");
            entity.Property(e => e.SskUstsinir).HasColumnName("SSK_USTSINIR");
            entity.Property(e => e.Tutari).HasColumnName("TUTARI");
            entity.Property(e => e.Yardim)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("YARDIM");
            entity.Property(e => e.YardimTuru).HasColumnName("YARDIM_TURU");
        });

        modelBuilder.Entity<Sgkislemsonuc>(entity =>
        {
            entity.HasKey(e => e.Blkodu).HasName("PK__SGKISLEM__24967F2623BBCDD1");

            entity.ToTable("SGKISLEMSONUC");

            entity.Property(e => e.Blkodu)
                .ValueGeneratedNever()
                .HasColumnName("BLKODU");
            entity.Property(e => e.AdSoyad)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("AD_SOYAD");
            entity.Property(e => e.GcIslem)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("GC_ISLEM");
            entity.Property(e => e.GcTarihi)
                .HasColumnType("datetime")
                .HasColumnName("GC_TARIHI");
            entity.Property(e => e.HataAciklama)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("HATA_ACIKLAMA");
            entity.Property(e => e.HataKodu).HasColumnName("HATA_KODU");
            entity.Property(e => e.IslemAciklamasi)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("ISLEM_ACIKLAMASI");
            entity.Property(e => e.IslemSonucu).HasColumnName("ISLEM_SONUCU");
            entity.Property(e => e.IslemTarihi)
                .HasColumnType("datetime")
                .HasColumnName("ISLEM_TARIHI");
            entity.Property(e => e.IsyeriSicil)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ISYERI_SICIL");
            entity.Property(e => e.PdfHataAciklama)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("PDF_HATA_ACIKLAMA");
            entity.Property(e => e.PdfHataKodu).HasColumnName("PDF_HATA_KODU");
            entity.Property(e => e.ReferansKodu).HasColumnName("REFERANS_KODU");
            entity.Property(e => e.SicilNo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SICIL_NO");
            entity.Property(e => e.TcNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TC_NO");
        });

        modelBuilder.Entity<Sinav>(entity =>
        {
            entity.HasKey(e => e.Blkodu).HasName("PK__SINAV__24967F263E78DC2C");

            entity.ToTable("SINAV");

            entity.Property(e => e.Blkodu)
                .ValueGeneratedNever()
                .HasColumnName("BLKODU");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Adi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ADI");
            entity.Property(e => e.Aktif).HasColumnName("AKTIF");
            entity.Property(e => e.BslTarihi)
                .HasColumnType("datetime")
                .HasColumnName("BSL_TARIHI");
            entity.Property(e => e.BtsTarihi)
                .HasColumnType("datetime")
                .HasColumnName("BTS_TARIHI");
            entity.Property(e => e.Degistiren)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DEGISTIREN");
            entity.Property(e => e.DegistirmeTarihi)
                .HasColumnType("datetime")
                .HasColumnName("DEGISTIRME_TARIHI");
            entity.Property(e => e.Kaydeden)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KAYDEDEN");
            entity.Property(e => e.OlusturmaTarihi)
                .HasColumnType("datetime")
                .HasColumnName("OLUSTURMA_TARIHI");
            entity.Property(e => e.OzelKodu)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("OZEL_KODU");
            entity.Property(e => e.SinavAnket).HasColumnName("SINAV_ANKET");
            entity.Property(e => e.SinavKodu)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("SINAV_KODU");
            entity.Property(e => e.Suresi).HasColumnName("SURESI");
            entity.Property(e => e.WebdeGorunsun).HasColumnName("WEBDE_GORUNSUN");
            entity.Property(e => e.YetkiDurumu).HasColumnName("YETKI_DURUMU");
            entity.Property(e => e.YetkiSeviyesi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("YETKI_SEVIYESI");
            entity.Property(e => e.Yetkililer)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("YETKILILER");
        });

        modelBuilder.Entity<SinavSonuc>(entity =>
        {
            entity.HasKey(e => e.Blkodu).HasName("PK__SINAV_SO__24967F26A25C185D");

            entity.ToTable("SINAV_SONUC");

            entity.Property(e => e.Blkodu)
                .ValueGeneratedNever()
                .HasColumnName("BLKODU");
            entity.Property(e => e.AdiSoyadi)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("ADI_SOYADI");
            entity.Property(e => e.BaslSaati)
                .HasColumnType("datetime")
                .HasColumnName("BASL_SAATI");
            entity.Property(e => e.BitisSaati)
                .HasColumnType("datetime")
                .HasColumnName("BITIS_SAATI");
            entity.Property(e => e.Blsnkodu).HasColumnName("BLSNKODU");
            entity.Property(e => e.Degistiren)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DEGISTIREN");
            entity.Property(e => e.DegistirmeTarihi)
                .HasColumnType("datetime")
                .HasColumnName("DEGISTIRME_TARIHI");
            entity.Property(e => e.EkBilgiler)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("EK_BILGILER");
            entity.Property(e => e.Kaydeden)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KAYDEDEN");
            entity.Property(e => e.Personelkodu).HasColumnName("PERSONELKODU");
            entity.Property(e => e.PuanKatsy).HasColumnName("PUAN_KATSY");
            entity.Property(e => e.SinavAdi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SINAV_ADI");
            entity.Property(e => e.SinavAnket).HasColumnName("SINAV_ANKET");
            entity.Property(e => e.Tarihi)
                .HasColumnType("datetime")
                .HasColumnName("TARIHI");
        });

        modelBuilder.Entity<SinavSonucDt>(entity =>
        {
            entity.HasKey(e => e.Blkodu).HasName("PK__SINAV_SO__24967F2621727C6C");

            entity.ToTable("SINAV_SONUC_DT");

            entity.Property(e => e.Blkodu)
                .ValueGeneratedNever()
                .HasColumnName("BLKODU");
            entity.Property(e => e.Blmaskodu).HasColumnName("BLMASKODU");
            entity.Property(e => e.Cevap)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CEVAP");
            entity.Property(e => e.CevapAciklama)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("CEVAP_ACIKLAMA");
            entity.Property(e => e.Degistiren)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DEGISTIREN");
            entity.Property(e => e.DegistirmeTarihi)
                .HasColumnType("datetime")
                .HasColumnName("DEGISTIRME_TARIHI");
            entity.Property(e => e.Kaydeden)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KAYDEDEN");
            entity.Property(e => e.Puan).HasColumnName("PUAN");
            entity.Property(e => e.SoruNo).HasColumnName("SORU_NO");
        });

        modelBuilder.Entity<SinavSoru>(entity =>
        {
            entity.HasKey(e => e.Blkodu).HasName("PK__SINAV_SO__24967F2617011D71");

            entity.ToTable("SINAV_SORU");

            entity.Property(e => e.Blkodu)
                .ValueGeneratedNever()
                .HasColumnName("BLKODU");
            entity.Property(e => e.Blmaskodu).HasColumnName("BLMASKODU");
            entity.Property(e => e.Cevap)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CEVAP");
            entity.Property(e => e.Cevaptipi).HasColumnName("CEVAPTIPI");
            entity.Property(e => e.Degistiren)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DEGISTIREN");
            entity.Property(e => e.DegistirmeTarihi)
                .HasColumnType("datetime")
                .HasColumnName("DEGISTIRME_TARIHI");
            entity.Property(e => e.EklemeTarihi)
                .HasColumnType("datetime")
                .HasColumnName("EKLEME_TARIHI");
            entity.Property(e => e.Kaydeden)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KAYDEDEN");
            entity.Property(e => e.Puan).HasColumnName("PUAN");
            entity.Property(e => e.Soru)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("SORU");
            entity.Property(e => e.SoruNo).HasColumnName("SORU_NO");
            entity.Property(e => e.SoruSira).HasColumnName("SORU_SIRA");
        });

        modelBuilder.Entity<SinavSoruDt>(entity =>
        {
            entity.HasKey(e => e.Blkodu).HasName("PK__SINAV_SO__24967F267EB9E4A4");

            entity.ToTable("SINAV_SORU_DT");

            entity.Property(e => e.Blkodu)
                .ValueGeneratedNever()
                .HasColumnName("BLKODU");
            entity.Property(e => e.Blmaskodu).HasColumnName("BLMASKODU");
            entity.Property(e => e.Cevap)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("CEVAP");
            entity.Property(e => e.Degistiren)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DEGISTIREN");
            entity.Property(e => e.DegistirmeTarihi)
                .HasColumnType("datetime")
                .HasColumnName("DEGISTIRME_TARIHI");
            entity.Property(e => e.Kaydeden)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KAYDEDEN");
            entity.Property(e => e.MetinGirisi).HasColumnName("METIN_GIRISI");
            entity.Property(e => e.Secenek)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SECENEK");
            entity.Property(e => e.Sira).HasColumnName("SIRA");
        });

        modelBuilder.Entity<Sqlcreate>(entity =>
        {
            entity.HasKey(e => e.Blkodu).HasName("PK__SQLCREAT__24967F26C0ECF989");

            entity.ToTable("SQLCREATE");

            entity.Property(e => e.Blkodu)
                .ValueGeneratedNever()
                .HasColumnName("BLKODU");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Kriterler)
                .IsUnicode(false)
                .HasColumnName("KRITERLER");
            entity.Property(e => e.Modul)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODUL");
            entity.Property(e => e.Tanimi)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("TANIMI");
        });

        modelBuilder.Entity<SskTesvikTanim>(entity =>
        {
            entity.HasKey(e => e.Blkodu).HasName("PK__SSK_TESV__24967F26929D94E4");

            entity.ToTable("SSK_TESVIK_TANIM");

            entity.HasIndex(e => e.KanunNo, "UQ__SSK_TESV__D3F6EB1230716A48").IsUnique();

            entity.Property(e => e.Blkodu)
                .ValueGeneratedNever()
                .HasColumnName("BLKODU");
            entity.Property(e => e.Aktif).HasColumnName("AKTIF");
            entity.Property(e => e.DvTesvik).HasColumnName("DV_TESVIK");
            entity.Property(e => e.DvTesvikTavan).HasColumnName("DV_TESVIK_TAVAN");
            entity.Property(e => e.GvTesvik).HasColumnName("GV_TESVIK");
            entity.Property(e => e.GvTesvikTavan).HasColumnName("GV_TESVIK_TAVAN");
            entity.Property(e => e.IssizlikTesvik).HasColumnName("ISSIZLIK_TESVIK");
            entity.Property(e => e.IssizlikTesvikTavan).HasColumnName("ISSIZLIK_TESVIK_TAVAN");
            entity.Property(e => e.KanunNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KANUN_NO");
            entity.Property(e => e.SskTesvik).HasColumnName("SSK_TESVIK");
            entity.Property(e => e.SskTesvikTavan).HasColumnName("SSK_TESVIK_TAVAN");
        });

        modelBuilder.Entity<Vardiyasabit>(entity =>
        {
            entity.HasKey(e => e.Blkodu).HasName("PK__VARDIYAS__24967F263C2A3DCA");

            entity.ToTable("VARDIYASABIT");

            entity.Property(e => e.Blkodu)
                .ValueGeneratedNever()
                .HasColumnName("BLKODU");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Baslama)
                .HasColumnType("datetime")
                .HasColumnName("BASLAMA");
            entity.Property(e => e.Baslama2)
                .HasColumnType("datetime")
                .HasColumnName("BASLAMA_2");
            entity.Property(e => e.Bitis)
                .HasColumnType("datetime")
                .HasColumnName("BITIS");
            entity.Property(e => e.Bitis2)
                .HasColumnType("datetime")
                .HasColumnName("BITIS_2");
            entity.Property(e => e.Fazlamesai).HasColumnName("FAZLAMESAI");
            entity.Property(e => e.Fazlamesai2).HasColumnName("FAZLAMESAI_2");
            entity.Property(e => e.Fmbaslama)
                .HasColumnType("datetime")
                .HasColumnName("FMBASLAMA");
            entity.Property(e => e.Fmbaslama2)
                .HasColumnType("datetime")
                .HasColumnName("FMBASLAMA_2");
            entity.Property(e => e.Fmbitis)
                .HasColumnType("datetime")
                .HasColumnName("FMBITIS");
            entity.Property(e => e.Fmbitis2)
                .HasColumnType("datetime")
                .HasColumnName("FMBITIS_2");
            entity.Property(e => e.Fmkatsayi).HasColumnName("FMKATSAYI");
            entity.Property(e => e.Fmkatsayi2).HasColumnName("FMKATSAYI_2");
            entity.Property(e => e.Gcizinverme).HasColumnName("GCIZINVERME");
            entity.Property(e => e.Gcizinverme2).HasColumnName("GCIZINVERME_2");
            entity.Property(e => e.Ikincimesaivar).HasColumnName("IKINCIMESAIVAR");
            entity.Property(e => e.Mola1).HasColumnName("MOLA_1");
            entity.Property(e => e.Mola2).HasColumnName("MOLA_2");
            entity.Property(e => e.Nmkaysayi).HasColumnName("NMKAYSAYI");
            entity.Property(e => e.Nmkaysayi2).HasColumnName("NMKAYSAYI_2");
            entity.Property(e => e.Normalmesai).HasColumnName("NORMALMESAI");
            entity.Property(e => e.Normalmesai2).HasColumnName("NORMALMESAI_2");
            entity.Property(e => e.Resmitatil).HasColumnName("RESMITATIL");
            entity.Property(e => e.Resmitatil2).HasColumnName("RESMITATIL_2");
            entity.Property(e => e.Siralama).HasColumnName("SIRALAMA");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
            entity.Property(e => e.Tatil).HasColumnName("TATIL");
            entity.Property(e => e.Tatil2).HasColumnName("TATIL_2");
            entity.Property(e => e.Vardiyaadi)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("VARDIYAADI");
            entity.Property(e => e.Yemekbaslama)
                .HasColumnType("datetime")
                .HasColumnName("YEMEKBASLAMA");
            entity.Property(e => e.Yemekbaslama2)
                .HasColumnType("datetime")
                .HasColumnName("YEMEKBASLAMA_2");
            entity.Property(e => e.Yemekbitis)
                .HasColumnType("datetime")
                .HasColumnName("YEMEKBITIS");
            entity.Property(e => e.Yemekbitis2)
                .HasColumnType("datetime")
                .HasColumnName("YEMEKBITIS_2");
        });

        modelBuilder.Entity<Yemekhanegiris>(entity =>
        {
            entity.HasKey(e => e.Blkodu).HasName("PK__YEMEKHAN__24967F26B998D7D5");

            entity.ToTable("YEMEKHANEGIRIS");

            entity.Property(e => e.Blkodu)
                .ValueGeneratedNever()
                .HasColumnName("BLKODU");
            entity.Property(e => e.Blpersonelkodu).HasColumnName("BLPERSONELKODU");
            entity.Property(e => e.Giristarihi)
                .HasColumnType("datetime")
                .HasColumnName("GIRISTARIHI");
            entity.Property(e => e.Mesaitarihi)
                .HasColumnType("datetime")
                .HasColumnName("MESAITARIHI");
        });

        modelBuilder.Entity<Yillikizin>(entity =>
        {
            entity.HasKey(e => e.Blkodu).HasName("PK__YILLIKIZ__24967F26D67383DF");

            entity.ToTable("YILLIKIZIN");

            entity.Property(e => e.Blkodu)
                .ValueGeneratedNever()
                .HasColumnName("BLKODU");
            entity.Property(e => e.Blperkodu).HasColumnName("BLPERKODU");
            entity.Property(e => e.Degistiren)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DEGISTIREN");
            entity.Property(e => e.DegistirmeTarihi)
                .HasColumnType("datetime")
                .HasColumnName("DEGISTIRME_TARIHI");
            entity.Property(e => e.DepMudIslemTar)
                .HasColumnType("datetime")
                .HasColumnName("DEP_MUD_ISLEM_TAR");
            entity.Property(e => e.DepMudNot)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("DEP_MUD_NOT");
            entity.Property(e => e.DepMudOnay).HasColumnName("DEP_MUD_ONAY");
            entity.Property(e => e.DepMudTarihIlk)
                .HasColumnType("datetime")
                .HasColumnName("DEP_MUD_TARIH_ILK");
            entity.Property(e => e.DepMudTarihSon)
                .HasColumnType("datetime")
                .HasColumnName("DEP_MUD_TARIH_SON");
            entity.Property(e => e.DepMudTarihUygunDgl).HasColumnName("DEP_MUD_TARIH_UYGUN_DGL");
            entity.Property(e => e.IkMudIslemTar)
                .HasColumnType("datetime")
                .HasColumnName("IK_MUD_ISLEM_TAR");
            entity.Property(e => e.IkMudNot)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("IK_MUD_NOT");
            entity.Property(e => e.IkMudOnay).HasColumnName("IK_MUD_ONAY");
            entity.Property(e => e.IkMudTarihIlk)
                .HasColumnType("datetime")
                .HasColumnName("IK_MUD_TARIH_ILK");
            entity.Property(e => e.IkMudTarihSon)
                .HasColumnType("datetime")
                .HasColumnName("IK_MUD_TARIH_SON");
            entity.Property(e => e.IkMudTarihUygunDgl).HasColumnName("IK_MUD_TARIH_UYGUN_DGL");
            entity.Property(e => e.ImzaDurumu).HasColumnName("IMZA_DURUMU");
            entity.Property(e => e.Iptal).HasColumnName("IPTAL");
            entity.Property(e => e.Kaydeden)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KAYDEDEN");
            entity.Property(e => e.Modul)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("MODUL");
            entity.Property(e => e.OnayDm).HasColumnName("ONAY_DM");
            entity.Property(e => e.OnayIk).HasColumnName("ONAY_IK");
            entity.Property(e => e.OnaylananTarihIlk)
                .HasColumnType("datetime")
                .HasColumnName("ONAYLANAN_TARIH_ILK");
            entity.Property(e => e.OnaylananTarihSon)
                .HasColumnType("datetime")
                .HasColumnName("ONAYLANAN_TARIH_SON");
            entity.Property(e => e.OncekiYilIzin).HasColumnName("ONCEKI_YIL_IZIN");
            entity.Property(e => e.OncekiYilIzintarihiIlk)
                .HasColumnType("datetime")
                .HasColumnName("ONCEKI_YIL_IZINTARIHI_ILK");
            entity.Property(e => e.OncekiYilIzintarihiSon)
                .HasColumnType("datetime")
                .HasColumnName("ONCEKI_YIL_IZINTARIHI_SON");
            entity.Property(e => e.TalepGerekcesi)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("TALEP_GEREKCESI");
            entity.Property(e => e.TalepIslemTar)
                .HasColumnType("datetime")
                .HasColumnName("TALEP_ISLEM_TAR");
            entity.Property(e => e.TalepTarihiIlk)
                .HasColumnType("datetime")
                .HasColumnName("TALEP_TARIHI_ILK");
            entity.Property(e => e.TalepTarihiSon)
                .HasColumnType("datetime")
                .HasColumnName("TALEP_TARIHI_SON");
        });

        modelBuilder.Entity<YillikizinPlan>(entity =>
        {
            entity.HasKey(e => e.Blkodu).HasName("PK__YILLIKIZ__24967F26B3997109");

            entity.ToTable("YILLIKIZIN_PLAN");

            entity.HasIndex(e => e.Blperkodu, "YI_PLAN_BLPERKODU");

            entity.Property(e => e.Blkodu)
                .ValueGeneratedNever()
                .HasColumnName("BLKODU");
            entity.Property(e => e.Agustos).HasColumnName("AGUSTOS");
            entity.Property(e => e.Aralik).HasColumnName("ARALIK");
            entity.Property(e => e.Blperkodu).HasColumnName("BLPERKODU");
            entity.Property(e => e.DeviredecekYilIzin).HasColumnName("DEVIREDECEK_YIL_IZIN");
            entity.Property(e => e.Ekim).HasColumnName("EKIM");
            entity.Property(e => e.Eylul).HasColumnName("EYLUL");
            entity.Property(e => e.Haziran).HasColumnName("HAZIRAN");
            entity.Property(e => e.Kasim).HasColumnName("KASIM");
            entity.Property(e => e.KullanilacakTopIzin).HasColumnName("KULLANILACAK_TOP_IZIN");
            entity.Property(e => e.Mart).HasColumnName("MART");
            entity.Property(e => e.Mayis).HasColumnName("MAYIS");
            entity.Property(e => e.Nisan).HasColumnName("NISAN");
            entity.Property(e => e.Ocak).HasColumnName("OCAK");
            entity.Property(e => e.Subat).HasColumnName("SUBAT");
            entity.Property(e => e.Temmuz).HasColumnName("TEMMUZ");
        });

        modelBuilder.Entity<Ysayar>(entity =>
        {
            entity.HasKey(e => e.Blkodu).HasName("PK__YSAYAR__24967F2665443CD5");

            entity.ToTable("YSAYAR");

            entity.Property(e => e.Blkodu)
                .ValueGeneratedNever()
                .HasColumnName("BLKODU");
            entity.Property(e => e.AsgUcret).HasColumnName("ASG_UCRET");
            entity.Property(e => e.Aykodu).HasColumnName("AYKODU");
            entity.Property(e => e.CirakUcret).HasColumnName("CIRAK_UCRET");
            entity.Property(e => e.CocukParasi).HasColumnName("COCUK_PARASI");
            entity.Property(e => e.CocukPrlm).HasColumnName("COCUK_PRLM");
            entity.Property(e => e.CocukPrsmua).HasColumnName("COCUK_PRSMUA");
            entity.Property(e => e.Crk16Ucret).HasColumnName("CRK16_UCRET");
            entity.Property(e => e.DmvrOrani).HasColumnName("DMVR_ORANI");
            entity.Property(e => e.GntatilGunu).HasColumnName("GNTATIL_GUNU");
            entity.Property(e => e.GocmenIndirimi).HasColumnName("GOCMEN_INDIRIMI");
            entity.Property(e => e.GvOrani).HasColumnName("GV_ORANI");
            entity.Property(e => e.IsGunu).HasColumnName("IS_GUNU");
            entity.Property(e => e.Isc16kcUcret).HasColumnName("ISC16KC_UCRET");
            entity.Property(e => e.IsyeriKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ISYERI_KODU");
            entity.Property(e => e.KidemTztv).HasColumnName("KIDEM_TZTV");
            entity.Property(e => e.MatrahTaban).HasColumnName("MATRAH_TABAN");
            entity.Property(e => e.MatrahTavan).HasColumnName("MATRAH_TAVAN");
            entity.Property(e => e.MesaiBayram).HasColumnName("MESAI_BAYRAM");
            entity.Property(e => e.MesaiBayramGece).HasColumnName("MESAI_BAYRAM_GECE");
            entity.Property(e => e.MesaiHfici).HasColumnName("MESAI_HFICI");
            entity.Property(e => e.MesaiHficiGece).HasColumnName("MESAI_HFICI_GECE");
            entity.Property(e => e.MesaiHfsonu).HasColumnName("MESAI_HFSONU");
            entity.Property(e => e.MesaiHfsonuGece).HasColumnName("MESAI_HFSONU_GECE");
            entity.Property(e => e.MesaiSaati).HasColumnName("MESAI_SAATI");
            entity.Property(e => e.MtsOran1).HasColumnName("MTS_ORAN1");
            entity.Property(e => e.MtsOran2).HasColumnName("MTS_ORAN2");
            entity.Property(e => e.MtsOran3).HasColumnName("MTS_ORAN3");
            entity.Property(e => e.MtsOran4).HasColumnName("MTS_ORAN4");
            entity.Property(e => e.MtsOran5).HasColumnName("MTS_ORAN5");
            entity.Property(e => e.MtsOran6).HasColumnName("MTS_ORAN6");
            entity.Property(e => e.MtsOran7).HasColumnName("MTS_ORAN7");
            entity.Property(e => e.MtsTutar1).HasColumnName("MTS_TUTAR1");
            entity.Property(e => e.MtsTutar2).HasColumnName("MTS_TUTAR2");
            entity.Property(e => e.MtsTutar3).HasColumnName("MTS_TUTAR3");
            entity.Property(e => e.MtsTutar4).HasColumnName("MTS_TUTAR4");
            entity.Property(e => e.MtsTutar5).HasColumnName("MTS_TUTAR5");
            entity.Property(e => e.MtsTutar6).HasColumnName("MTS_TUTAR6");
            entity.Property(e => e.MtsTutar7).HasColumnName("MTS_TUTAR7");
            entity.Property(e => e.OgiMatrah1).HasColumnName("OGI_MATRAH1");
            entity.Property(e => e.OgiMatrah2).HasColumnName("OGI_MATRAH2");
            entity.Property(e => e.OgiMatrah3).HasColumnName("OGI_MATRAH3");
            entity.Property(e => e.OgiMatrah4).HasColumnName("OGI_MATRAH4");
            entity.Property(e => e.OgiMatrah5).HasColumnName("OGI_MATRAH5");
            entity.Property(e => e.OgiOran1).HasColumnName("OGI_ORAN1");
            entity.Property(e => e.OgiOran2).HasColumnName("OGI_ORAN2");
            entity.Property(e => e.OgiOran3).HasColumnName("OGI_ORAN3");
            entity.Property(e => e.OgiOran4).HasColumnName("OGI_ORAN4");
            entity.Property(e => e.OgiOran5).HasColumnName("OGI_ORAN5");
            entity.Property(e => e.OgiOrani).HasColumnName("OGI_ORANI");
            entity.Property(e => e.OncYore1).HasColumnName("ONC_YORE_1");
            entity.Property(e => e.OncYore2).HasColumnName("ONC_YORE_2");
            entity.Property(e => e.OncYore3).HasColumnName("ONC_YORE_3");
            entity.Property(e => e.SakatlikTut1).HasColumnName("SAKATLIK_TUT1");
            entity.Property(e => e.SakatlikTut2).HasColumnName("SAKATLIK_TUT2");
            entity.Property(e => e.SakatlikTut3).HasColumnName("SAKATLIK_TUT3");
            entity.Property(e => e.TatilGunu).HasColumnName("TATIL_GUNU");
        });

        modelBuilder.Entity<Ziyaretci>(entity =>
        {
            entity.HasKey(e => e.Blkodu).HasName("PK__ZIYARETC__24967F26FBC46B57");

            entity.ToTable("ZIYARETCI");

            entity.HasIndex(e => e.Adi, "I_ZIYARETCI_ADI");

            entity.HasIndex(e => e.Ast, "I_ZIYARETCI_AST");

            entity.HasIndex(e => e.Geliskapi, "I_ZIYARETCI_GELISKAPI");

            entity.HasIndex(e => e.Gelistarihi, "I_ZIYARETCI_GELISTARIHI");

            entity.HasIndex(e => e.Gidiskapi, "I_ZIYARETCI_GIDISKAPI");

            entity.HasIndex(e => e.Gidistarihi, "I_ZIYARETCI_GIDISTARIHI");

            entity.HasIndex(e => e.IsyeriAdi, "I_ZIYARETCI_ISYERI_ADI");

            entity.HasIndex(e => e.IsyeriKodu, "I_ZIYARETCI_ISYERI_KODU");

            entity.HasIndex(e => e.Kartno, "I_ZIYARETCI_KARTNO");

            entity.HasIndex(e => e.Kimlikno, "I_ZIYARETCI_KIMLIKNO");

            entity.HasIndex(e => e.Personel, "I_ZIYARETCI_PERSONEL");

            entity.HasIndex(e => e.Soyadi, "I_ZIYARETCI_SOYADI");

            entity.HasIndex(e => e.Ticariunvan, "I_ZIYARETCI_TICARIUNVAN");

            entity.HasIndex(e => e.ZiyaretciAlan1, "I_ZIYARETCI_ZIYARETCI_ALAN1");

            entity.HasIndex(e => e.ZiyaretciAlan2, "I_ZIYARETCI_ZIYARETCI_ALAN2");

            entity.HasIndex(e => e.ZiyaretciAlan3, "I_ZIYARETCI_ZIYARETCI_ALAN3");

            entity.HasIndex(e => e.Gelistarihi2, "ZYRT_GELISTARIHI2");

            entity.HasIndex(e => e.Gidistarihi2, "ZYRT_GIDISTARIHI2");

            entity.Property(e => e.Blkodu)
                .ValueGeneratedNever()
                .HasColumnName("BLKODU");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Adi)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("ADI");
            entity.Property(e => e.AileSno)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("AILE_SNO");
            entity.Property(e => e.AnaAdi)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ANA_ADI");
            entity.Property(e => e.AnalikSoyadi)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ANALIK_SOYADI");
            entity.Property(e => e.Ast)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComputedColumnSql("(upper((coalesce([ADI],'')+coalesce([SOYADI],''))+coalesce([TICARIUNVAN],'')))", false)
                .HasColumnName("AST");
            entity.Property(e => e.BabaAdi)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("BABA_ADI");
            entity.Property(e => e.BagliBlkodu).HasColumnName("BAGLI_BLKODU");
            entity.Property(e => e.CepTel)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CEP_TEL");
            entity.Property(e => e.CiltNo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("CILT_NO");
            entity.Property(e => e.Cinsiyeti).HasColumnName("CINSIYETI");
            entity.Property(e => e.Dini)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("DINI");
            entity.Property(e => e.DogTarihi)
                .HasColumnType("datetime")
                .HasColumnName("DOG_TARIHI");
            entity.Property(e => e.DogYeri)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("DOG_YERI");
            entity.Property(e => e.Geliskapi)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("GELISKAPI");
            entity.Property(e => e.Gelistarihi)
                .HasColumnType("datetime")
                .HasColumnName("GELISTARIHI");
            entity.Property(e => e.Gelistarihi2)
                .HasComputedColumnSql("(dateadd(day,datediff(day,(0),[GELISTARIHI]),(0)))", false)
                .HasColumnType("datetime")
                .HasColumnName("GELISTARIHI2");
            entity.Property(e => e.Gidiskapi)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("GIDISKAPI");
            entity.Property(e => e.Gidistarihi)
                .HasColumnType("datetime")
                .HasColumnName("GIDISTARIHI");
            entity.Property(e => e.Gidistarihi2)
                .HasComputedColumnSql("(dateadd(day,datediff(day,(0),[GIDISTARIHI]),(0)))", false)
                .HasColumnType("datetime")
                .HasColumnName("GIDISTARIHI2");
            entity.Property(e => e.IsyeriAdi)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("ISYERI_ADI");
            entity.Property(e => e.IsyeriKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ISYERI_KODU");
            entity.Property(e => e.KanGrubu)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("KAN_GRUBU");
            entity.Property(e => e.Kartno)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("KARTNO");
            entity.Property(e => e.KayitNo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("KAYIT_NO");
            entity.Property(e => e.KayitliIl)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("KAYITLI_IL");
            entity.Property(e => e.KayitliIlce)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("KAYITLI_ILCE");
            entity.Property(e => e.KimlikSeri)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("KIMLIK_SERI");
            entity.Property(e => e.Kimlikno)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("KIMLIKNO");
            entity.Property(e => e.Kisisayisi).HasColumnName("KISISAYISI");
            entity.Property(e => e.MahKoy)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("MAH_KOY");
            entity.Property(e => e.MedeniDrm).HasColumnName("MEDENI_DRM");
            entity.Property(e => e.Personel)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PERSONEL");
            entity.Property(e => e.SiraNo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("SIRA_NO");
            entity.Property(e => e.Soyadi)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("SOYADI");
            entity.Property(e => e.Ticariunvan)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TICARIUNVAN");
            entity.Property(e => e.Uyrugu)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("UYRUGU");
            entity.Property(e => e.VerNedeni)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("VER_NEDENI");
            entity.Property(e => e.VerTarihi)
                .HasColumnType("datetime")
                .HasColumnName("VER_TARIHI");
            entity.Property(e => e.VerYer)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("VER_YER");
            entity.Property(e => e.ZiyaretciAlan1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ZIYARETCI_ALAN1");
            entity.Property(e => e.ZiyaretciAlan2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ZIYARETCI_ALAN2");
            entity.Property(e => e.ZiyaretciAlan3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ZIYARETCI_ALAN3");
        });

        modelBuilder.Entity<Ziyaretcikart>(entity =>
        {
            entity.HasKey(e => e.Blkodu).HasName("PK__ZIYARETC__24967F26FF9EBB1C");

            entity.ToTable("ZIYARETCIKART");

            entity.HasIndex(e => e.Adi, "I_ZIYARETCIKART_ADI");

            entity.HasIndex(e => e.Kimlikno, "I_ZIYARETCIKART_KIMLIKNO");

            entity.HasIndex(e => e.Kisakodu, "I_ZIYARETCIKART_KISAKODU");

            entity.HasIndex(e => e.Soyadi, "I_ZIYARETCIKART_SOYADI");

            entity.HasIndex(e => e.Ticariunvani, "I_ZIYARETCIKART_TICARIUNVANI");

            entity.Property(e => e.Blkodu)
                .ValueGeneratedNever()
                .HasColumnName("BLKODU");
            entity.Property(e => e.Adi)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("ADI");
            entity.Property(e => e.AileSno)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("AILE_SNO");
            entity.Property(e => e.AnaAdi)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ANA_ADI");
            entity.Property(e => e.AnalikSoyadi)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ANALIK_SOYADI");
            entity.Property(e => e.BabaAdi)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("BABA_ADI");
            entity.Property(e => e.CepTel)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CEP_TEL");
            entity.Property(e => e.CiltNo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("CILT_NO");
            entity.Property(e => e.Cinsiyeti).HasColumnName("CINSIYETI");
            entity.Property(e => e.Dini)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("DINI");
            entity.Property(e => e.DogTarihi)
                .HasColumnType("datetime")
                .HasColumnName("DOG_TARIHI");
            entity.Property(e => e.DogYeri)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("DOG_YERI");
            entity.Property(e => e.KanGrubu)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("KAN_GRUBU");
            entity.Property(e => e.KaraListe).HasColumnName("KARA_LISTE");
            entity.Property(e => e.KayitNo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("KAYIT_NO");
            entity.Property(e => e.KayitliIl)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("KAYITLI_IL");
            entity.Property(e => e.KayitliIlce)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("KAYITLI_ILCE");
            entity.Property(e => e.KimlikSeri)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("KIMLIK_SERI");
            entity.Property(e => e.Kimlikno)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("KIMLIKNO");
            entity.Property(e => e.Kisakodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KISAKODU");
            entity.Property(e => e.MahKoy)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("MAH_KOY");
            entity.Property(e => e.MedeniDrm).HasColumnName("MEDENI_DRM");
            entity.Property(e => e.SiraNo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("SIRA_NO");
            entity.Property(e => e.Soyadi)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("SOYADI");
            entity.Property(e => e.Ticariunvani)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TICARIUNVANI");
            entity.Property(e => e.Uyari).HasColumnName("UYARI");
            entity.Property(e => e.Uyarimetni)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("UYARIMETNI");
            entity.Property(e => e.Uyrugu)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("UYRUGU");
            entity.Property(e => e.VerNedeni)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("VER_NEDENI");
            entity.Property(e => e.VerTarihi)
                .HasColumnType("datetime")
                .HasColumnName("VER_TARIHI");
            entity.Property(e => e.VerYer)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("VER_YER");
        });

        modelBuilder.Entity<ZorunluAlanlar>(entity =>
        {
            entity.HasKey(e => e.Blkodu).HasName("PK__ZORUNLU___24967F2645BD236F");

            entity.ToTable("ZORUNLU_ALANLAR");

            entity.Property(e => e.Blkodu)
                .ValueGeneratedNever()
                .HasColumnName("BLKODU");
            entity.Property(e => e.AlanAdi)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("ALAN_ADI");
            entity.Property(e => e.AlanTipi).HasColumnName("ALAN_TIPI");
            entity.Property(e => e.GoruntuAdi)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("GORUNTU_ADI");
            entity.Property(e => e.ModulKodu)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("MODUL_KODU");
            entity.Property(e => e.TabloAdi)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("TABLO_ADI");
        });
        modelBuilder.HasSequence("ACIKLAMA_GEN").StartsAt(0L);
        modelBuilder.HasSequence("BORDRO_GEN").StartsAt(0L);
        modelBuilder.HasSequence("BORDRO_KESINTI_GEN").StartsAt(0L);
        modelBuilder.HasSequence("BORDRO_YARDIM_GEN").StartsAt(0L);
        modelBuilder.HasSequence("CALISMAGUNLERI_GEN").StartsAt(0L);
        modelBuilder.HasSequence("CALISMAPLAN_GEN").StartsAt(0L);
        modelBuilder.HasSequence("GIRISCIKIS_GEN").StartsAt(0L);
        modelBuilder.HasSequence("ICMAL_GEN").StartsAt(0L);
        modelBuilder.HasSequence("ICRA_GEN").StartsAt(0L);
        modelBuilder.HasSequence("ISYERI_DEPARTMAN_GEN").StartsAt(0L);
        modelBuilder.HasSequence("ISYERI_GEN").StartsAt(0L);
        modelBuilder.HasSequence("ISYERI_KESINTI_GEN").StartsAt(0L);
        modelBuilder.HasSequence("ISYERI_YARDIM_GEN").StartsAt(0L);
        modelBuilder.HasSequence("KIDEM_GEN").StartsAt(0L);
        modelBuilder.HasSequence("KULLANICI_OZELRAPOR_UPDATE_GEN");
        modelBuilder.HasSequence("PER_GRUP_GEN").StartsAt(0L);
        modelBuilder.HasSequence("PERSONEL_AVANS_GEN").StartsAt(0L);
        modelBuilder.HasSequence("PERSONEL_GEN").StartsAt(0L);
        modelBuilder.HasSequence("PERSONEL_IKRAMIYEHARCIRAH_GEN").StartsAt(0L);
        modelBuilder.HasSequence("PERSONEL_KESINTI_GEN").StartsAt(0L);
        modelBuilder.HasSequence("PERSONEL_KODU_GEN").StartsAt(97000000L);
        modelBuilder.HasSequence("PERSONEL_YARDIM_GEN").StartsAt(0L);
        modelBuilder.HasSequence("PUANTAJ_CETVELI_GEN").StartsAt(0L);
        modelBuilder.HasSequence("PUANTAJ_GEN").StartsAt(0L);
        modelBuilder.HasSequence("PUANTAJ_KESINTI_GEN").StartsAt(0L);
        modelBuilder.HasSequence("PUANTAJ_YARDIM_GEN").StartsAt(0L);
        modelBuilder.HasSequence("SSK_TESVIK_TANIM_GEN").StartsAt(0L);
        modelBuilder.HasSequence("VARDIYASABIT_GEN").StartsAt(0L);
        modelBuilder.HasSequence("VERSION_ID_GEN").StartsAt(824L);
        modelBuilder.HasSequence("YSAYAR_GEN").StartsAt(0L);

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
