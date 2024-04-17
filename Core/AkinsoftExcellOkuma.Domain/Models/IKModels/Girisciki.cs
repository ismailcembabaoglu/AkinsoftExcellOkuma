using System;
using System.Collections.Generic;

namespace AkinsoftExcellOkuma.Persistence;

public partial class Girisciki
{
    public long Blkodu { get; set; }

    public long? Blpersonelkodu { get; set; }

    public DateTime? Giristarihi { get; set; }

    public DateTime? Cikistarihi { get; set; }

    public DateTime? Ogiristarihi { get; set; }

    public DateTime? Ocikistarihi { get; set; }

    public string? Giriskapi { get; set; }

    public string? Cikiskapi { get; set; }

    public string? Kaydeden { get; set; }

    public string? Duzenleyen { get; set; }

    public string? Puantoraciklama { get; set; }

    public string? Mazerettanimi { get; set; }

    public double? Yillikizinmiktari { get; set; }

    public short? Tip { get; set; }

    public DateTime? Cikistarihi2 { get; set; }

    public DateTime? Giristarihi2 { get; set; }

    public string? InsIp { get; set; }

    public string? EditIp { get; set; }

    public DateTime? InsZaman { get; set; }

    public DateTime? EditZaman { get; set; }

    public short? InsOrtam { get; set; }

    public short? EditOrtam { get; set; }
}
