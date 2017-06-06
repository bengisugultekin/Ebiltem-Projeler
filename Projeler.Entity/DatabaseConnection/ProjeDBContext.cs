namespace Projeler.Entity.DatabaseConnection
{
    using Projeler.Entity.Models;
    using System.Collections.Generic;
    using System.Data.Entity;

    public class ProjectDBContext : DbContext
    {

        public ProjectDBContext()
            : base("name=ProjeDB")
        {
            Database.SetInitializer(new ProjectDBInitializer());
        }

        public virtual DbSet<Proje> Proje { get; set; }
        public virtual DbSet<Kaynak> Kaynak { get; set; }
        public virtual DbSet<Tema> Tema { get; set; }
        public virtual DbSet<Yurutucu> Yurutucu { get; set; }
        public virtual DbSet<CalismaAlani> CalismaAlani { get; set; }
        public virtual DbSet<AnahtarKelime> AnahtarKelime { get; set; }

        public class ProjectDBInitializer : CreateDatabaseIfNotExists<ProjectDBContext>
        {
            protected override void Seed(ProjectDBContext context)
            {            
                var proje1 = new Proje()
                {
                    Baslik = "TÜBİTAK-1503- Proje Pazarları Destekleme Programı",
                    Butce = 60000,
                    Icerik = "Proje pazarları, somut Ar-Ge düşünce ya da proje önerilerine sahip olup, bunları gerçekleştirmek için kendi yetenekleri dışında başka uzmanlık alanlarında katkıya gereksinim duyan, proje öneri veya sonuçlarına ilişkin talep varlığını araştıran, arz edilen proje işbirliği önerilerine teknolojik veya finansal katkıda bulunmak isteyen, üniversite, araştırma ve özel sektör kuruluşlarından temsilcilerin bir araya gelerek aktif katılımları ile projelerini birbirlerine tanıtmaları yoluyla işbirliği olanaklarına ortam oluşturulmasına yönelik düzenlenen ulusal ve/veya uluslar arası etkinliklerdir.",
                    KaynakID = 1,
                    Link = "http://www.tubitak.gov.tr/tr/destekler/sanayi/ulusal-destek-programlari/icerik-1503-proje-pazarlari-destekleme-programi",
                    ProjeReferansNo = "170214-DST-02",
                    SonBasvuruTarihi = "Her zaman",
                    _ProjeTipi = ProjeTipi.Hibe,                  
                };

                List<Proje> ProjelerListesi1 = new List<Proje>() { proje1 };
                context.Proje.Add(proje1);

                var proje2 = new Proje()
                {
                    Baslik = "TÜBİTAK-1002-Hızlı Destek Programı",
                    Butce = 75000,
                    Icerik = "Hızlı Destek Programının amacı, üniversitelerde, araştırma hastanelerinde ve araştırma enstitülerinde yürütülecek acil, kısa süreli, küçük bütçeli araştırma ve geliştirme projelerine destek sağlamaktır.",
                    KaynakID = 1,
                    Link = "http://www.tubitak.gov.tr/tr/destekler/akademik/ulusal-destek-programlari/icerik-1002-hizli-destek-programi",
                    ProjeReferansNo = "170214-DST-01",
                    SonBasvuruTarihi = "2/7/2014",
                    _ProjeTipi = ProjeTipi.Ortaklıklar,
                };
                
                List<Proje> ProjelerListesi2 = new List<Proje>() { proje2 };
                context.Proje.Add(proje2);

                List<Proje> ProjelerListesi3 = new List<Proje>() { proje1, proje2 };

                context.AnahtarKelime.Add(new AnahtarKelime { AnahtarKelimeAdi = "Burs", Projeler = ProjelerListesi3 });
                context.AnahtarKelime.Add(new AnahtarKelime { AnahtarKelimeAdi = "Sağlık", Projeler = ProjelerListesi3 });
                context.AnahtarKelime.Add(new AnahtarKelime { AnahtarKelimeAdi = "Sosyal Bilimler", Projeler = ProjelerListesi2 });

                context.CalismaAlani.Add(new CalismaAlani() { CalismaAlaniAdi = "Sağlık Bilimleri", Projeler = ProjelerListesi3 });
                context.CalismaAlani.Add(new CalismaAlani() { CalismaAlaniAdi = "Eğitim Bilimleri", Projeler = ProjelerListesi3 });
                context.CalismaAlani.Add(new CalismaAlani() { CalismaAlaniAdi = "Sosyal Bilimler", Projeler = ProjelerListesi1 });
                context.CalismaAlani.Add(new CalismaAlani() { CalismaAlaniAdi = "Teknik Bilimler", Projeler = ProjelerListesi1 });
                context.CalismaAlani.Add(new CalismaAlani() { CalismaAlaniAdi = "Temel Bilimler", Projeler = ProjelerListesi1 });
                context.CalismaAlani.Add(new CalismaAlani() { CalismaAlaniAdi = "Yarışmalar", Projeler = ProjelerListesi2 });

                context.Kaynak.Add(new Kaynak() { KaynakAdi = "Ulusal Kaynaklar" });

                context.Tema.Add(new Tema() { TemaAdi = "Sağlık Bilimleri", Projeler = ProjelerListesi1 });
                context.Tema.Add(new Tema() { TemaAdi = "Biyoteknoloji", Projeler = ProjelerListesi1 });
                context.Tema.Add(new Tema() { TemaAdi = "İlaç", Projeler = ProjelerListesi1 });
                context.Tema.Add(new Tema() { TemaAdi = "AB Genişlemesi ve Bütünleşmesi", Projeler = ProjelerListesi2 });
                context.Tema.Add(new Tema() { TemaAdi = "Ağ Kurma", Projeler = ProjelerListesi2 });
                context.Tema.Add(new Tema() { TemaAdi = "Araştırma Altyapıları", Projeler = ProjelerListesi2 });

                context.Yurutucu.Add(new Yurutucu() { YurutucuAdi = "Araştırmacı", Projeler = ProjelerListesi3 });
                context.Yurutucu.Add(new Yurutucu() { YurutucuAdi = "Öğrenci", Projeler = ProjelerListesi2 });
                context.Yurutucu.Add(new Yurutucu() { YurutucuAdi = "Sanayici", Projeler = ProjelerListesi2 });

                context.SaveChanges();
            }
        }
    }
}