using System.Collections.Generic;

namespace YaHugh
{
    public interface StockQuotes
    {
        IEnumerable<StockQuotes> Pull();
    }
}