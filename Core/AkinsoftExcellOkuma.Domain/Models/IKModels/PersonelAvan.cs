using System;
using System.Collections.Generic;

namespace AkinsoftExcellOkuma.Persistence;

public partial class PersonelAvan
{
    public long Blkodu { get; set; }

    public long? Blmaskodu { get; set; }

    public DateTime? Tarihi { get; set; }

    public short? PuantajAyi { get; set; }

    public short? PuantajYili { get; set; }

    public string? Aciklama { get; set; }

    public double? Tutari { get; set; }
}
