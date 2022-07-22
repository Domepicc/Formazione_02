using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Domain;

namespace WebAPI.DataAccess
{
    public class MachineRepository : IRepository<Machine>
    {
        public bool Delete(string id)
        {
            throw new NotImplementedException();
        }

        public bool Delete(string id, string id2)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Machine item)
        {
            using (MyDBContext myDb = new MyDBContext())
            {
                myDb.Machines.Add(item);
                return myDb.SaveChanges() > 0;
            }
        }

        public List<Machine> ReadAll()
        {
            using( MyDBContext myDb = new MyDBContext())
            {
                return myDb.Machines.ToList();
            }
        }

        public List<string> ReadAllCodeMachine()
        {
            using(MyDBContext myDb = new MyDBContext())
            {
                return myDb.Machines.Select(m => m.MachineCode).Distinct().ToList();
            }
        }

        public Machine ReadById(string id)
        {
            using(MyDBContext myDb = new MyDBContext())
            {
                var result = myDb.Machines.Where(t => t.MachineCode == id).Include(x => x.ToolMachine).FirstOrDefault();
                return result;

            }
        }

        public Machine ReadById(string id, string id2)
        {
            throw new NotImplementedException();
        }

        public List<Machine> ReadByPartialId(string id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Machine item, string key)
        {
            throw new NotImplementedException();
        }

        public List<string> ReadMachineCodeExcepted (string id)
        {
            using(MyDBContext myDb =new MyDBContext())
            {
                List<string> idMachines = new List<string>();
                var tool = myDb.Tools.Where(t => t.IdTool.Equals(id)).Include(x => x.ToolMachine).FirstOrDefault();

                foreach (ToolMachine t in tool.ToolMachine)
                {
                    idMachines.Add(t.MachineCode);
                }
                return myDb.Machines.Select(m => m.MachineCode).Except(idMachines).ToList(); 
            }
        }


        public List<string> ReadMachineCode()
        {
            using (MyDBContext myDb = new MyDBContext())
            {
                return myDb.Machines.Select(t => t.MachineCode).Distinct().ToList();
            }
        }

        Machine IRepository<Machine>.ReadById(string id)
        {
            throw new NotImplementedException();
        }
    }
}
