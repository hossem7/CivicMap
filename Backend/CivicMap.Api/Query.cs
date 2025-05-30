using CivicMap.Domain.Entities;
using CivicMap.Infrastructure.Db;
using Microsoft.EntityFrameworkCore;

namespace CivicMap.Api
{
    public class Query
    {
        public IQueryable<Policy> GetPolicies([Service] IDbContextFactory<AppDbContext> contextFactory) =>
        contextFactory.CreateDbContext().Policies;
    }
}
