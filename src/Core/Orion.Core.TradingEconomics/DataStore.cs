using System.Globalization;
using Orion.Core.TradingEconomics.Domain;


namespace Orion.Core.TradingEconomics
{
    public class DataStore
    {
        private readonly Dictionary<string, Company> _companies = new Dictionary<string, Company>();

        private static Dictionary<string, IEnumerable<StockPrice>> _stocks 
            = new Dictionary<string, IEnumerable<StockPrice>>();

        private string BasePath { get; }

        public DataStore(string basePath)
        {
            this.BasePath = basePath;
        }

        public async Task<Dictionary<string, IEnumerable<StockPrice>>> LoadStocks()
        {
            if (_stocks.Any()) return _stocks;

            await LoadCompanies();

            var prices = await GetStockPrices();

            _stocks = prices
                .GroupBy(x => x.Ticker)
                .ToDictionary(x => x.Key, x => x.AsEnumerable());

            return _stocks;
        }

        private async Task LoadCompanies()
        {
            using var stream = new StreamReader(File.OpenRead(Path.Combine(BasePath, @"CompanyData.csv")));
            await stream.ReadLineAsync();

            while (await stream.ReadLineAsync() is { } line)
            {
                #region Loading and Adding Company to In-Memory Dictionary

                var segments = line.Split(',');

                for (var i = 0; i < segments.Length; i++) segments[i] = segments[i].Trim('\'', '"');

                var company = new Company
                {
                    Symbol = segments[0],
                    CompanyName = segments[1],
                    Exchange = segments[2],
                    Industry = segments[3],
                    Website = segments[4],
                    Description = segments[5],
                    CEO = segments[6],
                    IssueType = segments[7],
                    Sector = segments[8]
                };

                if (!_companies.ContainsKey(segments[0]))
                {
                    _companies.Add(segments[0], company);
                }

                #endregion
            }
        }


        private async Task<IList<StockPrice>> GetStockPrices()
        {
            var prices = new List<StockPrice>();

            using var stream =
                new StreamReader(File.OpenRead(Path.Combine(BasePath, @"StockPrices_Small.csv")));
            await stream.ReadLineAsync(); // Skip headers

            while (await stream.ReadLineAsync() is { } line)
            {
                var segments = line.Split(',');

                for (var i = 0; i < segments.Length; i++) segments[i] = segments[i].Trim('\'', '"');
                var price = new StockPrice
                {
                    Ticker = segments[0],
                    TradeDate = DateTime.ParseExact(segments[1], "M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture),
                    Volume = Convert.ToInt32(segments[6], CultureInfo.InvariantCulture),
                    Change = Convert.ToDecimal(segments[7], CultureInfo.InvariantCulture),
                    ChangePercent = Convert.ToDecimal(segments[8], CultureInfo.InvariantCulture),
                };
                prices.Add(price);
            }

            return prices;
        }
    }
}
