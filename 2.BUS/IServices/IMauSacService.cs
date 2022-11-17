using _1.DAL.DomainClass;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2.BUS.IServices
{
    public interface IMauSacService
    {
        string Add(MauSacView obj);
        string Delete(MauSacView obj);
        string Update(MauSacView obj);

        List<MauSacView> GetAll();
    }
}
