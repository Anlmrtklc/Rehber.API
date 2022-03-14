using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rehber.Entities.Abstract
{
    public abstract class BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public bool Aktif { get; set; }
        public DateTime OlusturmaTarih { get; set; }
        public DateTime GuncellemeTarih { get; set; }
    }
}
