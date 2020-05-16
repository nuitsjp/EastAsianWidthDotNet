using System.Globalization;

namespace EastAsianWidthDotNet
{
    /// <summary>
    /// EastAsianWidth of Unicode.
    /// http://www.unicode.org/reports/tr11/
    /// </summary>
    public class EastAsianWidth : IEastAsianWidth
    {
        /// <summary>
        /// Only one instance.
        /// </summary>
        public static readonly IEastAsianWidth Instance = new EastAsianWidth(new EastAsianWidthRangesProvider());

        /// <summary>
        /// Kind by Range in the Unicode dictionary.
        /// </summary>
        private readonly EastAsianWidthRange[] _ranges;

        /// <summary>
        /// Resolve instance.
        /// </summary>
        /// <param name="provider"></param>
        internal EastAsianWidth(IEastAsianWidthRangesProvider provider)
        {
            _ranges = provider.Resolve();
        }

        /// <summary>
        /// Get the width of the string with respect to EastAsianWidth, according to CultureInfo.CurrentUICulture.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public int GetWidth(string value) => GetWidth(value, EastAsia.IsEastAsia());

        /// <summary>
        /// Gets the width of the string considering EastAsianWidth by specifying CultureInfo.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="cultureInfo"></param>
        /// <returns></returns>
        public int GetWidth(string value, CultureInfo cultureInfo) => GetWidth(value, cultureInfo.IsEastAsia());

        /// <summary>
        /// Get the width of the string considering EastAsianWidth by specifying whether it is East Asia.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="isEastAsia"></param>
        /// <returns></returns>
        public int GetWidth(string value, bool isEastAsia)
        {
            int width = 0;
            foreach (var c in value)
            {
                width += IsFullWidth(c, isEastAsia) ? 2 : 1;
            }
            return width;
        }

        /// <summary>
        /// Indicates whether this character is Full Width.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool IsFullWidth(char value) => IsFullWidth(value, EastAsia.IsEastAsia());

        /// <summary>
        /// Indicates whether this character is Full Width by specifying CultureInfo.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="cultureInfo"></param>
        /// <returns></returns>
        public bool IsFullWidth(char value, CultureInfo cultureInfo) => IsFullWidth(value, cultureInfo.IsEastAsia());

        /// <summary>
        /// Indicates whether this character is Full Width by specifying whether it is East Asia.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="isEastAsia"></param>
        /// <returns></returns>
        public bool IsFullWidth(char value, bool isEastAsia)
        {
            switch (GetKind(value))
            {
                case EastAsianWidthKind.Ambiguous:
                    return isEastAsia;
                case EastAsianWidthKind.FullWidth:
                case EastAsianWidthKind.Wide:
                    return true;
                default:
                    return false;
            }
        }

        /// <summary>
        /// Get the EastAsianWidthKind of the character.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public EastAsianWidthKind GetKind(char value)
            => GetKind(value, 0, _ranges.Length);

        /// <summary>
        /// Get the EastAsianWidthKind of the character.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        private EastAsianWidthKind GetKind(int value, int start, int end)
        {
            int currentStart = start;
            int currentEnd = end;
            while (true)
            {
                var centerIndex = currentStart + (currentEnd - currentStart) / 2;
                var current = _ranges[centerIndex];

                if (value < current.Start)
                {
                    currentEnd = centerIndex - 1;
                    continue;
                }

                if (current.End < value)
                {
                    currentStart = centerIndex + 1;
                    continue;
                }

                return current.Kind;
            }
        }

    }
}