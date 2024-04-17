using System;
using System.Collections.Generic;

namespace AkinsoftExcellOkuma.Persistence;

public partial class CalismaPlaniPersonel
{
    public long Blkodu { get; set; }

    public long? Blperkodu { get; set; }

    public long? Blplankodu { get; set; }

    public DateTime? BasTar { get; set; }

    public DateTime? BitTar { get; set; }

    public DateTime? KayitTarihi { get; set; }

    public string? Kaydeden { get; set; }

    public string? Degistiren { get; set; }

    public DateTime? DegistirmeTarihi { get; set; }

    public string? Aciklama { get; set; }
}
