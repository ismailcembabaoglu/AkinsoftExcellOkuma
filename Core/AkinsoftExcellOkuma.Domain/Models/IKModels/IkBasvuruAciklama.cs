using System;
using System.Collections.Generic;

namespace AkinsoftExcellOkuma.Persistence;

public partial class IkBasvuruAciklama
{
    public long Blkodu { get; set; }

    public long? Blbasvurukodu { get; set; }

    public DateTime? KayitTarih { get; set; }

    public string? Aciklama { get; set; }

    public string? AckKodu { get; set; }

    public string? Kaydeden { get; set; }

    public string? Degistiren { get; set; }

    public DateTime? DegistirmeTarihi { get; set; }
}
