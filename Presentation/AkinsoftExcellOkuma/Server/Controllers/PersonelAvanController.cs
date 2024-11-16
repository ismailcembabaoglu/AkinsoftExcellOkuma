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
    public class PersonelAvanController : ControllerBase
    {
        private readonly IPersonelAvanService personelAvanService;
        public PersonelAvanController(IPersonelAvanService _personelAvanService)
        {
            personelAvanService = _personelAvanService;
        }
        [HttpGet("PersonelAvans")]
        [AllowAnonymous]
        public async Task<ServiceResponse<List<PersonelAvanDTO>>> GetPersonelAvans()
        {
            return new ServiceResponse<List<PersonelAvanDTO>>()
            {

                Value = await personelAvanService.GetPersonelAvans()
            };
        }
        [HttpPost("Create")]
        [AllowAnonymous]
        public async Task<ServiceResponse<PersonelAvanDTO>> CreatePersonelAvan([FromBody] PersonelAvanDTO PersonelAvan)
        {
            return new ServiceResponse<PersonelAvanDTO>()
            {
                Value = await personelAvanService.CreatePersonelAvan(PersonelAvan)
            };
        }
        [HttpPost("Update")]
        [AllowAnonymous]
        public async Task<ServiceResponse<PersonelAvanDTO>> UpdatePersonelAvan([FromBody] PersonelAvanDTO PersonelAvan)
        {
            return new ServiceResponse<PersonelAvanDTO>()
            {
                Value = await personelAvanService.UpdatePersonelAvan(PersonelAvan)
            };
        }
        [HttpPost("Delete")]
        [AllowAnonymous]
        public async Task<ServiceResponse<bool>> DeletePersonelAvanBlKodu([FromBody] long BlKodu)
        {
            return new ServiceResponse<bool>()
            {
                Value = await personelAvanService.DeletePersonelAvanBlKodu(BlKodu)
            };
        }
        [HttpGet("PersonelAvanByBlKodu/{BlKodu}")]
        [AllowAnonymous]
        public async Task<ServiceResponse<PersonelAvanDTO>> GetPersonelAvanByBlKodu(long BlKodu)
        {
            return new ServiceResponse<PersonelAvanDTO>()
            {
                Value = await personelAvanService.GetPersonelAvanByBlKodu(BlKodu)
            };
        }
    }
}
