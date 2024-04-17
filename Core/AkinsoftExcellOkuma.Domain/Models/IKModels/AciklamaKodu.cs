using System;
using System.Collections.Generic;

namespace AkinsoftExcellOkuma.Persistence;

public partial class AciklamaKodu
{
    public long Blaciklamakodu { get; set; }

    public string Kodu { get; set; } = null!;

    public string? Modul { get; set; }

    public string? Kaydeden { get; set; }

    public string? Degistiren { get; set; }

    public DateTime? DegistirmeTarihi { get; set; }

    public string? Aciklama { get; set; }
}
