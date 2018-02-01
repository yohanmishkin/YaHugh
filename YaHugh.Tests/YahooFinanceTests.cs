using System;
using Xunit;

namespace YaHugh.Tests
{
    public class YahooFinanceTests
    {
        [Fact]
        public void PullStockQuotes()
        {
            Ticker ticker = new SimpleTicker("securityIdentifier");

            DateRange dateRange =
                new SimpleDateRange(
                    new DateTime(2012, 12, 12),
                    new DateTime(2013, 12, 1)
                );

            MarketDataProvider yahooFinance = new YahooFinance();

            Assert.NotEmpty(
                yahooFinance.Pull(ticker, dateRange)
            );
        }

        [Fact]
        public void NoReturnedDataThrowsInvalidOperationException()
        {
            Ticker strangeTicker = new SimpleTicker(
                Guid.NewGuid().ToString()
            );

            DateRange dateRange =
                new SimpleDateRange(
                    new DateTime(2012, 11, 12),
                    new DateTime(2013, 11, 1)
                );

            MarketDataProvider yahooFinance = new YahooFinance();

            Assert.Throws<InvalidOperationException>(
                () => yahooFinance.Pull(strangeTicker, dateRange)
            );
        }
    }
}
