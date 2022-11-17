using _1.DAL.Context;
using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.DAL.Repositories
{
    public class CuaHangRepository : ICuaHangRepository
    {
        FpolyDBContext _DBcontext;
        public CuaHangRepository()
        {
            _DBcontext = new FpolyDBContext();
        }
        public bool Add(CuaHang obj)
        {
            if (obj == null) return false;
            _DBcontext.CuaHangs.Add(obj);
            _DBcontext.SaveChanges();
            return true;
        }

        public bool Delete(CuaHang obj)
        {
            if (obj == null) return false;
            var tempobj = _DBcontext.CuaHangs.FirstOrDefault(c => c.Ma == obj.Ma);
            _DBcontext.Remove(tempobj);
            _DBcontext.SaveChanges();
            return true;
        }

        public List<CuaHang> GetAll()
        {
            return _DBcontext.CuaHangs.ToList();
        }

        public CuaHang GetById(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _DBcontext.CuaHangs.FirstOrDefault(c => c.Id == id);
        }

        public bool Update(CuaHang obj)
        {
            if (obj == null) return false;
            var tempobj = _DBcontext.CuaHangs.FirstOrDefault(c => c.Ma == obj.Ma);
            tempobj.Ma = obj.Ma;
            tempobj.Ten = obj.Ten;
            tempobj.DiaChi = obj.DiaChi;
            tempobj.ThanhPho = obj.ThanhPho;
            tempobj.QuocGia = obj.QuocGia;
            _DBcontext.Update(tempobj);
            _DBcontext.SaveChanges();
            return true;
        }
    }
}
