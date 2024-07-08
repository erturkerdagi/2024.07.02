using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LayerDataAccess
{
    public class GenericRepo<T> : IGenericDAL<T> where T : class
    {
        DbConnect db = new DbConnect();
        public void Ekle(T t)
        {
            db.Add(t);
            db.SaveChanges();
        }
        public void Sil(T t) 
        { 
            db.Remove(t);
            db.SaveChanges();
        }
        public T Getir(int id)
        {
            return db.Set<T>().Find(id);
        }
        public T Getir(T t) 
        {
            return db.Set<T>().Find(t);
        }
        public List<T> Getir(Expression<Func<T, bool>> filtre) { 
            return db.Set<T>().Where(filtre).ToList();
        }
        public void Guncelle(T t)
        {
            db.Update(t);
            db.SaveChanges();
        }
        public List<T> TumunuGetir()
        {
            return db.Set<T>().ToList();
        }
    }
}
