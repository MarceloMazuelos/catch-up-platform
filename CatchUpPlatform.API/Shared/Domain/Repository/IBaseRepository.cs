namespace CatchUpPlatform.API.Shared.Domain.Repository;

public interface IBaseRepository<TEntity>
{
    Task    AddAsync(TEntity entity);
    Task<TEntity> FindByIdAsync(Guid id);
    Task<IEnumerable<TEntity>> ListAsync();
    void Update(TEntity entity);
    void Delete(TEntity entity);
}