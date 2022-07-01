using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
  public  interface IAdminService
    {

        List<Admın> GetList();
        void AdminAdd(Admın admin);
        Admın GetByID(int id);
        void AdminDelete(Admın admin);
        void AdminUpdate(Admın admin);

    }
}
