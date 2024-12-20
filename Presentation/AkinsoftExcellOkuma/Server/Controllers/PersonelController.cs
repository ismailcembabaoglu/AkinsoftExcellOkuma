﻿using AkinsoftExcellOkuma.Application.DTOs;
using AkinsoftExcellOkuma.Application.DTOs.IKDTOs;
using AkinsoftExcellOkuma.Application.IServices;
using AkinsoftExcellOkuma.Application.ResponseModels;
using AkinsoftExcellOkuma.Persistence.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AkinsoftExcellOkuma.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class PersonelController : ControllerBase
    {
        private readonly IPersonelService personelService;
        public PersonelController(IPersonelService _personelService)
        {
            personelService= _personelService;
        }
        [HttpGet("PersonelById/{Kodu}")]
        [AllowAnonymous]
        public async Task<ServiceResponse<long>> GetPersonelByIdKod(string Kodu)
        {
            return new ServiceResponse<long>()
            {

                Value = await personelService.GetPersonelById(Kodu)
            };
        }
        [HttpPost("CreateOrUpdatePersonelKesinti")]
        [AllowAnonymous]
        public async Task<ServiceResponse<PersonelKesintiDTO>> CreateOrUpdatePersonelKesinti([FromBody] PersonelKesintiDTO personelKesinti)
        {
            return new ServiceResponse<PersonelKesintiDTO>()
            {
                Value = await personelService.CreateOrUpdateKesinti(personelKesinti)
            };
        }
        [HttpGet("Personel")]
        [AllowAnonymous]
        public async Task<ServiceResponse<PersonelDTO>> GetCar()
        {
            return new ServiceResponse<PersonelDTO>()
            {

                Value = await personelService.GetPersonel()
            };
        }
        [HttpGet("GetPersonelById/{Blkodu}")]
        [AllowAnonymous]
        public async Task<ServiceResponse<PersonelDTO>> GetPersonelById(long Blkodu)
        {
            return new ServiceResponse<PersonelDTO>()
            {

                Value = await personelService.GetPersonelByBlKodu(Blkodu)
            };
        }
    }
}
