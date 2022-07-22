using WebAPI.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.DataAccess
{
    public class PartNumberRepository : IRepository<PartNumber>
    {
        public bool Delete(string id)
        {
            throw new NotImplementedException();
        }

        public bool Delete(string id, string id2)
        {
            throw new NotImplementedException();
        }

        public bool Insert(PartNumber item)
        {
            throw new NotImplementedException();
        }

        public List<PartNumber> ReadAll()
        {
            using (MyDBContext myDb = new MyDBContext())
            {
                return myDb.PartNumber.AsQueryable().Include(x => x.PartNumberTools).ToList();
            }
        }

        public PartNumber ReadById(string id)
        {
            throw new NotImplementedException();
        }

        public PartNumber ReadById(string id, string id2)
        {
            throw new NotImplementedException();
        }

        public List<PartNumber> ReadByPartialId(string id)
        {
            throw new NotImplementedException();
        }

        public bool Update(PartNumber item, string key)
        {
            throw new NotImplementedException();
        }
    }
}