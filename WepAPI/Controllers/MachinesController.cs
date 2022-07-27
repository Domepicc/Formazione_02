using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Mvc;
using WebAPI.Domain;
using WebAPI.DataAccess;

namespace WepAPI.Controllers
{
    public class MachinesController : ApiController
    {

        private MachineRepository repo = new MachineRepository();

        public List<Machine> Get()
        {
            return repo.ReadAll();
        }

        public Machine Get(string id)
        {
            return repo.ReadById(id);
        }



    }
}