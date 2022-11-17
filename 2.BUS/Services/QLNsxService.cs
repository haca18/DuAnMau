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
    public class QLNsxService : IQLNsxService
    {
        private INsxRepository _iNsxRepos;
        
        public QLNsxService()
        {
            _iNsxRepos = new NsxRepository();
        }

        public string Add(NsxView obj)
        {
            if (obj == null) return "Thêm thất bại";
            var Nsx = new Nsx()
            {
                Ma = obj.Ma,
                Ten = obj.Ten
            };
            if (_iNsxRepos.Add(Nsx)) return "Thêm thành công";
            return "Thêm thất bại";
        }

        public string Delete(NsxView obj)
        {
            if (obj == null) return "Xóa thất bại";
            var Nsx = new Nsx()
            {
                Ma = obj.Ma,
                Ten = obj.Ten
            };
            if (_iNsxRepos.Delete(Nsx)) return "Xóa thành công";
            return "Xóa thất bại";
        }

        public List<NsxView> GetAll()
        {
            throw new NotImplementedException();
        }

        public string Update(NsxView obj)
        {
            if (obj == null) return "Sửa thất bại";
            var Nsx = new Nsx()
            {
                Ma = obj.Ma,
                Ten = obj.Ten
            };
            if (_iNsxRepos.Update(Nsx)) return "Sửa thành công";
            return "Sửa thất bại";
        }
      
    }
}
