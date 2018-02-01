using System;
using Xunit;

namespace YaHugh.Tests
{
    public class SimpleDateRangeTests
    {
        [Fact]
        public void ValidDateRange()
        {
            Assert.NotNull(
                new SimpleDateRange(
                    new DateTime(1900, 1, 1),
                    new DateTime(2000, 1, 1)
                )
            );
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
