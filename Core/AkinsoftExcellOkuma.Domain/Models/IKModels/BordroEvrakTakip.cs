using System;
using System.Collections.Generic;

namespace AkinsoftExcellOkuma.Persistence;

public partial class BordroEvrakTakip
{
    public long Blkodu { get; set; }

    public string? EvrakTipi { get; set; }

    public DateTime? Tarihi { get; set; }

    public string? Aciklama { get; set; }

    public string? IsyeriKodu { get; set; }

    public string? IsyeriAdi { get; set; }

    public long? Blperskodu { get; set; }
}
