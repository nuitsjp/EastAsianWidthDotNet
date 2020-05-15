using System.Globalization;
using Xunit;

namespace EastAsianWidthDotNet.Test
{
    namespace EastAsiaTest
    {
        public class IsEastAsia
        {
            [Fact]
            public void WhenTrue()
            {
                CultureInfo.CurrentUICulture = CultureInfo.GetCultureInfo("ja-JP");
                Assert.True(EastAsia.IsEastAsia());
            }

            [Fact]
            public void WhenFalse()
            {
                CultureInfo.CurrentUICulture = CultureInfo.GetCultureInfo("ru-RU");
                Assert.False(EastAsia.IsEastAsia());
            }
        }

        public class IsEastAsiaCultureInfo
        {
            [Fact]
            public void WhenTrue()
            {
                Assert.True(CultureInfo.GetCultureInfo("ja-JP").IsEastAsia());
            }

            [Fact]
            public void WhenFalse()
            {
                Assert.False(CultureInfo.GetCultureInfo("ru-RU").IsEastAsia());
            }
        }
    }
}