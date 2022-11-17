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
    public class ChucVuService : IChucVuService
    {

        private IChucVuRepository _iChucVuRepos;
        public ChucVuService()
        {
            _iChucVuRepos = new ChucVuRepository();
        }

        public string Add(ChucVuView obj)
        {
            if (obj == null) return "Thêm thất bại";
            var chucvu = new ChucVu()
            {
                Ma = obj.Ma,
                Ten = obj.Ten
            };
            if (_iChucVuRepos.Add(chucvu)) return "Thêm thành công";
            return "Thêm thất bại";
        }

        public string Delete(ChucVuView obj)
        {
            if (obj == null) return "Xóa thất bại";
            var chucvu = new ChucVu()
            {
                Ma = obj.Ma,
                Ten = obj.Ten
            };
            if (_iChucVuRepos.Delete(chucvu)) return "Xóa thành công";
            return "Xóa thất bại";
        }

        public List<ChucVuView> GetAll()
        {
            List<ChucVuView> lst = new List<ChucVuView>();
            lst =
                (
                    from a in _iChucVuRepos.GetAll()
                    select new ChucVuView()
                    {
                        Id = a.Id,
                        Ma = a.Ma,
                        Ten = a.Ten,
                    }
                ).ToList();
            return lst;
        }

        public string Update(ChucVuView obj)
        {
            if (obj == null) return "Sửa thất bại";
            var chucvu = new ChucVu()
            {
                Ma = obj.Ma,
                Ten = obj.Ten
            };
            if (_iChucVuRepos.Update(chucvu)) return "Sửa thành công";
            return "Sửa thất bại";
        }
        
    }
}
