using System;
using System.Collections.Generic;

namespace AkinsoftExcellOkuma.Persistence;

public partial class OtelSantralAyar
{
    public long Blkodu { get; set; }

    public short? SantralAktif { get; set; }

    public short? SantralKontrol { get; set; }

    public int? SantralTur { get; set; }

    public string? SantralServer { get; set; }

    public string? SantralDatabase { get; set; }

    public string? SantralDbUsername { get; set; }

    public string? SantralDbUserpass { get; set; }

    public string? SubeKodu { get; set; }
}
