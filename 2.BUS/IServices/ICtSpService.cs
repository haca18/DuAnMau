using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2.BUS.IServices
{
    public interface ICtSpService
    {
        string Add(ChiTietSpView obj);
        string Delete(ChiTietSpView obj);
        string Update(ChiTietSpView obj);
        List<ChiTietSpView> GetAll();
    }
}
