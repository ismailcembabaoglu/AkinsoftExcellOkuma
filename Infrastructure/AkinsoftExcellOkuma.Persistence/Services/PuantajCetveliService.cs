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
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace AkinsoftExcellOkuma.Persistence.Services
{

    public class PuantajCetveliService : IPuantajCetveliService
    {
        private readonly IMapper mapper;
        private readonly IConfiguration configuration;
        private readonly Wolvox80012024IkaynakContext context;
        public PuantajCetveliService(IMapper _mapper, IConfiguration _configuration, Wolvox80012024IkaynakContext _context)
        {
            mapper = _mapper;
            configuration = _configuration;
            context = _context;
        }

        public async Task<PuantajCetveliDTO> CreatePuantajCetveli(PuantajCetveliDTO PuantajCetveli)
        {
            var dbPuantajCetveli = await context.PuantajCetvelis.Where(c => c.Blkodu == PuantajCetveli.Blkodu).FirstOrDefaultAsync();
            if (dbPuantajCetveli != null)
                throw new Exception("Bu Puantaj zaten ekli");
            dbPuantajCetveli = mapper.Map<PuantajCetveli>(PuantajCetveli);
            await context.PuantajCetvelis.AddAsync(dbPuantajCetveli);
            int result = await context.SaveChangesAsync();

            return mapper.Map<PuantajCetveliDTO>(dbPuantajCetveli);
        }

        public async Task<bool> DeletePuantajcetveliBlKodu(long BlKodu)
        {
            var dbPuantajCetveli = await context.PuantajCetvelis.Where(c => c.Blkodu == BlKodu).FirstOrDefaultAsync();
            if (dbPuantajCetveli == null)
                throw new Exception("Puantaj Bulunamadı");
            context.PuantajCetvelis.Remove(dbPuantajCetveli);
            int result = await context.SaveChangesAsync();
            return result > 0;
        }

        public async Task<PuantajCetveliDTO> GetPuantajCetveliByBlKodu(long BlKodu)
        {
            var dbPuantajCetveli = await context.PuantajCetvelis.Where(c => c.Blkodu == BlKodu)
                .ProjectTo<PuantajCetveliDTO>(mapper.ConfigurationProvider).FirstOrDefaultAsync();
            if (dbPuantajCetveli == null)
                throw new Exception("Lokasyon Bulunamadı.");
            return dbPuantajCetveli;
        }

        public async Task<List<PuantajCetveliDTO>> GetPuantajCetvelis()
        {
            var dbPuantajCetveli = await context.PuantajCetvelis.ProjectTo<PuantajCetveliDTO>(mapper.ConfigurationProvider).ToListAsync();
            return dbPuantajCetveli;
        }

        public async Task<PuantajCetveliDTO> UpdatePuantajCetveli(PuantajCetveliDTO PuantajCetveli)
        {
            var dbPuantajCetveli = await context.PuantajCetvelis.Where(c => c.Blkodu == PuantajCetveli.Blkodu).FirstOrDefaultAsync();
            if (dbPuantajCetveli == null)
                throw new Exception("Lokasyon Bulunamadığından Dolayı Güncelleme İşlemi Başarısız");
            mapper.Map(PuantajCetveli, dbPuantajCetveli);

            int result = await context.SaveChangesAsync();
            return mapper.Map<PuantajCetveliDTO>(dbPuantajCetveli);
        }
    }
}
