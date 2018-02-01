using System;
using System.Collections.Generic;
using System.Net;

namespace YaHugh
{
    public class YahooFinance : MarketDataProvider
    {
        public YahooFinance()
        {
        }

        public IEnumerable<StockQuote> Pull(Ticker ticker, DateRange dateRange)
        {
            var url = 
                "http://chart.finance.yahoo.com/table.csv?"
                    + $"s={ticker}&"
                    + $"a={dateRange.StartMonth()}&"
                    + $"b={dateRange.StartDay()}&"
                    + $"c={dateRange.StartYear()}&"
                    + $"d={dateRange.EndMonth()}&"
                    + $"e={dateRange.EndDay()}&"
                    + $"f={dateRange.EndYear()}&"
                    + "g=d&ignore=.csv";

            using (var webClient = new WebClient())
            {
                var csvData = webClient.DownloadString(url);

                if (string.IsNullOrEmpty(csvData))
                    throw new InvalidOperationException();
            }

            return new StockQuote[1];
        }
    }
}