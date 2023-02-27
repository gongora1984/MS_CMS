using Microsoft.EntityFrameworkCore;

namespace CMSSERVICE.INFRASTRUCTURE.Repositories;

internal class GenericRepository<T> : IGenericRepository<T>
    where T : class
{
    private readonly ApplicationDbContext _dbContext;
    private readonly DbSet<T> dbSet;
    public GenericRepository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
        dbSet = dbContext.Set<T>();
    }

    public virtual async Task<bool> Add(T entity)
    {
        await dbSet.AddAsync(entity);
        return true;
    }

    public virtual async Task<bool> Update(T entity)
    {
        dbSet.Update(entity);
        await _dbContext.SaveChangesAsync();
        return true;
    }

    ////public Task<bool> Update(T entity) =>
    ////    _dbContext.Set<T>().Update(entity);
}
