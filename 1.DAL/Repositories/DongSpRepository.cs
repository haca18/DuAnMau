using _1.DAL.Context;
using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.DAL.Repositories
{
    public class DongSpRepository : IDongSpRepository
    {
        private FpolyDBContext _DBcontext;
        public DongSpRepository()
        {
            _DBcontext = new FpolyDBContext();
        }
        public bool Add(DongSp obj)
        {
            if (obj == null) return false;
            _DBcontext.DongSps.Add(obj);
            _DBcontext.SaveChanges();
            return true;
        }

        public bool Delete(DongSp obj)
        {
            if (obj == null) return false;
            var tempobj = _DBcontext.DongSps.FirstOrDefault(c => c.Ma == obj.Ma);
            _DBcontext.Remove(tempobj);
            _DBcontext.SaveChanges();
            return true;
        }

        public List<DongSp> GetAll()
        {
            return _DBcontext.DongSps.ToList();
        }

        public DongSp GetById(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _DBcontext.DongSps.FirstOrDefault(c => c.Id == id);
        }

        //public List<string> GetLoc()
        //{ }

        public bool Update(DongSp obj)
        {
            if (obj == null) return false;
            var tempobj = _DBcontext.DongSps.FirstOrDefault(c => c.Ma == obj.Ma);
            //tempobj.Id = obj.Id;
            tempobj.Ma = obj.Ma;
            tempobj.Ten = obj.Ten;
            _DBcontext.Update(tempobj);
            _DBcontext.SaveChanges();
            return true;
        }
    }
}
