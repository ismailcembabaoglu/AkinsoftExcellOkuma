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
    [Authorize]
    public class PuantajCetveliController : ControllerBase
    {
        private readonly IPuantajCetveliService puantajCetveliService;
        public PuantajCetveliController(IPuantajCetveliService _puantajCetveliService)
        {
            puantajCetveliService = _puantajCetveliService;
        }
        [HttpGet("PuantajCetvelis")]
        [AllowAnonymous]
        public async Task<ServiceResponse<List<PuantajCetveliDTO>>> GetPuantajCetvelis()
        {
            return new ServiceResponse<List<PuantajCetveliDTO>>()
            {

                Value = await puantajCetveliService.GetPuantajCetvelis()
            };
        }
        [HttpPost("Create")]
        [AllowAnonymous]
        public async Task<ServiceResponse<PuantajCetveliDTO>> CreatePuantajCetveli([FromBody] PuantajCetveliDTO PuantajCetveli)
        {
            return new ServiceResponse<PuantajCetveliDTO>()
            {
                Value = await puantajCetveliService.CreatePuantajCetveli(PuantajCetveli)
            };
        }
        [HttpPost("Update")]
        [AllowAnonymous]
        public async Task<ServiceResponse<PuantajCetveliDTO>> UpdatePuantajCetveli([FromBody] PuantajCetveliDTO PuantajCetveli)
        {
            return new ServiceResponse<PuantajCetveliDTO>()
            {
                Value = await puantajCetveliService.UpdatePuantajCetveli(PuantajCetveli)
            };
        }
        [HttpPost("Delete")]
        [AllowAnonymous]
        public async Task<ServiceResponse<bool>> DeletePuantajCetveliBlKodu([FromBody] long BlKodu)
        {
            return new ServiceResponse<bool>()
            {
                Value = await puantajCetveliService.DeletePuantajcetveliBlKodu(BlKodu)
            };
        }
        [HttpGet("PuantajCetveliByBlKodu/{BlKodu}")]
        [AllowAnonymous]
        public async Task<ServiceResponse<PuantajCetveliDTO>> GetPuantajCetveliByBlKodu(long BlKodu)
        {
            return new ServiceResponse<PuantajCetveliDTO>()
            {
                Value = await puantajCetveliService.GetPuantajCetveliByBlKodu(BlKodu)
            };
        }
    }
}
