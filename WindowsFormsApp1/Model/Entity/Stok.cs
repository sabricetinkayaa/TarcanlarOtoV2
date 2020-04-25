using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model.Entity
{
    [Table("Stok")]
    class Stok
    {
        [Key]
        public int UrunId { get; set; }
        public UrunDetay UrunDetayId { get; set; }
        public int Adet { get; set; }
        public string Birimi { get; set; }
    }
}
