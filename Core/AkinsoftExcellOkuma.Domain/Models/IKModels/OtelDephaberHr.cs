using System;
using System.Collections.Generic;

namespace AkinsoftExcellOkuma.Persistence;

public partial class OtelDephaberHr
{
    public long Blkodu { get; set; }

    public string? Mesaj { get; set; }

    public long? Departman { get; set; }

    public short? Aktif { get; set; }

    public string? Kaydeden { get; set; }

    public string? Degistiren { get; set; }

    public DateTime? KayitTarihi { get; set; }

    public DateTime? DegistirmeTarihi { get; set; }

    public string? SubeKodu { get; set; }
}
