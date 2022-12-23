using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralIntegration.Infrastructure.Concrete.AdoNet.Commands
{
    internal static class ReindexResultCommands
    {
        internal static string GetByBaseNameAndDateCommand(string baseName, DateTime date)
        {
            return $@"SELECT TOP 1
                           ID
                          ,BaseName
                          ,StartDateTime
                          ,EndDateTime
                          ,IsFinish
                      FROM REINDEXCHECKS
                      WHERE BaseName='{baseName}'
                      ORDER BY ID DESC";
        }
    }
}
