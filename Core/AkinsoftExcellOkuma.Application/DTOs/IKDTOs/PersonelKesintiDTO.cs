using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkinsoftExcellOkuma.Application.DTOs.IKDTOs
{
    public class PersonelKesintiDTO
    {
        public long Blkodu { get; set; }

        public long? Blpersonelkodu { get; set; }

        public string? Kodu { get; set; }

        public string? Kesinti { get; set; }

        public double? Tutari { get; set; }

        public string? MuhKodu { get; set; }

        public short? NetMaasiEtkilesin { get; set; }

        public short? GvIndirimiUygula { get; set; }

        public double? GvIndUstSinir { get; set; }
    }
}
