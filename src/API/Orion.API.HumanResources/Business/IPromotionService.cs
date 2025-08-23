using System.Globalization;

namespace Orion.API.HumanResources.Business;

public interface IPromotionService
{
    Task<bool> PromoteCalendarAsync(Calendar employee);
}