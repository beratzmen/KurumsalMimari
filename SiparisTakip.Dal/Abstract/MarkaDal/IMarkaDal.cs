using SiparisTakip.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SiparisTakip.Dal.Abstract.MarkaDal
{
   public interface IMarkaDal
    {
        Marka Kaydet(Marka entity);
        List<Marka> Listele();
        List<Marka> Listele(Expression<Func<Marka, bool>> predicate);

        Marka Getir(int id);
        int Guncelle(Marka entity);

        bool Sil(int id);

        bool Sil(Marka entity);
    }
}
