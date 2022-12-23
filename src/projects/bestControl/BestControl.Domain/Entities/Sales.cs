using Core.Domain.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestControl.Domain.Entities
{
    public class Sales : IEntity
    {
        public DateTime DATATIME { get; set; }
        public string DOCTYPE { get; set; }
        public string DOCNUM { get; set; }
        public double STRNUM { get; set; }
        public string IDTOV { get; set; }
        public string KODTOV { get; set; }
        public string TOVAR { get; set; }
        public string BASEEI { get; set; }
        public string STREI { get; set; }
        public double KOLVO { get; set; }
        public double CENA { get; set; }
        public double SEBEST { get; set; }
        public string IDKONTR { get; set; }
        public string KODKON { get; set; }
        public string KONTRAG { get; set; }
        public string IDKL { get; set; }
        public string KODKL { get; set; }
        public string KLIENT { get; set; }
        public string KODUL { get; set; }
        public string URLICO { get; set; }
        public string KODDOG { get; set; }
        public string DOGOVOR { get; set; }
        public string KODSKL { get; set; }
        public string SKLAD { get; set; }
        public string KODPODR { get; set; }
        public string PODRAZD { get; set; }
        public string KODOTV { get; set; }
        public string OTVDOC { get; set; }
        public string IDPOST { get; set; }
        public string POSTAVDOC { get; set; }
        public string DATAZAK { get; set; }
        public string NUMZAK { get; set; }
        public string DATAPART { get; set; }
        public string NUMPART { get; set; }
        public string INFSYS { get; set; }

    }
}
