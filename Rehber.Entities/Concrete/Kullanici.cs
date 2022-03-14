using Rehber.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rehber.Entities.Concrete
{
    public class Kullanici : BaseEntity
    {
        public string Ad { get; set; }
        public string SoyAd { get; set; }
        public string Telefon { get; set; }
    }
}
