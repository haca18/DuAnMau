using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2.BUS.ViewModels
{
    public class HoaDonView
    {
        public HoaDon HoaDon { get; set; }
        public HoaDonChiTiet HoaDonChiTiet { get; set; }
        public _1.DAL.DomainClass.ChiTietSp ChiTietSp { get; set; }
        public _1.DAL.DomainClass.KhachHang KhachHang { get; set; }
        public _1.DAL.DomainClass.NhanVien NhanVien { get; set; }

        public Guid Id { get; set; }
        public Guid? IdKh { get; set; }
        public Guid? IdNv { get; set; }
        public string Ma { get; set; }
        public DateTime? NgayTao { get; set; }
        public DateTime? NgayThanhToan { get; set; }
        public DateTime? NgayShip { get; set; }
        public DateTime? NgayNhan { get; set; }
        public int? TinhTrang { get; set; }
        public string TenNguoiNhan { get; set; }
        public string DiaChi { get; set; }
        public string Sdt { get; set; }
    }
}
