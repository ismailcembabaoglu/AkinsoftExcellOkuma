using System;
using System.Collections.Generic;

namespace AkinsoftExcellOkuma.Persistence;

public partial class IkBasvuruOzellikTanim
{
    public long Blkodu { get; set; }

    public string? Kodu { get; set; }

    public string? Tanimi { get; set; }

    public short? MetinGirisi { get; set; }

    public short? Aktif { get; set; }
}
