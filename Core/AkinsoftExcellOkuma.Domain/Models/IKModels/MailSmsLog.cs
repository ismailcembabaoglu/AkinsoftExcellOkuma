using System;
using System.Collections.Generic;

namespace AkinsoftExcellOkuma.Persistence;

public partial class MailSmsLog
{
    public long Blkodu { get; set; }

    public string? Modul { get; set; }

    public long? Blmaskodu { get; set; }

    public short? GonderimTipi { get; set; }

    public string? AliciAdres { get; set; }

    public string? Konu { get; set; }

    public string? Mesaj { get; set; }

    public DateTime? Tarihi { get; set; }

    public string? Kaydeden { get; set; }

    public string? Modul2 { get; set; }

    public long? Blmaskodu2 { get; set; }
}
