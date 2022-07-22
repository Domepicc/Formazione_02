using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAPI.Domain;
using WebAPI.DataAccess;
using System.Web.Http;

namespace WepAPI.Controllers
{
    public class ToolsController : ApiController
    {
        // GET: Tools


        //public List<Tool> Get()
        //{
        //    ToolsRepository repo = new ToolsRepository();
        //    return repo.ReadAll();
        //}

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

        public bool Put(Tool item)
        {
            ToolsRepository repo = new ToolsRepository();
            return repo.Update(item, item.IdTool);
        }
    }
}