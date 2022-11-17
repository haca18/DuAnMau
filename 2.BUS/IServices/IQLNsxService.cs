using _1.DAL.DomainClass;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2.BUS.IServices
{
    public interface IQLNsxService
    {
        string Add(NsxView obj);
        string Delete(NsxView obj);
        string Update(NsxView obj);
        List<NsxView> GetAll();



    }
}
