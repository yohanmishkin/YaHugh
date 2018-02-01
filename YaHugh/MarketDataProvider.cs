using System.Collections.Generic;

namespace YaHugh
{
    public interface MarketDataProvider
    {
        IEnumerable<StockQuote> Pull(Ticker ticker, DateRange dateRange);
    }
}