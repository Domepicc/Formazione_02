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
        // GET: Tools


        public List<Tool> Get()
        {
            ToolsRepository repo = new ToolsRepository();
            return repo.ReadAll();
        }

        public Tool Get(string id)
        {
            ToolsRepository repo = new ToolsRepository();
            return repo.ReadById(id);
        }

        public bool Post(Tool item)
        {
            ToolsRepository repo = new ToolsRepository();
            return repo.Insert(item);
        }

        public bool Put(Tool item)
        {

            ToolsRepository repo = new ToolsRepository();
            return repo.Update(item, item.IdTool);
        }

        [System.Web.Http.Route("api/Tools/{id}/CodeExcepted")]
        public List<string> GetMachineCodeExcepted(string id)
        {
            ToolsRepository repo = new ToolsRepository();
            return repo.ReadMachinesCodeExcepted(id);
        }

        [System.Web.Http.Route("api/Tools/ByPartialId/{id}")]
        public List<Tool> GetByPartialId (string id)
        {
            ToolsRepository repo = new ToolsRepository();
            return repo.ReadByPartialId(id);

        }
    }
}