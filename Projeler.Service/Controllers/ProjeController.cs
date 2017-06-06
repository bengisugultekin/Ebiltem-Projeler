using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Projeler.Entity.ViewModels;
using Projeler.DAL.Repositories;

namespace Projeler.Service.Controllers
{
    public class ProjeController : ApiController
    {
        //public List<ViewModelDetay> Get()
        //{
        //    return ProjectRepository.GetAllProjectDetail();
        //}

        //public List<ViewModelDetay> Get(string search)
        //{
        //    return ProjectRepository.GetAllProjectsByKey(search);
        //}


        //public HttpResponseMessage Get(string search = "All")
        //{
        //    if (search == "All")
        //    {
        //        return Request.CreateResponse(HttpStatusCode.OK, ProjectRepository.GetAllProjectDetail());
        //    }
        //    else
        //    {
        //        return Request.CreateResponse(HttpStatusCode.OK, ProjectRepository.GetAllProjectsByKey(search));
        //    }
        //}


        public HttpResponseMessage Get()
        {         
            
            return Request.CreateResponse(HttpStatusCode.OK, ProjectRepository.GetAllProjectDetail());            
            
        }

        public HttpResponseMessage Get(string search)
        {           
            return Request.CreateResponse(HttpStatusCode.OK, ProjectRepository.GetAllProjectsByKey(search));
            
        }

        //[HttpPost]
        //public List<ViewModelDetay> Get([FromBody]string search)
        //{        

        //    return ProjectRepository.GetAllProjectsByKey(search);

        //}
    }
}
