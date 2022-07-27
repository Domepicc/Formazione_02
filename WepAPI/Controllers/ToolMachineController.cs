using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using WebAPI.DataAccess;
using WebAPI.Domain;

namespace WepAPI.Controllers
{
    public class ToolMachineController : ApiController
    {
        
        private ToolMachineRepository repo = new ToolMachineRepository();

        public List<ToolMachine> Get()
        {
            return repo.ReadAll();       
        }

        public ToolMachine Get(string id)
        {
            return repo.ReadById(id);
        }

        public bool Post (ToolMachine item)
        {
            return repo.Insert(item);
        }


    }
}