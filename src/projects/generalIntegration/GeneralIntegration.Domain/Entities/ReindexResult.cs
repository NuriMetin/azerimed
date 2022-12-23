using Core.Domain.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralIntegration.Domain.Entities
{
    public class ReindexResult : IEntity
    {
        public int ID { get; set; }
        public string BaseName { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public bool IsFinish { get; set; }
    }
}
