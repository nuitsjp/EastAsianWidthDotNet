using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace UnicodeDictionaryDotNet.Test
{
    namespace UnicodeDictionaryTest
    {
        public class GetEastAsianWidthRangesAsync
        {
            [Fact]
            public async Task WhenNormal()
            {
                var ranges = await UnicodeDictionary.GetEastAsianWidthRangesAsync();
                Assert.True(ranges.Any());
            }
        }
    }
}