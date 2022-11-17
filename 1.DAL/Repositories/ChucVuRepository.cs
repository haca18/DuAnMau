using _1.DAL.Context;
using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.DAL.Repositories
{
    public class ChucVuRepository : IChucVuRepository
    {
        private FpolyDBContext _DBcontext;

        public ChucVuRepository()
        {
            _DBcontext = new FpolyDBContext();
        }
        public bool Add(ChucVu obj)
        {
            if (obj == null) return false;
            _DBcontext.ChucVus.Add(obj);
            _DBcontext.SaveChanges();
            return true;
        }

        public bool Delete(ChucVu obj)
        {
            if (obj == null) return false;
            var tempobj = _DBcontext.ChucVus.FirstOrDefault(c => c.Ma == obj.Ma);
            _DBcontext.Remove(tempobj);
            _DBcontext.SaveChanges();
            return true;
        }

        public List<ChucVu> GetAll()
        {
            return _DBcontext.ChucVus.ToList();
        }

        public ChucVu GetById(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _DBcontext.ChucVus.FirstOrDefault(c => c.Id == id);

        }

        public bool Update(ChucVu obj)
        {
            if (obj == null) return false;
            var tempobj = _DBcontext.ChucVus.FirstOrDefault(c => c.Ma == obj.Ma);
            tempobj.Ma = obj.Ma;
            tempobj.Ten = obj.Ten;
            _DBcontext.Update(tempobj);
            _DBcontext.SaveChanges();
            return true;
        }
    }
}
