using _1.DAL.Context;
using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.DAL.Repositories
{
    public class MauSacRepository : IMauSacRepository
    {
        FpolyDBContext _DBcontext;
        public MauSacRepository()
        {
            _DBcontext=new FpolyDBContext();
        }
        public bool Add(MauSac obj)
        {
            if (obj == null) return false;
            _DBcontext.MauSacs.Add(obj);
            _DBcontext.SaveChanges();
            return true;
        }

        public bool Delete(MauSac obj)
        {
            if (obj == null) return false;
            var tempobj = _DBcontext.MauSacs.FirstOrDefault(x => x.Ma == obj.Ma);
            _DBcontext.Remove(tempobj);
            _DBcontext.SaveChanges();
            return true;
        }

        public List<MauSac> GetAll()
        {
            return _DBcontext.MauSacs.ToList();
        }

        public MauSac GetById(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _DBcontext.MauSacs.FirstOrDefault(c => c.Id == id);
        }

        public bool Update(MauSac obj)
        {
            if (obj == null) return false;
            var tempobj = _DBcontext.MauSacs.FirstOrDefault(x => x.Ma == obj.Ma);
            tempobj.Ma = obj.Ma;
            tempobj.Ten=obj.Ten;
            _DBcontext.Update(tempobj);
            _DBcontext.SaveChanges();
            return true;
        }
    }
}
