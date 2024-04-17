using System;
using System.Collections.Generic;

namespace AkinsoftExcellOkuma.Persistence;

public partial class PersonelYilizsayilmayangun
{
    public long Blkodu { get; set; }

    public long? Blperkodu { get; set; }

    public DateTime? IzinBastar { get; set; }

    public int? IzinGun { get; set; }

    public DateTime? IzinBittar { get; set; }
}
