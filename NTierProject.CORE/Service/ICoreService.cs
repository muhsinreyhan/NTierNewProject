using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NTierProject.CORE.Service
{
    public interface ICoreService<T> where T:Entity.CoreEntity
    {
        //Ekleme
        void Add(T item);

        //Liste Halinde Ekleme
        void AddList(List<T> item);

        //Güncelleme
        void Update(T item);

        //Silme
        void Remove(T item);

        //Hepsini Silme
        void RemoveAll(Expression<Func<T, bool>> exp);

        //Tekil Olarak Getirme
        T GetById(Guid id);

        //Varsayılan Olarak Getirme
        T GetByDefault(Expression<Func<T, bool>> exp);

        //Aktif Olanları Listeleme
        List<T> GetActive();
        List<T> GetStatus(Expression<Func<T, bool>> exp); //Alternatif

        //Hepsini Listeleme
        List<T> GetAll();

        //Koşula Göre Getirme
        bool Any(Expression<Func<T, bool>> exp);

        //Kaydetme
        int Save();
    }
}
