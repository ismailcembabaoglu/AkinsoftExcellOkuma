using System;
using System.Collections.Generic;

namespace AkinsoftExcellOkuma.Persistence;

public partial class Calismaplan
{
    public long Blkodu { get; set; }

    public string Planadi { get; set; } = null!;

    public string? Aciklama { get; set; }

    public short? Geckalmacezasi { get; set; }

    public short? Geckalmatolaransi { get; set; }

    public double? Gelmemeceza { get; set; }

    public short? Ayliktolerans { get; set; }

    public double? Aylikkesinti { get; set; }

    public int? Ayliktoleransdk { get; set; }

    public short? Geckalmafazlamesai { get; set; }
}
