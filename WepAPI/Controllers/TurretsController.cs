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

        public List<Turret> Get()
        {
            TurretsRepository repo = new TurretsRepository();
            return repo.ReadAll();
        }

        public Turret Get(string id)
        {
            TurretsRepository repo = new TurretsRepository();
            return repo.ReadById(id);
        }

        public bool Delete(string id)
        {
            TurretsRepository repo = new TurretsRepository();
            return repo.Delete(id);
        }

        public bool Post (Turret item)
        {
            TurretsRepository repo = new TurretsRepository();
            return repo.Insert(item);

        }


    }
}
