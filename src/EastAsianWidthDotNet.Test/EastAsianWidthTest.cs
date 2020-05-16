using System.Globalization;
using Xunit;

namespace EastAsianWidthDotNet.Test
{
    namespace EastAsianWidthTest
    {
        [Collection("Depends on CultureInfo.CurrentUICulture")]
        public class GetWidthString
        {
            [Fact]
            public void WhenIaAsian()
            {
                CultureInfo.CurrentUICulture = CultureInfo.GetCultureInfo("ja-JP");
                var eastAsianWidth = new EastAsianWidth(new TestProvider());

                string value = new string(new[] { (char)0, (char)3 });
                Assert.Equal(3, eastAsianWidth.GetWidth(value));
            }

            [Fact]
            public void WhenIsNotAsian()
            {
                CultureInfo.CurrentUICulture = CultureInfo.GetCultureInfo("az-Cyrl-AZ");
                var eastAsianWidth = new EastAsianWidth(new TestProvider());

                string value = new string(new[] { (char)0, (char)3 });
                Assert.Equal(2, eastAsianWidth.GetWidth(value));
            }

            private class TestProvider : IEastAsianWidthRangesProvider
            {
                public EastAsianWidthRange[] Resolve()
                {
                    return new[]
                    {
                        new EastAsianWidthRange(0, 0, EastAsianWidthKind.Ambiguous),
                        new EastAsianWidthRange(1, 2, EastAsianWidthKind.FullWidth),
                        new EastAsianWidthRange(3, 4, EastAsianWidthKind.HalfWidth),
                        new EastAsianWidthRange(5, 6, EastAsianWidthKind.Narrow),
                        new EastAsianWidthRange(7, 7, EastAsianWidthKind.Wide),
                        new EastAsianWidthRange(8, 9, EastAsianWidthKind.Neutral),
                    };
                }
            }
        }

        public class GetWidthStringCultureInfo
        {
            [Fact]
            public void WhenIaAsian()
            {
                var eastAsianWidth = new EastAsianWidth(new TestProvider());

                string value = new string(new[] { (char)0, (char)3 });
                Assert.Equal(3, eastAsianWidth.GetWidth(value, CultureInfo.GetCultureInfo("ja-JP")));
            }

            [Fact]
            public void WhenIsNotAsian()
            {
                var eastAsianWidth = new EastAsianWidth(new TestProvider());

                string value = new string(new[] { (char)0, (char)3 });
                Assert.Equal(2, eastAsianWidth.GetWidth(value, CultureInfo.GetCultureInfo("az-Cyrl-AZ")));
            }

            private class TestProvider : IEastAsianWidthRangesProvider
            {
                public EastAsianWidthRange[] Resolve()
                {
                    return new[]
                    {
                        new EastAsianWidthRange(0, 0, EastAsianWidthKind.Ambiguous),
                        new EastAsianWidthRange(1, 2, EastAsianWidthKind.FullWidth),
                        new EastAsianWidthRange(3, 4, EastAsianWidthKind.HalfWidth),
                        new EastAsianWidthRange(5, 6, EastAsianWidthKind.Narrow),
                        new EastAsianWidthRange(7, 7, EastAsianWidthKind.Wide),
                        new EastAsianWidthRange(8, 9, EastAsianWidthKind.Neutral),
                    };
                }
            }
        }

        public class GetWidthStringBool
        {
            [Fact]
            public void WhenIaAsian()
            {
                var eastAsianWidth = new EastAsianWidth(new TestProvider());

                string value = new string(new []{ (char)0, (char)3 });
                Assert.Equal(3, eastAsianWidth.GetWidth(value, true));
            }

            [Fact]
            public void WhenIsNotAsian()
            {
                var eastAsianWidth = new EastAsianWidth(new TestProvider());

                string value = new string(new[] { (char)0, (char)3 });
                Assert.Equal(2, eastAsianWidth.GetWidth(value, false));
            }

            private class TestProvider : IEastAsianWidthRangesProvider
            {
                public EastAsianWidthRange[] Resolve()
                {
                    return new[]
                    {
                        new EastAsianWidthRange(0, 0, EastAsianWidthKind.Ambiguous),
                        new EastAsianWidthRange(1, 2, EastAsianWidthKind.FullWidth),
                        new EastAsianWidthRange(3, 4, EastAsianWidthKind.HalfWidth),
                        new EastAsianWidthRange(5, 6, EastAsianWidthKind.Narrow),
                        new EastAsianWidthRange(7, 7, EastAsianWidthKind.Wide),
                        new EastAsianWidthRange(8, 9, EastAsianWidthKind.Neutral),
                    };
                }
            }
        }

        [Collection("Depends on CultureInfo.CurrentUICulture")]
        public class IsFullWidth
        {
            [Fact]
            public void WhenAsian()
            {
                CultureInfo.CurrentUICulture = CultureInfo.GetCultureInfo("ja-JP");

                var eastAsianWidth = new EastAsianWidth(new TestProvider());
                Assert.True(eastAsianWidth.IsFullWidth((char)0));
            }

            [Fact]
            public void WhenNotAsian()
            {
                CultureInfo.CurrentUICulture = CultureInfo.GetCultureInfo("ru-RU");

                var eastAsianWidth = new EastAsianWidth(new TestProvider());
                Assert.False(eastAsianWidth.IsFullWidth((char)0));
            }


