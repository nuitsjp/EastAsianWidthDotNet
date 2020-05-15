using System.Linq;
using EastAsianWidthDotNet;
using Xunit;

namespace UnicodeDictionaryDotNet.Test
{
    namespace EastAsianWidthNormalizerTest
    {
        public class Normalize
        {
            [Fact]
            public void WhenContinuousAndSameKind()
            {
                var ranges = new[]
                {
                new EastAsianWidthRange(1, 2, EastAsianWidthKind.Ambiguous),
                new EastAsianWidthRange(3, 4, EastAsianWidthKind.Ambiguous)
            };
                var normalized = ranges.Normalize().ToArray();

                Assert.Equal(2, normalized.Length);

                Assert.Equal(1, normalized[0].Start);
                Assert.Equal(4, normalized[0].End);
                Assert.Equal(EastAsianWidthKind.Ambiguous, normalized[0].Kind);

                Assert.Equal(5, normalized[1].Start);
                Assert.Equal(int.MaxValue, normalized[1].End);
                Assert.Equal(EastAsianWidthKind.Neutral, normalized[1].Kind);
            }

            [Fact]
            public void WhenContinuousAndDifferentKind()
            {
                var ranges = new[]
                {
                new EastAsianWidthRange(1, 2, EastAsianWidthKind.Ambiguous),
                new EastAsianWidthRange(3, 4, EastAsianWidthKind.Neutral)
            };
                var normalized = ranges.Normalize().ToArray();

                Assert.Equal(2, normalized.Length);

                Assert.Equal(1, normalized[0].Start);
                Assert.Equal(2, normalized[0].End);
                Assert.Equal(EastAsianWidthKind.Ambiguous, normalized[0].Kind);

                Assert.Equal(3, normalized[1].Start);
                Assert.Equal(int.MaxValue, normalized[1].End);
                Assert.Equal(EastAsianWidthKind.Neutral, normalized[1].Kind);
            }

            [Fact]
            public void WhenDiscontinuousAndNotNeutral()
            {
                var ranges = new[]
                {
                new EastAsianWidthRange(1, 2, EastAsianWidthKind.Ambiguous),
                new EastAsianWidthRange(4, 5, EastAsianWidthKind.Ambiguous)
            };
                var normalized = ranges.Normalize().ToArray();

                Assert.Equal(4, normalized.Length);

                Assert.Equal(1, normalized[0].Start);
                Assert.Equal(2, normalized[0].End);
                Assert.Equal(EastAsianWidthKind.Ambiguous, normalized[0].Kind);

                Assert.Equal(3, normalized[1].Start);
                Assert.Equal(3, normalized[1].End);
                Assert.Equal(EastAsianWidthKind.Neutral, normalized[1].Kind);

                Assert.Equal(4, normalized[2].Start);
                Assert.Equal(5, normalized[2].End);
                Assert.Equal(EastAsianWidthKind.Ambiguous, normalized[2].Kind);

                Assert.Equal(6, normalized[3].Start);
                Assert.Equal(int.MaxValue, normalized[3].End);
                Assert.Equal(EastAsianWidthKind.Neutral, normalized[3].Kind);
            }

            [Fact]
            public void WhenDiscontinuousAndNeutral()
            {
                var ranges = new[]
                {
                new EastAsianWidthRange(1, 2, EastAsianWidthKind.Neutral),
                new EastAsianWidthRange(4, 5, EastAsianWidthKind.Neutral)
            };
                var normalized = ranges.Normalize().ToArray();

                Assert.Single(normalized);

                Assert.Equal(1, normalized[0].Start);
                Assert.Equal(int.MaxValue, normalized[0].End);
                Assert.Equal(EastAsianWidthKind.Neutral, normalized[0].Kind);
            }
        }
    }
}
