using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model.Entity
{
    [Table("FaturaTip")]
    class FaturaTip
    {
        public int faturatipNo { get; set; }
        public string faturaTuru { get; set; }
    }
}
