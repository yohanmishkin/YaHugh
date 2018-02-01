using System;

namespace YaHugh
{
    public class SimpleDateRange : DateRange
    {
        public SimpleDateRange(DateTime startDate, DateTime endDate)
        {
            throw new ArgumentException("StartDate must be a date prior to (or equal to) the EndDate.");
        }
    }
}