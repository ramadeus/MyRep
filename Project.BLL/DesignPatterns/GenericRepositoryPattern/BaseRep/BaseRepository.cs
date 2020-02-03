using Project.BLL.DesignPatterns.GenericRepositoryPattern.IntRep;
using Project.BLL.DesignPatterns.SingletonPattern;
using Project.DAL.Context;
using Project.MODEL.Entities;
using Project.MODEL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.DesignPatterns.GenericRepositoryPattern.BaseRep
{
    public abstract class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        public BaseRepository()
        {
            db = DBTool.DbInstance;
        }
        protected MyContext db;
        void Save()
        {
            db.SaveChanges();
        }
        public void Add(T item)
        {
            db.Set<T>().Add(item);
            Save();
        }

        public bool Any(Expression<Func<T, bool>> exp)
        {
            return db.Set<T>().Any(exp);
        }

        public void Delete(T item)
        {
            item.DeletedTime = DateTime.Now;
            item.Status = DataStatus.Deleted;
            Save();
        }

        public T Find(int id)
        {
            return db.Set<T>().Find(id);
        }

        public List<T> GetActives()
        {
           return Where(x => x.Status != DataStatus.Deleted);
        }

        public List<T> GetAll()
        {
            return db.Set<T>().ToList();
        }

        public T GetDefault(Expression<Func<T, bool>> exp)
        {
            return db.Set<T>().FirstOrDefault(exp);
        }

        public List<T> GetPassives()
        {
            return Where(x => x.Status == DataStatus.Deleted);
        }

        public List<T> GetUpdateds()
        {
            return Where(x => x.Status == DataStatus.Updated);
        }

        public void Remove(T item)
        {
            db.Set<T>().Remove(item);
            Save();
        }

        public object Select(Expression<Func<T, bool>> exp)
        {
            return db.Set<T>().Select(exp);
        }

        public void Update(T item)
        {
            item.Status = DataStatus.Updated;
            item.UpdatedTime = DateTime.Now;
            T guncellenecek = db.Set<T>().Find(item.ID);
            db.Entry(guncellenecek).CurrentValues.SetValues(item);
            Save();
        }

        public List<T> Where(Expression<Func<T, bool>> exp)
        {
            throw new NotImplementedException();
        }
    }
}
