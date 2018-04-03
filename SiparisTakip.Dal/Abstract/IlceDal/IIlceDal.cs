using SiparisTakip.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SiparisTakip.Dal.Abstract.IlceDal
{
    public  interface IIlceDal
    {
        Ilce Kaydet(Ilce entity);
        List<Ilce> Listele();
        List<Ilce> Listele(Expression<Func<Ilce, bool>> predicate);
        Ilce Getir(int id);
        int Guncelle(Ilce entity);

        bool Sil(int id);

        bool Sil(Ilce entity);
    }
}
