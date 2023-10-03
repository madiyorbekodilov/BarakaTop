using BarakaTop.Domain.Commons;
using BarakatTop.Data.Contexts;
using BarakatTop.Data.IRepasitories;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BarakatTop.Data.Repasitories;

public class Repasitory<T> : IRepasitory<T> where T : Auditable
{
    private readonly AppDbContext appDbContext;
    private readonly DbSet<T> dbSet;
    public Repasitory(AppDbContext appDbContext)
    {
        this.appDbContext = appDbContext;
        dbSet = this.appDbContext.Set<T>();
    }

    public async ValueTask<T> CreateAsync(T entity)
    {
        await this.dbSet.AddAsync(entity);
        return entity;
    }

    public void Destroy(T entity)
    {
        this.dbSet.Remove(entity);  
    }

    public async ValueTask SaveAsync()
    {
        await appDbContext.SaveChangesAsync();
    }

    public IQueryable<T> SelectAll(Expression<Func<T, bool>> expression = null, bool isNoTracked = true, string[] includes = null)
    {
        IQueryable<T> query = expression is null ? dbSet.AsQueryable() : dbSet.Where(expression).AsQueryable();

        query = isNoTracked ? query.AsNoTracking() : query;

        if (includes is not null)
            foreach (var include in includes)
                query = query.Include(include);

        return query;
    }

    public async ValueTask<T> SelectAsync(Expression<Func<T, bool>> expression, string[] includes = null)
    {
        IQueryable<T> query = dbSet.Where(expression).AsQueryable();

        if (includes is not null)
            foreach (var include in includes)
                query = query.Include(include);

        var entity = await query.FirstOrDefaultAsync(expression);
        return entity;
    }

    public void Update(T entity)
    {
        entity.UpdateAt = DateTime.UtcNow;
        appDbContext.Entry(entity).State = EntityState.Modified;
    }
}
