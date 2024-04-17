using System;
using System.Collections.Generic;

namespace AkinsoftExcellOkuma.Persistence;

public partial class Ozelalantanim
{
    public long Blkodu { get; set; }

    public long? Blgrupkodu { get; set; }

    public string? Baslik { get; set; }

    public short? Aktif { get; set; }

    public int? Siralama { get; set; }

    public int? Veritipi { get; set; }

    public string? Secenekler { get; set; }

    public short? Filtrelemeaktif { get; set; }

    public int? Uzunluk { get; set; }

    public string? Displayformat { get; set; }

    public short? ComboReadonly { get; set; }
}
