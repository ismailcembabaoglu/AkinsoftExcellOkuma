using System;
using System.Collections.Generic;

namespace AkinsoftExcellOkuma.Persistence;

public partial class Sgkislemsonuc
{
    public long Blkodu { get; set; }

    public string? GcIslem { get; set; }

    public DateTime? IslemTarihi { get; set; }

    public short? HataKodu { get; set; }

    public string? HataAciklama { get; set; }

    public short? IslemSonucu { get; set; }

    public string? IslemAciklamasi { get; set; }

    public long? ReferansKodu { get; set; }

    public string? AdSoyad { get; set; }

    public DateTime? GcTarihi { get; set; }

    public string? SicilNo { get; set; }

    public string? TcNo { get; set; }

    public string? IsyeriSicil { get; set; }

    public short? PdfHataKodu { get; set; }

    public string? PdfHataAciklama { get; set; }
}
