using SiparisTakip.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SiparisTakip.Dal.Abstract.IsyeriDal
{
  public  interface IIsyeriDal
    {
        Isyeri Kaydet(Isyeri entity);
        List<Isyeri> Listele();
        List<Isyeri> Listele(Expression<Func<Isyeri, bool>> predicate);

        Isyeri Getir(int id);
        int Guncelle(Isyeri entity);

        bool Sil(int id);

        bool Sil(Isyeri entity);
    }
}
