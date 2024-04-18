using AkinsoftExcellOkuma.Application.DTOs.IKDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkinsoftExcellOkuma.Application.IServices
{
    public interface IPuantajCetveliService
    {
        public Task<List<PuantajCetveliDTO>> GetPuantajCetvelis();
        public Task<PuantajCetveliDTO> CreatePuantajCetveli(PuantajCetveliDTO PuantajCetveli);

        public Task<PuantajCetveliDTO> UpdatePuantajCetveli(PuantajCetveliDTO PuantajCetveli);
        public Task<bool> DeletePuantajcetveliBlKodu(long BlKodu);
        public Task<PuantajCetveliDTO> GetPuantajCetveliByBlKodu(long BlKodu);
    }
}
