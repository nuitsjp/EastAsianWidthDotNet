using System.Globalization;
using Xunit;

namespace EastAsianWidthDotNet.Test
{
    [Collection("Depends on CultureInfo.CurrentUICulture")]
    public class StringExtensionsTest
    {
        [Fact]
        public void GetWidthString()
        {
            CultureInfo.CurrentUICulture = CultureInfo.GetCultureInfo("ja-JP");
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
            CultureInfo.CurrentUICulture = CultureInfo.GetCultureInfo("el-CY");
            Assert.False('○'.IsFullWidth());
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