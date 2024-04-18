using AkinsoftExcellOkuma.Application.IServices;
using AkinsoftExcellOkuma.Persistence.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkinsoftExcellOkuma.Persistence.Extensions
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IExcellImportService, ExcellImportService>();
            services.AddScoped<IPersonelService, PersonelService>();
            services.AddScoped<IPuantajCetveliService, PuantajCetveliService>();
            return services;
        }
    }
}
