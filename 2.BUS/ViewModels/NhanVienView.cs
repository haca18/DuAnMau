using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2.BUS.ViewModels
{
    public class NhanVienView
    {
        public _1.DAL.DomainClass.ChucVu ChucVu { get; set; }
        public _1.DAL.DomainClass.CuaHang CuaHang { get; set; }
        public _1.DAL.DomainClass.NhanVien NhanVien { get; set; }

        public Guid Id { get; set; }
        public string Ma { get; set; }
        public string Ten { get; set; }
        public string TenDem { get; set; }
        public string Ho { get; set; }
        public string GioiTinh { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string Sdt { get; set; }
    }
}
