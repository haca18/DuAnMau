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
    public class CTSpService : ICtSpService
    {
        private IChiTietSpRepository _iCtSpRepos;
        public CTSpService()
        {
            _iCtSpRepos = new ChiTietSpRepository();
        }
        public string Add(ChiTietSpView obj)
        {
            if (obj == null) return "Thêm thất bại";
            var chitietSp = new ChiTietSp()
            {
                IdSp = obj.IdSp,
                IdNsx = obj.IdNsx,
                IdMauSac = obj.IdMauSac,
                IdDongSp=obj.IdDongSp,
                NamBh=obj.NamBh,
                MoTa=obj.MoTa,
                SoLuongTon=obj.SoLuongTon,
                GiaBan=obj.GiaBan,
                GiaNhap=obj.GiaNhap,

            };
            if (_iCtSpRepos.Add(chitietSp)) return "Thêm thành công";
            return "Thêm thất bại";
        }

        public string Delete(ChiTietSpView obj)
        {
            if (obj == null) return "Xóa thất bại";
            var chitietSp = new ChiTietSp()
            {
                IdSp = obj.IdSp,
                IdNsx = obj.IdNsx,
                IdMauSac = obj.IdMauSac,
                IdDongSp = obj.IdDongSp,
                NamBh = obj.NamBh,
                MoTa = obj.MoTa,
                SoLuongTon = obj.SoLuongTon,
                GiaBan = obj.GiaBan,
                GiaNhap = obj.GiaNhap,

            };
            if (_iCtSpRepos.Delete(chitietSp)) return "Xóa thành công";
            return "Xóa thất bại";
        }

        public List<ChiTietSpView> GetAll()
        {
            List<ChiTietSpView> lst = new List<ChiTietSpView>();
            lst =
                (
                    from a in _iCtSpRepos.GetAll()
                    select new ChiTietSpView()
                    {
                        Id = a.Id,
                        IdSp = a.IdSp,
                        IdNsx = a.IdNsx,
                        IdMauSac = a.IdMauSac,
                        IdDongSp = a.IdDongSp,
                        NamBh = a.NamBh,
                        MoTa = a.MoTa,
                        SoLuongTon = a.SoLuongTon,
                        GiaBan = a.GiaBan,
                        GiaNhap = a.GiaNhap,
                    }
                ).ToList();
            return lst;
        }

        public string Update(ChiTietSpView obj)
        {
            if (obj == null) return "Sửa thất bại";
            var chitietSp = new ChiTietSp()
            {
                IdSp = obj.IdSp,
                IdNsx = obj.IdNsx,
                IdMauSac = obj.IdMauSac,
                IdDongSp = obj.IdDongSp,
                NamBh = obj.NamBh,
                MoTa = obj.MoTa,
                SoLuongTon = obj.SoLuongTon,
                GiaBan = obj.GiaBan,
                GiaNhap = obj.GiaNhap,

            };
            if (_iCtSpRepos.Update(chitietSp)) return "Sửa thành công";
            return "Sửa thất bại";
        }
    }
}
