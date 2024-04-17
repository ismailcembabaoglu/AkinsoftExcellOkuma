using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkinsoftExcellOkuma.Persistence.Contexts
{
    public class DesignTimeDbContextFactory :IDesignTimeDbContextFactory<Wolvox80012024IkaynakContext>
    {
        public Wolvox80012024IkaynakContext CreateDbContext(string[] args)
        {
            ConfigurationManager configurationManager = new ConfigurationManager();
            configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/AkinsoftExcellOkuma/Server"));
            configurationManager.AddJsonFile("appsettings.json");
            var builder = new DbContextOptionsBuilder<Wolvox80012024IkaynakContext>();
            //var dbDataSource = new NpgsqlDataSourceBuilder(configurationManager.GetConnectionString("PostgreSql"));
            builder.UseSqlServer(configurationManager.GetConnectionString("Mssql"));
            return new Wolvox80012024IkaynakContext(builder.Options);
        }
    }
}
