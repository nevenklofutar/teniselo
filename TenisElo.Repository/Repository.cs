using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TenisElo.Data;

namespace TenisElo.Repository
{

    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly ApplicationContext Context;

        public Repository(ApplicationContext context)
        {
            Context = context;
        }

        public TEntity Get(int id)
        {
            // Here we are working with a DbContext, not PlutoContext. So we don't have DbSets 
            // such as Courses or Authors, and we need to use the generic Set() method to access them.
            return Context.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            // Note that here I've repeated Context.Set<TEntity>() in every method and this is causing
            // too much noise. I could get a reference to the DbSet returned from this method in the 
            // constructor and store it in a private field like _entities. This way, the implementation
            // of our methods would be cleaner:
            // 
            // _entities.ToList();
            // _entities.Where();
            // _entities.SingleOrDefault();
            // 
            // I didn't change it because I wanted the code to look like the videos. But feel free to change
            // this on your own.
            return Context.Set<TEntity>().ToList();
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return Context.Set<TEntity>().Where(predicate);
        }

        public TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate)
        {
            return Context.Set<TEntity>().SingleOrDefault(predicate);
        }

        public void Add(TEntity entity)
        {
            Context.Set<TEntity>().Add(entity);
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            Context.Set<TEntity>().AddRange(entities);
        }

        public void Remove(TEntity entity)
        {
            Context.Set<TEntity>().Remove(entity);
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            Context.Set<TEntity>().RemoveRange(entities);
        }
    }

    //public class Repository<T> : IRepository<T> where T : class
    //{
    //    private readonly ApplicationContext context;
    //    private DbSet<T> entities;
    //    string errorMessage = string.Empty;

    //    public Repository(ApplicationContext context)
    //    {
    //        this.context = context;
    //        entities = context.Set<T>();
    //    }
    //    public IQueryable<T> GetAll()
    //    {
    //        return entities.AsQueryable();
    //    }

    //    public T Get(long id)
    //    {
    //        return entities.Find(id);
    //    }
    //    public IQueryable<T> GetQueryable()
    //    {
    //        return entities.AsQueryable();
    //    }
    //    public IQueryable<T> GetQueryable(long id)
    //    {
    //        return entities.Where(x => x.Id == id).AsQueryable();
    //    }
    //    public void Insert(T entity)
    //    {
    //        if (entity == null)
    //        {
    //            throw new ArgumentNullException("entity");
    //        }
    //        entities.Add(entity);
    //        SaveChange();
    //    }

    //    public void Update(T entity)
    //    {
    //        if (entity == null)
    //        {
    //            throw new ArgumentNullException("entity");
    //        }
    //        SaveChange();
    //    }

    //    public void Delete(T entity)
    //    {
    //        if (entity == null)
    //        {
    //            throw new ArgumentNullException("entity");
    //        }
    //        entities.Remove(entity);
    //        SaveChange();
    //    }
    //    private void SaveChange()
    //    {
    //        context.SaveChanges();
    //    }
    //}
}
