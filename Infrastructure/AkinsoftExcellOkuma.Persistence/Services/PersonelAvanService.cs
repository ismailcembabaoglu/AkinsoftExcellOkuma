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
    public class PersonelAvanService:IPersonelAvanService
    {
        private readonly IMapper mapper;
        private readonly IConfiguration configuration;
        private readonly Wolvox80012024IkaynakContext context;
        public PersonelAvanService(IMapper _mapper, IConfiguration _configuration, Wolvox80012024IkaynakContext _context)
        {
            mapper = _mapper;
            configuration = _configuration;
            context = _context;
        }

        public async Task<PersonelAvanDTO> CreatePersonelAvan(PersonelAvanDTO PersonelAvan)
        {
            var blKod = context.Database.SqlQueryRaw<long>($"select  NEXT VALUE FOR  PERSONEL_AVANS_GEN");
            var dbPersonelAvan = await context.PersonelAvans.Where(c => c.Blkodu == PersonelAvan.Blkodu).FirstOrDefaultAsync();
            if (dbPersonelAvan != null)
                throw new Exception("Bu Avans zaten ekli");

            dbPersonelAvan = mapper.Map<PersonelAvan>(PersonelAvan);
            dbPersonelAvan.Blkodu = blKod.ToList().FirstOrDefault();
            await context.PersonelAvans.AddAsync(dbPersonelAvan);
            int result = await context.SaveChangesAsync();

            return mapper.Map<PersonelAvanDTO>(dbPersonelAvan);
        }

        public async Task<bool> DeletePersonelAvanBlKodu(long BlKodu)
        {
            var dbPersonelAvan = await context.PersonelAvans.Where(c => c.Blkodu == BlKodu).FirstOrDefaultAsync();
            if (dbPersonelAvan == null)
                throw new Exception("Avans Bulunamadı");
            context.PersonelAvans.Remove(dbPersonelAvan);
            int result = await context.SaveChangesAsync();
            return result > 0;
        }

        public async Task<PersonelAvanDTO> GetPersonelAvanByBlKodu(long BlKodu)
        {
            var dbPersonelAvan = await context.PersonelAvans.Where(c => c.Blkodu == BlKodu)
                .ProjectTo<PersonelAvanDTO>(mapper.ConfigurationProvider).FirstOrDefaultAsync();
            if (dbPersonelAvan == null)
                throw new Exception("Avans Bulunamadı.");
            return dbPersonelAvan;
        }

        public async Task<List<PersonelAvanDTO>> GetPersonelAvans()
        {
            var dbPersonelAvan = await context.PersonelAvans.ProjectTo<PersonelAvanDTO>(mapper.ConfigurationProvider).ToListAsync();
            return dbPersonelAvan;
        }

        public async Task<PersonelAvanDTO> UpdatePersonelAvan(PersonelAvanDTO PersonelAvan)
        {
            var dbPersonelAvan = await context.PersonelAvans.Where(c => c.Blkodu == PersonelAvan.Blkodu).FirstOrDefaultAsync();
            if (dbPersonelAvan == null)
                throw new Exception("Avans Bulunamadığından Dolayı Güncelleme İşlemi Başarısız");
            mapper.Map(PersonelAvan, dbPersonelAvan);

            int result = await context.SaveChangesAsync();
            return mapper.Map<PersonelAvanDTO>(dbPersonelAvan);
        }
    }
}
