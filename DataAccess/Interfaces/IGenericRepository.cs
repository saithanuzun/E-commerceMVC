using System.Linq.Expressions;

namespace DataAccess.Interfaces;

public interface IGenericRepository<T>
{
    T GetById(int id);
    T GetOne(Expression<Func<T, bool>> filter);
    List<T> GetAll(Expression<Func<T, bool>> filter = null);

    void Create(T entity);
    void Update(T entity);
    void Delete(T entity);
}