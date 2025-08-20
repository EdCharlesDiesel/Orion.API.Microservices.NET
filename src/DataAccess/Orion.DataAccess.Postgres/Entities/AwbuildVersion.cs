using Orion.Domain.Tools;

namespace Orion.DataAccess.Postgres.Entities
{
    public class AwbuildVersion:Entity<Guid>   {
        public byte SystemInformationId { get; set; }
        public string DatabaseVersion { get; set; }
        public DateTime VersionDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
