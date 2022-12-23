using GeneralIntegration.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralIntegration.Infrastructure.Abstract
{
    public interface IReindexResultRepository
    {
        Task<ReindexResult> GetByBaseNameAndDateAsync(string baseName, DateTime date);
    }
}
