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
    public class QLKhachHangService : IQLKhachHangService
    {
        private IKhachHangRepository _iKHangRepos;
        public QLKhachHangService()
        {
            _iKHangRepos =new KhachHangRepository();
        }

        public string Add(KhachHangView obj)
        {
            if (obj == null) return "Thêm thất bại";
            var khachHang = new KhachHang()
            {
                Ma = obj.Ma,
                Ten = obj.Ten,
                TenDem=obj.TenDem,
                Ho=obj.Ho,
                NgaySinh=obj.NgaySinh,
                Sdt=obj.Sdt,
                DiaChi=obj.DiaChi,
                ThanhPho=obj.ThanhPho,
                QuocGia=obj.QuocGia,
                MatKhau=obj.MatKhau
            };
            if (_iKHangRepos.Add(khachHang)) return "Thêm thành công";
            return "Thêm thất bại";
        }

        public string Delete(KhachHangView obj)
        {
            if (obj == null) return "Xóa thất bại";
            var khachHang = new KhachHang()
            {
                Ma = obj.Ma,
                Ten = obj.Ten,
                TenDem = obj.TenDem,
                Ho = obj.Ho,
                NgaySinh = obj.NgaySinh,
                Sdt = obj.Sdt,
                DiaChi = obj.DiaChi,
                ThanhPho = obj.ThanhPho,
                QuocGia = obj.QuocGia,
                MatKhau = obj.MatKhau
            };
            if (_iKHangRepos.Delete(khachHang)) return "Xóa thành công";
            return "Xóa thất bại";
        }

        public List<KhachHangView> GetAll()
        {
            List<KhachHangView> lst = new List<KhachHangView>();
            lst =
                (
                    from a in _iKHangRepos.GetAll()
                    select new KhachHangView()
                    {
                        Id = a.Id,
                        Ma = a.Ma,
                        Ten = a.Ten,
                        DiaChi=a.DiaChi,
                        TenDem=a.TenDem,
                        Ho=a.Ho,
                    }
                ).ToList();
            return lst;
        }

        public List<KhachHangView> GetAll(string input)
        {
            List<KhachHangView> lst = new List<KhachHangView>();
            lst =
                (
                    from a in _iKHangRepos.GetAll()
                    select new KhachHangView()
                    {

                        Id = a.Id,
                        Ma = a.Ma,
                        Ten = a.Ten,
                        DiaChi = a.DiaChi,
                        TenDem = a.TenDem,
                        Ho = a.Ho,

                    }
                ).Where(c => c.DiaChi.ToLower().Contains(input) || c.DiaChi.ToUpper().Contains(input)).ToList();
            return lst;
        }

        public string Update(KhachHangView obj)
        {
            if (obj == null) return "Sửa thất bại";
            var khachHang = new KhachHang()
            {
                Ma = obj.Ma,
                Ten = obj.Ten,
                TenDem = obj.TenDem,
                Ho = obj.Ho,
                NgaySinh = obj.NgaySinh,
                Sdt = obj.Sdt,
                DiaChi = obj.DiaChi,
                ThanhPho = obj.ThanhPho,
                QuocGia = obj.QuocGia,
                MatKhau = obj.MatKhau
            };
            if (_iKHangRepos.Update(khachHang)) return "Sửa thành công";
            return "Sửa thất bại";
        }
       
    }
}
