using System;
using System.Collections.Generic;

namespace AkinsoftExcellOkuma.Persistence;

public partial class BioCihaz
{
    public long Blkodu { get; set; }

    public string? IsyeriKodu { get; set; }

    public string? Cihazid { get; set; }

    public string? Tanim { get; set; }

    public string? Ip { get; set; }

    public int? Port { get; set; }

    public short? Iletisim { get; set; }

    public string? Comport { get; set; }

    public int? Hiz { get; set; }

    public short? Clsmod { get; set; }

    public short? ImportAfter { get; set; }

    public short? Pasif { get; set; }

    public short? CihazTipi { get; set; }

    public short? CekilecekVeriTuru { get; set; }
}
