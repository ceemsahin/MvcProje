using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepository<T>
    {
        void Insert(T p);   //(Ekle)
        List<T> List();     //(Oku-Listele)
        T Get(Expression<Func<T,bool>> filter);
        void Delete(T p);   //(Sil)
        void Update(T p);   //(Güncelle)

        List<T> List(Expression<Func<T,bool>> filter); //şartlı listeleme

    }
}
