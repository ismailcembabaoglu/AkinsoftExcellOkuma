using System;
using System.Collections.Generic;

namespace AkinsoftExcellOkuma.Persistence;

public partial class PersonelDevredenSpm
{
    public long Blkodu { get; set; }

    public long? Blmaskodu { get; set; }

    public short? Aykodu { get; set; }

    public short? Yilkodu { get; set; }

    public double? SpmDevreden { get; set; }

    public double? SpmKullanilan { get; set; }

    public short? Bordrodan { get; set; }
}
