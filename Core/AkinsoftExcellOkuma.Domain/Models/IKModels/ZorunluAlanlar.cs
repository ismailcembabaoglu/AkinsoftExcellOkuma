using System;
using System.Collections.Generic;

namespace AkinsoftExcellOkuma.Persistence;

public partial class ZorunluAlanlar
{
    public long Blkodu { get; set; }

    public string? TabloAdi { get; set; }

    public string? AlanAdi { get; set; }

    public short? AlanTipi { get; set; }

    public string? ModulKodu { get; set; }

    public string? GoruntuAdi { get; set; }
}
