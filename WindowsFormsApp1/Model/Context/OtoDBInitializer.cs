using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Model.Entity;

namespace WindowsFormsApp1.Model.Context
{
    class OtoDBInitializer<T>:DropCreateDatabaseAlways<OtoContext>
    {
        protected override void Seed(OtoContext context)
        {
            IList<UrunDetay> defaultUrundetaylar = new List<UrunDetay>();
            defaultUrundetaylar.Add(new UrunDetay() { UrunMarka = "EMR", UrunModel = "DY418-12", UrunUretimTarihi = DateTime.Now });
            defaultUrundetaylar.Add(new UrunDetay() { UrunMarka = "EMR", UrunModel = "DY453-15", UrunUretimTarihi = DateTime.Now });
            defaultUrundetaylar.Add(new UrunDetay() { UrunMarka = "EMR", UrunModel = "DY500-20", UrunUretimTarihi = DateTime.Now });
            context.UrunDetay.AddRange(defaultUrundetaylar);
            base.Seed(context);
        }
    }
}
