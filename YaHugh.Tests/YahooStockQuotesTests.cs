using System;
using System.Collections.Generic;
using Xunit;

namespace YaHugh.Tests
{
    public class YahooStockQuotesTests
    {
        [Fact]
        public void Test()
        {
            Ticker ticker = new SimpleTicker("securityIdentifier");
            DateRange dateRange =
                new SimpleDateRange(
                    new DateTime(2012, 12, 12),
                    new DateTime(2013, 12, 1)
                );

            IEnumerable<StockQuotes> yahooQuotes =
                new YahooStockQuotes(
                    ticker,
                    dateRange
                ).Pull();

            Assert.NotEmpty(yahooQuotes);
        }
    }
}
