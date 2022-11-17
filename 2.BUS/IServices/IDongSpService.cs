using _1.DAL.DomainClass;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2.BUS.IServices
{
    public interface IDongSpService
    {
        string Add(DongSpView obj);
        string Delete(DongSpView obj);
        string Update(DongSpView obj);
        List<DongSpView> GetAll(String input);

        //List<string> GetLoc();
    }
}