            private class TestProvider : IEastAsianWidthRangesProvider
            {
                public EastAsianWidthRange[] Resolve()
                {
                    return new[]
                    {
                        new EastAsianWidthRange(0, 0, EastAsianWidthKind.Ambiguous)
                    };
                }
            }
        }

        public class IsFullWidthCharCultureInfo
        {
            [Fact]
            public void WhenAsian()
            {
                var eastAsianWidth = new EastAsianWidth(new TestProvider());
                Assert.True(eastAsianWidth.IsFullWidth((char)0, CultureInfo.GetCultureInfo("ja-JP")));
            }

            [Fact]
            public void WhenNotAsian()
            {
                var eastAsianWidth = new EastAsianWidth(new TestProvider());
                Assert.False(eastAsianWidth.IsFullWidth((char)0, CultureInfo.GetCultureInfo("ru-RU")));
            }


            private class TestProvider : IEastAsianWidthRangesProvider
            {
                public EastAsianWidthRange[] Resolve()
                {
                    return new[]
                    {
                        new EastAsianWidthRange(0, 0, EastAsianWidthKind.Ambiguous)
                    };
                }
            }
        }

        public class IsFullWidthCharBool
        {
            [Fact]
            public void WhenAmbiguousAndIsAsian()
            {
                var eastAsianWidth = new EastAsianWidth(new TestProvider());
                Assert.True(eastAsianWidth.IsFullWidth((char)0, true));
            }

            [Fact]
            public void WhenAmbiguousAndIsNotAsian()
            {
                var eastAsianWidth = new EastAsianWidth(new TestProvider());
                Assert.False(eastAsianWidth.IsFullWidth((char)0, false));
            }

            [Fact]
            public void WhenFullWidth()
            {
                var eastAsianWidth = new EastAsianWidth(new TestProvider());

                Assert.True(eastAsianWidth.IsFullWidth((char)1, true));
                Assert.True(eastAsianWidth.IsFullWidth((char)1, false));
            }

            [Fact]
            public void WhenHalfWidth()
            {
                var eastAsianWidth = new EastAsianWidth(new TestProvider());

                Assert.False(eastAsianWidth.IsFullWidth((char)4, true));
                Assert.False(eastAsianWidth.IsFullWidth((char)4, false));
            }

            [Fact]
            public void WhenNarrow()
            {
                var eastAsianWidth = new EastAsianWidth(new TestProvider());

                Assert.False(eastAsianWidth.IsFullWidth((char)5, true));
                Assert.False(eastAsianWidth.IsFullWidth((char)5, false));
            }

            [Fact]
            public void WhenWide()
            {
                var eastAsianWidth = new EastAsianWidth(new TestProvider());

                Assert.True(eastAsianWidth.IsFullWidth((char)7, true));
                Assert.True(eastAsianWidth.IsFullWidth((char)7, false));
            }

            [Fact]
            public void WhenNeutral()
            {
                var eastAsianWidth = new EastAsianWidth(new TestProvider());

                Assert.False(eastAsianWidth.IsFullWidth((char)9, true));
                Assert.False(eastAsianWidth.IsFullWidth((char)9, false));
            }

            private class TestProvider : IEastAsianWidthRangesProvider
            {
                public EastAsianWidthRange[] Resolve()
                {
                    return new[]
                    {
                        new EastAsianWidthRange(0, 0, EastAsianWidthKind.Ambiguous),
                        new EastAsianWidthRange(1, 2, EastAsianWidthKind.FullWidth),
                        new EastAsianWidthRange(3, 4, EastAsianWidthKind.HalfWidth),
                        new EastAsianWidthRange(5, 6, EastAsianWidthKind.Narrow),
                        new EastAsianWidthRange(7, 7, EastAsianWidthKind.Wide),
                        new EastAsianWidthRange(8, 9, EastAsianWidthKind.Neutral),
                    };
                }
            }
        }

        public class GetKind
        {
            [Fact]
            public void WhenNormal()
            {
                var eastAsianWidth = new EastAsianWidth(new TestProvider());

                Assert.Equal(EastAsianWidthKind.Ambiguous, eastAsianWidth.GetKind((char)0));
                Assert.Equal(EastAsianWidthKind.FullWidth, eastAsianWidth.GetKind((char)1));
                Assert.Equal(EastAsianWidthKind.HalfWidth, eastAsianWidth.GetKind((char)4));
                Assert.Equal(EastAsianWidthKind.Narrow, eastAsianWidth.GetKind((char)5));
                Assert.Equal(EastAsianWidthKind.Wide, eastAsianWidth.GetKind((char)7));
                Assert.Equal(EastAsianWidthKind.Neutral, eastAsianWidth.GetKind((char)9));
            }

            private class TestProvider : IEastAsianWidthRangesProvider
            {
                public EastAsianWidthRange[] Resolve()
                {
                    return new []
                    {
                        new EastAsianWidthRange(0, 0, EastAsianWidthKind.Ambiguous),
                        new EastAsianWidthRange(1, 2, EastAsianWidthKind.FullWidth),
                        new EastAsianWidthRange(3, 4, EastAsianWidthKind.HalfWidth),
                        new EastAsianWidthRange(5, 6, EastAsianWidthKind.Narrow),
                        new EastAsianWidthRange(7, 7, EastAsianWidthKind.Wide),
                        new EastAsianWidthRange(8, 9, EastAsianWidthKind.Neutral),
                    };
                }
            }
        }
    }
}