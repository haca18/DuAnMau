using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1.DAL.IRepositories
{
    public interface ICTHoaDonRepository
    {
        bool Add(HoaDonChiTiet obj);
        bool Update(HoaDonChiTiet obj);
        bool Delete(HoaDonChiTiet obj);
        HoaDonChiTiet GetById(Guid id);
        List<HoaDonChiTiet> GetAll();
    }
}
