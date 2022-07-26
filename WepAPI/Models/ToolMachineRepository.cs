using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Domain;

namespace WebAPI.DataAccess
{
    public class ToolMachineRepository : IRepository<ToolMachine>
    {
        public bool Delete(string id)
        {
            throw new NotImplementedException();
        }

        public bool Delete(string id, string id2)
        {
            throw new NotImplementedException();
        }

        public bool Insert(ToolMachine item)
        {
            using (MyDBContext mydb = new MyDBContext())
            {
                mydb.ToolMachine.Add(item);
                return mydb.SaveChanges() > 0;
            }
        }

        public List<ToolMachine> ReadAll()
        {
            using(MyDBContext myDb = new MyDBContext())
            {
                return myDb.ToolMachine.ToList();
            }
        }

        public ToolMachine ReadById(string id)
        {
            throw new NotImplementedException();


        }

        public ToolMachine ReadById(string id, string id2)
        {
            using (MyDBContext myDb = new MyDBContext())
            {
                return myDb.ToolMachine.Where(t => t.IdTool.Equals(id) && t.MachineCode.Equals(id2) ).FirstOrDefault();
            }
        }

        public List<ToolMachine> ReadByPartialId(string id)
        {
            throw new NotImplementedException();
        }

        public bool Update(ToolMachine item, string key)
        {
            throw new NotImplementedException();
        }
    }
}
