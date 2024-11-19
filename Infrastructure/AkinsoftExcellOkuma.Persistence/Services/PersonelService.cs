using AkinsoftExcellOkuma.Application.DTOs.IKDTOs;
using AkinsoftExcellOkuma.Application.IServices;
using AkinsoftExcellOkuma.Persistence.Contexts;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkinsoftExcellOkuma.Persistence.Services
{
    public class PersonelService : IPersonelService
    {
        private readonly IMapper mapper;
        private readonly IConfiguration configuration;
        private readonly Wolvox80012024IkaynakContext context;
        public PersonelService(IMapper _mapper, IConfiguration _configuration, Wolvox80012024IkaynakContext _context)
        {
            mapper = _mapper;
            configuration = _configuration;
            context = _context;
        }

        public async Task<PersonelKesintiDTO> CreateOrUpdateKesinti(PersonelKesintiDTO personelKesinti)
        {
            var dbPersonelKesinti = await context.PersonelKesintis.AsNoTracking().Where(c=>c.Blpersonelkodu==personelKesinti.Blpersonelkodu && c.Kodu==personelKesinti.Kodu).FirstOrDefaultAsync();
            if (dbPersonelKesinti == null)
            {
                personelKesinti.Blkodu = context.Database.SqlQueryRaw<long>($"select  NEXT VALUE FOR  PERSONEL_KESINTI_GEN").ToList().FirstOrDefault();
              var pers=  mapper.Map<PersonelKesinti>(personelKesinti);
               await context.AddAsync(pers);
                await context.SaveChangesAsync();
                return personelKesinti;
            }
            personelKesinti.Blkodu=dbPersonelKesinti.Blkodu;
            mapper.Map(personelKesinti, dbPersonelKesinti);
            context.Update(dbPersonelKesinti);
            await context.SaveChangesAsync();
       return mapper.Map<PersonelKesintiDTO>(dbPersonelKesinti);
        }

        public async Task<PersonelDTO> GetPersonel()
        {
            var dbCarLocation = await context.Personels.ProjectTo<PersonelDTO>(mapper.ConfigurationProvider).FirstOrDefaultAsync();
            return dbCarLocation;
        }

        public async Task<PersonelDTO> GetPersonelByBlKodu(long BlKodu)
        {
            var dbPersonel = await context.Personels.AsNoTracking().ProjectTo<PersonelDTO>(mapper.ConfigurationProvider)
                .Where(c => c.Blkodu == BlKodu).FirstOrDefaultAsync();
            if (dbPersonel == null)
                return new PersonelDTO();
            return dbPersonel;
        }

        public async Task<long> GetPersonelById(string Kodu)
        {
            var dbCarLocation = await context.Personels.Where(c=>c.Kodu==Kodu).FirstOrDefaultAsync() ;
            return dbCarLocation.Blkodu;
        }
    }
}
