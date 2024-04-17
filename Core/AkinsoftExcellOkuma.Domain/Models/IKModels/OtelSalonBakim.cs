using System;
using System.Collections.Generic;

namespace AkinsoftExcellOkuma.Persistence;

public partial class OtelSalonBakim
{
    public long Blkodu { get; set; }

    public long? Blsalonkodu { get; set; }

    public DateTime? BaslangicTarihi { get; set; }

    public DateTime? BitisTarihi { get; set; }

    public string? Aciklama { get; set; }
}
