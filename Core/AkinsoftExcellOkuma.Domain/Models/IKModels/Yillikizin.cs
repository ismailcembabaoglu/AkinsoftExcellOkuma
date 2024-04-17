using System;
using System.Collections.Generic;

namespace AkinsoftExcellOkuma.Persistence;

public partial class Yillikizin
{
    public long Blkodu { get; set; }

    public long? Blperkodu { get; set; }

    public DateTime? TalepIslemTar { get; set; }

    public DateTime? TalepTarihiIlk { get; set; }

    public DateTime? TalepTarihiSon { get; set; }

    public string? TalepGerekcesi { get; set; }

    public short? OncekiYilIzin { get; set; }

    public DateTime? OncekiYilIzintarihiIlk { get; set; }

    public DateTime? OncekiYilIzintarihiSon { get; set; }

    public short? DepMudOnay { get; set; }

    public DateTime? DepMudIslemTar { get; set; }

    public short? DepMudTarihUygunDgl { get; set; }

    public DateTime? DepMudTarihIlk { get; set; }

    public DateTime? DepMudTarihSon { get; set; }

    public string? DepMudNot { get; set; }

    public short? IkMudOnay { get; set; }

    public DateTime? IkMudIslemTar { get; set; }

    public short? IkMudTarihUygunDgl { get; set; }

    public DateTime? IkMudTarihIlk { get; set; }

    public DateTime? IkMudTarihSon { get; set; }

    public string? IkMudNot { get; set; }

    public string? Kaydeden { get; set; }

    public string? Degistiren { get; set; }

    public DateTime? DegistirmeTarihi { get; set; }

    public DateTime? OnaylananTarihIlk { get; set; }

    public DateTime? OnaylananTarihSon { get; set; }

    public long? OnayDm { get; set; }

    public long? OnayIk { get; set; }

    public short? Iptal { get; set; }

    public short? ImzaDurumu { get; set; }

    public string? Modul { get; set; }
}
