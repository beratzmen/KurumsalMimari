using SiparisTakip.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SiparisTakip.Dal.Abstract.SektorDal
{
    public  interface ISektorDal
    {
        Sektor Kaydet(Sektor entity);
        List<Sektor> Listele();
        List<Sektor> Listele(Expression<Func<Sektor, bool>> predicate);

        Sektor Getir(int id);
        int Guncelle(Sektor entity);

        bool Sil(int id);

        bool Sil(Sektor entity);
    }
}
