using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Domain;

namespace WebAPI.DataAccess
{
    public class PartNumberToolRepository : IRepository<PartNumberTool>
    {

        public bool Insert(PartNumberTool partNumberTool)
        {
            bool result = false;
            using (MyDBContext myDb = new MyDBContext())
            {
                myDb.PartNumberTool.Add(partNumberTool);
                result = myDb.SaveChanges() > 0;

            }
            return result;

        }

        public List<PartNumberTool> ReadAll()
        {
            using (MyDBContext myDb = new MyDBContext())
            {
                return myDb.PartNumberTool.ToList();
            }
        }

        public PartNumberTool ReadById(string id, string id2)
        {
            using (MyDBContext myDb = new MyDBContext())
            {
                return myDb.PartNumberTool.Where(t => t.PartNumber.Equals(id) && t.ToolCode.Equals(id2)).FirstOrDefault();
            }

        }

        public bool Delete(string partNumber, string toolCode)
        {
            bool result = false;
            using (MyDBContext myDb = new MyDBContext())
            {
                var item = myDb.PartNumberTool.Where(t => t.PartNumber.Equals(partNumber) && t.ToolCode.Equals(toolCode)).FirstOrDefault();

                if (item != null)
                {
                    myDb.PartNumberTool.Remove(item);
                }


                result = myDb.SaveChanges() > 0;

            }

            return result;

        }

        public PartNumberTool ReadById(string id)
        {
            throw new NotImplementedException();
        }

        public bool Update(PartNumberTool item, string key)
        {
            throw new NotImplementedException();
        }

        public bool Delete(string id)
        {
            throw new NotImplementedException();
        }

        public List<PartNumberTool> ReadByPartialId(string id)
        {
            throw new NotImplementedException();
        }
    }
}