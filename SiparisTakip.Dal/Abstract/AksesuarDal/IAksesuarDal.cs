using SiparisTakip.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SiparisTakip.Dal.Abstract.AksesuarDal
{
   public  interface IAksesuarDal
    {
        Aksesuar Kaydet(Aksesuar entity);
        List<Aksesuar> Listele();
        List<Aksesuar> Listele(Expression<Func<Aksesuar, bool>> predicate);
        Aksesuar Getir(int id);
        int Guncelle(Aksesuar entity);

        bool Sil(int id);

        bool Sil(Aksesuar entity);
    }
}
