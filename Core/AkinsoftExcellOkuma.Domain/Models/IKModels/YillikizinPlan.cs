using System;
using System.Collections.Generic;

namespace AkinsoftExcellOkuma.Persistence;

public partial class YillikizinPlan
{
    public long Blkodu { get; set; }

    public long? Blperkodu { get; set; }

    public short? Ocak { get; set; }

    public short? Subat { get; set; }

    public short? Mart { get; set; }

    public short? Nisan { get; set; }

    public short? Mayis { get; set; }

    public short? Haziran { get; set; }

    public short? Temmuz { get; set; }

    public short? Agustos { get; set; }

    public short? Eylul { get; set; }

    public short? Ekim { get; set; }

    public short? Kasim { get; set; }

    public short? Aralik { get; set; }

    public short? KullanilacakTopIzin { get; set; }

    public short? DeviredecekYilIzin { get; set; }
}
