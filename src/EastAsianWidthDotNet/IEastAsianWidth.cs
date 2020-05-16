using System.Globalization;

namespace EastAsianWidthDotNet
{
    /// <summary>
    /// EastAsianWidth of Unicode.
    /// http://www.unicode.org/reports/tr11/
    /// </summary>
    public interface IEastAsianWidth
    {
        /// <summary>
        /// Get the width of the string with respect to EastAsianWidth, according to CultureInfo.CurrentUICulture.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        int GetWidth(string value);

        /// <summary>
        /// Gets the width of the string considering EastAsianWidth by specifying CultureInfo.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="cultureInfo"></param>
        /// <returns></returns>
        int GetWidth(string value, CultureInfo cultureInfo);

        /// <summary>
        /// Get the width of the string considering EastAsianWidth by specifying whether it is East Asia.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="isEastAsia"></param>
        /// <returns></returns>
        int GetWidth(string value, bool isEastAsia);

        /// <summary>
        /// Indicates whether this character is Full Width.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        bool IsFullWidth(char value);

        /// <summary>
        /// Indicates whether this character is Full Width by specifying CultureInfo.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="cultureInfo"></param>
        /// <returns></returns>
        bool IsFullWidth(char value, CultureInfo cultureInfo);

        /// <summary>
        /// Indicates whether this character is Full Width by specifying whether it is East Asia.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="isEastAsia"></param>
        /// <returns></returns>
        bool IsFullWidth(char value, bool isEastAsia);

        /// <summary>
        /// Get the EastAsianWidthKind of the character.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        EastAsianWidthKind GetKind(char value);
    }
}