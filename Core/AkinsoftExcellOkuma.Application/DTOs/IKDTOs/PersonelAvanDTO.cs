using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkinsoftExcellOkuma.Application.DTOs.IKDTOs
{
    public class PersonelAvanDTO
    {
        public long Blkodu { get; set; }

        public long? Blmaskodu { get; set; }

        public DateTime? Tarihi { get; set; }

        public short? PuantajAyi { get; set; }

        public short? PuantajYili { get; set; }

        public string? Aciklama { get; set; }

        public double? Tutari { get; set; }
    }
}
