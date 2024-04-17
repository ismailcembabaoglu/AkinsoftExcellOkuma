using System;
using System.Collections.Generic;

namespace AkinsoftExcellOkuma.Persistence;

public partial class Puantaj
{
    public long Blkodu { get; set; }

    public string? IsyeriKodu { get; set; }

    public string? IsyeriAdi { get; set; }

    public short? Aykodu { get; set; }

    public short? UcretTipi { get; set; }

    public double? Ucreti { get; set; }

    public double? GlvrMatrahi { get; set; }

    public short? HesapTipi { get; set; }

    public short? CocukOkm { get; set; }

    public short? CocukIlk { get; set; }

    public short? CocukLise { get; set; }

    public short? CocukUnv { get; set; }

    public double? GunCalisma { get; set; }

    public double? GunTatil { get; set; }

    public double? GunRaporlu { get; set; }

    public double? GunYillik { get; set; }

    public double? GunUcretli { get; set; }

    public double? GunUcretsiz { get; set; }

    public double? SaatCalisma { get; set; }

    public double? SaatTatil { get; set; }

    public double? SaatRaporlu { get; set; }

    public double? SaatYillik { get; set; }

    public double? SaatUcretli { get; set; }

    public double? SaatUcretsiz { get; set; }

    public double? MesaiHfici { get; set; }

    public double? MesaiHfsn { get; set; }

    public double? MesaiByrm { get; set; }

    public double? MesaiHficiGece { get; set; }

    public double? MesaiHfsnGece { get; set; }

    public double? MesaiByrmGece { get; set; }

    public short? Sakatlik { get; set; }

    public short? Gocmen { get; set; }

    public string? SendikaDrm { get; set; }

    public double? OzelSigorta { get; set; }

    public double? PrimTutari { get; set; }

    public double? IkramiyeTutari { get; set; }

    public double? IhbarTutari { get; set; }

    public double? HarcTutari { get; set; }

    public short? PrimGunu { get; set; }

    public double? IhbarGvkes { get; set; }

    public string? EksikGun { get; set; }

    public double? GunGentatil { get; set; }

    public double? UcretGunu { get; set; }

    public double? UcretSaati { get; set; }

    public double? SaatGenTatil { get; set; }

    public long? Blperskodu { get; set; }

    public double? BireyselEmkSigortasi { get; set; }

    public double? KidemTazminatiTutari { get; set; }

    public double? GunUzaktanCalisma { get; set; }
}
