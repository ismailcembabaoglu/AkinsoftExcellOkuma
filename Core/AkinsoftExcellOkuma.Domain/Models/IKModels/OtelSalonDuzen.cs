using System;
using System.Collections.Generic;

namespace AkinsoftExcellOkuma.Persistence;

public partial class OtelSalonDuzen
{
    public long Blkodu { get; set; }

    public long? Blsalonkodu { get; set; }

    public long? Bloturmaduzenikodu { get; set; }

    public int? MinKapasite { get; set; }

    public int? MaxKapasite { get; set; }

    public int? HazirlanmaZamani { get; set; }

    public int? ToplanmaZamani { get; set; }

    public short? Varsayilan { get; set; }

    public short? Aktif { get; set; }
}
