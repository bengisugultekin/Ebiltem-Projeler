using System;
using System.Collections.Generic;

namespace Projeler.Entity.Models
{
    public enum ProjeTipi
    {
        Hibe,
        Ortaklıklar,
    }

    public class Proje
    {
        public int ProjeID { get; set; }

        public string ProjeReferansNo { get; set; }

        public string Baslik { get; set; }

        public int KaynakID { get; set; }

        public ProjeTipi _ProjeTipi { get; set; }

        public List<CalismaAlani> CalismaAlanlari { get; set; }

        public List<Tema> Temalar { get; set; }

        public List<Yurutucu> Yurutuculer { get; set; }

        public double Butce { get; set; }
        
        public string SonBasvuruTarihi { get; set; }

        public string Icerik { get; set; }

        public string Link { get; set; }

        public List<AnahtarKelime> AnahtarKelimeler { get; set; }

        //mapping
        public Kaynak Kaynak { get; set; }        
    }

   
}
