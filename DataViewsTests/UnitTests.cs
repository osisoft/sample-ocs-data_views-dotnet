using Xunit;

namespace DataViewsTests
{
    public class UnitTests
    {
        [Fact]
        public void DataViewsTest()
        {
            Assert.True(DataViews.Program.MainAsync(true).Result);
        }
    }
}
