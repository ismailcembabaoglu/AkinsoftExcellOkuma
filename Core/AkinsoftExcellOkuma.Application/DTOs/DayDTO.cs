using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkinsoftExcellOkuma.Application.DTOs
{
    public class DayDTO
    {
        public string SicilNo { get; set; }
        public short AyKodu { get; set; }
        public string IsyeriKodu { get; set; }
        public string IsyeriAdi { get; set; }
        public int CL { get; set; }
        public int HS { get; set; }
        public int GT { get; set; }
        public int RP { get; set; }
        public int UL { get; set; }
        public int UZ { get; set; }
        public int YL { get; set; }
        public int GM { get; set; }
        public string EksikGun { get; set; }
        public short ToplamPrimGun { get; set; }
        public short ToplamUcretGun { get; set; }
        public double MESAI_HFICI_PNC { get; set; }
        public double MESAI_HFSN_PNC { get; set; }
        public double MESAI_BYRM_PNC { get; set; }
        public double MESAI_HFICI_GECE_PNC { get; set; }
        public double MESAI_HFSN_GECE_PNC { get; set; }
        public double MESAI_BYRM_GECE_PNC { get; set; }
        public short TOPLAM_UZAKTAN_CALISMA { get; set; }
    }
}
