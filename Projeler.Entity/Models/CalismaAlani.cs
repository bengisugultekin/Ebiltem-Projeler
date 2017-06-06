using System.Collections.Generic;

namespace Projeler.Entity.Models
{
    public class CalismaAlani
    {
        public int CalismaAlaniID { get; set; }

        public string CalismaAlaniAdi { get; set; }

        public List<Proje> Projeler { get; set; }
    }
}
