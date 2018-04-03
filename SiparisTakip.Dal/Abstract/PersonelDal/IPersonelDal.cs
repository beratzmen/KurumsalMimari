using SiparisTakip.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SiparisTakip.Dal.Abstract.PersonelDal
{
  public  interface IPersonelDal
    {
        Personel Kaydet(Personel entity);
        List<Personel> Listele();
        List<Personel> Listele(Expression<Func<Personel, bool>> predicate);

        Personel Getir(int id);
        int Guncelle(Personel entity);

        bool Sil(int id);

        bool Sil(Personel entity);
    }
}
