using System;

namespace YaHugh
{
    public class SimpleTicker : Ticker
    {
        public SimpleTicker(string stockIdentifier)
        {
            if (stockIdentifier == null)
                throw new ArgumentNullException(nameof(stockIdentifier));
        }
    }
}