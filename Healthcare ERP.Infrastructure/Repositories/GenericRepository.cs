using System.Linq.Expressions;
using Healthcare_ERP.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Healthcare_ERP.Infrastructure.Repositories;

public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    private readonly DbContext _dbContext;

    public GenericRepository(DbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<T> Add(T entity)
    {
        var res = await _dbContext.Set<T>().AddAsync(entity);
        return res.Entity;
    }

    public IQueryable<T> FindWithIncludes(
        Expression<Func<T, bool>> expression,
        params Expression<Func<T, object>>[] includes)
    {
        IQueryable<T> query = _dbContext.Set<T>().Where(expression);

        foreach (var include in includes)
        {
            query = query.Include(include);
        }

        return query;
    }

    public Task<decimal> SumAsync(
        Expression<Func<T, bool>> expression,
        Expression<Func<T, decimal>> selector)
    {
        return _dbContext.Set<T>()
            .Where(expression)
            .SumAsync(selector);
    }

    public Task<int> CountAsync(
        Expression<Func<T, bool>> expression)
    {
        return _dbContext.Set<T>()
            .Where(expression)
            .CountAsync();
    }

    public IQueryable<T> Find(Expression<Func<T, bool>> expression)
    {
        return _dbContext.Set<T>().Where(expression);
    }

    public async Task<T?> Get(int id)
    {
        return await _dbContext.Set<T>().FindAsync(id);
    }

    public IQueryable<T> GetAll()
    {
        return _dbContext.Set<T>();
    }

    /// <summary>
    /// Gets all entities of type T with the specified related entities included.
    /// </summary>
    /// <param name="includes">The expressions for the related entities to include.</param>
    /// <returns>Returns all the data of the Table but the Related Tables will be loaded too</returns>

    public Task<IQueryable<T>> GetAllWithIncludes(params Expression<Func<T, object>>[] includes)
    {
        IQueryable<T> query = _dbContext.Set<T>();

        if (includes != null)
        {
            foreach (var include in includes)
            {
                query = query.Include(include);
            }
        }

        return Task.FromResult(query);
    }

    public Task<IQueryable<T>> GetWithIncludesByIdAsync(
        int id,
        params Expression<Func<T, object>>[] includes)
    {
        IQueryable<T> query = _dbContext.Set<T>();

        if (includes != null)
        {
            foreach (var include in includes)
            {
                query = query.Include(include);
            }
        }

        return Task.FromResult(query.Where(x => EF.Property<int>(x, "Id") == id));
    }

    public Task Remove(T entity)
    {
        _dbContext.Set<T>().Remove(entity);
        return Task.CompletedTask;
    }

    public Task Update(T entity)
    {
        _dbContext.Set<T>().Update(entity);
        return Task.CompletedTask;
    }
}
