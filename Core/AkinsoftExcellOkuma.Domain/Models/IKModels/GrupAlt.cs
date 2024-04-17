using System;
using System.Collections.Generic;

namespace AkinsoftExcellOkuma.Persistence;

public partial class GrupAlt
{
    public long Blkodu { get; set; }

    public long Blmaskodu { get; set; }

    public string? GrupAdi { get; set; }

    public string? Aciklama { get; set; }

    public string? Modul { get; set; }

    public string? UstGrupAdi { get; set; }

    public string? UstGrupAdi2 { get; set; }

    public string? GrupKodu { get; set; }

    public DateTime? KayitTarihi { get; set; }

    public string? Kaydeden { get; set; }

    public string? Degistiren { get; set; }

    public DateTime? DegistirmeTarihi { get; set; }
}
