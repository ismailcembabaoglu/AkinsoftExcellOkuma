using System;
using System.Collections.Generic;

namespace AkinsoftExcellOkuma.Persistence;

public partial class OtelEnvanterHareket
{
    public long Blkodu { get; set; }

    public long? Blenvanterkodu { get; set; }

    public int? Adet { get; set; }

    public DateTime? BaslamaTarihi { get; set; }

    public DateTime? BitisTarihi { get; set; }

    public string? EntegrasyonAdi { get; set; }

    public long? EntegrasyonKodu { get; set; }

    public string? Aciklama { get; set; }

    public double? Fiyati { get; set; }

    public long? Blhesapkodu { get; set; }

    public short? Sabit { get; set; }

    public short? SaatlikCalistir { get; set; }
}
