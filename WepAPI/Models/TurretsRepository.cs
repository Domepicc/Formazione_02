using WebAPI.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.DataAccess
{
    public class TurretsRepository : IRepository<Turret>
    {

        public bool Delete(string id)
        {
            using (MyDBContext myDb = new MyDBContext())
            {
                var itemDelete = myDb.Turrets.Where(t => t.TurretCode.Equals(id)).FirstOrDefault();

                myDb.Turrets.Remove(itemDelete);
                return myDb.SaveChanges() > 0;
            }
        }

        public bool Delete(string id, string id2)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Turret item)
        {
            using (MyDBContext myDb = new MyDBContext())
            {
                myDb.Turrets.Add(item);
                return myDb.SaveChanges() > 0;
            }
        }


        public List<Turret> ReadAll()
        {
            using (MyDBContext myDb = new MyDBContext())
            {
            
                return myDb.Turrets.ToList();
            }
        }

        public Turret ReadById(string id)
        {
            using (MyDBContext myDb = new MyDBContext())
            {
                return myDb.Turrets.Where(t => t.TurretCode.Equals(id)).FirstOrDefault();
            }

        }

        public Turret ReadById(string id, string id2)
        {
            throw new NotImplementedException();
        }

        public List<Turret> ReadByPartialId(string id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Turret item, string id)
        {

            using (MyDBContext myDb = new MyDBContext())
            {
                var itemUpdate = myDb.Turrets.Where(t => t.TurretCode.Equals(id)).FirstOrDefault();
                itemUpdate.TurretCode = item.TurretCode;
                itemUpdate.Description = item.Description;
                return myDb.SaveChanges() > 0;
            }

        }


    }
}