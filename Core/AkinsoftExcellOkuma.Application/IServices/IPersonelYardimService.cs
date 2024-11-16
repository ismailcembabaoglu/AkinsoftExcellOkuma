using AkinsoftExcellOkuma.Application.DTOs.IKDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkinsoftExcellOkuma.Application.IServices
{
    public interface IPersonelYardimService
    {
        public Task<List<PersonelYardimDTO>> GetPersonelYardims();
        public Task<PersonelYardimDTO> CreatePersonelYardim(PersonelYardimDTO PersonelYardim);

        public Task<PersonelYardimDTO> UpdatePersonelYardim(PersonelYardimDTO PersonelYardim);
        public Task<bool> DeletePersonelYardimBlKodu(long BlKodu);
        public Task<PersonelYardimDTO> GetPersonelYardimByBlKodu(long BlKodu, string kodu);
    }
}
