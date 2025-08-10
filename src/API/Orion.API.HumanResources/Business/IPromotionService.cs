using Orion.API.HumanResources.DataAccess.Entities;

namespace Orion.API.HumanResources.Business;

public interface IPromotionService
{
    Task<bool> PromoteCalendarAsync(Calendar employee);
}