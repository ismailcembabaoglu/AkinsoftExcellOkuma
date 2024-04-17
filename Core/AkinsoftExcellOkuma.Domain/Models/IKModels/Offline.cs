using System;
using System.Collections.Generic;

namespace AkinsoftExcellOkuma.Persistence;

public partial class Offline
{
    public long Blkodu { get; set; }

    public short? Makineno { get; set; }

    public long? Personelno { get; set; }

    public short? Emakineno { get; set; }

    public short? Verifymode { get; set; }

    public short? Giriscikis { get; set; }

    public DateTime? Tarih { get; set; }

    public short? Islendi { get; set; }

    public short? Kaynak { get; set; }

    public short? Tip { get; set; }

    public string? Aciklama { get; set; }

    public DateTime? MesaiBaslama { get; set; }

    public DateTime? MesaiBitis { get; set; }
}
