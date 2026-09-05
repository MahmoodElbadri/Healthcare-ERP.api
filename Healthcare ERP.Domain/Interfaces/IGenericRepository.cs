using System.Linq.Expressions;

namespace Healthcare_ERP.Domain.Interfaces;

public interface IGenericRepository<T> where T : class
{
    Task<T?> Get(int id);
    Task<IEnumerable<T>> GetAll();
    Task<IEnumerable<T>> Find(Expression<Func<T, bool>> expression);
    Task <T>Add(T entity);
    Task Update(T entity);
    Task Remove(T entity);
    Task<IEnumerable<T>> GetAllWithIncludes(
        params Expression<Func<T, object>>[] includes);

    // Optional: طريقة للـ Single مع Includes
    Task<IEnumerable<T>> GetWithIncludesByIdAsync(
        int id,
        params Expression<Func<T, object>>[] includes);
}
