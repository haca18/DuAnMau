using _1.DAL.Context;
using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.DAL.Repositories
{
    public class SanPhamRepository : ISanPhamRepository
    {
        FpolyDBContext _DBcontext;
        public SanPhamRepository()
        {
            _DBcontext =new FpolyDBContext();
        }

        public bool Add(SanPham obj)
        {
            if (obj == null) return false;
            _DBcontext.SanPhams.Add(obj);
            _DBcontext.SaveChanges();
            return true;
        }

        public bool Delete(SanPham obj)
        {
            if (obj == null) return false;
            var tempobj = _DBcontext.SanPhams.FirstOrDefault(x => x.Id == obj.Id);
            _DBcontext.Remove(tempobj);
            _DBcontext.SaveChanges();
            return true;
        }

        public List<SanPham> GetAll()
        {
            return _DBcontext.SanPhams.ToList();
        }

        public SanPham GetById(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _DBcontext.SanPhams.FirstOrDefault(c => c.Id == id);
        }

        public bool Update(SanPham obj)
        {
            if (obj == null) return false;
            var tempobj = _DBcontext.SanPhams.FirstOrDefault(x => x.Id == obj.Id);
            tempobj.Ma = obj.Ma;
            tempobj.Ten = obj.Ten;
            _DBcontext.Remove(tempobj);
            _DBcontext.SaveChanges();
            return true;
        }
    }
}
