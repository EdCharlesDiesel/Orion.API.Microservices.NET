using System.ComponentModel.DataAnnotations.Schema;
using Orion.DataAccess.Postgres.Aggregates;
using Orion.Domain.Enums;

namespace Orion.DataAccess.Postgres.Entities;

/// <summary>
/// Orion Calendar of the database. 
/// </summary>
[Table("OrionCalendarEvent")]
public class OrionCalendarEvent: IBaseEntity
{
    public string Reference { get; set; }
    public DateTime? LastUpdate { get; set; }
    public DateTime? Date { get; set; }
    public DateTime? ReferenceDate { get; set; }
    public Guid Id { get; set; }
    public DateTime CreateDate { get; set; }
    public DateTime? UpdateDate { get; set; }
    public DateTime? DeleteDate { get; set; }
    public Status Status { get; set; }
    public int JobLevel { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public object Salary { get; set; }
    public object SuggestedBonus { get; set; }
    public object YearsInService { get; set; }
}