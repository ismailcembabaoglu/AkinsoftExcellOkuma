using System;
using System.Collections.Generic;

namespace AkinsoftExcellOkuma.Persistence;

public partial class EgitimDetay
{
    public long Blkodu { get; set; }

    public long? Blegtkodu { get; set; }

    public DateTime? Tarihi { get; set; }

    public string? Modul { get; set; }

    public long? Blkisikodu { get; set; }

    public string? Kodu { get; set; }

    public string? Adi { get; set; }

    public string? Soyadi { get; set; }

    public string? OzelKodu1 { get; set; }

    public short? Katildi { get; set; }

    public double? Puani { get; set; }

    public string? Aciklama { get; set; }

    public short? Onay { get; set; }

    public string? TcNo { get; set; }
}
