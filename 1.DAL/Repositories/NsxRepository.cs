using _1.DAL.Context;
using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.DAL.Repositories
{
    public class NsxRepository : INsxRepository
    {
        FpolyDBContext _DBcontext;
        public NsxRepository()
        {
            _DBcontext=new FpolyDBContext();
        }
        public bool Add(Nsx obj)
        {
            if (obj == null) return false;
            _DBcontext.Nsxes.Add(obj);
            _DBcontext.SaveChanges();
            return true;
        }

        public bool Delete(Nsx obj)
        {
            if (obj == null) return false;
            var tempobj = _DBcontext.Nsxes.FirstOrDefault(x => x.Ma == obj.Ma);
            _DBcontext.Remove(tempobj);
            _DBcontext.SaveChanges();
            return true;
        }

        public List<Nsx> GetAll()
        {
            return _DBcontext.Nsxes.ToList();
        }

        public Nsx GetById(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _DBcontext.Nsxes.FirstOrDefault(c => c.Id == id);
        }

        public bool Update(Nsx obj)
        {
            if (obj == null) return false;
            var tempobj = _DBcontext.Nsxes.FirstOrDefault(x => x.Ma == obj.Ma);
            tempobj.Ma = obj.Ma;
            tempobj.Ten = obj.Ten;
            _DBcontext.Update(tempobj);
            _DBcontext.SaveChanges();
            return true;
        }
    }
}
