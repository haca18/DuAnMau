using _1.DAL.Context;
using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.DAL.Repositories
{
    public class ChiTietSpRepository : IChiTietSpRepository
    {
        private FpolyDBContext _DBcontext;
        public ChiTietSpRepository()
        {
            _DBcontext = new FpolyDBContext();
        }

        public bool Add(ChiTietSp obj)
        {
            if (obj == null) return false;
            _DBcontext.ChiTietSps.Add(obj);
            _DBcontext.SaveChanges();
            return true;
        }

        public bool Delete(ChiTietSp obj)
        {
            if (obj == null) return false;
            var tempobj = _DBcontext.ChiTietSps.FirstOrDefault(x => x.IdSp == obj.IdSp);
            _DBcontext.Remove(tempobj);
            _DBcontext.SaveChanges();
            return true;
        }

        public List<ChiTietSp> GetAll()
        {
            return _DBcontext.ChiTietSps.ToList();
        }

        public ChiTietSp GetById(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _DBcontext.ChiTietSps.FirstOrDefault(c => c.Id == id);

        }

        public bool Update(ChiTietSp obj)
        {
            if (obj == null) return false;
            var tempobj = _DBcontext.ChiTietSps.FirstOrDefault(x => x.IdSp == obj.IdSp);
           // tempobj.IdSp = obj.IdSp;
            tempobj.IdNsx = obj.IdNsx;
            tempobj.IdMauSac = obj.IdMauSac;
            tempobj.IdDongSp = obj.IdDongSp;
            tempobj.NamBh = obj.NamBh;
            tempobj.MoTa = obj.MoTa;
            tempobj.SoLuongTon = obj.SoLuongTon;
            tempobj.GiaBan = obj.GiaBan;
            tempobj.GiaNhap = obj.GiaNhap;
            _DBcontext.Update(tempobj);
            _DBcontext.SaveChanges();
            return true;
        }
    }
}
