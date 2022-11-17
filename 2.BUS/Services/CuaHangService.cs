using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2.BUS.Services
{
    public class CuaHangService : ICuaHangService
    {
        private ICuaHangRepository _iCuaHangRepos;
        public CuaHangService()
        {
            _iCuaHangRepos = new CuaHangRepository();
        }

        public string Add(CuaHangView obj)
        {

            if (obj == null) return "Thêm thất bại";
            var cuaHang = new CuaHang()
            {
                Ma = obj.Ma,
                Ten = obj.Ten
            };
            if (_iCuaHangRepos.Add(cuaHang)) return "Thêm thành công";
            return "Thêm thất bại";
        }

        public string Delete(CuaHangView obj)
        {
            if (obj == null) return "Xóa thất bại";
            var cuaHang = new CuaHang()
            {
                Ma = obj.Ma,
                Ten = obj.Ten
            };
            if (_iCuaHangRepos.Delete(cuaHang)) return "Xóa thành công";
            return "Xóa thất bại";
        }

        public List<CuaHangView> GetAll()
        {
            throw new NotImplementedException();
        }

        public string Update(CuaHangView obj)
        {
            if (obj == null) return "Sửa thất bại";
            var cuaHang = new CuaHang()
            {
                Ma = obj.Ma,
                Ten = obj.Ten
            };
            if (_iCuaHangRepos.Update(cuaHang)) return "Sửa thành công";
            return "Sửa thất bại";
        }
       
    }
}
