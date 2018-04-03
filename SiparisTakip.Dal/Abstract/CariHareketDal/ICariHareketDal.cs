using SiparisTakip.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SiparisTakip.Dal.Abstract.CariHareketDal
{
  public  interface ICariHareketDal
    {
        CariHareket Kaydet(CariHareket entity);
        List<CariHareket> Listele();
        List<CariHareket> Listele(Expression<Func<CariHareket, bool>> predicate);
        CariHareket Getir(int id);
        int Guncelle(CariHareket entity);

        bool Sil(int id);

        bool Sil(CariHareket entity);
    }
}
