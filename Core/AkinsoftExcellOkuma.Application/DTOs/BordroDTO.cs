using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkinsoftExcellOkuma.Application.DTOs
{
    public class BordroDTO
    {
        public string? SicilNo { get; set; }
        public string? PrimKodu { get; set; }
        public double? PrimTutari { get; set; }
        public string? IzinKodu { get; set; }
        public double? IzinTutari { get; set; }
        public string? KresKodu { get; set; }
        public double? KresTutari { get; set; }
        public string? AyniKodu { get; set; }
        public double? AyniTutari { get; set; }
        public string? PuantajTarihi { get; set; }
        public int? PuantajAyi { get; set; }
        public int? PuantajYili { get; set; }
        public double? AvansTutari { get; set; }
    }
}
