using System;
using System.Collections.Generic;

namespace AkinsoftExcellOkuma.Persistence;

public partial class Ozelalangrup
{
    public long Blkodu { get; set; }

    public string Baslik { get; set; } = null!;

    public short? Aktif { get; set; }

    public string? Modul { get; set; }

    public int? Siralama { get; set; }
}
