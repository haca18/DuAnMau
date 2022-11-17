using _1.DAL.Context;
using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.DAL.Repositories
{
    public class NhanVienRepository : INhanVienRepository
    {
        FpolyDBContext _DBcontext;
        public NhanVienRepository()
        {
            _DBcontext = new FpolyDBContext();
        }
        public bool Add(NhanVien obj)
        {
            if (obj == null) return false;
            _DBcontext.NhanViens.Add(obj);
            _DBcontext.SaveChanges();
            return true;
        }

        public bool Delete(NhanVien obj)
        {
            if (obj == null) return false;
            var tempobj = _DBcontext.NhanViens.FirstOrDefault(x => x.Ma == obj.Ma);
            _DBcontext.Remove(tempobj);
            _DBcontext.SaveChanges();
            return true;
        }

        public List<NhanVien> GetAll()
        {
            return _DBcontext.NhanViens.ToList();
        }

        public NhanVien GetById(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _DBcontext.NhanViens.FirstOrDefault(c => c.Id == id);
        }

        public bool Update(NhanVien obj)
        {
            if (obj == null) return false;
            var tempobj = _DBcontext.NhanViens.FirstOrDefault(x => x.Ma == obj.Ma);
            tempobj.Ma = obj.Ma;
            tempobj.TenDem=obj.TenDem;
            tempobj.Ten = obj.Ten;
            tempobj.Ho=obj.Ho;
            tempobj.GioiTinh = obj.GioiTinh;
            tempobj.NgaySinh = obj.NgaySinh;
            tempobj.DiaChi = obj.DiaChi;
            tempobj.Sdt = obj.Sdt;
            tempobj.MatKhau = obj.MatKhau;
            tempobj.IdCh=obj.IdCh;
            tempobj.IdCv=obj.IdCv;
            tempobj.IdGuiBc=obj.IdGuiBc;
            tempobj.TrangThai = obj.TrangThai;
            _DBcontext.Update(tempobj);
            _DBcontext.SaveChanges();
            return true;
        }
    }
}
