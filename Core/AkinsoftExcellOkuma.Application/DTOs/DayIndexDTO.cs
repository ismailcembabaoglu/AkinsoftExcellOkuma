using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkinsoftExcellOkuma.Application.DTOs
{
    public class DayIndexDTO
    {
        public string PathName { get; set; }
        public int SicilNo { get; set; }
        public int AyKodu { get; set; }
        public int IsyeriKodu { get; set; }
        public int IsyeriAdi { get; set; }
        public int CL { get; set; }
        public int HS { get; set; }
        public int GT { get; set; }
        public int RP { get; set; }
        public int UL { get; set; }
        public int UZ { get; set; }
        public int YL { get; set; }
        public int GM { get; set; }
        public int EksikGun { get; set; }
        public int ToplamPrimGun { get; set; }
        public int ToplamUcretGun { get; set; }
        public int MESAI_HFICI_PNC { get; set; }
        public int MESAI_HFSN_PNC { get; set; }
        public int MESAI_BYRM_PNC { get; set; }
        public int MESAI_HFICI_GECE_PNC { get; set; }
        public int MESAI_HFSN_GECE_PNC { get; set; }
        public int MESAI_BYRM_GECE_PNC { get; set; }
        public int TOPLAM_UZAKTAN_CALISMA { get; set; }
    }
}
