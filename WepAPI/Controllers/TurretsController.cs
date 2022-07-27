using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Domain;
using WebAPI.DataAccess;

namespace WepAPI.Controllers
{
    public class TurretsController : ApiController
    {

        private TurretsRepository repo = new TurretsRepository();

        public List<Turret> Get()
        {
            return repo.ReadAll();
        }

        public Turret Get(string id)
        {
            return repo.ReadById(id);
        }

        public bool Delete(string id)
        {
            return repo.Delete(id);
        }

        public bool Post (Turret item)
        {
            return repo.Insert(item);

        }


    }
}
