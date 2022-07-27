using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAPI.Domain;
using WebAPI.DataAccess;
using System.Web.Http;
using System.Net.Http;
using System.Net;

namespace WepAPI.Controllers
{
    public class ToolsController : ApiController
    {

        ToolsRepository repo = new ToolsRepository();

        public List<Tool> Get()
        {
            return repo.ReadAll();
        }

        public Tool Get(string id)
        {
            return repo.ReadById(id);
        }

        public bool Post(Tool item)
        {
            return repo.Insert(item);
        }

        public bool Put(Tool item)
        {
            return repo.Update(item, item.IdTool);
        }

        [System.Web.Http.Route("api/Tools/{id}/CodeExcepted")]
        public List<string> GetMachineCodeExcepted(string id)
        {
            return repo.ReadMachinesCodeExcepted(id);
        }

        [System.Web.Http.Route("api/Tools/ByPartialId/{id}")]
        public List<Tool> GetByPartialId (string id)
        {
            return repo.ReadByPartialId(id);

        }
    }
}