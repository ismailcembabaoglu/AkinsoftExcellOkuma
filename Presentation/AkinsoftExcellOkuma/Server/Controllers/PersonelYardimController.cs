using AkinsoftExcellOkuma.Application.DTOs.IKDTOs;
using AkinsoftExcellOkuma.Application.IServices;
using AkinsoftExcellOkuma.Application.ResponseModels;
using AkinsoftExcellOkuma.Persistence.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AkinsoftExcellOkuma.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonelYardimController : ControllerBase
    {
        private readonly IPersonelYardimService personelYardimService;
        public PersonelYardimController(IPersonelYardimService _personelYardimService)
        {
            personelYardimService = _personelYardimService;
        }
        [HttpGet("PersonelYardims")]
        [AllowAnonymous]
        public async Task<ServiceResponse<List<PersonelYardimDTO>>> GetPersonelYardims()
        {
            return new ServiceResponse<List<PersonelYardimDTO>>()
            {

                Value = await personelYardimService.GetPersonelYardims()
            };
        }
        [HttpPost("Create")]
        [AllowAnonymous]
        public async Task<ServiceResponse<PersonelYardimDTO>> CreatePersonelYardim([FromBody] PersonelYardimDTO PersonelYardim)
        {
            return new ServiceResponse<PersonelYardimDTO>()
            {
                Value = await personelYardimService.CreatePersonelYardim(PersonelYardim)
            };
        }
        [HttpPost("Update")]
        [AllowAnonymous]
        public async Task<ServiceResponse<PersonelYardimDTO>> UpdatePersonelYardim([FromBody] PersonelYardimDTO PersonelYardim)
        {
            return new ServiceResponse<PersonelYardimDTO>()
            {
                Value = await personelYardimService.UpdatePersonelYardim(PersonelYardim)
            };
        }
        [HttpPost("Delete")]
        [AllowAnonymous]
        public async Task<ServiceResponse<bool>> DeletePersonelYardimBlKodu([FromBody] long BlKodu)
        {
            return new ServiceResponse<bool>()
            {
                Value = await personelYardimService.DeletePersonelYardimBlKodu(BlKodu)
            };
        }
        [HttpGet("PersonelYardimByBlKodu/{BlKodu}/{kodu}")]
        [AllowAnonymous]
        public async Task<ServiceResponse<PersonelYardimDTO>> GetPersonelYardimByBlKodu(long BlKodu, string kodu)
        {
            return new ServiceResponse<PersonelYardimDTO>()
            {
                Value = await personelYardimService.GetPersonelYardimByBlKodu(BlKodu,kodu)
            };
        }
    }
}
