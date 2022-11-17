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
    public class DongSpService : IDongSpService
    {
        private IDongSpRepository _iDongSpRepos;

        public DongSpService()
        {
            _iDongSpRepos = new DongSpRepository();
        }

        public string Add(DongSpView obj)
        {
            if (obj == null) return "Thêm thất bại";
            var dongSP = new DongSp()
            {
                Ma = obj.Ma,
                Ten = obj.Ten
            };
            if (_iDongSpRepos.Add(dongSP)) return "Thêm thành công";
            return "Thêm thất bại";
        }

        public string Delete(DongSpView obj)
        {

            if (obj == null) return "Xóa thất bại";
            var dongSP = new DongSp()
            {
                Ma = obj.Ma,
                Ten = obj.Ten
            };
            if (_iDongSpRepos.Delete(dongSP)) return "Xóa thành công";
            return "Xóa thất bại";
        }

        public List<DongSpView> GetAll(string input)
        {
            List<DongSpView> lst = new List<DongSpView>();
            lst =
                (
                    from a in _iDongSpRepos.GetAll()
                    select new DongSpView()
                    {
                        Id = a.Id,
                        Ma = a.Ma,
                        Ten = a.Ten,
                    }
                ).ToList();
            return lst;
        }

       
        public string Update(DongSpView obj)
        {

            if (obj == null) return "Sửa thất bại";
            var dongSP = new DongSp()
            {
                Ma = obj.Ma,
                Ten = obj.Ten
            };
            if (_iDongSpRepos.Update(dongSP)) return "Sửa thành công";
            return "Sửa thất bại";
        }
    }
}
