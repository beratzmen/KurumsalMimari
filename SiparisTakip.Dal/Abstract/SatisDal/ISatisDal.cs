using SiparisTakip.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SiparisTakip.Dal.Abstract.SatisDal
{
   public interface ISatisDal
    {
        Satis Kaydet(Satis entity);
        List<Satis> Listele();
        List<Satis> Listele(Expression<Func<Satis, bool>> predicate);

        Satis Getir(int id);
        int Guncelle(Satis entity);

        bool Sil(int id);

        bool Sil(Satis entity);
    }
}
