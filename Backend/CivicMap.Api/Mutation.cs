using CivicMap.Domain.Entities;
using CivicMap.Infrastructure.Db;

namespace CivicMap.Api
{
    public class Mutation
    {
        public async Task<Policy> AddPolicy(
        string title,
        string summary,
        string category,
        DateTime effectiveDate,
        int cityId,
        List<string> impactedAreas,
        List<string> referenceUrl,
        [Service] AppDbContext db)
        {
            var policy = new Policy
            {
                Title = title,
                Summary = summary,
                Category = category,
                EffectiveDate = effectiveDate,
                CityId = cityId,
                ImpactedAreas = impactedAreas,
                ReferenceUrl = referenceUrl
            };

            db.Policies.Add(policy);
            await db.SaveChangesAsync();
            return policy;
        }
    }
}
