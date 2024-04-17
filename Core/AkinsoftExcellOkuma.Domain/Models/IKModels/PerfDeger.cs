using System;
using System.Collections.Generic;

namespace AkinsoftExcellOkuma.Persistence;

public partial class PerfDeger
{
    public long Blkodu { get; set; }

    public long? Blpdtkodu { get; set; }

    public long? Blprkodu { get; set; }

    public short? Degerlendir { get; set; }

    public short? Kendisi { get; set; }

    public string? UstperBlkodu { get; set; }

    public int? UstperSayisi { get; set; }

    public int? UstperMin { get; set; }

    public int? UstperMax { get; set; }

    public string? AstperBlkodu { get; set; }

    public int? AstperSayisi { get; set; }

    public int? AstperMin { get; set; }

    public int? AstperMax { get; set; }

    public string? DigerperBlkodu { get; set; }

    public int? DigerperSayisi { get; set; }

    public int? DigerperMin { get; set; }

    public int? DigerperMax { get; set; }

    public string? KuralBlkodu { get; set; }

    public int? KuralKisisayisi { get; set; }

    public short? SecimYapildi { get; set; }

    public short? PuanlamaYapildi { get; set; }

    public double? YetkinlikPuani { get; set; }

    public short? BilgimetniOnay { get; set; }

    public short? Sirano { get; set; }
}
