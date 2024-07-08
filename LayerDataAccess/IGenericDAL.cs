using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LayerDataAccess
{
    public interface IGenericDAL<T> where T : class
    {
        void Ekle(T t);
        void Sil(T t);
        void Guncelle(T t);
        List<T> TumunuGetir();
        T Getir(int id);
        T Getir(T t);
        List<T> Getir(Expression<Func<T, bool>> filtre);
    }
}