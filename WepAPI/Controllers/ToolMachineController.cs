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
        // GET: ToolMachine


        public List<ToolMachine> Get()
        {
            ToolMachineRepository repo = new ToolMachineRepository();
            return repo.ReadAll();       
        }

        public ToolMachine Get(string id)
        {
            ToolMachineRepository repo = new ToolMachineRepository();
            return repo.ReadById(id);
        }
    }
}