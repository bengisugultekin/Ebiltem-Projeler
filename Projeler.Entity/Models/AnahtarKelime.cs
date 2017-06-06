using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeler.Entity.Models
{
    public class AnahtarKelime
    {
        public int AnahtarKelimeID { get; set; }

        public string AnahtarKelimeAdi { get; set; }

        public List<Proje> Projeler { get; set; }
    }
}
