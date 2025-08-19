using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Orion.Domain.Aggregates;
using Orion.Domain.Enums;

namespace Orion.DataAccess.Postgres.Entities;

/// <summary>
/// Current version number of the database. 
/// </summary>
[Table("BuildVersion")]
public class BuildVersion:IBaseEntity
{
    /// <summary>
    /// Primary key for AWBuildVersion records.
    /// </summary>
    [Key]
    [Column("SystemInformationID")]
    public byte SystemInformationId { get; set; }

    /// <summary>
    /// Version number of the database in 9.yy.mm.dd.00 format.
    /// </summary>
    [Required]
    [Column("Database Version")]
    [StringLength(25)]
    public string DatabaseVersion { get; set; }

    /// <summary>
    /// Date and time the record was last updated.
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime VersionDate { get; set; }

    /// <summary>
    /// Date and time the record was last updated.
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime ModifiedDate { get; set; }

    public DateTime CreateDate { get; set; }
    public DateTime? UpdateDate { get; set; }
    public DateTime? DeleteDate { get; set; }
    public Status Status { get; set; }
}