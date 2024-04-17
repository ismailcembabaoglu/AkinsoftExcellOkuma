using System;
using System.Collections.Generic;

namespace AkinsoftExcellOkuma.Persistence;

public partial class PerfDegerPuanlama
{
    public long Blkodu { get; set; }

    public long? Blpdtkodu { get; set; }

    public long? BlprPuanverenKodu { get; set; }

    public long? BlpdPuanalanKodu { get; set; }

    public long? Blsrkodu { get; set; }

    public long? Blsrdtkodu { get; set; }

    public double? Puan { get; set; }
}
