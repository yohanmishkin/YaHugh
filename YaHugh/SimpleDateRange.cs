using System;

namespace YaHugh
{
    public class SimpleDateRange : DateRange
    {
        private readonly DateTime startDate;
        private readonly DateTime endDate;

        public SimpleDateRange(DateTime startDate, DateTime endDate)
        {
            if (endDate < startDate)
                throw new ArgumentException("StartDate must be a date prior to (or equal to) the EndDate.");

            this.startDate = startDate;
            this.endDate = endDate;
        }

        public int StartDay()
        {
            return this.startDate.Day;
        }

        public int StartMonth()
        {
            return this.startDate.Month;
        }

        public int StartYear()
        {
            return this.startDate.Year;
        }

        public int EndDay()
        {
            return this.endDate.Day;
        }

        public int EndMonth()
        {
            return this.endDate.Month;
        }

        public int EndYear()
        {
            return this.endDate.Year;
        }
    }
}