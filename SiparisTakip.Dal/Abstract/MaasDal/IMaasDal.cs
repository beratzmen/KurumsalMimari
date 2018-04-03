using SiparisTakip.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SiparisTakip.Dal.Abstract.MaasDal
{
    public interface IMaasDal
    {
        Maas Kaydet(Maas entity);
        List<Maas> Listele();
        List<Maas> Listele(Expression<Func<Maas, bool>> predicate);

        Maas Getir(int id);
        int Guncelle(Maas entity);

        bool Sil(int id);

        bool Sil(Maas entity);

    }
}
