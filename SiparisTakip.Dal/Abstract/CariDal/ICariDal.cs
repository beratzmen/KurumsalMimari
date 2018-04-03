using SiparisTakip.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SiparisTakip.Dal.Abstract.CariDal
{
   public interface ICariDal
    {
        Cari Kaydet(Cari entity);
        List<Cari> Listele();
        List<Cari> Listele(Expression<Func<Cari, bool>> predicate);
        Cari Getir(int id);
        int Guncelle(Cari entity);

        bool Sil(int id);

        bool Sil(Cari entity);
    }
}
