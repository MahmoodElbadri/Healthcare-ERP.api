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

    public async Task<IEnumerable<T>> Find(Expression<Func<T, bool>> expression)
    {
        return await _dbContext.Set<T>().Where(expression).ToListAsync();
    }

    public async Task<T?> Get(int id)
    {
        return await _dbContext.Set<T>().FindAsync(id);
    }

    public async Task<IEnumerable<T>> GetAll()
    {
        return await _dbContext.Set<T>().ToListAsync();
    }

    /// <summary>
    /// Gets all entities of type T with the specified related entities included.
    /// </summary>
    /// <param name="includes">The expressions for the related entities to include.</param>
    /// <returns>Returns all the data of the Table but the Related Tables will be loaded too</returns>

    public async Task<IEnumerable<T>> GetAllWithIncludes(params Expression<Func<T, object>>[] includes)
    {
        IQueryable<T> query = _dbContext.Set<T>();

        if (includes != null)
        {
            foreach (var include in includes)
            {
                query = query.Include(include);
            }
        }

        return await query.AsNoTracking().ToListAsync();
    }

    public async Task<IEnumerable<T>> GetWithIncludesByIdAsync(
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

        return await query.AsNoTracking().Where(x => EF.Property<int>(x, "Id") == id).ToListAsync();
    }


    public async Task Remove(T entity)
    {
        _dbContext.Set<T>().Remove(entity);
    }

    public async Task Update(T entity)
    {
        _dbContext.Set<T>().Update(entity);
    }
}
