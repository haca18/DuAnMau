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
    public class QLSpService : IQLSpService
    {
        private IChiTietSpRepository _iChiTietSpRepos;
        private IDongSpRepository _iDongSpRepos;
        private INsxRepository _iNsxRepos;
        private ISanPhamRepository _iSanPhamRepos;
        private IMauSacRepository _iMauSacRepos;
        public QLSpService()
        {
            _iChiTietSpRepos = new ChiTietSpRepository();
            _iDongSpRepos = new DongSpRepository();
            _iNsxRepos = new NsxRepository();
            _iSanPhamRepos = new SanPhamRepository();
            _iMauSacRepos = new MauSacRepository();
        }
        public string Add(SanPhamView obj)
        {
            if (obj == null) return "Thêm không thành công òi nè";
            var chiTietSp = obj.ChiTietSp;
            if (_iChiTietSpRepos.Add(chiTietSp)) return "Thêm thành công nè";
            return "Thêm thất bại đó";
        }

        public string Delete(SanPhamView obj)
        {
            if (obj == null) return "Xóa không thành công òi nè";
            var chiTietSp = obj.ChiTietSp;
            if (_iChiTietSpRepos.Delete(chiTietSp))
                return "Xóa thành công nè";
            return "Xóa thất bại đó";
        }

        public List<SanPhamView> GetAll()
        {
            List<SanPhamView> lstSpViews = new List<SanPhamView>();
            lstSpViews =
                (from a in _iChiTietSpRepos.GetAll()
                 join b in _iMauSacRepos.GetAll() on a.IdMauSac equals b.Id
                 join c in _iSanPhamRepos.GetAll() on a.IdSp equals c.Id
                 join d in _iDongSpRepos.GetAll() on a.IdDongSp equals d.Id
                 join e in _iNsxRepos.GetAll() on a.IdNsx equals e.Id
                 select new SanPhamView()
                 {
                     ChiTietSp = a,
                     MauSac = b,
                     SanPham = c,
                     DongSp = d,
                     Nsx = e,
                 }).ToList();
            return lstSpViews;
        }

        public string Update(SanPhamView obj)
        {
            if (obj == null) return "Sửa không thành công òi nè";
            var chiTietSp = obj.ChiTietSp;
            if (_iChiTietSpRepos.Update(chiTietSp)) return "Sửa thành công nè";
            return "Sửa thất bại đó";
        }
    }
}
