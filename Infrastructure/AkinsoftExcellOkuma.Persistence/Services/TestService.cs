using AkinsoftExcellOkuma.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkinsoftExcellOkuma.Persistence.Services
{
    public class TestService
    {
        private readonly Wolvox80012024IkaynakContext context;
        private readonly IConfiguration configuration;

        public TestService(Wolvox80012024IkaynakContext _context,IConfiguration _configuration)
        {
            context = _context;
            configuration=_configuration;
        }
        public async Task<Personel> GetPersonel()
        {
            var db = await context.Personels.FirstOrDefaultAsync();
            return db;
        }
    }
}
