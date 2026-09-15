using System.Linq.Expressions;

namespace Healthcare_ERP.Domain.Interfaces;

public interface IGenericRepository<T> where T : class
{
    Task<T?> Get(int id);
    IQueryable<T> GetAll();
    IQueryable<T> Find(Expression<Func<T, bool>> expression);
    Task<int> CountAsync(Expression<Func<T, bool>> expression);
    Task<decimal> SumAsync(
        Expression<Func<T, bool>> expression,
        Expression<Func<T, decimal>> selector);
    Task<T> Add(T entity);
    Task Update(T entity);
    Task Remove(T entity);
    Task<IQueryable<T>> GetAllWithIncludes(
        params Expression<Func<T, object>>[] includes);

    // Optional: طريقة للـ Single مع Includes
    Task<IQueryable<T>> GetWithIncludesByIdAsync(
        int id,
        params Expression<Func<T, object>>[] includes);

    IQueryable<T> FindWithIncludes(
        Expression<Func<T, bool>> expression,
        params Expression<Func<T, object>>[] includes);
}
