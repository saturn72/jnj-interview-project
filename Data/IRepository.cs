namespace interview_challenge.Data;

public interface IRepository<TEntity> where TEntity : class
{
    Task UpdateAsync(TEntity entity);
    Task CreateAsync(TEntity entity);
}
