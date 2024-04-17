using System;
using System.Collections.Generic;

namespace AkinsoftExcellOkuma.Persistence;

public partial class OtelSalonhr
{
    public long Blkodu { get; set; }

    public long? Bletkinlikkodu { get; set; }

    public long? Blsalonkodu { get; set; }

    public long? Bloturmaduzeni { get; set; }

    public long? Blfiyatkodu { get; set; }

    public double? Fiyati { get; set; }

    public short? SaatlikCalistir { get; set; }

    public DateTime? BaslamaTarihi { get; set; }

    public DateTime? BitisTarihi { get; set; }

    public string? Aciklama { get; set; }
}
