using _1.DAL.DomainClass;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using SanPham = _1.DAL.DomainClass.SanPham;

namespace _2.BUS.IServices
{
    public interface ICTSpService
    {
        string Add(SanPhamView obj);
        string Delete(SanPhamView obj);
        string Update(SanPhamView obj);
        List<SanPhamView> All { get; }
    }
}
