using AkinsoftExcellOkuma.Application.DTOs.IKDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkinsoftExcellOkuma.Application.IServices
{
    public interface IPersonelService
    {
        public Task<long> GetPersonelById(string Kodu);
        public Task<PersonelDTO> GetPersonel();
    }
}
