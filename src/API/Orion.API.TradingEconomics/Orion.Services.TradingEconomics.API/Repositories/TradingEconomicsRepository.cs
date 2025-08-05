using Orion.Core.TradingEconomics.Domain;
using Orion.Services.TradingEconomics.API.Services;

namespace Orion.Services.TradingEconomics.API.Repositories;

public class TradingEconomicsRepository: IRepository<CalendarEvent>
{
    public async Task<IEnumerable<CalendarEvent>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public async Task<CalendarEvent?> GetByIdAsync(object id)
    {
        throw new NotImplementedException();
    }

    public async Task AddAsync(CalendarEvent entity)
    {
        throw new NotImplementedException();
    }

    public async Task UpdateAsync(CalendarEvent entity)
    {
        throw new NotImplementedException();
    }

    public async Task DeleteAsync(object id)
    {
        throw new NotImplementedException();
    }
}