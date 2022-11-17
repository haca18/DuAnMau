using _1.DAL.Context;
using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.DAL.Repositories
{
    public class CTHoaDonRepository : ICTHoaDonRepository
    {
        FpolyDBContext _DBcontext;
        public CTHoaDonRepository()
        {
            _DBcontext = new FpolyDBContext();
        }

        public bool Add(HoaDonChiTiet obj)
        {
            if (obj == null) return false;
            _DBcontext.HoaDonChiTiets.Add(obj);
            _DBcontext.SaveChanges();
            return true;
        }

        public bool Delete(HoaDonChiTiet obj)
        {
            if (obj == null) return false;
            var tempobj = _DBcontext.HoaDonChiTiets.FirstOrDefault(x => x.IdHoaDon == obj.IdHoaDon);
            _DBcontext.Remove(tempobj);
            _DBcontext.SaveChanges();
            return true;
        }

        public List<HoaDonChiTiet> GetAll()
        {
            return _DBcontext.HoaDonChiTiets.ToList();
        }

        public HoaDonChiTiet GetById(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _DBcontext.HoaDonChiTiets.FirstOrDefault(c => c.IdHoaDon == id);
        }

        public bool Update(HoaDonChiTiet obj)
        {
            if (obj == null) return false;
            var tempobj = _DBcontext.HoaDonChiTiets.FirstOrDefault(x => x.IdHoaDon == obj.IdHoaDon);
            tempobj.IdChiTietSp = obj.IdChiTietSp;
            tempobj.IdHoaDon = obj.IdHoaDon;
            tempobj.SoLuong = obj.SoLuong;
            tempobj.DonGia = obj.DonGia;
            _DBcontext.Update(tempobj);
            _DBcontext.SaveChanges();
            return true;
        }
    }
}
