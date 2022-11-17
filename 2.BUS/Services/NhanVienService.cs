using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2.BUS.Services
{
    public class NhanVienService : INhanVienService
    {
        private INhanVienRepository _iNhanVienRepos;
        private IChucVuRepository _ichucVuRepos;
        private ICuaHangRepository _icuaHangRepos;

        public NhanVienService()
        {
            _iNhanVienRepos = new NhanVienRepository();
            _ichucVuRepos = new ChucVuRepository();
            _icuaHangRepos = new CuaHangRepository();
        }

        public string Add(NhanVienView obj)
        {
            if (obj == null) return "Thêm không thành công òi nè";
            var nv = new _1.DAL.DomainClass.NhanVien()
            {  Ma= obj.Ma,
            Ten= obj.Ten,
            NgaySinh= obj.NgaySinh,
            GioiTinh= obj.GioiTinh,
            };



            if (_iNhanVienRepos.Add(nv)) return "Thêm thành công nè";
            return "Thêm thất bại đó";
        }



        public string Delete(NhanVienView obj)
        {
            if (obj == null) return "Xóa không thành công òi nè";
            var nv = obj.NhanVien;
            if (_iNhanVienRepos.Delete(nv)) return "Xóa thành công nè";
            return "Xóa thất bại đó";
        }

        public List<NhanVien> GetNv()
        {
            List<_1.DAL.DomainClass.NhanVien> lstNhanVien = _iNhanVienRepos.GetAll();
            return lstNhanVien;
        }

        public string Update(NhanVienView obj)
        {
            if (obj == null) return "Sửa không thành công òi nè";
            var nv = obj.NhanVien;
            if (_iNhanVienRepos.Update(nv)) return "Sửa thành công nè";
            return "Sửa thất bại đó";
        }

        List<ViewModels.NhanVienView> INhanVienService.GetAll()
        {
            List<ViewModels.NhanVienView> lstNvViews = new List<ViewModels.NhanVienView>();
            lstNvViews =
                (from a in _iNhanVienRepos.GetAll()
                // join a in _iNhanVienRepos.GetAll() on a.Id equals a.IdGuiBc
                 join b in _ichucVuRepos.GetAll() on a.IdCv equals b.Id
                 join c in _icuaHangRepos.GetAll() on a.IdCh equals c.Id
                 select new ViewModels.NhanVienView()
                 {
                     NhanVien = a,
                     ChucVu = b,
                     CuaHang = c,
                 }).ToList();
            return lstNvViews;
        }

        List<NhanVienView> INhanVienService.GetNv()
        {
            throw new NotImplementedException();
        }
    }
}
