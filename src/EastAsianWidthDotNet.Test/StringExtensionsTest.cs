using System.Globalization;
using Xunit;

namespace EastAsianWidthDotNet.Test
{
#if netcoreapp31
    [Collection("Depends on CultureInfo.CurrentUICulture")]
#endif
    public class StringExtensionsTest
    {
        [Fact]
        public void GetWidthString()
        {
#if netcoreapp31
            CultureInfo.CurrentUICulture = CultureInfo.GetCultureInfo("ja-JP");
#endif
            Assert.Equal(3, "1○".GetWidth());
        }

        [Fact]
        public void GetWidthCultureInfo()
        {
            Assert.Equal(2, "1○".GetWidth(CultureInfo.GetCultureInfo("os-GE")));
        }

        [Fact]
        public void GetWidthBool()
        {
            Assert.Equal(2, "1○".GetWidth(false));
        }

        [Fact]
        public void IsFullWidth()
        {
#if netcoreapp31
            CultureInfo.CurrentUICulture = CultureInfo.GetCultureInfo("zh-TW");
#endif
            Assert.True('○'.IsFullWidth());
        }

        [Fact]
        public void IsFullWidthCultureInfo()
        {
            Assert.True('○'.IsFullWidth(CultureInfo.GetCultureInfo("zh-TW")));
        }

        [Fact]
        public void IsFullWidthBool()
        {
            Assert.False('○'.IsFullWidth(false));
        }

        [Fact]
        public void GetKind()
        {
            Assert.Equal(EastAsianWidthKind.Ambiguous, '○'.GetKind());
        }
    }
}