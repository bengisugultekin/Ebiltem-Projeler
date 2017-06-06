using Projeler.DAL.Repositories;
using System.Web.Mvc;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Net.Http;
using System.Collections.Generic;
using Projeler.Entity.Models;
using Projeler.Entity.ViewModels;
using System;

namespace Projeler.WEB.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ActionResult> Search()
        {
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync("http://localhost:65043/api/Proje");
                var result = JsonConvert.DeserializeObject<List<ViewModelDetay>>(response.Content.ReadAsStringAsync().Result);

                return View(result);
            }
        }


        [HttpPost]
        public ActionResult Search(string search)
        {
            var result = ProjectRepository.GetAllProjectsByKey(search);
            ViewBag.searchKeyword = "Anahtar Kelime: " + search;
            return View(result);
        }




    }
}


