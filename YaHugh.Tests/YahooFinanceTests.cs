using System;
using Xunit;

namespace YaHugh.Tests
{
    public class YahooFinanceTests
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

            MarketDataProvider yahooFinance = new YahooFinance();

            Assert.NotEmpty(
                yahooFinance.Pull(ticker, dateRange)
            );
        }
    }
}
