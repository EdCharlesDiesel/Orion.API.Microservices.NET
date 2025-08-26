using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Orion.DataAccess.Postgres.Entities.ECommerce
{
    [Table("Sales.Currency")]
    [Description("Lookup table containing standard ISO currencies.")]
    public class Currency
    {
        public Currency()
        {
            this.CountryRegionCurrencies = new List<CountryRegionCurrency>();
            this.CurrencyRates = new List<CurrencyRate>();
            this.CurrencyRates1 = new List<CurrencyRate>();
        }

        [Key]
        [Column(name:"CurrencyCode", TypeName = "nchar")]
        [MaxLength(3)]
        [StringLength(3)]
        [Required(ErrorMessage = "Currency Code is required")]
        [Display(Name = "Currency Code")]
        [Description("The ISO code for the Currency.")]
        public string CurrencyCode { get; set; } // nchar(3)
        [Column(name:"Name", TypeName = "nvarchar")]
        [MaxLength(50)]
        [StringLength(50)]
        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Name")]
        [Description("Currency name.")]
        public string Name { get; set; } // nvarchar(50)
        [Column(name:"ModifiedDate", TypeName = "datetime")]
        [Required(ErrorMessage = "Modified Date is required")]
        [Display(Name = "Modified Date")]
        [Description("Date and time the record was last updated.")]
        public DateTime? ModifiedDate { get; set; } // datetime

        // Sales.CountryRegionCurrency.CurrencyCode -> Sales.Currency.CurrencyCode (FK_CountryRegionCurrency_Currency_CurrencyCode)
        public IEnumerable<CountryRegionCurrency> CountryRegionCurrencies { get; set; }
        // Sales.CurrencyRate.FromCurrencyCode -> Sales.Currency.CurrencyCode (FK_CurrencyRate_Currency_FromCurrencyCode)
        public IEnumerable<CurrencyRate> CurrencyRates { get; set; }
        // Sales.CurrencyRate.ToCurrencyCode -> Sales.Currency.CurrencyCode (FK_CurrencyRate_Currency_ToCurrencyCode)
        public IEnumerable<CurrencyRate> CurrencyRates1 { get; set; }
    }
}
