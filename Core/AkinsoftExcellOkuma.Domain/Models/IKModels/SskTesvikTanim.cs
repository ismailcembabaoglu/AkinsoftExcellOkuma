using System;
using System.Collections.Generic;

namespace AkinsoftExcellOkuma.Persistence;

public partial class SskTesvikTanim
{
    public long Blkodu { get; set; }

    public string KanunNo { get; set; } = null!;

    public short? Aktif { get; set; }

    public short? SskTesvik { get; set; }

    public double? SskTesvikTavan { get; set; }

    public short? IssizlikTesvik { get; set; }

    public double? IssizlikTesvikTavan { get; set; }

    public short? GvTesvik { get; set; }

    public double? GvTesvikTavan { get; set; }

    public short? DvTesvik { get; set; }

    public double? DvTesvikTavan { get; set; }
}
