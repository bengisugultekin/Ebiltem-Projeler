using System.Collections.Generic;

namespace Projeler.Entity.Models
{
    public class Tema
    {
        public int TemaID { get; set; }

        public string TemaAdi { get; set; }

        public List<Proje> Projeler { get; set; }

    }
}
