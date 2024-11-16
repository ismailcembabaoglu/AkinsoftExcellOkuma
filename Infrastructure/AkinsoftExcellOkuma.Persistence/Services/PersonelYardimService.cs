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
    public class PersonelYardimService:IPersonelYardimService
    {
        private readonly IMapper mapper;
        private readonly IConfiguration configuration;
        private readonly Wolvox80012024IkaynakContext context;
        public PersonelYardimService(IMapper _mapper, IConfiguration _configuration, Wolvox80012024IkaynakContext _context)
        {
            mapper = _mapper;
            configuration = _configuration;
            context = _context;
        }

        public async Task<PersonelYardimDTO> CreatePersonelYardim(PersonelYardimDTO PersonelYardim)
        {
            var blKod = context.Database.SqlQueryRaw<long>($"select  NEXT VALUE FOR  PERSONEL_YARDIM_GEN");
            var dbPersonelYardim = await context.PersonelYardims.Where(c => c.Blkodu == PersonelYardim.Blkodu).FirstOrDefaultAsync();
            if (dbPersonelYardim != null)
                throw new Exception("Bu Yardım zaten ekli");

            dbPersonelYardim = mapper.Map<PersonelYardim>(PersonelYardim);
            dbPersonelYardim.Blkodu = blKod.ToList().FirstOrDefault();
            await context.PersonelYardims.AddAsync(dbPersonelYardim);
            int result = await context.SaveChangesAsync();

            return mapper.Map<PersonelYardimDTO>(dbPersonelYardim);
        }

        public async Task<bool> DeletePersonelYardimBlKodu(long BlKodu)
        {
            var dbPersonelYardim = await context.PersonelYardims.Where(c => c.Blkodu == BlKodu).FirstOrDefaultAsync();
            if (dbPersonelYardim == null)
                throw new Exception("Yardım Bulunamadı");
            context.PersonelYardims.Remove(dbPersonelYardim);
            int result = await context.SaveChangesAsync();
            return result > 0;
        }

        public async Task<PersonelYardimDTO> GetPersonelYardimByBlKodu(long BlKodu,string kodu)
        {
            var dbPersonelYardim = await context.PersonelYardims.Where(c => c.Kodu == kodu && c.Blpersonelkodu==BlKodu)
                .ProjectTo<PersonelYardimDTO>(mapper.ConfigurationProvider).FirstOrDefaultAsync();
            if (dbPersonelYardim == null)
                throw new Exception("Yardım Bulunamadı.");
            return dbPersonelYardim;
        }

        public async Task<List<PersonelYardimDTO>> GetPersonelYardims()
        {
            var dbPersonelYardim = await context.PersonelYardims.ProjectTo<PersonelYardimDTO>(mapper.ConfigurationProvider).ToListAsync();
            return dbPersonelYardim;
        }

        public async Task<PersonelYardimDTO> UpdatePersonelYardim(PersonelYardimDTO PersonelYardim)
        {
            var dbPersonelYardim = await context.PersonelYardims.Where(c => c.Blkodu == PersonelYardim.Blkodu).FirstOrDefaultAsync();
            if (dbPersonelYardim == null)
                throw new Exception("Yardım Bulunamadığından Dolayı Güncelleme İşlemi Başarısız");
            mapper.Map(PersonelYardim, dbPersonelYardim);

            int result = await context.SaveChangesAsync();
            return mapper.Map<PersonelYardimDTO>(dbPersonelYardim);
        }
    }
}
