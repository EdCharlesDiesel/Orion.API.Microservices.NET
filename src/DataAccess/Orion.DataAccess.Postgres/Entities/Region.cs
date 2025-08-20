using System.ComponentModel.DataAnnotations;
using Orion.Domain.Aggregates;
using Orion.Domain.Enums;
using Orion.Domain.Tools;

namespace Orion.DataAccess.Postgres.Entities
{
    public class Region: Entity<int>, IRegion
    {
        public void FullUpdate(IRegion o)
        {
            throw new NotImplementedException();
        }

        [MaxLength(50)]
        [Required(ErrorMessage = "Region Description is required")]
        public string RegionDescription { get; set; }

        public ICollection<Territory> Territories { get; set; }

        private DateTime _createDate = DateTime.Now;
        
        public DateTime CreateDate { get => _createDate; set => _createDate = value; }

        public DateTime? UpdateDate { get; set; }

        public DateTime? DeleteDate { get; set; }

        private Status _status = Status.Active;
        
        public Status Status { get => _status; set => _status = value; }  
    }
}
