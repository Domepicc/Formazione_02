﻿using System;
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
        // GET: Machine

        public List<Machine> Get()
        {
            MachineRepository repo = new MachineRepository();
            return repo.ReadAll();
        }

        public Machine Get(string id)
        {
            MachineRepository repo = new MachineRepository();
            return repo.ReadById(id);
        }



    }
}