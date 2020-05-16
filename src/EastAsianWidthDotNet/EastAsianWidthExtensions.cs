using System.Globalization;

namespace EastAsianWidthDotNet
{
    public static class EastAsianWidthExtensions
    {
        /// <summary>
        /// Get the width of the string considering EastAsianWidth.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int GetWidth(this string value) =>
            EastAsianWidth.Instance.GetWidth(value);

        /// <summary>
        /// Get the width of the string with respect to EastAsianWidth, according to CultureInfo.CurrentUICulture.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="cultureInfo"></param>
        /// <returns></returns>
        public static int GetWidth(this string value, CultureInfo cultureInfo) =>
            EastAsianWidth.Instance.GetWidth(value, cultureInfo);

        /// <summary>
        /// Get the width of the string considering EastAsianWidth by specifying whether it is East Asia.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="isEastAsia"></param>
        /// <returns></returns>
        public static int GetWidth(this string value, bool isEastAsia) =>
            EastAsianWidth.Instance.GetWidth(value, isEastAsia);

        /// <summary>
        /// Indicates whether this character is Full Width.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsFullWidth(this char value) =>
            EastAsianWidth.Instance.IsFullWidth(value);

        /// <summary>
        /// Indicates whether this character is Full Width by specifying CultureInfo.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="cultureInfo"></param>
        /// <returns></returns>
        public static bool IsFullWidth(this char value, CultureInfo cultureInfo) =>
            EastAsianWidth.Instance.IsFullWidth(value, cultureInfo);

        /// <summary>
        /// Indicates whether this character is Full Width by specifying whether it is East Asia.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="isEastAsia"></param>
        /// <returns></returns>
        public static bool IsFullWidth(this char value, bool isEastAsia) =>
            EastAsianWidth.Instance.IsFullWidth(value, isEastAsia);

        /// <summary>
        /// Get the EastAsianWidthKind of the character.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static EastAsianWidthKind GetKind(this char value) =>
            EastAsianWidth.Instance.GetKind(value);

    }
}