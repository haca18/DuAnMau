using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2.BUS.Services
{
    public class MauSacService : IMauSacService
    {
        private IMauSacRepository _iMauSacRepos;

        public MauSacService()
        {
            _iMauSacRepos = new MauSacRepository();
        }

        public string Add(MauSacView obj)
        {
            if (obj == null) return "Thêm thất bại";
            var mauSac = new MauSac()
            {
                Ma = obj.Ma,
                Ten = obj.Ten
            };
            if (_iMauSacRepos.Add(mauSac)) return "Thêm thành công";
            return "Thêm thất bại";
        }

        public string Delete(MauSacView obj)
        {
            if (obj == null) return "Xóa thất bại";
            var mauSac = new MauSac()
            {
                Ma = obj.Ma,
                Ten = obj.Ten
            };
            if (_iMauSacRepos.Delete(mauSac)) return "Xóa thành công";
            return "Xóa thất bại";
        }

        public List<MauSacView> GetAll()
        {
            List<MauSacView> lst = new List<MauSacView>();
            lst =
                (
                    from a in _iMauSacRepos.GetAll()
                    select new MauSacView()
                    {
                        Id = a.Id,
                        Ma = a.Ma,
                        Ten = a.Ten,
                        Ca = "Ha",
                    }
                ).ToList();
            return lst;
        }

        public string Update(MauSacView obj)
        {
            if (obj == null) return "Sửa thất bại";
            var mauSac = new MauSac()
            {
                //    DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn thêm sản phẩn này?", "Xác nhận", MessageBoxButtons.YesNo);
                //if (dialogResult == DialogResult.Yes)
                // int rowIndex = e.RowIndex;
                //if (rowIndex == _iMauSacService.GetAll().Count) return;
                //_maClick = dgrid_Mau.Rows[rowIndex].Cells[1].Value.ToString();
                //var obj = _iMauSacService.GetAll().FirstOrDefault(c => c.Ma == _maClick);
                //txt_Ma.Text = obj.Ma;
                //txt_Ten.Text = obj.Ten;
                Ma = obj.Ma,
                Ten = obj.Ten

            };
            if (_iMauSacRepos.Update(mauSac)) return "Sửa thành công";
            return "Sửa thất bại";
        }


    }
}
