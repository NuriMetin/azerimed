using Core.Application.Dtos;
using GeneralIntegration.Application.ReindexResult.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralIntegration.Application.ReindexResult.Queries
{
    public class GetReindexResultByBaseNameAndDateQuery : IRequest<Response<ReindexResultDto>>
    {
        public string BaseName { get; set; }
        public DateTime Date { get; set; }
    }
}
