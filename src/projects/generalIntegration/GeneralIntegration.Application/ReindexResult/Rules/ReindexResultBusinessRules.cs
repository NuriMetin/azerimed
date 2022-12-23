using GeneralIntegration.Infrastructure.Abstract;
using GeneralIntegration.Infrastructure.Concrete;
using GeneralIntegration.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralIntegration.Application.ReindexResult.Rules
{
    public class ReindexResultBusinessRules
    {
        private readonly IReindexResultRepository _reindexResultRepository;

        public ReindexResultBusinessRules(IReindexResultRepository reindexResultRepository)
        {
            _reindexResultRepository = reindexResultRepository;
        }

        public async Task ReindexResultIsLating(string baseName)
        {
            Domain.Entities.ReindexResult reindexResult = await _reindexResultRepository.GetByBaseNameAndDateAsync(baseName, DateTime.Now);

            if (reindexResult == null || reindexResult == default)
                throw new Exception("ReindexResult don't started");

            else if (!reindexResult.IsFinish)
                throw new Exception("ReindexResult is lating");
        }
    }
}
