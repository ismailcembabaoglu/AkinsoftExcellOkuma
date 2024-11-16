using AkinsoftExcellOkuma.Application.DTOs.IKDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkinsoftExcellOkuma.Application.IServices
{
    public interface IPersonelAvanService
    {
        public Task<List<PersonelAvanDTO>> GetPersonelAvans();
        public Task<PersonelAvanDTO> CreatePersonelAvan(PersonelAvanDTO PersonelAvan);

        public Task<PersonelAvanDTO> UpdatePersonelAvan(PersonelAvanDTO PersonelAvan);
        public Task<bool> DeletePersonelAvanBlKodu(long BlKodu);
        public Task<PersonelAvanDTO> GetPersonelAvanByBlKodu(long BlKodu);
    }
}
