using System;
using System.Collections.Generic;

namespace AkinsoftExcellOkuma.Persistence;

public partial class IkBasvuruOzellik
{
    public long Blkodu { get; set; }

    public long? Blbaskodu { get; set; }

    public long? Bldpkodu { get; set; }

    public long? Blotkodu { get; set; }

    public string? OzellikTanimi { get; set; }

    public double? Yetenek { get; set; }

    public short? MetinGirisi { get; set; }
}
