using System;
using System.Collections.Generic;

namespace AkinsoftExcellOkuma.Persistence;

public partial class IstekOneri
{
    public long Blkodu { get; set; }

    public string? AdiSoyadi { get; set; }

    public long? Blpersonelkodu { get; set; }

    public string? Konu { get; set; }

    public string? Aciklama { get; set; }

    public DateTime? Tarih { get; set; }

    public short? Durum { get; set; }

    public string? Cevap { get; set; }

    public string? Cevaplayan { get; set; }
}
