using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkinsoftExcellOkuma.Application.DTOs
{
    public class BordroIndexDTO
    {
        public string? PathName { get; set; }
        public int SicilNo { get; set; }
        public int PrimKodu { get; set; }
        public int PrimTutari { get; set; }
        public int IzinKodu { get; set; }
        public int IzinTutari { get; set; }
        public int KresKodu { get; set; }
        public int KresTutari { get; set; }
        public int AyniKodu { get; set; }
        public int AyniTutari { get; set; }
        public int PuantajTarihi { get; set; }
        public int PuantajAyi { get; set; }
        public int PuantajYili { get; set; }
        public int AvansTutari { get; set; }

    }
}
