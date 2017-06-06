using System.Collections.Generic;

namespace Projeler.Entity.Models
{
    public class Yurutucu
    {
        public int YurutucuID { get; set; }

        public string YurutucuAdi { get; set; }

        public List<Proje> Projeler { get; set; }

    }
}
