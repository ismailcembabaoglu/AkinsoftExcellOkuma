using System;
using System.Collections.Generic;

namespace AkinsoftExcellOkuma.Persistence;

public partial class OtelEnvanterFiyat
{
    public long Blkodu { get; set; }

    public long? Blenvanterkodu { get; set; }

    public long? Blfiyatgrupkodu { get; set; }

    public DateTime? BaslangicTarihi { get; set; }

    public DateTime? BitisTarihi { get; set; }

    public string? Aciklama { get; set; }

    public double? Fiyati { get; set; }

    public short? SaatlikCalistir { get; set; }

    public short? Aktif { get; set; }
}
