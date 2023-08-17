using System.Linq.Expressions;
using DataAccess.Interfaces;
using Entities.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories;

public abstract class GenericRepository<T,TContext> : IGenericRepository<T> 
    where T : BaseEntity  where TContext : DbContext , new()
{
    public T GetById(int id)
    {
        using (var context = new TContext())
        {
            return context.Set<T>().Find(id);
        }
    }

    public T GetOne(Expression<Func<T, bool>> filter)
    {
        using (var context = new TContext())
        {
            return context.Set<T>().Where(filter).SingleOrDefault();
        }
    }

    public List<T> GetAll(Expression<Func<T, bool>> filter = null)
    {
        using (var context = new TContext())
        {
            return filter == null
                ? context.Set<T>().ToList()
                : context.Set<T>().Where(filter).ToList();
        }
    }

    public void Create(T entity)
    {
        using (var context = new TContext())
        {
            context.Set<T>().Add(entity);
            context.SaveChanges();
        }
    }

    public void Update(T entity)
    {
        using (var context = new TContext())
        {
            context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }
    }

    public void Delete(T entity)
    {
        using (var context = new TContext())
        {
            context.Set<T>().Remove(entity);
            context.SaveChanges();
        }
    }
}