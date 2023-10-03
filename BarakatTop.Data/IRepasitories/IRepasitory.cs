using System.Linq.Expressions;
using BarakaTop.Domain.Commons;

namespace BarakatTop.Data.IRepasitories;

public interface IRepasitory<T> where T : Auditable
{
    ValueTask CreateAsync(T entity);
    void Update(T entity);
    void Delete(T entity);
    void Destroy(T entity);
    ValueTask<T> SelectAsync(Expression<Func<T, bool>> expression, string[] includes = null);
    IQueryable<T> SelectAll(Expression<Func<T, bool>> expression = null, bool isNoTracked = true, string[] includes = null);
    ValueTask SaveAsync();
}
