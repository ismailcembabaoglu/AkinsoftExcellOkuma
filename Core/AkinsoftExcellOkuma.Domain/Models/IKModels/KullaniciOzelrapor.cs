using System;
using System.Collections.Generic;

namespace AkinsoftExcellOkuma.Persistence;

public partial class KullaniciOzelrapor
{
    public long Blkodu { get; set; }

    public short? Surum { get; set; }

    public short? Dbindex { get; set; }

    public string? Raporadi { get; set; }

    public string? Prgkodu { get; set; }

    public string? Sql { get; set; }

    public string? Params { get; set; }

    public string? Paramstype { get; set; }

    public string? Oncalcfields { get; set; }

    public string? Ongetcellparams { get; set; }

    public string? Griddblclick { get; set; }

    public string? Kaydeden { get; set; }

    public string? Degistiren { get; set; }

    public DateTime? KayitTarihi { get; set; }

    public DateTime? DegistirmeTarihi { get; set; }

    public string? Yetkiler { get; set; }

    public short? Psscript { get; set; }
}
