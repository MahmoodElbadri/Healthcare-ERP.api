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

    public async Task Add(T entity)
    {
        await _dbContext.Set<T>().AddAsync(entity);
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

    public async Task Remove(T entity)
    {
        _dbContext.Set<T>().Remove(entity);
    }

    public async Task Update(T entity)
    {
        _dbContext.Set<T>().Update(entity);
    }

}
