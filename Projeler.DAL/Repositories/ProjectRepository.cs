using Projeler.Entity.DatabaseConnection;
using System.Collections.Generic;
using System.Linq;
using Projeler.Entity.ViewModels;

namespace Projeler.DAL.Repositories
{
    public class ProjectRepository
    {      
        public static List<ViewModelDetay> GetAllProjectDetail()
        {
            using (ProjectDBContext db = new ProjectDBContext())
            {
                return db.Proje
                    .Include("CalismaAlanlari")
                    .Include("Temalar")
                    .Include("Yurutuculer")
                    .Include("AnahtarKelimeler")
                    .Select(p => new ViewModelDetay
                    {
                        ProjeID = p.ProjeID,
                        ProjeReferansNo = p.ProjeReferansNo,
                        Baslik = p.Baslik,
                        KaynakAdi = p.Kaynak.KaynakAdi,
                        ProjeTipi = p._ProjeTipi,
                        CalismaAlanlari = p.CalismaAlanlari,
                        Temalar = p.Temalar,
                        Yurutuculer = p.Yurutuculer,
                        Butce = p.Butce,
                        SonBasvuruTarihi = p.SonBasvuruTarihi,
                        Icerik = p.Icerik,
                        Link = p.Link,
                        AnahtarKelimeler = p.AnahtarKelimeler

                    }).ToList();
            }
        }



        public static List<ViewModelDetay> GetAllProjectsByKey(string key)
        {
            using (ProjectDBContext db = new ProjectDBContext())
            {

                List<ViewModelDetay> VMList = new List<ViewModelDetay>();

                var projectList = db.Proje
                    .Include("AnahtarKelimeler")
                    .Select(p => new ViewModelDetay
                    {
                        ProjeID = p.ProjeID,
                        ProjeReferansNo = p.ProjeReferansNo,
                        Baslik = p.Baslik,
                        KaynakAdi = p.Kaynak.KaynakAdi,
                        ProjeTipi = p._ProjeTipi,
                        CalismaAlanlari = p.CalismaAlanlari,
                        Temalar = p.Temalar,
                        Yurutuculer = p.Yurutuculer,
                        Butce = p.Butce,
                        SonBasvuruTarihi = p.SonBasvuruTarihi,
                        Icerik = p.Icerik,
                        Link = p.Link,
                        AnahtarKelimeler = p.AnahtarKelimeler
                    }).ToList();


                for (int i = 0; i < projectList.Count; i++)
                {
                    for (int j = 0; j < projectList[i].AnahtarKelimeler.Count; j++)
                    {
                        if (projectList[i].AnahtarKelimeler[j].AnahtarKelimeAdi.Trim().ToLower() == key.Trim().ToLower())
                        {
                            VMList.Add(projectList[i]);
                        }
                    }
                }

                return VMList;
            }
        }        

    }
}
