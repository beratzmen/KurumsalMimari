using SiparisTakip.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SiparisTakip.Dal.Abstract.BankaHesapHareketDal
{
   public interface IBankaHesapHareketDal
    {
        BankaHesapHareket Kaydet(BankaHesapHareket entity);
        List<BankaHesapHareket> Listele();
        List<BankaHesapHareket> Listele(Expression<Func<BankaHesapHareket, bool>> predicate);
        BankaHesapHareket Getir(int id);
        int Guncelle(BankaHesapHareket entity);

        bool Sil(int id);

        bool Sil(BankaHesapHareket entity);
    }
}
