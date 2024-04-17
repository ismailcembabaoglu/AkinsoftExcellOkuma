using System;
using System.Collections.Generic;

namespace AkinsoftExcellOkuma.Persistence;

public partial class PersonelIsyeriNakil
{
    public long Blkodu { get; set; }

    public long? Blperkodu { get; set; }

    public string? EskiIsyerikodu { get; set; }

    public string? YeniIsyerikodu { get; set; }

    public DateTime? Tarihi { get; set; }
}
