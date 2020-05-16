using EastAsianWidthDotNet;
using Xunit;

namespace UnicodeDictionaryDotNet.Test
{
    namespace EastAsianWidthParserTest
    {
        public class Parse
        {
            [Fact]
            public void ForKind()
            {
                var ranges = EastAsianWidthParser.Parse(@"
0000;A  # Comment
0001;F  # Comment
0002;H  # Comment
0003;Na # Comment
0004;W  # Comment
0005;N  # Comment
");

                Assert.Equal(6, ranges.Count);

                Assert.Equal(EastAsianWidthKind.Ambiguous, ranges[0].Kind);
                Assert.Equal(EastAsianWidthKind.FullWidth, ranges[1].Kind);
                Assert.Equal(EastAsianWidthKind.HalfWidth, ranges[2].Kind);
                Assert.Equal(EastAsianWidthKind.Narrow, ranges[3].Kind);
                Assert.Equal(EastAsianWidthKind.Wide, ranges[4].Kind);
                Assert.Equal(EastAsianWidthKind.Neutral, ranges[5].Kind);
            }

            [Fact]
            public void ForRangeWhenSingle()
            {
                var ranges = EastAsianWidthParser.Parse(@"
0000;A  # Comment
");
                Assert.Equal(0, ranges[0].Start);
                Assert.Equal(0, ranges[0].End);
            }

            [Fact]
            public void ForRangeWhenRange()
            {
                var ranges = EastAsianWidthParser.Parse(@"
0000..00FF;A  # Comment
");
                Assert.Equal(0, ranges[0].Start);
                Assert.Equal(0x00FF, ranges[0].End);
            }

            [Fact]
            public void WhenEmpty()
            {
                var ranges = EastAsianWidthParser.Parse("#\r\r");
                Assert.Empty(ranges);
            }
        }

    }
}