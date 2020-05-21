using System.Globalization;

namespace EastAsianWidthDotNet
{
    public static partial class EastAsia
    {
        /// <summary>
        /// Indicates whether CultureInfo.CurrentUICulture is East Asia.
        /// </summary>
        /// <returns></returns>
        public static bool IsEastAsia()
        {
            return CultureInfo.CurrentUICulture.IsEastAsia();
        }

        /// <summary>
        /// Indicates whether CultureInfo is East Asia.
        /// </summary>
        /// <param name="cultureInfo"></param>
        /// <returns></returns>
        public static bool IsEastAsia(this CultureInfo cultureInfo)
        {
            return EastAsiaNames.Contains(cultureInfo.Name);
        }

    }
}