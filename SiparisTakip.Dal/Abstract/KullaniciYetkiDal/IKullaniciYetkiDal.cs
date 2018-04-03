using SiparisTakip.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SiparisTakip.Dal.Abstract.KullaniciYetkiDal
{
    public   interface IKullaniciYetkiDal
    {
        KullaniciYetki Kaydet(KullaniciYetki entity);
        List<KullaniciYetki> Listele();
        List<KullaniciYetki> Listele(Expression<Func<KullaniciYetki, bool>> predicate);

        KullaniciYetki Getir(int id);
        int Guncelle(KullaniciYetki entity);

        bool Sil(int id);

        bool Sil(KullaniciYetki entity);
    }
}
