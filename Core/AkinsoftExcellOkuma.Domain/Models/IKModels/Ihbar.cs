using System;
using System.Collections.Generic;

namespace AkinsoftExcellOkuma.Persistence;

public partial class Ihbar
{
    public long Blkodu { get; set; }

    public string? IsyeriKodu { get; set; }

    public string? IsyeriAdi { get; set; }

    public double? AylikUcreti { get; set; }

    public double? AylikEkgelirler { get; set; }

    public double? BirikimMatrahi { get; set; }

    public double? HafUcret { get; set; }

    public double? HafEkgelirler { get; set; }

    public double? HafToplami { get; set; }

    public short? CalismaSuresi { get; set; }

    public short? HaftaSayisi { get; set; }

    public double? IhbarTazminati { get; set; }

    public double? GelirVergisi { get; set; }

    public double? DamgaVergisi { get; set; }

    public double? NetTazminat { get; set; }

    public long? Blperskodu { get; set; }
}
