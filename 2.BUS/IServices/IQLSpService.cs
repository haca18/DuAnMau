using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2.BUS.IServices
{
    public interface IQLSpService
    {
        string Add(SanPhamView obj);
        string Delete(SanPhamView obj);
        string Update(SanPhamView obj);
        List<SanPhamView> GetAll();

      
           
    }
}
