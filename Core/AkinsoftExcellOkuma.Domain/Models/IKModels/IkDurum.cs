using System;
using System.Collections.Generic;

namespace AkinsoftExcellOkuma.Persistence;

public partial class IkDurum
{
    public long Blkodu { get; set; }

    public string Tanimi { get; set; } = null!;

    public string? Aciklama { get; set; }

    public short? Varsayilan { get; set; }

    public short? Kodu { get; set; }

    public string? Modul { get; set; }
}
