using AkinsoftExcellOkuma.Application.DTOs;
using AkinsoftExcellOkuma.Application.IServices;
using AkinsoftExcellOkuma.Application.ResponseModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server.IIS.Core;

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

        [HttpPost("GetPath")]
        [AllowAnonymous]
        public async Task<ServiceResponse<string>> GetPath(IFormFile file)
        {
            if (file == null || file.Length == 0)
                throw new Exception("Dosya Bulunamadı");

            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "uploads", file.FileName);

            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
             var ss=   file.FileName;
            }
            return new ServiceResponse<string>()
            {

                Value = file.FileName
            };
        }
        [HttpPost("Puantajs")]
        [AllowAnonymous]
        public async Task<ServiceResponse<List<DayDTO>>> GetPuantajs(DayIndexDTO dayIndex)
        {
            return new ServiceResponse<List<DayDTO>>()
            {

                Value = await excellImportService.GetExcellPuantajs(dayIndex)
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
