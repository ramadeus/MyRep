using Project.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.DesignPatterns.GenericRepositoryPattern.IntRep
{
    public interface IRepository<T> where T:BaseEntity
    {
        T Find(int id);
        //listeleme metodları
        List<T> GetAll();
        List<T> GetActives();
        List<T> GetPassives();
        List<T> GetUpdateds();



        // modifikasyon metodları
        void Add(T item);
        void Delete(T item);
        void Update(T item);
        void Remove(T item);



        //linq metodları

        List<T> Where(Expression<Func<T, bool>> exp);
        T GetDefault(Expression<Func<T, bool>> exp);
        object Select(Expression<Func<T, bool>> exp);
        bool Any(Expression<Func<T, bool>> exp);



    }
}
