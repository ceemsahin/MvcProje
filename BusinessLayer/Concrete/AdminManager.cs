using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AdminManager : IAdminService
    {
        IAdminDal _adminDal;

        public AdminManager(IAdminDal adminDal)
        {
            _adminDal = adminDal;
        }

        public void AdminAdd(Admın admin)
        {
            _adminDal.Insert(admin);
        }

        public void AdminDelete(Admın admin)
        {
            _adminDal.Delete(admin);
        }

        public void AdminUpdate(Admın admin)
        {
            _adminDal.Update(admin);
        }

        public Admın GetByID(int id)
        {
            return _adminDal.Get(x => x.AdminId == id);
        }

        public List<Admın> GetList()
        {
            return _adminDal.List();
        }
    }
}
