using Core.Domain.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestControl.Domain.Entities
{
    public class Dvost: IEntity
    {
        public DateTime DATATIME { get; set; }
        public string KODTOV { get; set; }
        public string IDTOV { get; set; }
        public string TOVAR { get; set; }
        public string HARAKT { get; set; }
        public string BASEEI { get; set; }
        public string STREI { get; set; }
        public double KOLVO { get; set; }
        public double PRIHKOL { get; set; }
        public double RASHKOL { get; set; }
        public double PRIHRUB { get; set; }
        public double RASHRUB { get; set; }
        public double CENA { get; set; }
        public string KODUL { get; set; }
        public string URLICO { get; set; }
        public string KODSKL { get; set; }
        public string SKLAD { get; set; }
        public string KODPOST { get; set; }
        public string IDPOST { get; set; }
        public string POSTAVDOC { get; set; }
        public string KODZAKUP { get; set; }
        public string ZAKUP { get; set; }
        public string DATAPART { get; set; }
        public string NUMPART { get; set; }
        public string INFSYS { get; set; }
    }
}
