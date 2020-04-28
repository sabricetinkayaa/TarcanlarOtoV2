using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model.Entity
{
    [Table("Cari")]
    class Cari
    {
        [Key]
        public int cariID { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public string birimi { get; set; }
        public string email { get; set; }
        public string tel { get; set; }
        public string adresdetay { get; set; }
        public string ilceID { get; set; }
        public string rolID { get; set; }
    }
}
