using System;
using System.Collections.Generic;

namespace AkinsoftExcellOkuma.Persistence;

public partial class IcraHrk
{
    public long Blkodu { get; set; }

    public long Icrablkodu { get; set; }

    public long Perblkodu { get; set; }

    public DateTime? Tarih { get; set; }

    public double? OdemeTutari { get; set; }

    public string? Aciklama { get; set; }

    public short? BordroAy { get; set; }

    public short? BordroYil { get; set; }
}
