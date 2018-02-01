using System;

namespace YaHugh
{
    public class SimpleDateRange : DateRange
    {
        private DateTime dateTime1;
        private DateTime dateTime2;

        public SimpleDateRange(DateTime dateTime1, DateTime dateTime2)
        {
            this.dateTime1 = dateTime1;
            this.dateTime2 = dateTime2;
        }
    }
}