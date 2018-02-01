using System;
using Xunit;

namespace YaHugh.Tests
{
    public class SimpleTickerTests
    {
        [Fact]
        public void NullIdentifier()
        {
            var exception = Assert.Throws<ArgumentNullException>(
                () => new SimpleTicker(null)
            );

            Assert.Equal(
                "Value cannot be null.\r\nParameter name: stockIdentifier", 
                exception.Message
            );
        }
    }
}
