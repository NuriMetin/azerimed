using Core.Infrastructure.AdoNet;
using GeneralIntegration.Domain.Entities;
using GeneralIntegration.Infrastructure.Abstract;
using GeneralIntegration.Infrastructure.Concrete.AdoNet.Commands;
using GeneralIntegration.Infrastructure.Concrete.AdoNet.DatabaseConnections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralIntegration.Infrastructure.Concrete
{
    public class ReindexResultRepository : AdoNetRepositoryBase<ReindexResult>, IReindexResultRepository
    {
        public async Task<ReindexResult> GetByBaseNameAndDateAsync(string baseName, DateTime date)
        {
            return await GetAsync<ReindexResult>(ReindexResultCommands.GetByBaseNameAndDateCommand(baseName, date), ConnectionStrings.TestRep);
        }
    }
}
