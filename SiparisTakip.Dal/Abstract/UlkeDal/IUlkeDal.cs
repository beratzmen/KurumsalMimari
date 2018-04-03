using SiparisTakip.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SiparisTakip.Dal.Abstract.UlkeDal
{
 public   interface IUlkeDal
    {
        Ulke Kaydet(Ulke entity);
        List<Ulke> Listele();
        List<Ulke> Listele(Expression<Func<Ulke, bool>> predicate);

        Ulke Getir(int id);
        int Guncelle(Ulke entity);

        bool Sil(int id);

        bool Sil(Ulke entity);
    }
}
