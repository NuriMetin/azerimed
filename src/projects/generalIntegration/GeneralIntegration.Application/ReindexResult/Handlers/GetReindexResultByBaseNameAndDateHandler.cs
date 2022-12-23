using AutoMapper;
using Core.Application.Dtos;
using GeneralIntegration.Application.ReindexResult.Dtos;
using GeneralIntegration.Application.ReindexResult.Mapping;
using GeneralIntegration.Domain.Entities;
using GeneralIntegration.Infrastructure.Abstract;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneralIntegration.Application.ReindexResult.Queries;

namespace GeneralIntegration.Application.ReindexResult.Handlers
{
    public class GetReindexResultByBaseNameAndDateHandler : IRequestHandler<GetReindexResultByBaseNameAndDateQuery, Response<ReindexResultDto>>
    {
        private readonly IReindexResultRepository _reindexResultRepository;
        private readonly IMapper _mapper;
        public GetReindexResultByBaseNameAndDateHandler(IReindexResultRepository reindexResultRepository, IMapper mapper)
        {
            _reindexResultRepository = reindexResultRepository;
            _mapper = mapper;
        }

        public async Task<Response<ReindexResultDto>> Handle(GetReindexResultByBaseNameAndDateQuery request, CancellationToken cancellationToken)
        {
            var reindexResult = await _reindexResultRepository.GetByBaseNameAndDateAsync(request.BaseName, request.Date);

            if (reindexResult == null || reindexResult == default)
                return Response<ReindexResultDto>.Success(new ReindexResultDto(), 200);

            ReindexResultDto reindexResultDto = _mapper.Map<ReindexResultDto>(reindexResult);

            return Response<ReindexResultDto>.Success(reindexResultDto, 200);
        }
    }
}
