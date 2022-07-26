using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Domain;
using System.Data.Entity;

namespace WebAPI.DataAccess
{
    public class ToolsRepository : IRepository<Tool>
    {

        public List<Tool> ReadAll()
        {

            using (MyDBContext myDb = new MyDBContext())
            {

                return myDb.Tools.ToList();
                
            }

        }

        public int CountRow()
        {
            using (MyDBContext myDb = new MyDBContext())
            {
                return ReadAll().Count();
            }
        }

        public List<string> ReadMachinesCodeExcepted(string id)
        {
            using (MyDBContext myDb = new MyDBContext())
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

        public Tool ReadById( string id)
        {
            using (MyDBContext myDb= new MyDBContext())
            {
                return myDb.Tools.AsQueryable().Where(t => t.IdTool.Equals(id)).Include(x => x.ToolMachine).FirstOrDefault();
            }
        }

        public bool Update(Tool item)
        {
            using(MyDBContext myDb = new MyDBContext())
            {

                var tool = myDb.Tools.Where(t => t.IdTool.Equals(item.IdTool)).Include(x => x.ToolMachine).FirstOrDefault();
                tool.BoschCode = item.BoschCode;
                tool.Description = item.Description;
                tool.PrimarySupplier = item.PrimarySupplier;
                tool.SecondarySupplier = item.SecondarySupplier;
                tool.Quantity = item.Quantity;

                //tool = item;

                return myDb.SaveChanges() > 0;

            }
        }


        public Tool ReadById(string id, string id2)
        {
            throw new NotImplementedException();
        }

        public List<Tool> ReadByPartialId(string id)
        {
            using (MyDBContext myDb = new MyDBContext())
            {
                return myDb.Tools.Where(t => t.IdTool.Contains(id)).ToList();

            }
        }


        public bool Insert(Tool item)
        {
            using (MyDBContext myDb = new MyDBContext())
            {
                myDb.Tools.Add(item);
                return myDb.SaveChanges() > 0;
            }
        }

        public bool Update(Tool item, string id)
        {
            using (MyDBContext myDb = new MyDBContext())
            {

                var tool = myDb.Tools.Where(t => t.IdTool.Equals(item.IdTool)).FirstOrDefault();
                var machine = myDb.Machines.Where(t => t.MachineCode.Equals(id)).FirstOrDefault();
                tool.BoschCode = item.BoschCode;
                tool.Description = item.Description;
                tool.PrimarySupplier = item.PrimarySupplier;
                tool.SecondarySupplier = item.SecondarySupplier;
                tool.Quantity = item.Quantity;

                return myDb.SaveChanges() > 0;

            }
        }

        public bool Delete(string id)
        {
            throw new NotImplementedException();
        }

        public bool Delete(string id, string id2)
        {
            throw new NotImplementedException();
        }
    }
}
