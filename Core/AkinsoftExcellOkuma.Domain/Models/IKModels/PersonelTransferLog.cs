using System;
using System.Collections.Generic;

namespace AkinsoftExcellOkuma.Persistence;

public partial class PersonelTransferLog
{
    public long Blkodu { get; set; }

    public DateTime? Transfertarihi { get; set; }

    public long? Blperkodu { get; set; }

    public string? Adisoyadi { get; set; }

    public string? Oncekisirketadi { get; set; }

    public string? Oncekiisyerikodu { get; set; }

    public string? Oncekiisyeriadi { get; set; }

    public string? Oncekidepadi { get; set; }

    public string? Yenisirketadi { get; set; }

    public string? Yeniisyerikodu { get; set; }

    public string? Yeniisyeriadi { get; set; }

    public string? Yenidepadi { get; set; }

    public string? Kaydeden { get; set; }
}
