using SiparisTakip.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SiparisTakip.Dal.Abstract.BankaHesapDal
{
   public interface IBankaHesapDal
    {
        BankaHesap Kaydet(BankaHesap entity);
        List<BankaHesap> Listele();
        List<BankaHesap> Listele(Expression<Func<BankaHesap, bool>> predicate);
        BankaHesap Getir(int id);
        int Guncelle(BankaHesap entity);

        bool Sil(int id);

        bool Sil(BankaHesap entity);
    }
}
