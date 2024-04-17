using System;
using System.Collections.Generic;

namespace AkinsoftExcellOkuma.Persistence;

public partial class DegisimLog
{
    public long Blkodu { get; set; }

    public DateTime? Tarihi { get; set; }

    public string? TabloAdi { get; set; }

    public long? Blmaskodu { get; set; }

    public string? DegisimLogu { get; set; }

    public string? Kullanici { get; set; }

    public string? MakineId { get; set; }

    public string? Uygulama { get; set; }

    public DateTime? Tarihi2 { get; set; }
}
