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
#if netcoreapp31
                CultureInfo.CurrentUICulture = CultureInfo.GetCultureInfo("ja-JP");
#endif
                Assert.True(EastAsia.IsEastAsia());
            }

#if netcoreapp31
            [Fact]
            public void WhenFalse()
            {
                CultureInfo.CurrentUICulture = CultureInfo.GetCultureInfo("ru-RU");
                Assert.False(EastAsia.IsEastAsia());
            }
#endif
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