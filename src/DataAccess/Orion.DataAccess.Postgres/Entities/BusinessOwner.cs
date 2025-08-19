using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Orion.DataAccess.Progres.Entities;
using ORION.Domain.Aggregates;
using Orion.Domain.Enums;
using Orion.Domain.Tools;
using Orion.Domain.Utility;

namespace Orion.DataAccess.Postgres.Entities
{
    /// <summary>
    /// Business Owner of the database. 
    /// </summary>
    [Table("BusinessOwner")]
    public abstract class BusinessOwner(string businessCity, string businessProvince) : Entity<int>, IBusinessOwner, IValidatableObject
    {
        public void FullUpdate(IBusinessOwner o)
        {
            if (IsTransient())
            {
                Id = o.Id;
            }
            FirstName = o.FirstName;
            LastName = o.LastName;
            ImageFilename = o.ImageFilename;
            BirthDate = o.BirthDate;
            BusinessDate = o.BusinessDate;
            BirthCity = o.BirthCity;
            BirthProvince = o.BirthProvince;
            DaysInOffice = o.DaysInOffice;
            CreateDate = o.CreateDate;
            UpdateDate = o.UpdateDate;
            DeleteDate = o.DeleteDate;
            Status = o.Status;
        }
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        
        public string LastName { get; set; }

        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public string ImageFilename { get; set; }
        

        [Display(Name = "Date of Birth")]
        [DateTimePropertyCompareValidator(
            DateTimeCompareTypeEnum.LessThan, nameof(BusinessDate))]
        [DisplayFormat(DataFormatString = "{0:d}")]
        
        public DateTime BirthDate { get; set; }

        [Display(Name = "Date of Business")]
        [DisplayFormat(DataFormatString = "{0:d}")]
        
        public DateTime BusinessDate { get; set; }

        [Display(Name = "Birth City")]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        
        public string BirthCity { get; set; }

        [Display(Name = "Birth Province")]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        
        public string BirthProvince { get; set; }

        [Display(Name = "Business City")]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public string BusinessCity { get; set; } = businessCity;


        [Display(Name = "Business Province")]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public string BusinessProvince { get; set; } = businessProvince;


        [Display(Name = "Days In Office")]
        public int DaysInOffice { get; private set; }

        public DateTime CreateDate { get; set; } = DateTime.Now;

        public DateTime? UpdateDate { get; set; }

        public DateTime? DeleteDate { get; set; }

        public Status Status { get; set; } = Status.Active;

        public List<Term> Terms { get; private set; }

        public void AddTerm(string role, DateTime startDate, DateTime endDate, int number)
        {
            Terms.Add(new Term
            {
                Role = role,
                StartOfTerm = startDate,
                EndOfTerm = endDate,
                NumberOfTerms = number
            });
        }

        public IEnumerable<ValidationResult> Validate(
            ValidationContext validationContext)
        {
            if (Terms.Count == 0)
            {
                yield return
                    new ValidationResult("BusinessOwner has no terms.");
            }

            if (Terms.Count > 2)
            {
                yield return
                    new ValidationResult("BusinessOwner cannot have more than 2 terms.");
            }
        }
    }
}