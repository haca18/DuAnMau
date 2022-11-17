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
    public class QLSanPhamService : ICTSpService
    {
        private ISanPhamRepository _iSpRepos;

        public QLSanPhamService()
        {
            _iSpRepos = new SanPhamRepository();
        }

      

        public string Add(SanPhamView obj)
        {
            throw new NotImplementedException();
        }

       
        public string Delete(SanPhamView obj)
        {
            throw new NotImplementedException();
        }

      
     
        public string Update(SanPhamView obj)
        {
            throw new NotImplementedException();
        }

        List<SanPhamView> ICTSpService.All => throw new NotImplementedException();
    }
}
