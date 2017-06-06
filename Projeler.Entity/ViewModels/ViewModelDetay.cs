using Projeler.Entity.Models;
using System.Collections.Generic;


namespace Projeler.Entity.ViewModels
{
    public class ViewModelDetay
    {
        public int ProjeID { get; set; }


        public string Baslik { get; set; }

        public string ProjeReferansNo { get; set; }

        public double Butce { get; set; }

        public string Icerik { get; set; }

        public string Link { get; set; }

        public List<AnahtarKelime> AnahtarKelimeler { get; set; }

        public string KaynakAdi { get; set; }

        public ProjeTipi ProjeTipi { get; set; }

        public List<CalismaAlani> CalismaAlanlari { get; set; }

        public List<Tema> Temalar { get; set; }

        public List<Yurutucu> Yurutuculer { get; set; }

        public string SonBasvuruTarihi { get; set; }

    }
}
