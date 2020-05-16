using System.Globalization;
using Xunit;

namespace EastAsianWidthDotNet.Test
{
    namespace EastAsianWidthTest
    {
        public class GetWidthString
        {
            public GetWidthString()
            {
                CultureInfo.CurrentUICulture = CultureInfo.GetCultureInfo("ja-JP");
            }

            [Fact]
            public void WhenNormal()
            {

            }
        }
    }
}