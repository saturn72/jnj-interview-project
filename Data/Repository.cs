using interview_challenge.Domain;

namespace interview_challenge.Data;

public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
{
    private readonly List<UserSession> _sessions = [];

    public Task UpdateAsync(TEntity entity)
    {
        throw new NotImplementedException();
    }

    public Task CreateAsync(TEntity entity)
    {
        throw new NotImplementedException();
    }
}
