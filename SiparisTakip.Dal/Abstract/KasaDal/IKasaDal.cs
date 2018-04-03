using SiparisTakip.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SiparisTakip.Dal.Abstract.KasaDal
{
 public   interface IKasaDal
    {
        Kasa Kaydet(Kasa entity);
        List<Kasa> Listele();
        List<Kasa> Listele(Expression<Func<Kasa, bool>> predicate);

        Kasa Getir(int id);
        int Guncelle(Kasa entity);

        bool Sil(int id);

        bool Sil(Kasa entity);
    }
}
