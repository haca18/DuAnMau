using _1.DAL.Context;
using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.DAL.Repositories
{
    public class KhachHangRepository : IKhachHangRepository
    {
        FpolyDBContext _DBcontext;
        public KhachHangRepository()
        {
            _DBcontext=new FpolyDBContext();
        }

        public bool Add(KhachHang obj)
        {
            if (obj == null) return false;
            _DBcontext.KhachHangs.Add(obj);
            _DBcontext.SaveChanges();
            return true;
        }

        public bool Delete(KhachHang obj)
        {
            if (obj == null) return false;
            var tempobj = _DBcontext.KhachHangs.FirstOrDefault(x => x.Ma == obj.Ma);
            _DBcontext.Remove(tempobj);
            _DBcontext.SaveChanges();
            return true;
        }

        public List<KhachHang> GetAll()
        {
            return _DBcontext.KhachHangs.ToList();
        }

        public KhachHang GetById(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _DBcontext.KhachHangs.FirstOrDefault(c => c.Id == id);
        }

        public bool Update(KhachHang obj)
        {
            if (obj == null) return false;
            var tempobj = _DBcontext.KhachHangs.FirstOrDefault(x => x.Ma == obj.Ma);
            tempobj.Ma = obj.Ma;
            tempobj.Ten=obj.Ten;
            tempobj.TenDem = obj.TenDem;
            tempobj.Ho=obj.Ho;
            tempobj.NgaySinh=obj.NgaySinh;
            tempobj.Sdt = obj.Sdt;
            tempobj.DiaChi=obj.DiaChi;
            tempobj.ThanhPho = obj.ThanhPho;
            tempobj.QuocGia=obj.QuocGia;
            tempobj.MatKhau = obj.MatKhau;
            _DBcontext.Update(tempobj);
            _DBcontext.SaveChanges();
            return true;
        }
    }
}
