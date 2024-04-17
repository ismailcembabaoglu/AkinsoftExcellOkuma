using System;
using System.Collections.Generic;

namespace AkinsoftExcellOkuma.Persistence;

public partial class PersonelEvrak
{
    public long Blkodu { get; set; }

    public long? Blpersonelkodu { get; set; }

    public long? Blevraksabitkodu { get; set; }

    public short? Durum { get; set; }

    public DateTime? Evraktarihi { get; set; }
}
