using AkinsoftExcellOkuma.Application.DTOs;
using AkinsoftExcellOkuma.Application.DTOs.IKDTOs;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace AkinsoftExcellOkuma.Persistence.Extensions
{
    public static class ConfigureMappingExtension
    {
        public static IServiceCollection ConfigureMapping(this IServiceCollection service)
        {
            var mappingConfig = new MapperConfiguration(mc => { mc.AddProfile(new MappingProfile()); });
            IMapper mapper = mappingConfig.CreateMapper();
            service.AddSingleton(mapper);
            return service;
        }
        public class MappingProfile : Profile
        {
            public MappingProfile()
            {
                AllowNullDestinationValues = true;
                AllowNullCollections = true;

                CreateMap<PersonelDTO, Personel>().ReverseMap();
                CreateMap<PuantajCetveliDTO, PuantajCetveli>().ReverseMap();


            }
        }
    }
}
