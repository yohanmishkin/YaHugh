using System;
using Xunit;

namespace YaHugh.Tests
{
    public class SimpleDateRangeTests
    {
        [Fact]
        public void ValidDateRange()
        {
            var startDate = new DateTime(1900, 1, 1);
            var endDate = new DateTime(2000, 1, 1);

            var dateRange =
                new SimpleDateRange(
                    startDate,
                    endDate
                );

            Assert.NotNull(dateRange); 
            Assert.Equal(startDate.Day, dateRange.StartDay());
            Assert.Equal(startDate.Month, dateRange.StartMonth());
            Assert.Equal(startDate.Year, dateRange.StartYear());
            Assert.Equal(endDate.Day, dateRange.EndDay());
            Assert.Equal(endDate.Month, dateRange.EndMonth());
            Assert.Equal(endDate.Year, dateRange.EndYear());
        }

        [Fact]
        public void EndDatePriorToStartDateCheck()
        {
            var exception = Assert.Throws<ArgumentException>(
                () => new SimpleDateRange(
                    new DateTime(2000, 1, 1),
                    new DateTime(1900, 1, 1)
                )
            );

            Assert.Equal(
                "StartDate must be a date prior to (or equal to) the EndDate.", 
                exception.Message
            );
        }
    }
}
