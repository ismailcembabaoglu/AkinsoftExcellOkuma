using AkinsoftExcellOkuma.Application.DTOs;
using AkinsoftExcellOkuma.Application.IServices;
using AkinsoftExcellOkuma.Application.ResponseModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AkinsoftExcellOkuma.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class PuantajController : ControllerBase
    {
        private readonly IExcellImportService excellImportService;
        public PuantajController(IExcellImportService _excellImportService)
        {
            excellImportService = _excellImportService; 
        }
        [HttpPost("Puantajs")]
        [AllowAnonymous]
        public async Task<ServiceResponse<List<DayDTO>>> GetPuantajs(string PathName,DayIndexDTO dayIndex)
        {
            return new ServiceResponse<List<DayDTO>>()
            {

                Value = await excellImportService.GetExcellPuantajs($"{PathName}",dayIndex)
            };
        }
        [HttpGet("Tatils/{Year}/{Month}")]
        [AllowAnonymous]
        public  ServiceResponse<List<TatilDTO>> GetTatils(int Year, int Month)
        {
            return new ServiceResponse<List<TatilDTO>>()
            {

                Value =  excellImportService.GetTatils(Year,Month)
            };
        }
        [HttpGet("Cleander/{Year}/{Month}")]
        [AllowAnonymous]
        public async Task< ServiceResponse<List<TatilDTO>>> GetCleanders(int Year, int Month)
        {
            return new ServiceResponse<List<TatilDTO>>()
            {

                Value = await excellImportService.GetCleanders(Year,Month)
            };
        }
    }
}
