using AutoMapper;
using Core.Infrastructure.Paging;
using GeneralIntegration.Application.ReindexResult.Dtos;
using GeneralIntegration.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralIntegration.Application.ReindexResult.Mapping
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Domain.Entities.ReindexResult, ReindexResultDto>();
        }
    }
}
