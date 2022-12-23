using AutoMapper;
using Core.Application.Dtos;
using Core.Application.Services.BackgroundServices;
using GeneralIntegration.Application.ReindexResult.Dtos;
using GeneralIntegration.Application.ReindexResult.Queries;
using GeneralIntegration.Infrastructure.Abstract;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralIntegration.Application.ReindexResult.Services.BackgroundServices
{
    public class ReindexResultBackgroundService : IReindexResultBackgroundService
    {
        private static readonly object Lock = new object();

        private readonly IReindexResultRepository _reindexResultRepository;
        private readonly IMapper _mapper;
        public ReindexResultBackgroundService(IReindexResultRepository reindexResultRepository, IMapper mapper)
        {
            _reindexResultRepository = reindexResultRepository;
            _mapper = mapper;
        }

        public async Task InvokeServiceAsync()
        {
            var reindexResult = await _reindexResultRepository.GetByBaseNameAndDateAsync("LOGO", DateTime.Now);
            ReindexResultDto reindexResultDto;
            if (reindexResult != null || reindexResult != default)
                reindexResultDto = _mapper.Map<ReindexResultDto>(reindexResult);

        }

        public async Task LockService()
        {
            lock (Lock)
            {
                InvokeServiceAsync().GetAwaiter().GetResult();
            }
        }
    }
}
