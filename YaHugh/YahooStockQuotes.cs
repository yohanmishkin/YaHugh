using System.Collections.Generic;

namespace YaHugh
{
    public class YahooStockQuotes : StockQuotes
    {
        private Ticker ticker;
        private DateRange dateRange;

        public YahooStockQuotes(Ticker ticker, DateRange dateRange)
        {
            this.ticker = ticker;
            this.dateRange = dateRange;
        }

        public IEnumerable<StockQuotes> Pull()
        {
            throw new System.NotImplementedException();
        }
    }
}