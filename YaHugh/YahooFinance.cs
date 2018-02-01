using System.Collections.Generic;

namespace YaHugh
{
    public class YahooFinance : MarketDataProvider
    {
        public YahooFinance()
        {
        }

        public IEnumerable<StockQuote> Pull(Ticker ticker, DateRange dateRange)
        {
            return new StockQuote[1];
        }
    }
}