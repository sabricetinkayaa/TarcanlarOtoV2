using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Model.Entity;

namespace WindowsFormsApp1.Model.Context
{
    class OtoContext:DbContext
    {
        public OtoContext():base("OtoContext")
        {
            Database.SetInitializer<OtoContext>(new OtoDBInitializer<OtoContext>());
        }
        public DbSet<UrunDetay> UrunDetay { get; set; }
        public DbSet<Stok> Stok { get; set; }

    }
}
