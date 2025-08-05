using Orion.API.CompetitionScorecard.Data;
using Orion.Core.CompetitionScorecard.Domain;
using Orion.Services.CompetitionScorecard.API.Services;

namespace Orion.API.CompetitionScorecard.Repositories;

public class CompetitionScorecardRepository(CompetitionScorecardContext context) : ICompetitionScorecardServices
{
       public async Task<IEnumerable<Coupon>> GetAllAsync()
    {
        var coupons =  context.Coupons.ToList();
        if (coupons == null || !coupons.Any())
            throw new ArgumentException("coupons be null or empty.");

        return coupons.ToList();
    }
    public async Task<List<Coupon>> CreateCoupons(List<Coupon> coupons)
    {
        if (coupons == null)
            throw new ArgumentException("coupon be null or empty.");

        await context.Coupons.AddRangeAsync(coupons);
        await context.SaveChangesAsync();
        
        return coupons;
    }

    //TODO: Add comments
    public async Task<Coupon> Create(List<Coupon> coupons)
    {
        if (coupons == null || !coupons.Any())
            throw new ArgumentException("coupon be null or empty.");

        await context.Coupons.AddRangeAsync(coupons);
        await context.SaveChangesAsync();

        // Return the first created event (or you can change this to return the list)
        return coupons.First();
    }

    public async Task<Coupon?> GetByIdAsync(object id)
    {
        throw new NotImplementedException();
    }

    public async Task<Coupon?> GetByIdAsync(Guid id)
    {
        var coupon =  context.Coupons.FirstOrDefault(x => x.Id == id);
        if (coupon == null )
            throw new ArgumentException("coupon id cannot be null or empty.");

        return coupon;
    }

    public async Task<Coupon> AddAsync(Coupon coupon)
    {
        if (coupon == null)
            throw new ArgumentException("Coupon cannot be null or empty.");

        await context.Coupons.AddAsync(coupon);
        await context.SaveChangesAsync();


        return coupon;
    }

    public async Task UpdateAsync(Coupon entity)
    {
        var coupon =  context.Coupons.FirstOrDefault(x => x.Id == entity.Id);
        if (coupon == null)
            throw new ArgumentException("Coupon cannot be null or empty.");

        context.Coupons.Update(coupon);
        await context.SaveChangesAsync();
    }

    public async Task DeleteAsync(object id)
    {
        throw new NotImplementedException();
    }

    public async Task<Coupon> BuildCreate(List<Coupon> coupons)
    {
        throw new NotImplementedException();
    }

    public async Task DeleteAsync(Guid id)
    {
        var coupon =  context.Coupons.FirstOrDefault(x => x.Id == id);
        if (coupon == null)
            throw new ArgumentException("Coupon cannot be null or empty.");

        context.Coupons.Remove(coupon);
        await context.SaveChangesAsync();
    }
    
    public async Task BulkCreate(List<Coupon> coupons)
    {
        if (coupons == null)
            throw new ArgumentException("Coupons cannot be null or empty.");

        await context.Coupons.AddRangeAsync(coupons);
        await context.SaveChangesAsync();
    }

}