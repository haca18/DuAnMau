using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2.BUS.ViewModels
{
    public class SanPhamView
    {
        public _1.DAL.DomainClass.ChiTietSp ChiTietSp { get; set; }
        public _1.DAL.DomainClass.SanPham SanPham { get; set; }
        public _1.DAL.DomainClass.MauSac MauSac { get; set; }
        public _1.DAL.DomainClass.DongSp DongSp { get; set; }
        public _1.DAL.DomainClass.Nsx Nsx { get; set; }

        public Guid Id { get; set; }
        public string Ma { get; set; }
        public string Ten { get; set; }
    }
}
