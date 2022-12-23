using Core.Domain.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestControl.Domain.Entities
{
    public class Tovar : IEntity
    {
        public string KODTOV { get; set; }
        public string IDTOV { get; set; }
        public string TOVAR { get; set; }
        public string TOVARPN { get; set; }
        public string ARTIKUL { get; set; }
        public string BASEEI { get; set; }
        public string VES { get; set; }
        public string KODZAKUP { get; set; }
        public string ZAKUP { get; set; }
        public string KODPOST { get; set; }
        public string IDPOST { get; set; }
        public string POSTAV { get; set; }
        public string VID { get; set; }
        public string GRUPPA { get; set; }
        public string URTOV1 { get; set; }
        public string URTOV2 { get; set; }
        public string URTOV3 { get; set; }
        public string URTOV4 { get; set; }
        public string URTOV5 { get; set; }
        public string URTOV6 { get; set; }
        public string URTOV7 { get; set; }
        public string INFSYS { get; set; }
    }
}
